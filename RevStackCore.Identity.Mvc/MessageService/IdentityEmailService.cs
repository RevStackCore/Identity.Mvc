using System;
using System.Threading.Tasks;
using System.Net;
using RevStackCore.Net;

namespace RevStackCore.Identity.Mvc
{
    public class IdentityEmailService : IIdentityEmailService
    {
		private string _host;
		private string _user;
		private string _password;
		private string _from;
        private NetworkCredential _credential;
        public IdentityEmailService(string host, string user, string password, string from)
        {
            _host = host;
            _user = user;
            _password = password;
            _from = from;
            _credential = new NetworkCredential(_user, _password);
        }

        public Task SendAsync(string email, string subject, string message)
        {
            Smtp.SendMail(email, _from, subject, message, false, _host, _credential);
            return Task.FromResult(true);
        }

        public Task SendAsync(string email, string subject, string message, string senderAddress)
        {
            Smtp.SendMail(email, senderAddress, subject, message, false, _host, _credential);
			return Task.FromResult(true);
        }

        public Task SendAsync(string email, string subject, string message, bool isHTML)
        {
            Smtp.SendMail(email, _from, subject, message, isHTML, _host, _credential);
			return Task.FromResult(true);
        }

        public Task SendAsync(string email, string subject, string message, string senderAddress, bool isHTML)
        {
            Smtp.SendMail(email, senderAddress, subject, message, isHTML, _host, _credential);
			return Task.FromResult(true);
        }
    }
}
