using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeCafeDay.Models
{
    public class OrderDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public int OrderDetailID { get; set; }
        [Required]
        [ForeignKey("OrderID")]
    public Orders? Orders { get; set; }
        [Required]
        [ForeignKey("ProductID")]
        public Products? Products { get; set; }
      public int Quantity { get; set; }
      public double Price { get; set; }
    }
}
