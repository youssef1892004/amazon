using System.ComponentModel.DataAnnotations;

namespace amazoon.Models
{
    public class User
    {

            [Key]
            public int UserId { get; set; }

            [Required, StringLength(255)]
            public string? FullName { get; set; }

            [Required, StringLength(255)]
            [EmailAddress]
            public string? Email { get; set; }

            [Required]
            public string? Password { get; set; }

            [StringLength(50)]
            public string? PhoneNumber { get; set; }

            public string? Address { get; set; }

            [StringLength(50)]
            public string? UserGroup { get; set; } = "customer";

            
            public ICollection<Order>? Orders { get; set; }
            public ICollection<Review>? Reviews { get; set; }
        }
    }

