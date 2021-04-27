﻿using System;
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
    public partial class UserRegistrationPanel : Form
    {
        public UserRegistrationPanel()
        {
            InitializeComponent();
            registerButton.Enabled = false;
        }

        private void UserRegistrationPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void registerButton_Click(object sender, EventArgs e)
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
            else if (addressTextBox.Text == "")
            {
                MessageBox.Show("Adress can not be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
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

        private void termsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (termsCheckBox.Checked)
            {
                registerButton.Enabled = true;
            }
            else
                registerButton.Enabled = false;
        }
    }
}
