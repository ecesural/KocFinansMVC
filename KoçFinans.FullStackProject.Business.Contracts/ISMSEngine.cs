using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoçFinans.FullStackProject.Business.Contracts
{
   public interface ISMSEngine
    {
        bool SendSms(string phoneNumber);
    }
}
