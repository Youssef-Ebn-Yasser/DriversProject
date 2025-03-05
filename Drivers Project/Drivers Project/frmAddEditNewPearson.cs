using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using DriversBusinessLayer;
using Drivers_Project;

namespace Drivers_Project
{
    public partial class frmAddEditNewPearson : Form
    {
        public static Action evSendPersonDataToDataBase;
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _PersonID;
        clsPeopleBusinessLayer _Person;

        public frmAddEditNewPearson(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
            if (_PersonID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

    
        private void btnSave_Click(object sender, EventArgs e)
        {
            evSendPersonDataToDataBase(); //raise the event
            int CountryID = ctrlPearsonCard.NationalityCountryID; // استخدم القيمة مباشرة  

            // تأكد من أن _Person تم تهيئته  
            if (_Person == null)
            {
                _Person = new clsPeopleBusinessLayer();
            }

            _Person.FirstName = ctrlPearsonCard.FirstName;
            _Person.SecondName = ctrlPearsonCard.SecondName; // تأكد من تعيين SecondName بشكل صحيح  

            if (ctrlPearsonCard.ThirdName != null)
                _Person.ThirdName = ctrlPearsonCard.ThirdName;
            else
                _Person.ThirdName = "";

            _Person.LastName = ctrlPearsonCard.LastName;
            _Person.DateOfBirth = ctrlPearsonCard.DateOfBirth;
            _Person.Gender = ctrlPearsonCard.Gender;
            _Person.Address = ctrlPearsonCard.Address;
            _Person.Phone = ctrlPearsonCard.Phone;
          
            if (ctrlPearsonCard.Email != null)
                _Person.Email = ctrlPearsonCard.Email;
            else
                _Person.Email = "";

            _Person.NationalityCountryID = CountryID;

            // تعيين مسار الصورة  
            _Person.ImagePath = !string.IsNullOrEmpty(ctrlPearsonCard.ImagePath) ? ctrlPearsonCard.ImagePath : "";

            if (ctrlPearsonCard.ImagePath != null)
                _Person.ImagePath = ctrlPearsonCard.ImagePath;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
                //_Mode = enMode.Update;
               // lblMode.Text = "Edit Contact ID = " + _Person.PersonID;
                lblPersonID.Text = _Person.PersonID.ToString();
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.");
            }

        }
        
        private void _LoadData()
        {
            ctrlPearsonCard.Visible = true; // تأكد من أن الـUserControl مرئي  

            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Person";
                _Person = new clsPeopleBusinessLayer();
                return;
            }

            _Person = clsPeopleBusinessLayer.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because No Person with ID = " + _PersonID);
                this.Close();
                return;
            }

            // تعيين القيم من _Person  
            ctrlPearsonCard.FirstName = _Person.FirstName;
            ctrlPearsonCard.SecondName = _Person.SecondName; // استخدم SecondName الصحيح  
            ctrlPearsonCard.ThirdName = _Person.ThirdName; // استخدم ThirdName الصحيح  
            ctrlPearsonCard.LastName = _Person.LastName;
            ctrlPearsonCard.DateOfBirth = _Person.DateOfBirth;
            ctrlPearsonCard.Gender = _Person.Gender;
            ctrlPearsonCard.Address = _Person.Address;
            ctrlPearsonCard.Phone = _Person.Phone;
            ctrlPearsonCard.Email = _Person.Email;

            ctrlPearsonCard.NationalityCountryID = _Person.NationalityCountryID;

            // تحميل الصورة إذا كان موجوداً  
            if (!string.IsNullOrEmpty(_Person.ImagePath))
            {
                ctrlPearsonCard.LoadImage(_Person.ImagePath); // افترض وجود دالة لتحميل الصورة في UserControl  
            }
        }
        private void frmAddEditNewPearson_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in ctrlPearsonCard.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
                else if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Checked = false;
                }
            }
        }
    }
}
