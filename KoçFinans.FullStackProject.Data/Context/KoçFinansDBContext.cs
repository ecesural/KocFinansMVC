using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoçFinans.FullStackProject.Data.Entity;

namespace KoçFinans.FullStackProject.Data.Context
{
  public  class KoçFinansDBContext :DbContext
    {
        public KoçFinansDBContext() : base("name = KocFinans")
        {

            Database.SetInitializer<KoçFinansDBContext>(null);
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }
        public virtual DbSet<UserInformation> UserInformation { get; set; }

        public virtual DbSet<CreditScore> CreditScore { get; set; }

    }
}