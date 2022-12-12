using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Wet
{
    public class AuthOptions
    {
        public const string ISSUER = "https://localhost:7201";
        public const string AUDIENCE = "https://localhost:7201";
        const string KEY = "r4u7x!A%D*G-KaPd";   
        public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
    }
}
