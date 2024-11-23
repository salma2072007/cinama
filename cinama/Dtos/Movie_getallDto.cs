using System.ComponentModel.DataAnnotations;

namespace cinama.Dtos
{
    public class Movie_getallDto
    {
        [Required]
        public string? Title { get; set; }
        public DateTime? Date { get; set; }

        public List<Director_AddDto> Directors { get; set; }

        public string? Category { get; set; }
    }
}
