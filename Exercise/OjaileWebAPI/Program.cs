using Microsoft.EntityFrameworkCore.Design;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.Twitter;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ojaile.abstraction;
using ojaile.facade;
using OjaileWebAPI.Data;
using OjaileWebAPI.Model;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddScoped<IPropertyItemService, IPropertyItemService>();
//builder.Services.AddTransient<IPropertyItemService, IPropertyItemService>();
//builder.Services.AddSingleton<IPropertyItemService, IPropertyItemService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

//builder.Services
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true && options.Password.RequireNonAlphanumeric )
.AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(builder.Configuration["Jwt:Key"]))
    }) ;
    
    
    //builder.Configuration.Bind("JwtConfig", options))
    //.AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
    //options => builder.Configuration.Bind(nameof(CookieAuthenticationDefaults)));

builder.Services.AddLogging();
var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", false, true);
var app = builder.Build();
//Google authentication
//builder.Services.AddAuthentication(
//    options =>
//    {
//        options.DefaultAuthenticateScheme = GoogleDefaults.AuthenticationScheme;
//        options.DefaultChallengeScheme = GoogleDefaults.TokenEndpoint;
//    })
//    .AddGoogle(
//    options =>
//    {
//        options.ClientId = " ";
//        options.ClientSecret = " ";
//    });
//    .AddFacebook(
//      facebookOptions =>
//        {
//            facebookOptions.AppId = "<my_app_id>";
//            facebookOptions.AppSecret = "<my_app_secret>";
//      });

//Twitter authentication
    //builder.Services.AddAuthentication(
    //    options =>
    //    {
    //        options.DefaultAuthenticateScheme = TwitterDefaults.AuthenticationScheme;
    //    })
    //.AddTwitter(twitterOptions =>
    //{
    //    twitterOptions.ConsumerKey = "";
    //    twitterOptions.ConsumerSecret = "";
    //});


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
//app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

app.MapControllers();

app.Run();
