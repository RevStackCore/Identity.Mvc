using System;


namespace RevStackCore.Identity.Mvc
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class BaseEmailMessage
    {
        public string Subject { get; set; }
        public string Body { get; set; }
    }

   
}
