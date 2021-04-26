
namespace E_HealthCare.PresentationLayer
{
    partial class Medicine
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
            this.appoinmentPanelButton = new System.Windows.Forms.Button();
            this.MedicinePanelButton = new System.Windows.Forms.Button();
            this.profilePanelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.byNameButton = new System.Windows.Forms.Button();
            this.byCatagoryButton = new System.Windows.Forms.Button();
            this.byDiseasesButton = new System.Windows.Forms.Button();
            this.diseasesDataGridView = new System.Windows.Forms.DataGridView();
            this.checkButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diseasesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appoinmentPanelButton
            // 
            this.appoinmentPanelButton.Location = new System.Drawing.Point(12, 12);
            this.appoinmentPanelButton.Name = "appoinmentPanelButton";
            this.appoinmentPanelButton.Size = new System.Drawing.Size(81, 104);
            this.appoinmentPanelButton.TabIndex = 4;
            this.appoinmentPanelButton.Text = "Appoinments";
            this.appoinmentPanelButton.UseVisualStyleBackColor = true;
            // 
            // MedicinePanelButton
            // 
            this.MedicinePanelButton.Location = new System.Drawing.Point(12, 122);
            this.MedicinePanelButton.Name = "MedicinePanelButton";
            this.MedicinePanelButton.Size = new System.Drawing.Size(81, 104);
            this.MedicinePanelButton.TabIndex = 5;
            this.MedicinePanelButton.Text = "Medicine";
            this.MedicinePanelButton.UseVisualStyleBackColor = true;
            // 
            // profilePanelButton
            // 
            this.profilePanelButton.Location = new System.Drawing.Point(12, 232);
            this.profilePanelButton.Name = "profilePanelButton";
            this.profilePanelButton.Size = new System.Drawing.Size(81, 104);
            this.profilePanelButton.TabIndex = 6;
            this.profilePanelButton.Text = "Profile";
            this.profilePanelButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkButton);
            this.groupBox1.Controls.Add(this.diseasesDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(158, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 214);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicines";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search By:";
            // 
            // byNameButton
            // 
            this.byNameButton.Location = new System.Drawing.Point(391, 50);
            this.byNameButton.Name = "byNameButton";
            this.byNameButton.Size = new System.Drawing.Size(75, 23);
            this.byNameButton.TabIndex = 10;
            this.byNameButton.Text = "Name";
            this.byNameButton.UseVisualStyleBackColor = true;
            // 
            // byCatagoryButton
            // 
            this.byCatagoryButton.Location = new System.Drawing.Point(472, 50);
            this.byCatagoryButton.Name = "byCatagoryButton";
            this.byCatagoryButton.Size = new System.Drawing.Size(75, 23);
            this.byCatagoryButton.TabIndex = 11;
            this.byCatagoryButton.Text = "Catagory";
            this.byCatagoryButton.UseVisualStyleBackColor = true;
            // 
            // byDiseasesButton
            // 
            this.byDiseasesButton.Location = new System.Drawing.Point(553, 50);
            this.byDiseasesButton.Name = "byDiseasesButton";
            this.byDiseasesButton.Size = new System.Drawing.Size(75, 23);
            this.byDiseasesButton.TabIndex = 12;
            this.byDiseasesButton.Text = "Diseases";
            this.byDiseasesButton.UseVisualStyleBackColor = true;
            // 
            // diseasesDataGridView
            // 
            this.diseasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diseasesDataGridView.Location = new System.Drawing.Point(6, 19);
            this.diseasesDataGridView.Name = "diseasesDataGridView";
            this.diseasesDataGridView.Size = new System.Drawing.Size(383, 189);
            this.diseasesDataGridView.TabIndex = 0;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(395, 77);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 70);
            this.checkButton.TabIndex = 13;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 351);
            this.Controls.Add(this.byDiseasesButton);
            this.Controls.Add(this.byCatagoryButton);
            this.Controls.Add(this.byNameButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.profilePanelButton);
            this.Controls.Add(this.MedicinePanelButton);
            this.Controls.Add(this.appoinmentPanelButton);
            this.Name = "Medicine";
            this.Text = "Medicine";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diseasesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button appoinmentPanelButton;
        private System.Windows.Forms.Button MedicinePanelButton;
        private System.Windows.Forms.Button profilePanelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button byNameButton;
        private System.Windows.Forms.Button byCatagoryButton;
        private System.Windows.Forms.Button byDiseasesButton;
        private System.Windows.Forms.DataGridView diseasesDataGridView;
        private System.Windows.Forms.Button checkButton;
    }
}