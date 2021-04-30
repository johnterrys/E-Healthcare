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
        int adminId;
        string name;
        int userId;
        List<string> department = new List<string> { "","Medicine", "Neurology", "ENT", "Dermatology", "Cardiology" };
        public AdminPanel(int userId, string name)
        {
            InitializeComponent();
            this.adminId = userId;
            this.name = name;
            doctorDepartmentComboBox.DataSource = department;
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
            UserService userService1 = new UserService();
            doctorDataGridView.DataSource = userService1.GetAdminDoctor();
            welcomeLabel.Text = this.name;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            UserRegistrationPanel userRegistrationPanel = new UserRegistrationPanel(this.adminId, this.name);
            this.Hide();
            userRegistrationPanel.Show();
        }

        private void addDoctorButton_Click(object sender, EventArgs e)
        {
            AddDoctorPanel addDoctorPanel = new AddDoctorPanel(this.adminId, this.name);
            this.Hide();
            addDoctorPanel.Show();
        }
        void UpdateLists()
        {
            UserService userService = new UserService();
            usersGridView.DataSource = userService.GetAdminUser();
            UserService userService1 = new UserService();
            doctorDataGridView.DataSource = userService1.GetAdminDoctor();
            welcomeLabel.Text = this.name;
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The Selected User Will be Deleted!", "Delete User", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                UserService userService = new UserService();
                int result = userService.DeleteUser(this.userId);
                if (result > 0)
                {
                    MessageBox.Show("User Deleted!");
                    UpdateLists();
                }
                else { MessageBox.Show("Error!"); }

            }
            else
            {

            }
        }

        private void removeDoctorButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The Selected Doctor Will be Deleted!", "Delete Doctor", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                UserService userService = new UserService();
                int result = userService.DeleteUser(this.userId);
                if (result > 0)
                {
                    MessageBox.Show("Doctor Deleted!");
                    UpdateLists();
                }
                else { MessageBox.Show("Error!"); }

            }
            else
            {

            }
        }

        private void doctorDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.userId = (int)doctorDataGridView.Rows[e.RowIndex].Cells[0].Value;
        }

        private void usersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.userId = (int)usersGridView.Rows[e.RowIndex].Cells[0].Value;
        }

        private void doctorSearchButton_Click(object sender, EventArgs e)
        {
            if (doctorDepartmentComboBox.Text == "")
            {
                UserService userService = new UserService();
                doctorDataGridView.DataSource = userService.GetDoctorByName(doctorNameTextBox.Text);
            }
            else {
                UserService userService = new UserService();
                doctorDataGridView.DataSource = userService.GetDoctorDepartment(doctorDepartmentComboBox.Text);
            }
        }

        private void userSearchButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            usersGridView.DataSource = userService.GetUserByPhone(userSearchTextBox.Text);
        }
    }
}
