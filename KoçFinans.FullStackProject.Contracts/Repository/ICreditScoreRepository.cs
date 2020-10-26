using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoçFinans.FullStackProject.Contracts.Repository
{
 public  interface ICreditScoreRepository
    {
        long GetCreditSkor(long kimlikNo);
    }
}
