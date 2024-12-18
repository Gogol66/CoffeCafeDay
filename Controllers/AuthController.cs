using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CoffeCafeDay.Models;
using System;
using System.Threading.Tasks;
namespace CoffeCafeDay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SMSService _smsService;

        public AuthController(SMSService smsService)
        {
            _smsService = smsService;
        }

        [HttpPost("sendotp")]
        public async Task<IActionResult> SendOtp([FromBody] OTPModel model)
        {
            if (ModelState.IsValid)
            {
                var otp = GenerateOtp();
                model.OTP = otp;
                model.ExpiryTime = DateTime.UtcNow.AddMinutes(10);
                await _smsService.SendOtpAsync(model.PhoneNumber, otp);
                return Ok(new { message = "OTP sent successfully." });
            }
            return BadRequest(ModelState);
        }

        [HttpPost("verifyotp")]
        public IActionResult VerifyOtp([FromBody] OTPModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ExpiryTime > DateTime.UtcNow && model.OTP == model.EnteredOTP)
                {
                    return Ok(new { message = "OTP verified successfully." });
                }
                return BadRequest(new { message = "Invalid OTP or expired." });
            }
            return BadRequest(ModelState);
        }

        private string GenerateOtp()
        {
            var random = new Random();
            return random.Next(100000, 999999).ToString();
        }
    }
}

