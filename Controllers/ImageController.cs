using Microsoft.AspNetCore.Mvc;

namespace Opaco.IA.Interface.Controllers
{
    public class ImageController : Controller
    {
        // Inicialmente, proponho um enpoint enxuto, apenas para requisição de prompt
        [HttpPost("/generate-image")]
        public IActionResult GenerateImage([FromBody] string prompt)
        {
            return Ok();
        }
    }
}
