using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace amazoon.Models
{
   
        public class Order
        {
            [Key]
            public int OrderId { get; set; }

            [Required]
            [Column(TypeName = "decimal(10,2)")]
            public decimal TotalPrice { get; set; }

            public DateTime CreatedAt { get; set; } = DateTime.Now;

            
            public int UserId { get; set; }
            public User? User { get; set; }


            public ICollection<OrderItem>? OrderItems { get; set; } 
            public Payment? Payment { get; set; }
        }
    }

