using cinama.Dtos;

namespace cinama.Reposatiory.DirectorRepo
{
    public interface IDirectoryRepo
    {
        public void add(Director_AddDto director_AddDto);

        public void Update(Director_updateDto director_UpdateDto, int id);

        public List<Director_AddDto> Getall();

        public void Delete(int id);
    }
}
