using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoçFinans.FullStackProject.Data.Entity;

namespace KoçFinans.FullStackProject.Business.DTO
{
   public class UserCreditDTO
    {
        public CreditLimit CreditLimit { get; set; }

        public UserInformation UserInformation { get; set; }

    }
}
