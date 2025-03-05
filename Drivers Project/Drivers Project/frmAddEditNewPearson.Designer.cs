namespace Drivers_Project
{
    partial class frmAddEditNewPearson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditNewPearson));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.ctrlPearsonCard = new Drivers_Project.ctrlPearsonCard();
            this.pearsonInfoUserControl1 = new Drivers_Project.ctrlPearsonCard();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(586, 517);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 45);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(439, 517);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 45);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 31);
            this.label1.TabIndex = 45;
            this.label1.Text = "Add/Edit New Pearson";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 46;
            this.label2.Text = "PersonID :";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(224, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 34);
            this.button1.TabIndex = 47;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(281, 125);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(53, 27);
            this.lblPersonID.TabIndex = 48;
            this.lblPersonID.Text = "N/A";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.Red;
            this.lblMode.Location = new System.Drawing.Point(411, 39);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(59, 40);
            this.lblMode.TabIndex = 49;
            this.lblMode.Text = "???";
            // 
            // ctrlPearsonCard
            // 
            this.ctrlPearsonCard.Address = "";
            this.ctrlPearsonCard.BackColor = System.Drawing.Color.Olive;
            this.ctrlPearsonCard.DateOfBirth = new System.DateTime(2007, 2, 5, 22, 28, 53, 603);
            this.ctrlPearsonCard.Email = "";
            this.ctrlPearsonCard.FirstName = "";
            this.ctrlPearsonCard.Gender = -1;
            this.ctrlPearsonCard.ImagePath = "";
            this.ctrlPearsonCard.LastName = "";
            this.ctrlPearsonCard.Location = new System.Drawing.Point(107, 155);
            this.ctrlPearsonCard.Name = "ctrlPearsonCard";
            this.ctrlPearsonCard.NationalityCountryID = 1;
            this.ctrlPearsonCard.NationalNo = "";
            this.ctrlPearsonCard.Phone = "";
            this.ctrlPearsonCard.SecondName = "";
            this.ctrlPearsonCard.Size = new System.Drawing.Size(958, 353);
            this.ctrlPearsonCard.TabIndex = 50;
            this.ctrlPearsonCard.ThirdName = "";
            // 
            // pearsonInfoUserControl1
            // 
            this.pearsonInfoUserControl1.Address = "";
            this.pearsonInfoUserControl1.BackColor = System.Drawing.Color.Olive;
            this.pearsonInfoUserControl1.DateOfBirth = new System.DateTime(2007, 2, 5, 2, 28, 35, 226);
            this.pearsonInfoUserControl1.Email = "";
            this.pearsonInfoUserControl1.FirstName = "";
            this.pearsonInfoUserControl1.Gender = -1;
            this.pearsonInfoUserControl1.ImagePath = "";
            this.pearsonInfoUserControl1.LastName = "";
            this.pearsonInfoUserControl1.Location = new System.Drawing.Point(109, 158);
            this.pearsonInfoUserControl1.Name = "pearsonInfoUserControl1";
            this.pearsonInfoUserControl1.NationalityCountryID = 0;
            this.pearsonInfoUserControl1.NationalNo = "";
            this.pearsonInfoUserControl1.Phone = "";
            this.pearsonInfoUserControl1.SecondName = "";
            this.pearsonInfoUserControl1.Size = new System.Drawing.Size(958, 353);
            this.pearsonInfoUserControl1.TabIndex = 44;
            this.pearsonInfoUserControl1.ThirdName = "";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Location = new System.Drawing.Point(1156, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 47);
            this.btnClose.TabIndex = 51;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddEditNewPearson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1213, 594);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlPearsonCard);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEditNewPearson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditNewPearson";
            this.Load += new System.EventHandler(this.frmAddEditNewPearson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private ctrlPearsonCard pearsonInfoUserControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label lblMode;
        private ctrlPearsonCard ctrlPearsonCard;
        private System.Windows.Forms.Button btnClose;
    }
}