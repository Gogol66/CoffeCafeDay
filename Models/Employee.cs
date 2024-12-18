using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CoffeCafeDay.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [MaxLength(50)]
        public string? LastName { get; set; }

        [MaxLength(50)]
        [Required]
        public string? Email { get; set; }
        [MaxLength(50)]
        [Required]
        public string? PhoneNumber { get; set; }
        [MaxLength(50)]

        public string? Position { get; set; }

        [Required]
        public DateTime? HireDate { get; set; }

        public double Salary { get; set; }
    }
}