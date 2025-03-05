using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DriversBusinessLayer;

namespace Drivers_Project
{
    public partial class frmPeopleManagement : Form
    {
        public frmPeopleManagement()
        {
            InitializeComponent();
        }

        private void _RefreshContactsList()
        {
            dgvPeopleManagement.DataSource = clsPeopleBusinessLayer.GetAllPeople();
            lblRecords.Text = clsPeopleBusinessLayer.GetAllPeople().Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPeopleManagement_Load(object sender, EventArgs e)
        {
            _RefreshContactsList();

        }

        private void btnAddperson_Click(object sender, EventArgs e)
        {
            Form form = new frmAddEditNewPearson(-1);
            form.ShowDialog();
        }
    }
}
