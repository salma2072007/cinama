using System.ComponentModel.DataAnnotations;

namespace cinama.Dtos
{
    public class NationalDto
    {
        [Required]
        public string Name  { get; set; }
    }
}
