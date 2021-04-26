
namespace E_HealthCare.PresentationLayer
{
    partial class UserPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ehealthcareLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.createAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentListLabel = new System.Windows.Forms.Label();
            this.appointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.orderByButton = new System.Windows.Forms.Button();
            this.prescriptionLabel = new System.Windows.Forms.Label();
            this.prescriptionDataGridView = new System.Windows.Forms.DataGridView();
            this.bloodRequestButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ehealthcareLabel
            // 
            this.ehealthcareLabel.AutoSize = true;
            this.ehealthcareLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ehealthcareLabel.Location = new System.Drawing.Point(303, 9);
            this.ehealthcareLabel.Name = "ehealthcareLabel";
            this.ehealthcareLabel.Size = new System.Drawing.Size(166, 24);
            this.ehealthcareLabel.TabIndex = 8;
            this.ehealthcareLabel.Text = "E-healthcare";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(622, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(79, 18);
            this.welcomeLabel.TabIndex = 21;
            this.welcomeLabel.Text = "Welcome";
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(638, 599);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(77, 32);
            this.logoutButton.TabIndex = 20;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // createAppointmentButton
            // 
            this.createAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAppointmentButton.Location = new System.Drawing.Point(558, 130);
            this.createAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createAppointmentButton.Name = "createAppointmentButton";
            this.createAppointmentButton.Size = new System.Drawing.Size(122, 67);
            this.createAppointmentButton.TabIndex = 24;
            this.createAppointmentButton.Text = "Make Appointment";
            this.createAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // appointmentListLabel
            // 
            this.appointmentListLabel.AutoSize = true;
            this.appointmentListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentListLabel.Location = new System.Drawing.Point(137, 65);
            this.appointmentListLabel.Name = "appointmentListLabel";
            this.appointmentListLabel.Size = new System.Drawing.Size(171, 18);
            this.appointmentListLabel.TabIndex = 23;
            this.appointmentListLabel.Text = "Current Appointments";
            // 
            // appointmentsDataGridView
            // 
            this.appointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGridView.Location = new System.Drawing.Point(140, 94);
            this.appointmentsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentsDataGridView.Name = "appointmentsDataGridView";
            this.appointmentsDataGridView.RowHeadersWidth = 51;
            this.appointmentsDataGridView.RowTemplate.Height = 24;
            this.appointmentsDataGridView.Size = new System.Drawing.Size(395, 150);
            this.appointmentsDataGridView.TabIndex = 22;
            // 
            // orderByButton
            // 
            this.orderByButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByButton.Location = new System.Drawing.Point(624, 370);
            this.orderByButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderByButton.Name = "orderByButton";
            this.orderByButton.Size = new System.Drawing.Size(73, 71);
            this.orderByButton.TabIndex = 28;
            this.orderByButton.Text = "Order By Date";
            this.orderByButton.UseVisualStyleBackColor = true;
            // 
            // prescriptionLabel
            // 
            this.prescriptionLabel.AutoSize = true;
            this.prescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionLabel.Location = new System.Drawing.Point(55, 312);
            this.prescriptionLabel.Name = "prescriptionLabel";
            this.prescriptionLabel.Size = new System.Drawing.Size(108, 18);
            this.prescriptionLabel.TabIndex = 27;
            this.prescriptionLabel.Text = "Prescriptions";
            // 
            // prescriptionDataGridView
            // 
            this.prescriptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prescriptionDataGridView.Location = new System.Drawing.Point(58, 332);
            this.prescriptionDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prescriptionDataGridView.Name = "prescriptionDataGridView";
            this.prescriptionDataGridView.RowHeadersWidth = 51;
            this.prescriptionDataGridView.RowTemplate.Height = 24;
            this.prescriptionDataGridView.Size = new System.Drawing.Size(549, 150);
            this.prescriptionDataGridView.TabIndex = 26;
            // 
            // bloodRequestButton
            // 
            this.bloodRequestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodRequestButton.Location = new System.Drawing.Point(217, 517);
            this.bloodRequestButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bloodRequestButton.Name = "bloodRequestButton";
            this.bloodRequestButton.Size = new System.Drawing.Size(106, 70);
            this.bloodRequestButton.TabIndex = 29;
            this.bloodRequestButton.Text = "Blood Request";
            this.bloodRequestButton.UseVisualStyleBackColor = true;
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.Location = new System.Drawing.Point(413, 517);
            this.findButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(110, 70);
            this.findButton.TabIndex = 30;
            this.findButton.Text = "Find Ambulance";
            this.findButton.UseVisualStyleBackColor = true;
            // 
            // dashboardButton
            // 
            this.dashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.Location = new System.Drawing.Point(589, 39);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(126, 32);
            this.dashboardButton.TabIndex = 31;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.UseVisualStyleBackColor = true;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 652);
            this.Controls.Add(this.dashboardButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.bloodRequestButton);
            this.Controls.Add(this.orderByButton);
            this.Controls.Add(this.prescriptionLabel);
            this.Controls.Add(this.prescriptionDataGridView);
            this.Controls.Add(this.createAppointmentButton);
            this.Controls.Add(this.appointmentListLabel);
            this.Controls.Add(this.appointmentsDataGridView);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.ehealthcareLabel);
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserPanel_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ehealthcareLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button createAppointmentButton;
        private System.Windows.Forms.Label appointmentListLabel;
        private System.Windows.Forms.DataGridView appointmentsDataGridView;
        private System.Windows.Forms.Button orderByButton;
        private System.Windows.Forms.Label prescriptionLabel;
        private System.Windows.Forms.DataGridView prescriptionDataGridView;
        private System.Windows.Forms.Button bloodRequestButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button dashboardButton;
    }
}