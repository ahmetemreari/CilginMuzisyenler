using System.ComponentModel.DataAnnotations;

namespace CrazyMusiciansAPI.Models
{
    public class Musician
    {

        //Müzisyen id
        public int Id { get; set; }

// Müzisyen adı
        [Required]
        [StringLength(50, ErrorMessage = "isim alanı 50 karakterden uzun olamaz")]
        public string Name { get; set; }

//müzisyen mesleği
        [Required]
        public string Profession { get; set; }

//müzisyen eğlenceli özellik
        [Required]
        public string FunFact { get; set; }
    }
}