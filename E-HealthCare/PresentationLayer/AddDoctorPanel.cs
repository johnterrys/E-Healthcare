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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Name can not be empty");
            }
            else if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Username can not be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
            }
            else if (bgComboBox.Text == "")
            {
                MessageBox.Show("Blood Group can not be empty");
            }
            else if (phoneTextBox.Text == "")
            {
                MessageBox.Show("Phone can not be empty");
            }
            else if (instituteTextBox.Text == "")
            {
                MessageBox.Show("Institute can not be empty");
            }
            else if (addressTextBox.Text == "")
            {
                MessageBox.Show("Adress can not be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
            }
            else if (shift1TextBox.Text == "")
            {
                MessageBox.Show("Shift One can not be empty");
            }
            else if (shift2TextBox.Text == "")
            {
                MessageBox.Show("Shift Two can not be empty");
            }
            else if (feeTextBox.Text == "")
            {
                MessageBox.Show("Fee can not be empty");
            }
            else if (degreeCheckedListBox.Text == "")
            {
                MessageBox.Show("Degree can not be empty");
            }
            else if (designationComboBox.Text == "")
            {
                MessageBox.Show("Designation can not be empty");
            }
            else if (deptComboBox.Text == "")
            {
                MessageBox.Show("Department can not be empty");
            }
            else
            {
                if (passwordTextBox.Text != confirmTextBox.Text)
                {
                    MessageBox.Show("Password and confirm password does not match");
                }
                else
                {
                    /*UserService userService = new UserService();
                    int result = userService.AddNewUser(nameTextBox.Text, userNameTextBox.Text, passwordTextBox.Text);
                    if (result > 0)
                    {
                        MessageBox.Show("You have been Registerd!");
                        this.Hide();
                        LoginPanel loginPanel = new LoginPanel();
                        loginPanel.Show();
                    }
                    else { MessageBox.Show("Registration Error!"); }*/
                }
            }
        }
    }
}
