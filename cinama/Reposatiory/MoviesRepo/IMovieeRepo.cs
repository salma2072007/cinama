using cinama.Dtos;

namespace cinama.Reposatiory.MoviesRepo
{
    public interface IMovieeRepo
    {
        public List<Movie_getallDto> Getall();
        public void Add(Movie_addDto movie_AddDto);

        public Movie_getallDto GetbyId(int id);
    }
}
