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
    public partial class DoctorPanel : Form
    {
        public DoctorPanel(int userId, string Name)
        {
            InitializeComponent();
            DoctorId = userId;
        }

        public int DoctorId { get; set; }

        private void DoctorPanel_Load(object sender, EventArgs e)
        {
            AppointmentService appointmentService = new AppointmentService();
            appoinmentsDataGridView.DataSource = appointmentService.GetDoctorAppointments(DoctorId);
        }

        private void DoctorPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
