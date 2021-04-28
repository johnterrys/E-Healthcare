using E_HealthCare.DataAccessLayer.Entity;
using Newtonsoft.Json;
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
    public partial class CreatePrescription : Form
    {
        public CreatePrescription()
        {
            InitializeComponent();
            Prescription = new List<Medicine>();
        }

        public List<Medicine> Prescription { get; set; }

        private void addMedicineButton_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.MedicineName = medicineNameTextBox.Text;
            medicine.Comment = commentTextBox.Text;
            Prescription.Add(medicine);
        }

        public void addJSON(List<Medicine> prescription)
        {
            string strResultJson = JsonConvert.SerializeObject(prescription);
            commentTextBox.Text = strResultJson;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            addJSON(Prescription);
        }
    }
}
