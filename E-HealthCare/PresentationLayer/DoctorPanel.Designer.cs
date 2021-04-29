
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
            this.checkButton = new System.Windows.Forms.Button();
            this.oldNewTriggerButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.appoinmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.appoinmentPanelButton = new System.Windows.Forms.Button();
            this.profilePanelButton = new System.Windows.Forms.Button();
            this.selector = new System.Windows.Forms.Label();
            this.appoinmentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appoinmentsGroupBox
            // 
            this.appoinmentsGroupBox.Controls.Add(this.checkButton);
            this.appoinmentsGroupBox.Controls.Add(this.oldNewTriggerButton);
            this.appoinmentsGroupBox.Controls.Add(this.doneButton);
            this.appoinmentsGroupBox.Controls.Add(this.appoinmentsDataGridView);
            this.appoinmentsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appoinmentsGroupBox.Location = new System.Drawing.Point(205, 12);
            this.appoinmentsGroupBox.Name = "appoinmentsGroupBox";
            this.appoinmentsGroupBox.Size = new System.Drawing.Size(413, 274);
            this.appoinmentsGroupBox.TabIndex = 0;
            this.appoinmentsGroupBox.TabStop = false;
            this.appoinmentsGroupBox.Text = "Appoinments";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(174, 223);
            this.checkButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(56, 23);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // oldNewTriggerButton
            // 
            this.oldNewTriggerButton.Location = new System.Drawing.Point(5, 224);
            this.oldNewTriggerButton.Margin = new System.Windows.Forms.Padding(2);
            this.oldNewTriggerButton.Name = "oldNewTriggerButton";
            this.oldNewTriggerButton.Size = new System.Drawing.Size(56, 23);
            this.oldNewTriggerButton.TabIndex = 2;
            this.oldNewTriggerButton.Text = "Old";
            this.oldNewTriggerButton.UseVisualStyleBackColor = true;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(332, 224);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 1;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            // 
            // appoinmentsDataGridView
            // 
            this.appoinmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appoinmentsDataGridView.Location = new System.Drawing.Point(4, 20);
            this.appoinmentsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.appoinmentsDataGridView.Name = "appoinmentsDataGridView";
            this.appoinmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appoinmentsDataGridView.Size = new System.Drawing.Size(404, 199);
            this.appoinmentsDataGridView.TabIndex = 0;
            this.appoinmentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appoinmentsDataGridView_CellContentClick);
            // 
            // appoinmentPanelButton
            // 
            this.appoinmentPanelButton.Location = new System.Drawing.Point(12, 12);
            this.appoinmentPanelButton.Name = "appoinmentPanelButton";
            this.appoinmentPanelButton.Size = new System.Drawing.Size(83, 126);
            this.appoinmentPanelButton.TabIndex = 3;
            this.appoinmentPanelButton.Text = "Appoinments";
            this.appoinmentPanelButton.UseVisualStyleBackColor = true;
            // 
            // profilePanelButton
            // 
            this.profilePanelButton.Location = new System.Drawing.Point(12, 155);
            this.profilePanelButton.Margin = new System.Windows.Forms.Padding(2);
            this.profilePanelButton.Name = "profilePanelButton";
            this.profilePanelButton.Size = new System.Drawing.Size(83, 131);
            this.profilePanelButton.TabIndex = 5;
            this.profilePanelButton.Text = "Profile";
            this.profilePanelButton.UseVisualStyleBackColor = true;
            // 
            // selector
            // 
            this.selector.AutoSize = true;
            this.selector.Location = new System.Drawing.Point(132, 142);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(0, 13);
            this.selector.TabIndex = 6;
            // 
            // DoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 304);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.profilePanelButton);
            this.Controls.Add(this.appoinmentPanelButton);
            this.Controls.Add(this.appoinmentsGroupBox);
            this.Name = "DoctorPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoctorPanel_FormClosing);
            this.Load += new System.EventHandler(this.DoctorPanel_Load);
            this.appoinmentsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox appoinmentsGroupBox;
        private System.Windows.Forms.Button oldNewTriggerButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.DataGridView appoinmentsDataGridView;
        private System.Windows.Forms.Button appoinmentPanelButton;
        private System.Windows.Forms.Button profilePanelButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label selector;
    }
}