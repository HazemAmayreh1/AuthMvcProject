using System.ComponentModel.DataAnnotations;

namespace mvcOne.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [DataType("varchar")]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; } = null!;

        [DataType("varchar")]
        [MaxLength(50)]
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [DataType(DataType.Password)]
        [MaxLength(25)]
        [Required]
        public string Passwored { get; set; } = null!;
    }
}
