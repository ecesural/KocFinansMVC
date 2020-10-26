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
    public class UserInformationRepository : IUserInformationRepository
    {
        public void AddUser(UserInformation userInformation)
        {

            using (var db = new KoçFinansDBContext())
            {

                db.UserInformation.Add(userInformation);
                try
                {
                    db.SaveChanges();
                }
                catch(Exception ex)
                {
                    
                }


            }
        }
    }
}
