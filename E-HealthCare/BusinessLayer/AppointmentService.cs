using E_HealthCare.DataAccessLayer;
using E_HealthCare.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HealthCare.BusinessLayer
{
    class AppointmentService
    {
        public List<Appointment> GetDoctorAppointments(int doctorId)
        {
            AppointmentDataAccess appointmentDataAccess = new AppointmentDataAccess();
            return appointmentDataAccess.GetDoctorAppointments(doctorId);
        }
    }
}
