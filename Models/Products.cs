using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Products
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductID { get; set; }
    [MaxLength(100)]
    public string? ProductName { get; set; }
    [MaxLength(100)]
    public string? Description { get; set; }
    public double? Price { get; set; }
    public string? Category { get; set; }
}