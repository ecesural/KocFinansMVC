using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace KoçFinans.FullStackProject.Utils.Validation
{
   public interface IValidationService
    {
        string CheckModelHasErrorMessage(ICollection<ModelState> values);
        bool _IsPhoneNumber(string phoneNumber);
    }
}
