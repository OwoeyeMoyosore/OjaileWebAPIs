using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using OjaileWebAPI.Model;
using Serilog;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace OjaileWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

   
        private readonly IConfiguration _configuration;
        private readonly ILogger<AccountController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        public AccountController(IConfiguration configuration, UserManager<ApplicationUser> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
        }
        public List<RegisterViewModel> Registers = new List<RegisterViewModel>()
        {
            new RegisterViewModel{FirstName ="Emmanuel ", Email ="thegreatdammy@gmail.com", LastName="Obafemi", Password ="password",PhoneNumber ="7235252389", UserName ="DammyDammy"},
            new RegisterViewModel{FirstName ="Obiora", Email ="ObiIgwilo@gmail.com ", LastName="Igwilo ", Password ="password",PhoneNumber ="5292422867 ", UserName ="ObiCubana"},
            new RegisterViewModel{FirstName ="Moyosore ", Email ="moyosoreo@gmail.com", LastName="Owoeye ", Password ="password",PhoneNumber ="0810397632", UserName ="Emwhy"},
            new RegisterViewModel{FirstName ="Folajimi ", Email ="jmiie@gmail.com ", LastName="Olaosebikan ", Password ="password",PhoneNumber ="53223723", UserName ="Gmieee "},
        };
        [HttpPost("/Login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            Log.Information("Call login action");
            _logger.LogInformation("Call login action");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var user = AuthenticateUser(model);
            if (user != null)
            {
                var token = GenerateAuthenticatedUserToken(user);
                return Ok(token);
                Log.Information("Login succeed");
            }
            return BadRequest(ModelState);
        }
        [HttpPost("/Register")]
        //[ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var user = new ApplicationUser();
            user.Email = model.Email;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.PhoneNumber = model.PhoneNumber;
            user.UserName = model.UserName;
            user.Created = DateTime.Now;
            user.Institution = 1;

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
                return Ok(result);
            return BadRequest(ModelState);

        }

        private string GenerateAuthenticatedUserToken(RegisterViewModel register)
        {
            var signKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]));
            var credential = new SigningCredentials(signKey, SecurityAlgorithms.HmacSha256);
            var claim = new[]
            {
                new Claim(ClaimTypes.Name, register.FirstName + ' ' + register),
                new Claim(ClaimTypes.Email, register.Email),
                new Claim(ClaimTypes.MobilePhone, register.PhoneNumber)

            };
            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"], claim, notBefore: DateTime.Now,
                expires: DateTime.Now.AddMinutes(30), credential).ToString();
            return token;
        }

        private RegisterViewModel AuthenticateUser(LoginViewModel model)
        {
            var user = Registers.Where(m => m.UserName == model.UserName && m.Password == model.Password).FirstOrDefault();
            if (user != null)
            {
                return user;
            }   
            return null;
        }
    }
}
