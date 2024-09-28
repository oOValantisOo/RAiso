using CrystalDecisions.ReportSource;
using RAisoLab.Handler;
using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Linq;

namespace RAisoLab.Controller
{
    public class UserController
    {
        UserHandler handler = new UserHandler();
        public String doRegister(string UserName, string UserGender, DateTime UserDOB, string UserPhone, string UserAddress, string UserPassword)
        {
            DateTime current = DateTime.Now;
            if (UserName == "" || UserGender == "" || UserDOB == null || UserPhone == "" || UserPassword == "")
            {
                return "All fields must be filled";
            }
            else if (UserName.Length < 5 || UserName.Length > 50)
            {
                return "Length of Username must be between 5 and 50 characters long";
            }
            else if (current > DateTime.Now.AddYears(-1))
            {
                return "Date of birth must be at least 1 year old";
            }
            else if (!UserPassword.Any(char.IsLetter) || !UserPassword.Any(char.IsDigit))
            {
                return "Password must contain both letters and numbers";
            }
            else if (!UserPassword.All(char.IsLetterOrDigit))
            {
                return "Password must be alphanumeric (letters and digits only)";
            }
            handler.Register(UserName, UserGender, UserDOB, UserPhone, UserAddress, UserPassword);
            return "Success";
        }

        public MsUser doLogin(String UserName, String Password)
        {
            MsUser user = handler.Login(UserName, Password);
            return user;
        }

        public String doProfileUpdate(int userId, string UserName, string UserGender, DateTime UserDOB, string UserPhone, string UserAddress, string UserPassword)
        {
            DateTime current = DateTime.Now;
            if (UserName == "" || UserGender == "" || UserDOB == null || UserPhone == "" || UserPassword == "")
            {
                return "All fields must be filled";
            }
            else if (UserName.Length < 5 || UserName.Length > 50)
            {
                return "Length of Username must be between 5 and 50 characters long";
            } else if (current > DateTime.Now.AddYears(-1))
            {
                return "Date of birth must be at least 1 year old";
            }
            else if (UserPassword.All(char.IsLetterOrDigit) != true)
            {
                return "Password must be alphanumeric";
            } else if (!UserPassword.Any(char.IsLetter) || !UserPassword.Any(char.IsDigit))
            {
                return "Password must contain both letters and numbers";
            } else if (!UserPassword.All(char.IsLetterOrDigit))
            {
                return "Password must be alphanumeric (letters and digits only)";
            }
            handler.UpdateProfile(userId, UserName, UserGender, UserDOB, UserPhone, UserAddress, UserPassword);
            return "Success";
        }

        public MsUser getUserById(int userId)
        {
            UserHandler handler = new UserHandler();
            MsUser user = handler.getUserById(userId);
            return user;
        }
    }
}