using System.ComponentModel.DataAnnotations;

namespace amazoon.Models
{
  
        public class Category
        {
            [Key]
            public int CategoryId { get; set; }

            [Required]
            [StringLength(255)]
            public string? Name { get; set; }
            public ICollection<Product>? Products { get; set; }
        }
    }
