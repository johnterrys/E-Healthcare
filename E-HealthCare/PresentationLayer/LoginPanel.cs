using E_HealthCare.BusinessLayer;
using E_HealthCare.DataAccessLayer.Entity;
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
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void LoginPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Name can not be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
            }
            else
            {
                //For Testing Purpose (Zihan)
                UserService userService = new UserService();
                User user = userService.GetUser(userNameTextBox.Text, passwordTextBox.Text);
                if (user != null)
                {
                    DoctorPanel doctorPanel = new DoctorPanel(user.UserId, user.Name);
                    this.Hide();
                    doctorPanel.Show();
                }
                else 
                { 
                    MessageBox.Show("You Don't Have Any Account!"); 
                }
                //For Testing Purpose (Zihan)


                /* UserService userService = new UserService();
                 User user = userService.GetUser(nameTextBox.Text, passwordTextBox.Text);
                 if (user != null)
                 {
                     HomePanel homePanel = new HomePanel(user.UserId, user.Username);
                     this.Hide();
                     homePanel.Show();
                 }
                 else { MessageBox.Show("You Don't Have Any Account!"); }*/
            }
        }
    }
}
