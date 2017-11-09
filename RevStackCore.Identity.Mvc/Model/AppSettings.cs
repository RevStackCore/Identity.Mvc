using System;
namespace RevStackCore.Identity.Mvc
{
    public class EmailConfiguration
    {
        public string Host { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string From { get; set; }
    }

    public class MessagingConfiguration
    {
        public EmailConfiguration Email { get; set; }
        public string Valediction { get; set; }
        public CompanyConfiguration Company { get; set; }
        public CssAttributesConfiguration CssAttributes { get; set; }
    }

    public class CompanyConfiguration
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string LogoUrl { get; set; }
        public string From { get; set; }
    }

    public class CssAttributesConfiguration
    {
        public string HightlightColor { get; set; }
        public string LinkColor { get; set; }
    }

    public class OAuthSettingsConfiguration
    {
        public string AppId { get; set; }
        public string AppSecret { get; set; }
    }

    public class BaseMessagingConfiguration
    {
        public EmailConfiguration Email { get; set; }
    }

    public class JwtTokenConfiguration
    {
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}
