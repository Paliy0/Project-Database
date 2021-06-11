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
            if (txtAnswer.Text == secretAnswerPiet || txtAnswer.Text == secretAnswerRita)
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

        private void btnSecretQuestion_Click(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "piet@infhaarlem.nl")
            {
                lblQuestion.Text = "What is the name of your first pet?";
                lblQuestion.Visible = true;
            }
            else if (txtBoxUser.Text == "piet@infhaarlem.nl")
            {
                lblQuestion.Text = "What is the street name you were born in?";
                lblQuestion.Visible = true;
            }
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
