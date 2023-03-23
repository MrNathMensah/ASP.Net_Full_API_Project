using DBC27API1.Repo;
using Microsoft.AspNetCore.Mvc;
using SecondProject.Models;

namespace DBC27API1.Controllers
{
        [ApiController]
        [Route("[controller]")]
        public class ProgrammeController : ControllerBase
        {
            private readonly IRepository _repository;

            public ProgrammeController(IRepository repository)
            {
                _repository = repository;
            }

            [HttpGet]
            public IEnumerable<Programme> GetProgrammes()
            {
                var model = _repository.GetAllProgramme();
                return model;
            }

            [HttpGet("id")]
            public IActionResult GetProgramme(int id)
            {
                var model = _repository.GetProgramme(id);
                return Ok(model);
            }
        }
    }
