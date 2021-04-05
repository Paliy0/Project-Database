using SomerenLogic;
using SomerenModel;
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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }
        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            if (txtBoxUser.Text != "" && txtBoxPassw.Text != "")
            {
                if (userService.Login(txtBoxUser.Text, txtBoxPassw.Text))
                {
                    DialogResult = DialogResult.OK;
                    this.Hide();
                    //pnlDashboard.Show();

                }
                else
                {
                    MessageBox.Show("Check Username or Password");
                }
                
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
