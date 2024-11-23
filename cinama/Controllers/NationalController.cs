using cinama.Dtos;
using cinama.Reposatiory.NationaltyRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cinama.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalController : ControllerBase
    {
        private readonly INationalRepo _Repo;

        public NationalController(INationalRepo repo)
        {
            _Repo = repo;
        }
        [HttpPost]

        public IActionResult Post(NationalDto nationalDto)
        {
            _Repo.post(nationalDto);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _Repo.Delete(id);
            return Ok();
        }
    }
}
