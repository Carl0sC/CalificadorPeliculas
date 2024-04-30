using System.ComponentModel.DataAnnotations;

namespace PeliculasCalifi.Models.entidades
{
    public class Movies
    {
        public int movieid { get; set; }
      
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Tilte { get; set;}
        
        [DisplayFormat (DataFormatString = "{0:yyy/MM/dd}")]
        public DateTime RelaseYears { get; set;}
        public string Genre {  get; set;}
        public string Description { get; set; }

        public double AverageRating { get; set; }

    }
}
