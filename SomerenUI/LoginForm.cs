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
    public partial class LoginForm : Form //our username and password still needs to be added to the database
    {
        const string USERNAME = "root";
        const string PASSWORD = "admin";

        public LoginForm()
        {
            InitializeComponent();
        }
        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == USERNAME && txtBoxPassw.Text == PASSWORD)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void linkLabelNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUserForm n = new NewUserForm();
            n.ShowDialog();
        }

        private void linkLabelPassw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordForgottenForm m = new PasswordForgottenForm();
            m.ShowDialog();
        }
    }
}
