using System;

namespace RevStackCore.Identity.Mvc
{
    public class BaseApplicationUser : IdentityUser
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Street { get; set; }
		public string ZipCode { get; set; }
        public string Avatar { get; set; }
        public string MobilePhoneNumber { get; set; }
    }
}
