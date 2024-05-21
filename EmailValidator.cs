using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidatorApp
{
    public static class EmailValidator
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            if (email.StartsWith(" ") || email.EndsWith(" "))
                return false;

            if (email.Length < 3 || email.Length > 100)
                return false;

            int atIndex = email.IndexOf("@");
            if (atIndex < 1 || atIndex != email.LastIndexOf("@"))
                return false;

            string localPart = email.Substring(0, atIndex);
            string domainPart = email.Substring(atIndex + 1);

            if (domainPart.Length < 3 || domainPart.Length > 100)
                return false;

            if (!domainPart.Contains("."))
                return false;

            return true;
        }
    }
}