using MextFullStack.Persistence.Services;
using MextFullStack.WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MextFullStack.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RootPathsController : ControllerBase
    {
        private readonly IRoothPathService _roothPathService;

        public RootPathsController(IRoothPathService roothPathService)
        {
            _roothPathService = roothPathService;
        }

        [HttpGet]
        public IActionResult GetRootPath()
        {
            return Ok(_roothPathService.GetRoothPath());

        }

        [HttpPost]
        public IActionResult SaveCountsToRootPath()
        {
            _roothPathService.WriteTotalCount();
            return Ok("Total Counts have been succcesfuly written");

        }
    }
}
