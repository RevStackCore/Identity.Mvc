using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using RevStackCore.Extensions.Mvc;

namespace RevStackCore.Identity.Mvc
{
	public class SignInModel
	{
		public string UserName { get; set; }
        [Required]
		public string Email { get; set; }
        [Required]
		public string Password { get; set; }
		public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
		public SignInModel()
		{
			RememberMe = true;
		}
	}

	public class SignUpModel
	{
		public string UserName { get; set; }
		[Required]
		public string Email { get; set; }
        [Required]
		public string Password { get; set; }
		public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
		public List<string> Roles { get; set; }

		public SignUpModel()
		{
			Roles = new List<string>();
			RememberMe = true;
		}
	}

	public class ManageLoginsModel
	{
		public IList<UserLoginInfo> CurrentLogins { get; set; }
		public IList<AuthenticationDescription> OtherLogins { get; set; }
	}

	public class RemoveLoginModel
	{
		public string LoginProvider { get; set; }
		public string ProviderKey { get; set; }
	}

	public class FactorModel
	{
		public string Purpose { get; set; }
	}

	public class SetPasswordModel
	{
		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "New password")]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "Confirm new password")]
		[System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The new password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }
	}

	public class ResetPasswordModel
	{

		[Required]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "New password")]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "Confirm new password")]
		[System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The new password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }

		public string Code { get; set; }
	}

	public class ChangePasswordModel
	{
		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "Current password")]
		public string OldPassword { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "New password")]
		public string NewPassword { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "Confirm new password")]
		[System.ComponentModel.DataAnnotations.Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }
	}

	public class ForgotPasswordModel
	{
		[Required]
		[EmailAddress]
		[Display(Name = "Email")]
		public string Email { get; set; }
	}

	public class AddPhoneNumberModel
	{
		[Required]
		[Phone]
		[Display(Name = "Phone Number")]
		public string Number { get; set; }
	}

	public class RemovePhoneNumberModel
	{
		[Required]
		[Phone]
		[Display(Name = "Phone Number")]
		public string Number { get; set; }
	}

	public class VerifyPhoneNumberModel
	{
		[Required]
		[Display(Name = "Code")]
		public string Code { get; set; }

		[Required]
		[Phone]
		[Display(Name = "Phone Number")]
		public string PhoneNumber { get; set; }
	}

	public class ConfigureTwoFactorModel
	{
		public string SelectedProvider { get; set; }
		public ICollection<SelectListItem> Providers { get; set; }
	}

	public class ExternalLoginConfirmationModel
	{
		[Required]
		[Display(Name = "Email")]
		public string Email { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}

	public class ExternalLoginListModel
	{
		public string ReturnUrl { get; set; }
	}

	public class SendCodeModel
	{
		[SelectRequired]
		public string Provider { get; set; }
		public ICollection<SelectListItem> Providers { get; set; }
		public string ReturnUrl { get; set; }
		public bool RememberMe { get; set; }
		public SendCodeModel()
		{
			Provider = "Select";
		}
	}


	public class VerifyCodeModel
	{
		[Required]
		public string Provider { get; set; }

		[Required]
		[Display(Name = "Code")]
		public string Code { get; set; }

		public string ReturnUrl { get; set; }

		[Display(Name = "Remember this browser?")]
		public bool RememberBrowser { get; set; }

		public bool RememberMe { get; set; }

	}
}
