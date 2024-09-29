using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase

    {
        [HttpGet("add")]

        public IActionResult Add(decimal a, decimal b)
        {
            return Ok(a + b);
        }

    }
}