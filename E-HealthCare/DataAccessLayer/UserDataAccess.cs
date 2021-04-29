using E_HealthCare.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HealthCare.DataAccessLayer
{
    class UserDataAccess: DataAccess
    {
        public User GetUser(string userName, string password)
        {
            string sql = "SELECT * FROM Users WHERE UserName='" + userName + "' AND Password='" + password + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                User user = new User();
                user.UserId = Convert.ToInt32(reader["UserId"]);
                user.Name = reader["Name"].ToString();
                return user;
            }
            return null;
        }

        //Created by (zihan) for PatientPanel 
        public User GetPatient(int userId, int appointmentId)
        {
            //getting data from two tables because "Problem" column is not present in "Users" table
            string sql = "SELECT * FROM Users WHERE UserId = " + userId; 
            string sql2 = "SELECT * FROM Appointments WHERE AppointmentId = " + appointmentId;
            User user = new User();
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                user.Name = reader["Name"].ToString();
                user.Age = Convert.ToInt32(reader["Age"]);
                user.BloodGroup = reader["BloodGroup"].ToString();
            }
            reader.Close();
            SqlDataReader reader2 = this.GetData(sql2);
            if (reader2.Read())
            {
                user.Problem = reader2["Problem"].ToString();
            }
            return user;
        }

        public int AddUser(User user)
        {
            string sql = "INSERT INTO Users(Name,Username,DoB,BloodGroup,Phone,Address,Password) VALUES ('" + user.Name + "', '" + user.UserName + "','" + user.DoB + "','" + user.BloodGroup + "','" + user.Phone + "','" + user.Address + "', '" + user.Password + "')";
            return this.ExecuteQuery(sql);
        }

        public int AddDoctor(User user)
        {
            string sql = "INSERT INTO Users(Name,Username,DoB,BloodGroup,Phone,Address,Department,Qualification,Institute,Designation,Fees,Password,ShiftOne,ShiftTwo,Role) VALUES ('" + user.Name + "', '" + user.UserName + "','" + user.DoB + "','" + user.BloodGroup + "','" + user.Phone + "','" + user.Address + "','" + user.Department + "','" + user.Qualification + "','" + user.Institute + "','" + user.Designation + "',"+ user.Fees+",'" + user.Password + "','" +user.ShiftOne + "', '" + user.ShiftTwo + "',"+user.Role+")";
            return this.ExecuteQuery(sql);
        }
    }
}
