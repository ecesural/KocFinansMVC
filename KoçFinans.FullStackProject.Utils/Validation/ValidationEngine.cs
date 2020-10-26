using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace KoçFinans.FullStackProject.Utils.Validation
{
    public class ValidationEngine : IValidationService
    {
        public ValidationEngine()
        {

        }
        public string CheckModelHasErrorMessage(ICollection<ModelState> values)
        {
            foreach (var modelState in values)
            {
                foreach (var error in modelState.Errors)
                {
                    return error.ErrorMessage;
                }
            }
            return "";
        }
        public bool _IsPhoneNumber(string phoneNumber)
        {
            string result = @"^((\d{3})-(\d{3})-(\d{4}))$";
            Match match = Regex.Match(phoneNumber, result, RegexOptions.IgnoreCase);

            return match.Success;
        }


    }
}

