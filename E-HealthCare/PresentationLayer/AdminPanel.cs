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
    public partial class AdminPanel : Form
    {
        int userId;
        string name;
        public AdminPanel(int userId, string name)
        {
            InitializeComponent();
            this.userId = userId;
            this.name = name;
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            this.Hide();
            loginPanel.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            usersGridView.DataSource = userService.GetAdminUser();
            welcomeLabel.Text = this.name;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            UserRegistrationPanel userRegistrationPanel = new UserRegistrationPanel(this.userId, this.name);
            this.Hide();
            userRegistrationPanel.Show();
        }
    }
}
