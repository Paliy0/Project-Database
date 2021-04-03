using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{ 
    public partial class NewUserForm : Form /////still need to add a code to save new username and password to the database + license key
    {
        const string KEY = "XsZAb - tgz3PsD - qYh69un - WQCEx";

        public NewUserForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtBoxLicense.Text == KEY)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                lblError.Visible = true;
            }
        }
    }
}
