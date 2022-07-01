using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ojaile.abstraction;

namespace OjaileWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyItemController : ControllerBase
    {
        private readonly IPropertyItemService _propertyItem;
        public PropertyItemController(IPropertyItemService propertyItem)
        {
            _propertyItem = propertyItem;
        }

        [HttpGet]
        public IActionResult GetPropertyItems()
        {
            List<object> items = new List<object>();
            if (_propertyItem == null)
            {
                return NotFound();
            }
            else
            {
                items = (List<object>)_propertyItem.GetPropertyItem();
            }
            return Ok(items);
        }
    }
}
