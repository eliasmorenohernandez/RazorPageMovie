using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        //Se debe de poner esta línea cuando se requiere utiliza el tipo de dato Date
        [Display(Name ="Release Date")]
        [DataType(DataType.Date)]
        public DateTime RelaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }
        [Column(TypeName = "decimal(18:2)")]
        public decimal Price { get; set; }
        public string? Rating { get; set; }
        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        //[Required]
        
    }
}
