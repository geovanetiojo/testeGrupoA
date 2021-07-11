using Microsoft.AspNetCore.Mvc;

namespace ensinosup_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : Controller
    {
        public AlunoController()
        {

        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
        [HttpGet("{AlunoRA}")]
        public IActionResult Get(int AlunoRA)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }
        [HttpPut("{AlunoRA}")]
        public IActionResult Put(int AlunoRA)
        {
            return Ok();
        }
        [HttpDelete("{AlunoRA}")]
        public IActionResult Delete(int AlunoRA)
        {
            return Ok();
        }
    }
}