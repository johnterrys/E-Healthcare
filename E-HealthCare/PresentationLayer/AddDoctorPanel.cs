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
    public partial class AddDoctorPanel : Form
    {
        public AddDoctorPanel()
        {
            InitializeComponent();
        }

        private void AddDoctorPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void instituteLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
