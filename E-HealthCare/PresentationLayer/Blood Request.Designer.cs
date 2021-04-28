
namespace E_HealthCare.PresentationLayer
{
    partial class Blood_Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blood_Request));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.selectBlood = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.donorList = new System.Windows.Forms.Label();
            this.searchDonor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Red;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AB+",
            "AB-",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.comboBox1.Location = new System.Drawing.Point(12, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 29);
            this.comboBox1.TabIndex = 0;
            // 
            // selectBlood
            // 
            this.selectBlood.AutoSize = true;
            this.selectBlood.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBlood.ForeColor = System.Drawing.Color.DarkRed;
            this.selectBlood.Location = new System.Drawing.Point(7, 12);
            this.selectBlood.Name = "selectBlood";
            this.selectBlood.Size = new System.Drawing.Size(202, 27);
            this.selectBlood.TabIndex = 1;
            this.selectBlood.Text = "Select Blood Group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(497, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(479, 341);
            this.dataGridView1.TabIndex = 3;
            // 
            // donorList
            // 
            this.donorList.AutoSize = true;
            this.donorList.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorList.ForeColor = System.Drawing.Color.DarkGreen;
            this.donorList.Location = new System.Drawing.Point(12, 144);
            this.donorList.Name = "donorList";
            this.donorList.Size = new System.Drawing.Size(117, 23);
            this.donorList.TabIndex = 4;
            this.donorList.Text = "Donor\'s List";
            // 
            // searchDonor
            // 
            this.searchDonor.Location = new System.Drawing.Point(16, 78);
            this.searchDonor.Name = "searchDonor";
            this.searchDonor.Size = new System.Drawing.Size(92, 30);
            this.searchDonor.TabIndex = 5;
            this.searchDonor.Text = "Search";
            this.searchDonor.UseVisualStyleBackColor = true;
            // 
            // Blood_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 549);
            this.Controls.Add(this.searchDonor);
            this.Controls.Add(this.donorList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.selectBlood);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Blood_Request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood_Request";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Blood_Request_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label selectBlood;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label donorList;
        private System.Windows.Forms.Button searchDonor;
    }
}