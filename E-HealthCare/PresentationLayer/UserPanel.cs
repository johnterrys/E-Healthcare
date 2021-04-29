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
    public partial class UserPanel : Form
    {
        public UserPanel( int userId, string name)
        {
            InitializeComponent();
        }

        private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            this.Hide();
            loginPanel.Show();
        }
    }
}
