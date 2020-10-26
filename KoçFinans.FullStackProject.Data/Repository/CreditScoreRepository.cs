using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoçFinans.FullStackProject.Contracts.Repository;
using KoçFinans.FullStackProject.Data.Context;
using KoçFinans.FullStackProject.Data.Entity;

namespace KoçFinans.FullStackProject.Data.Repository
{
   public class CreditScoreRepository: ICreditScoreRepository
    {
        public long GetCreditSkor(long TCNo)
        {

            using (var db = new KoçFinansDBContext())
            {
                var query = (from k in db.CreditScore 
                             where k.TCNo == TCNo
                             select k.Score).FirstOrDefault();


                return query;
            }
          

        }
    }
}
