
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeCafeDay.Models
{
    public class OTPModel
    {
        [Required]
        [Key]
        public string PhoneNumber { get; set; }
        public string OTP { get; set; }
        public string EnteredOTP { get; set; } // This property will hold the OTP entered by the user for verification
        public DateTime ExpiryTime { get; set; }
    }

}