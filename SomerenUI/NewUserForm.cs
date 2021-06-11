using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
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
            User user = new User();
            UserService userService = new UserService();

            if (txtBoxLicense.Text == KEY)
            {
                user.Username = txtBoxUser.Text;
                user.Password = txtBoxPassw.Text;
                user.Admin = false;
                userService.AddUser(user);
                DialogResult = DialogResult.OK;
            }
            else
            {
                lblError.Visible = true;
            }
        }
    }
}
