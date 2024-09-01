using System;
using System.ComponentModel.DataAnnotations;

namespace mvcOne.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        public string UserName { get; set; } = null!;

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; } = null!;

        public bool IsActive { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; 
    }
}
