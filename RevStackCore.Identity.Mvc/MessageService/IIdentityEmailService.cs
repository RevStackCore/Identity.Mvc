using System;
using System.Threading.Tasks;

namespace RevStackCore.Identity.Mvc
{
    public interface IIdentityEmailService
    {
        Task SendAsync(string email, string subject, string message);
		Task SendAsync(string email, string subject, string message, string senderAddress);
		Task SendAsync(string email, string subject, string message, bool isHTML);
		Task SendAsync(string email, string subject, string message, string senderAddress, bool isHTML);
    }
}
