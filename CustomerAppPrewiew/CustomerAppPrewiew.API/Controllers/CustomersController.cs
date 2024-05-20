using CustomerAppPrewiew.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerAppPrewiew.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly NotepadCustomerService _customerService;
        [HttpGet]
        public IActionResult GetAll()
        {
            _customerService.Add(new());
            return Ok(_customerService.List());

        }
    }
}
