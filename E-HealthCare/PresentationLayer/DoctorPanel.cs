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
    public partial class DoctorPanel : Form
    {
        public DoctorPanel()
        {
            InitializeComponent();
        }

        private void DoctorPanel_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
