using cinama.model;
using System.ComponentModel.DataAnnotations;

namespace cinama.Dtos
{
    public class MovieDto
    {
        [Required]
        public string? Title { get; set; }

        public DateTime? Date { get; set; }


    }
}
