using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }
        //Se debe de poner esta línea cuando se requiere utiliza el tipo de dato Date
        [DataType(DataType.Date)]
        [Display(Name = "Realese Date")]
        [Required]
        public DateTime RelaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }
        [Column(TypeName = "decimal(18:2)")]
        [Range(1, 100)]
        [Required]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        public string? Rating { get; set; }
        
    }
}
