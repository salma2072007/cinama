using cinama.Data;
using cinama.Dtos;
using cinama.model;
using Microsoft.EntityFrameworkCore;

namespace cinama.Reposatiory.DirectorRepo
{
    public class DirectoryRepoo : IDirectoryRepo
    {
        private readonly AppDbcontext _context;

        public DirectoryRepoo(AppDbcontext context)
        {
            _context = context;
        }

        public void add(Director_AddDto director_AddDto)
        {
            var d = new Director
            {
                Name = director_AddDto.Name,
                contect=director_AddDto.contect,
                Email = director_AddDto.Email,
                 
            };
            _context.Directors.Add(d);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
           var d= _context.Directors.Find(id);
            _context.Directors.Remove(d);
            _context.SaveChanges();
        }

        public List< Director_AddDto> Getall()
        {
            var d = _context.Directors.Include(a=>a.Nationalty).Select(m => new Director_AddDto
            {
                Name = m.Name,
                contect=m.contect,
                Email = m.Email,
                nationalname=m.Name,
                

            }).ToList();
            return d; 
        }
        

        public void Update(Director_updateDto director_UpdateDto, int id)
        {
             var a= _context.Directors.Include(x=>x.Movies).ThenInclude(x=>x.Category).FirstOrDefault(x=>x.Id==id);
            a.Name= director_UpdateDto.Name;
            a.contect=director_UpdateDto.contect;
            a.Email= director_UpdateDto.Email;
            a.Movies= director_UpdateDto.MovieDtos.Select(x=> new Movies
            {
                Title= x.Title,
                Date= x.Date,   
                Category= new Category
                {
                    Name=director_UpdateDto.categoryname.Name
                }

            }).ToList();
            _context.Directors.Update(a);
            _context.SaveChanges();
        }
    }
}
