using cinama.Data;
using cinama.Dtos;
using cinama.model;

namespace cinama.Reposatiory.CategoryRepo
{
    public class CategoryRepoo : ICategoryRepo
    {
        private readonly AppDbcontext _context;

        public CategoryRepoo(AppDbcontext context)
        {
            _context = context;
        }

        public void add(CategoryDto categoryDto)
        {
            var c = new Category
            {
                Name = categoryDto.Name,
            };
            _context.Categories.Add(c);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = _context.Categories.FirstOrDefault(x => x.Id == id);
            _context.Categories.Remove(c);
            _context.SaveChanges();
        }

        public CategoryDto put(CategoryDto categoryDto, int id)
        {
            var c = new Category
            {
                Name = categoryDto.Name,
            };
            _context.Categories.Update(c);
            _context.SaveChanges();
            return categoryDto;
        }
    }
}
