using cinama.Dtos;

namespace cinama.Reposatiory.NationaltyRepo
{
    public interface INationalRepo
    {
        public void post(NationalDto nationalDto);

        public void Delete(int id);


    }
}
