using E_HealthCare.DataAccessLayer;
using E_HealthCare.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HealthCare.BusinessLayer
{
    class UserService
    {
        UserDataAccess userDataAccess;
        public UserService()
        {

            this.userDataAccess = new UserDataAccess();
        }
        public User GetUser(string userName, string password)
        {
            return this.userDataAccess.GetUser(userName, password);
        }
        public User GetPatient(int userId, int appointmentId)
        {
            return userDataAccess.GetPatient(userId, appointmentId);
        }

        public int AddNewUser(string name, string userName, string password, string dob, string bg, string gender, int age, int role, string phone, string address)
        {

            User user = new User() { Name = name, UserName = userName, Password = password, DoB= dob, BloodGroup = bg, Gender = gender, Age = age, Role = role, Phone = phone, Address = address};
            return this.userDataAccess.AddUser(user);
        }
    }
}
