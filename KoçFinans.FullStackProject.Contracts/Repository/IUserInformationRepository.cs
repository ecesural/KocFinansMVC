﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoçFinans.FullStackProject.Data.Entity;

namespace KoçFinans.FullStackProject.Contracts.Repository
{
   public interface IUserInformationRepository
    {
        void AddUser(UserInformation userInformation);
    }
}
