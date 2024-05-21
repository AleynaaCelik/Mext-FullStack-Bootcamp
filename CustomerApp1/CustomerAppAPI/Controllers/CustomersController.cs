using CustomerApp.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

         private readonly InMemoryCustomerService _inMemoryCustomerService;
        public CustomersController()
        {
                   _inMemoryCustomerService = new();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var List=_inMemoryCustomerService.List();
            return Ok(List);
        }
    }
}
