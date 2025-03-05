using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DriversBusinessLayer;
using System.Net;

namespace Drivers_Project
{
    public partial class ctrlPearsonCard : UserControl
    {
        public ctrlPearsonCard()
        {
            InitializeComponent();
            frmAddEditNewPearson.evSendPersonDataToDataBase += SendPersonDataToDataBase;
        }
        private void SendPersonDataToDataBase()
        {
            _UpdateGender();
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);

            // تعيين القيم من عناصر التحكم  
            FirstName = txtFirstName.Text;
            SecondName = txtSecondName.Text;
            ThirdName = txtThirdName.Text;
            LastName = txtLastName.Text;
            NationalNo = txtNationalNo.Text;
            Phone = txtPhone.Text;
            Email = txtEmail.Text;

            // تعيين NationalityCountryID مع تحويل القيمة إلى int  
            if (cbCountry.SelectedItem != null)
            {
                NationalityCountryID = (int) ((DataRowView) cbCountry.SelectedItem)["CountryID"];
            }
            else
            {
                NationalityCountryID = 0; // القيمة الافتراضية في حال عدم تحديد عنصر  
            }


Address = txtAddress.Text;
DateOfBirth = dateTimePicker1.Value;

// تعيين مسار الصورة  
ImagePath = pbSetImage.ImageLocation ?? string.Empty;
        }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID {  get; set; }
        public string ImagePath 
        {
            get { return pbSetImage.ImageLocation; }
            set { pbSetImage.ImageLocation = value; }
        }

        private void _UpdateGender()
        {
            if (chkMale.Checked)
            {
                Gender = 0;
                chkfemale.Visible = false;
            }
            else if (chkfemale.Checked)
            {
                Gender = 1;
                chkMale.Visible = false;
            }
            else
            {
                Gender = -1; // -1 for not specified  
                chkfemale.Visible = true;
                chkMale.Visible = true;
            }
        }

        private void _FillCountriesInComboBox()
        {
            try
            {
                DataTable dtCountries = clsCountryBusinessLayer.GetAllCountries();
                cbCountry.DataSource = dtCountries;
                cbCountry.DisplayMember = "CountryName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading countries: " + ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            DateTime minDate = DateTime.Now.AddYears(-18);

            if (selectedDate > minDate)
            {
                errorProvider1.SetError(dateTimePicker1, "Must be 18 years or older.");
            }
            else
            {
                errorProvider1.SetError(dateTimePicker1, string.Empty);
                DateOfBirth = selectedDate; // Update DateOfBirth when valid  
            }
        }

        private void PearsonInfoUserControl_Load(object sender, EventArgs e)
        {
            _FillCountriesInComboBox();
           
        }

        private void ValidateTextBox(TextBox textBox, string errorMessage, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider1.SetError(textBox, errorMessage);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        // وظائف التحقق من القيم...  
        private void txtFirstName_Validating(object sender, CancelEventArgs e) =>
            ValidateTextBox(txtFirstName, "FirstName Must contain a value!", e);
        private void txtSecondName_Validating(object sender, CancelEventArgs e) =>
            ValidateTextBox(txtSecondName, "SecondName Must contain a value!", e);
        private void txtThirdName_Validating(object sender, CancelEventArgs e) =>
            ValidateTextBox(txtThirdName, "ThirdName Must contain a value!", e);
        private void txtLastName_Validating(object sender, CancelEventArgs e) =>
            ValidateTextBox(txtLastName, "LastName Must contain a value!", e);
        private void txtNationalNo_Validating(object sender, CancelEventArgs e) =>
            ValidateTextBox(txtNationalNo, "NationalNo Must contain a value!", e);
        private void txtPhone_Validating(object sender, CancelEventArgs e) =>
            ValidateTextBox(txtPhone, "Phone Must contain a value!", e);
        private void txtEmail_Validating(object sender, CancelEventArgs e) =>
            ValidateTextBox(txtEmail, "Email Must contain a value!", e);
        private void txtAddress_Validating(object sender, CancelEventArgs e) =>
            ValidateTextBox(txtAddress, "Address Must contain a value!", e);

        private void cbCountry_Validating(object sender, CancelEventArgs e)
        {
            if (cbCountry.SelectedValue == null) // تعديل للتحقق من القيمة المحددة  
            {
                e.Cancel = true;
                cbCountry.Focus();
                errorProvider1.SetError(cbCountry, "Country Must contain a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbCountry, "");
            }
        }


        // حدث لاختيار الصورة  
        private void lblSetImage_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbSetImage.ImageLocation = openFileDialog.FileName; // تعيين الصورة الملتقطة  
                    ImagePath = openFileDialog.FileName; // تحديث مسار الصورة  
                    pbSetImage.SizeMode = PictureBoxSizeMode.StretchImage; // تعدد الأحجام  
                }
            }

        }


        public void LoadImage(string path)
        {
            if (!string.IsNullOrEmpty(path) && File.Exists(path)) // تحقق من وجود الملف  
            {
                try
                {
                    pbSetImage.Image = Image.FromFile(path); // تحميل الصورة من المسار  
                }
                catch (Exception ex) // ضم الخطأ  
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                    pbSetImage.Image = null; // مسح الصورة في حالة وجود خطأ  
                }
            }
            else
            {
                MessageBox.Show("Image path is invalid or file does not exist.");
                pbSetImage.Image = null; // مسح الصورة في حالة عدم وجود مسار صحيح  
            }
        }

    }

}
