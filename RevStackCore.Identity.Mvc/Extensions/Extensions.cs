using System;
using System.Security.Claims;
using System.Text;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace RevStackCore.Identity.Mvc
{
    public static class Extensions
    {
        public static string ToDisplayName<TKey>(this IProfileModel<TKey> profile)
        {
            if(string.IsNullOrEmpty(profile.FirstName) && string.IsNullOrEmpty(profile.LastName))
            {
                return profile.Email;
            }
            else
            {
                return profile.FirstName + " " + profile.LastName;
            }
        }

		public static string ToDisplayName<TKey>(this IProfileModel<TKey> profile, string emptyResult)
		{
			if (string.IsNullOrEmpty(profile.FirstName) && string.IsNullOrEmpty(profile.LastName))
			{
                return emptyResult;
			}
			else
			{
                return profile.FirstName + " " + profile.LastName;
			}
		}

		public static string ToDisplayPhoneNumber<TKey>(this IProfileModel<TKey> profile, string emptyResult)
		{
            if (string.IsNullOrEmpty(profile.PhoneNumber) && string.IsNullOrEmpty(profile.MobilePhoneNumber))
			{
				return emptyResult;
			}
            else if(!string.IsNullOrEmpty(profile.PhoneNumber))
			{
                return profile.PhoneNumber;
			}
            else if (!string.IsNullOrEmpty(profile.MobilePhoneNumber))
			{
                return profile.MobilePhoneNumber;
			}
            else
            {
                return emptyResult;
            }
		}

        public static string ToDisplaySignUpDate<TKey>(this IProfileModel<TKey> profile)
        {
            return profile.SignUpDate.ToString("D");
        }

		public static string ToDisplaySignUpDate<TKey>(this IProfileModel<TKey> profile, bool useShortDateTimeFormat)
		{
            if(useShortDateTimeFormat)
            {
                return profile.SignUpDate.ToString("d");
            }
            else
            {
                return profile.SignUpDate.ToString("D");
            }

		}

        public static string ToConfigNormalized(this string src, string replace, ConfigFilterType filterType)
        {
            string filter = "[Email]";
            if (filterType == ConfigFilterType.LineBreak)
            {
                src = src.Replace(filter, replace);
            }
            else
            {
                filter = "[br]";
                src = src.Replace(filter, replace);
            }
            return src;
        }

    }
}
