using RAisoLab.Models;
using RAisoLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;

namespace RAisoLab.Handler
{
    public class UserHandler
    {
        UserRepository userRepository = new UserRepository();
        public MsUser Login(String username, String password)
        {
            MsUser user = userRepository.getUserByProfile(username, password);
            return user;
        }

        public void Register(String username, String gender, DateTime dob, String phone, String address, String password)
        {
            userRepository.addUser(username, gender, dob, phone, address, password, "Customer");
        }

        public void UpdateProfile(int UserId, String username, String gender, DateTime dob, String phone, String address, String password)
        {
            MsUser temp = userRepository.getUserById(UserId);
            userRepository.updateUser(UserId, username, dob, gender, phone, address, password);
        }

        public MsUser getUserById(int UserId)
        {
            MsUser user = userRepository.getUserById(UserId);
            return user;
        }
    }
}
