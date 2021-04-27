
namespace E_HealthCare.PresentationLayer
{
    partial class DoctorPanel
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
            this.appoinmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.oldNewTriggerButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.appoinmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.appoinmentPanelButton = new System.Windows.Forms.Button();
            this.MedicinePanelButton = new System.Windows.Forms.Button();
            this.profilePanelButton = new System.Windows.Forms.Button();
            this.appoinmentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appoinmentsGroupBox
            // 
            this.appoinmentsGroupBox.Controls.Add(this.oldNewTriggerButton);
            this.appoinmentsGroupBox.Controls.Add(this.doneButton);
            this.appoinmentsGroupBox.Controls.Add(this.appoinmentsDataGridView);
            this.appoinmentsGroupBox.Location = new System.Drawing.Point(273, 15);
            this.appoinmentsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appoinmentsGroupBox.Name = "appoinmentsGroupBox";
            this.appoinmentsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appoinmentsGroupBox.Size = new System.Drawing.Size(492, 304);
            this.appoinmentsGroupBox.TabIndex = 0;
            this.appoinmentsGroupBox.TabStop = false;
            this.appoinmentsGroupBox.Text = "Appoinments";
            // 
            // oldNewTriggerButton
            // 
            this.oldNewTriggerButton.Location = new System.Drawing.Point(8, 268);
            this.oldNewTriggerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oldNewTriggerButton.Name = "oldNewTriggerButton";
            this.oldNewTriggerButton.Size = new System.Drawing.Size(100, 28);
            this.oldNewTriggerButton.TabIndex = 2;
            this.oldNewTriggerButton.Text = "Old";
            this.oldNewTriggerButton.UseVisualStyleBackColor = true;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(384, 268);
            this.doneButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(100, 28);
            this.doneButton.TabIndex = 1;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            // 
            // appoinmentsDataGridView
            // 
            this.appoinmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appoinmentsDataGridView.Location = new System.Drawing.Point(8, 23);
            this.appoinmentsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appoinmentsDataGridView.Name = "appoinmentsDataGridView";
            this.appoinmentsDataGridView.RowHeadersWidth = 51;
            this.appoinmentsDataGridView.Size = new System.Drawing.Size(476, 238);
            this.appoinmentsDataGridView.TabIndex = 0;
            // 
            // appoinmentPanelButton
            // 
            this.appoinmentPanelButton.Location = new System.Drawing.Point(16, 15);
            this.appoinmentPanelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appoinmentPanelButton.Name = "appoinmentPanelButton";
            this.appoinmentPanelButton.Size = new System.Drawing.Size(108, 128);
            this.appoinmentPanelButton.TabIndex = 3;
            this.appoinmentPanelButton.Text = "Appoinments";
            this.appoinmentPanelButton.UseVisualStyleBackColor = true;
            // 
            // MedicinePanelButton
            // 
            this.MedicinePanelButton.Location = new System.Drawing.Point(16, 148);
            this.MedicinePanelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MedicinePanelButton.Name = "MedicinePanelButton";
            this.MedicinePanelButton.Size = new System.Drawing.Size(108, 128);
            this.MedicinePanelButton.TabIndex = 4;
            this.MedicinePanelButton.Text = "Medicine";
            this.MedicinePanelButton.UseVisualStyleBackColor = true;
            // 
            // profilePanelButton
            // 
            this.profilePanelButton.Location = new System.Drawing.Point(16, 283);
            this.profilePanelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profilePanelButton.Name = "profilePanelButton";
            this.profilePanelButton.Size = new System.Drawing.Size(108, 128);
            this.profilePanelButton.TabIndex = 5;
            this.profilePanelButton.Text = "Profile";
            this.profilePanelButton.UseVisualStyleBackColor = true;
            // 
            // DoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 426);
            this.Controls.Add(this.profilePanelButton);
            this.Controls.Add(this.MedicinePanelButton);
            this.Controls.Add(this.appoinmentPanelButton);
            this.Controls.Add(this.appoinmentsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DoctorPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorPanel";
            this.Load += new System.EventHandler(this.DoctorPanel_Load);
            this.appoinmentsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox appoinmentsGroupBox;
        private System.Windows.Forms.Button oldNewTriggerButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.DataGridView appoinmentsDataGridView;
        private System.Windows.Forms.Button appoinmentPanelButton;
        private System.Windows.Forms.Button MedicinePanelButton;
        private System.Windows.Forms.Button profilePanelButton;
    }
}