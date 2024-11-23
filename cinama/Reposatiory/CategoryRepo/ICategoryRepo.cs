using cinama.Dtos;

namespace cinama.Reposatiory.CategoryRepo
{
    public interface ICategoryRepo
    {
        public void add(CategoryDto categoryDto);

        public void Delete(int id);

        public CategoryDto put(CategoryDto categoryDto,int id);
    }
}
