using cinama.Dtos;
using cinama.Reposatiory.MoviesRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cinama.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieeRepo _Repo;

        public MovieController(IMovieeRepo repo)
        {
            _Repo = repo;
        }
        [HttpPost]
        public  IActionResult AddAll(Movie_addDto movie_AddDto)
        {
          _Repo.Add(movie_AddDto);
            return Created();

        }
        [HttpGet]
        public IActionResult Get()
        {
          var m=  _Repo.Getall();
            if(m == null)
            {
                return NotFound();
            }
            return Ok(m);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
          var m=  _Repo.GetbyId(id);
            if(m == null)
            {
                return NotFound();
            }
            return Ok(m);
        }

    }
}
