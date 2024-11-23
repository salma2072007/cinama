using cinama.model;
using System.ComponentModel.DataAnnotations;

namespace cinama.Dtos
{
    public class Director_updateDto
    {
        [Required]
        public string? Name { get; set; }

        public string? contect { get; set; }

        public string ? Email { get; set; }

        public List<MovieDto> MovieDtos { get; set; }

        public CategoryDto categoryname { get; set; }
      


    }
}
