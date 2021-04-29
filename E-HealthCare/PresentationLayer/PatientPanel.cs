using E_HealthCare.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_HealthCare.PresentationLayer
{
    public partial class PatientPanel : Form
    {
        public PatientPanel(int patientId, int appointmentId, string doctorName)
        {
            InitializeComponent();
            PatientId = patientId;
            AppointmentId = appointmentId;
            DoctorName = doctorName;
        }

        public int PatientId { get; set; }
        public int AppointmentId { get; set; }
        public string DoctorName { get; set; }

        private void PatientPanel_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            var patient = userService.GetPatient(PatientId, AppointmentId);
            namelabel.Text = patient.Name;
            problemLabel.Text = patient.Problem;
            bloodGroupLabel.Text = patient.BloodGroup;
            ageLabel.Text = patient.Age.ToString();
        }

        private void PatientPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void createPrescriptionButton_Click(object sender, EventArgs e)
        {
            CreatePrescription createPrescription = new CreatePrescription(DoctorName, PatientId, AppointmentId);
            createPrescription.Show();
        }
    }
}
