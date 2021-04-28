using E_HealthCare.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HealthCare.DataAccessLayer
{
    class PrescriptionDataAccess: DataAccess
    {
        public Prescription GetUserPrescription(string userId)
        {
            string sql = "SELECT Date,DoctorName,Department,Problem,Advice fROM Prescription WHERE UserId='" + userId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                Prescription prescription = new Prescription();
                prescription.Date = reader["Date"].ToString();
                prescription.DoctorName = reader["DoctorName"].ToString();
                prescription.Department = reader["Department"].ToString();
                prescription.Advice = reader["Advice"].ToString();
                return prescription;
            }
            return null;
        }

        public int AddPrescription(Prescription prescription)
        {
            string sql = "INSERT INTO Prescription(Date,DoctorName,Department,Problem,Advice,UserId) VALUES ('" + prescription.Date + "', '" + prescription.DoctorName + "','" + prescription.Department + "','" + prescription.Problem + "','" + prescription.Advice + "',"+ prescription.UserId + ")";
            return this.ExecuteQuery(sql);
        }
    }
}
