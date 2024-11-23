using System.ComponentModel.DataAnnotations;

namespace cinama.Dtos
{
    public class Movie_addDto
    {
        [Required]
        public string? Title { get; set; }

        public DateTime? Date { get; set; }

        public string ? Categoryname { get; set; }

        public List<Director_AddDto>? Directors { get; set; }

        public string ? Nationaltyname  { get; set; }
    }
}
