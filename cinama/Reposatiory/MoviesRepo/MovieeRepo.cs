using cinama.Data;
using cinama.Dtos;
using cinama.model;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace cinama.Reposatiory.MoviesRepo
{
    public class MovieeRepo : IMovieeRepo
    {
        // ده اسمو declaration
        private readonly AppDbcontext _context;
        //و ده ال depandenc injection من نوع constorctor
        public MovieeRepo(AppDbcontext context)
        {
            _context = context;
        }

        public void Add(Movie_addDto movie_AddDto)
        {
            var m = new Movies
            {
                Title = movie_AddDto.Title,
                Date = movie_AddDto.Date,
                Category = new Category
                {
                    Name = movie_AddDto.Categoryname
                },
                Directors = movie_AddDto.Directors.Select(d=> new Director 
                { 
                    Name =d.Name,
                    contect=d.contect,
                    Email = d.Email,
                    Nationalty=new National
                    {
                        Name=movie_AddDto.Nationaltyname,
                    }

                }).ToList(),
            };
            _context.Movies.Add(m);
            _context.SaveChanges();
        }


        public List<Movie_getallDto> Getall()
        {
            var movie = _context.Movies.Include(d => d.Directors).Include(c => c.Category).Select(m => new Movie_getallDto
            {
                Title = m.Title,
                Date = m.Date,
                Directors = m.Directors.Select(d => new Director_AddDto
                {
                    Name = d.Name,
                    contect = d.contect,
                    Email = d.Email,
                    nationalname = d.Name

                }).ToList(),
                Category = m.Category.Name,

            }).ToList();
            return movie;

        }

        public Movie_getallDto GetbyId(int id)
        {
            var m= _context.Movies.Include(x=>x.Directors).Include(x=>x.Category).FirstOrDefault(x=>x.Id==id);
            var movie = new Movie_getallDto
            {
                Title=m.Title,
                Date=m.Date,
                Category=m.Category.Name,
                Directors=m.Directors.Select(x=> new Director_AddDto
                {
                    Name=x.Name,
                    contect=x.contect,
                    Email=x.Email,
                    nationalname=x.Name,

                }).ToList(),
            };
            return movie;

        }
    }
}
