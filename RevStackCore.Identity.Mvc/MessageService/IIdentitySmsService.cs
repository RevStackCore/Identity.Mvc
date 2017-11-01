using System;
using System.Threading.Tasks;

namespace RevStackCore.Identity.Mvc
{
    public interface IIdentitySmsService
    {
        Task SendAsync(string number, string message);
    }
}
