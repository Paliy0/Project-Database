﻿using System;
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
    }
}