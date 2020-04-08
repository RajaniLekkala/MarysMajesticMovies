using System.ComponentModel.DataAnnotations;

namespace MarysMajesticMovies
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int Telephone { get; set; }
    }
}
