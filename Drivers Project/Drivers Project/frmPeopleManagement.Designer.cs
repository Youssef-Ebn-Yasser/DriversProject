namespace Drivers_Project
{
    partial class frmPeopleManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeopleManagement));
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.dgvPeopleManagement = new System.Windows.Forms.DataGridView();
            this.lblFilterby = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAddperson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Location = new System.Drawing.Point(1485, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 47);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(574, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 156);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.BackColor = System.Drawing.Color.Transparent;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(554, 162);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(363, 44);
            this.lblTitel.TabIndex = 2;
            this.lblTitel.Text = "People Management";
            // 
            // dgvPeopleManagement
            // 
            this.dgvPeopleManagement.AllowUserToAddRows = false;
            this.dgvPeopleManagement.AllowUserToDeleteRows = false;
            this.dgvPeopleManagement.AllowUserToOrderColumns = true;
            this.dgvPeopleManagement.AllowUserToResizeRows = false;
            this.dgvPeopleManagement.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvPeopleManagement.CausesValidation = false;
            this.dgvPeopleManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeopleManagement.Location = new System.Drawing.Point(2, 228);
            this.dgvPeopleManagement.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPeopleManagement.Name = "dgvPeopleManagement";
            this.dgvPeopleManagement.ReadOnly = true;
            this.dgvPeopleManagement.RowHeadersWidth = 51;
            this.dgvPeopleManagement.RowTemplate.Height = 24;
            this.dgvPeopleManagement.Size = new System.Drawing.Size(1543, 392);
            this.dgvPeopleManagement.TabIndex = 0;
            // 
            // lblFilterby
            // 
            this.lblFilterby.AutoSize = true;
            this.lblFilterby.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterby.Location = new System.Drawing.Point(12, 175);
            this.lblFilterby.Name = "lblFilterby";
            this.lblFilterby.Size = new System.Drawing.Size(130, 31);
            this.lblFilterby.TabIndex = 4;
            this.lblFilterby.Text = "Filter by : ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // btnAddperson
            // 
            this.btnAddperson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddperson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddperson.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddperson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddperson.Image")));
            this.btnAddperson.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddperson.Location = new System.Drawing.Point(1327, 114);
            this.btnAddperson.Name = "btnAddperson";
            this.btnAddperson.Size = new System.Drawing.Size(218, 108);
            this.btnAddperson.TabIndex = 6;
            this.btnAddperson.Text = "Add \r\nPerson";
            this.btnAddperson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddperson.UseVisualStyleBackColor = false;
            this.btnAddperson.Click += new System.EventHandler(this.btnAddperson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 658);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "# Records : ";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(173, 658);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(36, 31);
            this.lblRecords.TabIndex = 8;
            this.lblRecords.Text = "??";
            // 
            // frmPeopleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1565, 720);
            this.ControlBox = false;
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddperson);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblFilterby);
            this.Controls.Add(this.dgvPeopleManagement);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(378, 247);
            this.Name = "frmPeopleManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "People Management";
            this.Load += new System.EventHandler(this.frmPeopleManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.DataGridView dgvPeopleManagement;
        private System.Windows.Forms.Label lblFilterby;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAddperson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecords;
    }
}