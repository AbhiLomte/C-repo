using System.ComponentModel.DataAnnotations;

namespace YourProjectName.Models
{
    public class Country
    {
        [Key]
        public int ID { get; set; } // Primary key

        [Required]
        [StringLength(100)]
        public string CountryName { get; set; }

        [Required]
        [StringLength(100)]
        public string Capital { get; set; }
    }
}
