using personapi_dotnet.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using personapi_dotnet.Models.Entities;


namespace personapi_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesionController : Controller
    {

        private IProfesionRepository _profesionRepository;

        string baseUrl = "http://localhost:58794/";

        public ActionResult Index()
        {
            IEnumerable<Profesion> profesion = null;
            using (var httpClient = new HttpClient()) { 
            httpClient.BaseAddress = new Uri("http://localhost:49555/api/");
                var ResponseTask = httpClient.GetAsync("profesiones");
                ResponseTask.Wait();

                var result = ResponseTask.Result;
                if(result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Profesion>>();
                    readTask.Wait();
                    profesion = readTask.Result;
                }
                else
                {
                    profesion = Enumerable.Empty<Profesion>();
                    ModelState.AddModelError(string.Empty, "Server Error :( " );

                }

            }
            return View(profesion);
        }

        [HttpGet]
        [ActionName(nameof(GetProfesionsAsync))]
        public IEnumerable<Profesion> GetProfesionsAsync()
        {
            return _profesionRepository.GetProfesions();
        }

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
