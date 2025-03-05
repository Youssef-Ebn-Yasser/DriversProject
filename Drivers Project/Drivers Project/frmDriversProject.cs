using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers_Project
{
    public partial class frmDriversProject : Form
    {
        public frmDriversProject()
        {
            InitializeComponent();
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            Form form = new frmPeopleManagement();
            form.ShowDialog();
        }

        private void frmDriversProject_Load(object sender, EventArgs e)
        {

        }
    }
}
