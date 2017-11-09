using System;
namespace RevStackCore.Identity.Mvc
{
    public class JwtDecodedPayload
    {
        public string Sub { get; set; }
        public string Jti { get; set; }
        public DateTime Exp { get; set; }
    }
}
