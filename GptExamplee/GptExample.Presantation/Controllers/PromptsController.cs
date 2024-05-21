using GptExample.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GptExample.Presantation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromptsController : ControllerBase
    {
        private readonly IPromptService _promptService;
        public PromptsController(IPromptService promptService)
        {
            _promptService = promptService;
        }

        [HttpGet("{userId:string}")]
        public IActionResult GetPrompts(string userId)
        {
            var prompts = _promptService.GetAll(userId);
            return Ok(prompts);
        }
        [HttpPost]
        public I
    }
}
