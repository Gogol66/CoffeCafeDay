using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeCafeDay.Models
{
    public class ProductSuppliers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductSupplierID { get; set; }
        [ForeignKey("ProductID")]
        public Products? Products { get; set; }
        [ForeignKey("SupplierID")]
        public Suppliers? Suppliers { get; set; }
       public double Price { get; set; }
    }
}

