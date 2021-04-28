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
<<<<<<< HEAD
        public User GetUser(string userName, string password)
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            var user = userDataAccess.GetUser(userName, password);
            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
=======
        
>>>>>>> 4245b7778979ec2400fef0f06085d997ec435c21
    }
}
