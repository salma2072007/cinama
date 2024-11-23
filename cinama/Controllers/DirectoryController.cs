using cinama.Dtos;
using cinama.Reposatiory.DirectorRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cinama.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectoryController : ControllerBase
    {
        private readonly IDirectoryRepo _Repo;

        public DirectoryController(IDirectoryRepo repo)
        {
            _Repo = repo;
        }
        [HttpPost]
        public IActionResult add(Director_AddDto director_AddDto)
        {
            _Repo.add(director_AddDto);
            return Created();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _Repo.Delete(id);
            return Ok();
        }
        [HttpGet]
        public IActionResult Get()
        {
           var a= _Repo.Getall();
            return Ok(a);

        }
        [HttpPut]
        public IActionResult put(Director_updateDto director_UpdateDto, int id)
        {
            _Repo.Update(director_UpdateDto, id);
            return Ok();

        }
    }
}
