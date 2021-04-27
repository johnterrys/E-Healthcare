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
        public PatientPanel()
        {
            InitializeComponent();
        }

        private void PatientPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void PatientPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
