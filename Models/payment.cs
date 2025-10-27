using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace amazoon.Models
{
    
        using System;

        public class Payment
        {
            [Key]
            public int PaymentId { get; set; }

            [Required, StringLength(100)]
            public string? PaymentMethod { get; set; }

            [Required, StringLength(50)]
            public string? PaymentStatus { get; set; }

            [Required]
            [Column(TypeName = "decimal(10,2)")]
            public decimal Amount { get; set; }

            public DateTime PaymentDate { get; set; } = DateTime.Now;

          
            public int OrderId { get; set; } 
            public Order? Order { get; set; }
        }
    }



