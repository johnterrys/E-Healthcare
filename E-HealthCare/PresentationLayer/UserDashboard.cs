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
    public partial class UserDashboard : Form
    {
        int userId;
        int role;
        string userName;
        public UserDashboard(int userId, string userName, int role)
        {
            InitializeComponent();
            this.userId = userId;
            this.userName = userName;
            this.role = role;
        }

        private void UserDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = this.userName;
        }
    }
}
