using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace amazoon.Models
{
    
        using System;

        public class Payment
        {
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Key]
            public string PaymentId { get; set; }

            [Required, StringLength(100)]
            public string? PaymentMethod { get; set; }

            [Required, StringLength(50)]
            public string? PaymentStatus { get; set; }

          

            public DateTime PaymentDate { get; set; } = DateTime.Now;

          
            public int OrderId { get; set; } 
            public Order? Order { get; set; }
        }
    }



