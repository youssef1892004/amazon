using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace amazoon.Models
{
    public class Product
    {
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Key]
            public string ProductId { get; set; }

            [Required, StringLength(255)]
            public string? Name { get; set; }

            public string? Description { get; set; }

            [Required]
            [Column(TypeName = "decimal(10,2)")]
            public decimal Price { get; set; }

            public int InStock { get; set; } = 0;

            
            public int CategoryId { get; set; }
            public Category? Category { get; set; }

            public ICollection<Review>? Reviews { get; set; }
            public ICollection<OrderItem>? OrderItems { get; set; }
        }
    }
