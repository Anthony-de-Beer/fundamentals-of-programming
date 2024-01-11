using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Fundamentals_of_programming.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FactorialController : ControllerBase
    {
        private readonly IFactorialService _factorialService;

        public FactorialController(IFactorialService factorialService)
        {
            _factorialService = factorialService;
        }

        [HttpPost]
        public int CalculateFactorial(int input)
        {
            return _factorialService.GetFactorial(input);
        }
    }
}
