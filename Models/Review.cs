using System.ComponentModel.DataAnnotations;

namespace amazoon.Models
{
  
        public class Review
        {
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Key]
            public string ReviewId { get; set; }

            [Range(1, 5)]
            public int Rating { get; set; }

            public string? Opinion { get; set; }

            public DateTime CreatedAt { get; set; } = DateTime.Now;


            public int UserId { get; set; }
            public User? User { get; set; }
            public int ProductId { get; set; }
            public Product? Product { get; set; }
        }
    }