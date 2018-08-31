using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IService _service;
        private readonly IRepository<Entity> _repository;

        public ValuesController(IService service, IRepository<Entity> repository)
        {
            _service = service;
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public int Get() => _service.AnswerToTheUltimateQuestionOfLifeTheUniverseAndEverything();
    }
}
