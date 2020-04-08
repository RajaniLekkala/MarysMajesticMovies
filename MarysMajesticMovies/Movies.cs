using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarysMajesticMovies
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ImdbId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime YearReleased { get; set; }
        [Required]
        public TimeSpan Length { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Actors { get; set; }
        [Required]
        public string Plot { get; set; }
        [Required]
        public int ImdbRating { get; set; }
    }
}
