using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

public class SMSService
{
    private readonly string _accountSid;
    private readonly string _authToken;
    private readonly string _baseUrl = "https://api.twilio.com/2010-04-01/Accounts/{0}/Messages.json";

    public SMSService(string accountSid, string authToken)
    {
        _accountSid = accountSid;
        _authToken = authToken;
    }

    public async Task SendOtpAsync(string phoneNumber, string otp)
    {
        var url = string.Format(_baseUrl, _accountSid);
        var client = new HttpClient();
        var payload = new JObject
        {
            { "To", phoneNumber },
            { "From", "+919123317556" },
            { "Body", $"Your OTP is: {otp}" }
        };

        var response = await client.PostAsync(url, new StringContent(payload.ToString(), Encoding.UTF8, "application/json"));
        response.EnsureSuccessStatusCode();
    }
}
