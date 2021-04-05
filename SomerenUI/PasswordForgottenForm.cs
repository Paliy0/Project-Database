using SomerenLogic;
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
    public partial class PasswordForgottenForm : Form /// still need to add info from Piet and Rita and save new password to the database 
    {
        //for Piet: secret question "Name of your first pet?", answer is "El Pepe"
        //for Rita: secret question "Street name you were born in?", answer is "Bakerstreet"

        const string secretAnswerPiet = "El Pepe";
        const string secretAnswerRita = "Bakerstreet";

        public PasswordForgottenForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBoxAnswer.Text == secretAnswerPiet || txtBoxAnswer.Text == secretAnswerRita)
            {
                DialogResult = DialogResult.OK;
                string userName = txtBoxUser.Text;
                string password = txtBoxPassword.Text;
                UserService userService = new UserService();
                userService.EditPassword(userName, password);
                this.Hide();
            }
            else
            {
                lblError.Visible = true;
            }
        }
    }
}
