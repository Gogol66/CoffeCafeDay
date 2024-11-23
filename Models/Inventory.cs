using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeCafeDay.Models
{
    public class Inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventoryID { get; set; }
        [Required]
        [ForeignKey("ProductID")]
        public Products? Products { get; set; }
        public int QuantityInStock { get; set; }
        public int ReorderLevel { get; set; }
    }
}
