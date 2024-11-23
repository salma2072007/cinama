using cinama.Data;
using cinama.Dtos;
using cinama.model;

namespace cinama.Reposatiory.NationaltyRepo
{
    public class NationalRepoocs : INationalRepo
    {
        private readonly AppDbcontext _context;

        public NationalRepoocs(AppDbcontext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var d = _context.National.FirstOrDefault(x=> x.Id==id);
            _context.National.Remove(d);
            _context.SaveChanges();
        }

        public void post(NationalDto nationalDto)
        {
            var d = new National
            {
                Name = nationalDto.Name,
                
            };
            _context.National.Add(d);
            _context.SaveChanges();
        }
    }
}
