using System;

namespace RevStackCore.Identity.Mvc
{
    public class BaseApplicationUser : IdentityUser
    {
		public virtual string FirstName { get; set; }
		public virtual string LastName { get; set; }
		public virtual string City { get; set; }
		public virtual string State { get; set; }
		public virtual string Street { get; set; }
		public virtual string ZipCode { get; set; }
        public virtual string Avatar { get; set; }
        public virtual string MobilePhoneNumber { get; set; }
    }
}
