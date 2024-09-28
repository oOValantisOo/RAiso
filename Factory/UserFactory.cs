using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAisoLab.Factory
{
    public class UserFactory
    {
        public static MsUser Create(string UserName, string UserGender, DateTime UserDOB, string UserPhone, string UserAddress, string UserPassword, string UserRole)
        {
            MsUser user = new MsUser();

            user.UserName = UserName;
            user.UserGender = UserGender;
            user.UserRole = UserRole;
            user.UserDOB = UserDOB;
            user.UserPassword = UserPassword;
            user.UserPhone = UserPhone;
            user.UserAddress = UserAddress;

            return user;
        }
    }
}
