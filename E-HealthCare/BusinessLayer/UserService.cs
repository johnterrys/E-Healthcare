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

        public List<User> GetAdminUser()
        {
            return this.userDataAccess.GetAdminUser();
        }

        public List<User> GetAdminDoctor()
        {
            return this.userDataAccess.GetAdminDoctor();
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

        public int AddNewDoctor(string name, string userName, string password, string dob, string bg, string institute, string degree, string designation,
            string shiftOne, string shiftTwo,string department,float fee,string gender, int age, int role, string phone, string address)
        {

            User user = new User() { Name = name, UserName = userName, Password = password, DoB = dob, Qualification = degree, Institute = institute , Fees = fee,
                BloodGroup = bg, Gender = gender, Age = age, Role = role, Phone = phone, Address = address, Designation = designation, Department = department};
            return this.userDataAccess.AddDoctor(user);
        }
    }
}
