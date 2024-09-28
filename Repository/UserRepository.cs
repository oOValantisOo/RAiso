using RAisoLab.Factory;
using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAisoLab.Repository
{
    public class UserRepository
    {
        RAisoDatabaseEntities1 db = Singleton.Singleton.getInstance();

        public List<MsUser> getAllUsers()
        {
            return (from x in db.MsUsers select x).ToList();
        }

        public MsUser getUserByProfile(String username, String password)
        {
            return (from x in db.MsUsers where (x.UserName == username && x.UserPassword == password) select x).FirstOrDefault();
        }

        public MsUser getUserById(int id)
        {
            return (from x in db.MsUsers where x.UserID == id select x).FirstOrDefault();
        }

        public void removeUser(int id)
        {
            MsUser temp = getUserById(id);

            db.MsUsers.Remove(temp);
            db.SaveChanges();
        }

        public void updateUser(int id, String username, DateTime dob, String gender, String phone, String address, String password)
        {
            MsUser temp = getUserById(id);

            temp.UserPhone = phone;
            temp.UserGender = gender;
            temp.UserAddress = address;
            temp.UserDOB = dob;
            temp.UserName = username;

            db.SaveChanges();
        }
        public void addUser(string UserName, string UserGender, DateTime UserDOB, string UserPhone, string UserAddress, string UserPassword, string UserRole)
        {
            MsUser user = UserFactory.Create(UserName, UserGender, UserDOB, UserPhone, UserAddress, UserPassword, UserRole);

            db.MsUsers.Add(user);
            db.SaveChanges();
        }
    }
}