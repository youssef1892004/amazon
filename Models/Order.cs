using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace amazoon.Models
{
   
        public class Order
        {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
            public string OrderId { get; set; }

            [Required]
            [Column(TypeName = "decimal(10,2)")]
            public decimal TotalPrice { get; set; }

            public DateTime CreatedAt { get; set; } = DateTime.Now;

            
            public int UserId { get; set; }
            public User? User { get; set; }


            public ICollection<OrderItem>?0 OrderItems { get; set; } 
            public Payment? Payment { get; set; }
        }
    }

