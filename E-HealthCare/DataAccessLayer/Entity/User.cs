using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HealthCare.DataAccessLayer.Entity
{
    class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string BloodGroup { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public string Qualification { get; set; }
        public double Fees { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }
}
