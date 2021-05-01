using E_HealthCare.DataAccessLayer;
using E_HealthCare.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HealthCare.BusinessLayer
{
    class PrescriptionService
    {
        PrescriptionDataAccess prescriptionDataAccess;

        public PrescriptionService() {
            this.prescriptionDataAccess = new PrescriptionDataAccess();
        }
        public int AddPrescription(Prescription prescription)
        { 
            prescriptionDataAccess.AddPrescription(prescription);
            return prescriptionDataAccess.GetPrescriptionId(prescription.UserId, prescription.DoctorName);
        }

        public string GetProblem(int appointmentId)
        {
            return prescriptionDataAccess.GetProblem(appointmentId);
        }

        public List<Prescription> GetUserPrescriptions(int userId)
        {
            return prescriptionDataAccess.GetUserPrescriptions(userId);
        }

        public Prescription GetUserPrescription(int prescriptionId)
        {
            PrescriptionDataAccess prescriptionDataAccess = new PrescriptionDataAccess();
            return prescriptionDataAccess.GetUserPrescription(prescriptionId);
        }
    }
}
