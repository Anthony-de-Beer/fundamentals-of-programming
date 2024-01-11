using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Fundamentals_of_programming.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReverseSentenceController : ControllerBase
    {
        private readonly IReverseService _reverseService;

        public ReverseSentenceController(IReverseService reverseService)
        {
            _reverseService = reverseService;
        }

        [HttpPost]
        public string ReverseInputString(string input)
        {
            return _reverseService.ReverseString(input);
        }
    }
}
