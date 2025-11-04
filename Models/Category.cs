using System.ComponentModel.DataAnnotations;

namespace amazoon.Models
{
  
        public class Category
        {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
            public string CategoryId { get; set; }

            [Required]
            [StringLength(255)]
            public string? Name { get; set; }
            public ICollection<Product>? Products { get; set; }
        }
    }
