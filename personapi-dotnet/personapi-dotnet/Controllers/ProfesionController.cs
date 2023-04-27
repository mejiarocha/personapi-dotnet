using personapi_dotnet.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesionController : ControllerBase
    {
        private IProfesionRepository _profesionRepository;

        public ProfesionController(IProfesionRepository profesionRepository)
        {
            _profesionRepository = profesionRepository;
        }

        [HttpGet("{id}")]
        [ActionName(nameof(GetProfesionId))]
        public ActionResult<Profesion> GetProfesionId(int id)
        {
            var productByID = _profesionRepository.GetProfesion(id);
            if (productByID == null)
            {
                return NotFound();
            }
            return productByID;
        }


        [HttpPost]
        [ActionName(nameof(CreateProfesionAsync))]
        public async Task<ActionResult<Profesion>> CreateProfesionAsync(Profesion profesion)
        {
            await _profesionRepository.CreateProfesion(profesion);
            return CreatedAtAction(nameof(GetProfesionId), new {id = profesion.Id}, profesion);
        }

        [HttpDelete("{id}")]
        [ActionName(nameof(DeleteProfesion))]
        public async Task<IActionResult> DeleteProfesion(int id)
        {
            var profesion = _profesionRepository.GetProfesion(id);
            if(profesion == null)
            {
                return NotFound();
            }
            await _profesionRepository.DeleteProfesion(profesion);
            return NoContent();
        }


    }
}
