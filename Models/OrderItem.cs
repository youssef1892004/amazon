using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace amazoon.Models
{
  
        public class OrderItem
        {
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Key]
            public string OrderItemId { get; set; }

            [Required]
            public int Quantity { get; set; }

            [Required]
            [Column(TypeName = "decimal(10,2)")]
            public decimal RowTotal { get; set; }


            public int OrderId { get; set; }
            public Order? Order { get; set; }


            public int ProductId { get; set; }s
            public Product? Product { get; set; }
        }
    }

