using cinama.Dtos;
using cinama.Reposatiory.CategoryRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cinama.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepo _Repo;

        public CategoryController(ICategoryRepo repo)
        {
            _Repo = repo;
        }
        [HttpPost]
        public IActionResult add(CategoryDto categoryDto)
        {
            _Repo.add(categoryDto);
            return Created();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
           _Repo.Delete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(CategoryDto categoryDto,int id)
        {
            _Repo.put(categoryDto,id);
            return Ok();

        }
    }
}
