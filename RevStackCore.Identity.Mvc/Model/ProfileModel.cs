using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RevStackCore.Pattern;

namespace RevStackCore.Identity.Mvc
{

    public interface IProfileCardModel<TKey> : IEntity<TKey>
    {
        string DisplayName { get; set; }
        string Email { get; set; }
        string Avatar { get; set; }
        bool SignedIn { get; set; }
    }

	public interface IProfileModel<TKey> : IEntity<TKey>
	{
		string UserName { get; set; }
        string FirstName { get; set; }
		string LastName { get; set; }
		string Email { get; set; }
		string Street { get; set; }
		string City { get; set; }
		string State { get; set; }
		string ZipCode { get; set; }
		string PhoneNumber { get; set; }
        string MobilePhoneNumber { get; set; }
        string Avatar { get; set; }
		DateTime SignUpDate { get; set; }
        IEnumerable<string> Roles { get; set; }
	}

    public class ProfileCardModel<TKey> : IProfileCardModel<TKey>
    {
		public TKey Id { get; set; }
        public string DisplayName { get; set; }
		public string Email { get; set; }
		public string Avatar { get; set; }
		public bool SignedIn { get; set; }
    }

	public class ProfileModel<TKey> : IProfileModel<TKey>
	{
		public TKey Id { get; set; }
		public string UserName { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		[Required]
		public string Email { get; set; }
		public string Street { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string ZipCode { get; set; }
		public string PhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string Avatar { get; set; }
		public DateTime SignUpDate { get; set; }
        public IEnumerable<string> Roles { get; set; }

		public ProfileModel()
		{
			Roles = new List<string>();
		}
	}

    public class ProfileModel : ProfileModel<string> {}
}
