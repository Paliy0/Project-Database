
namespace SomerenUI
{
    partial class NewUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassw = new System.Windows.Forms.Label();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.txtBoxLicense = new System.Windows.Forms.TextBox();
            this.lblLicense = new System.Windows.Forms.Label();
            this.txtBoxPassw = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(36, 27);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(77, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username:";
            // 
            // lblPassw
            // 
            this.lblPassw.AutoSize = true;
            this.lblPassw.Location = new System.Drawing.Point(36, 87);
            this.lblPassw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassw.Name = "lblPassw";
            this.lblPassw.Size = new System.Drawing.Size(73, 17);
            this.lblPassw.TabIndex = 1;
            this.lblPassw.Text = "Password:";
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(153, 23);
            this.txtBoxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(216, 22);
            this.txtBoxUser.TabIndex = 2;
            // 
            // txtBoxLicense
            // 
            this.txtBoxLicense.Location = new System.Drawing.Point(153, 144);
            this.txtBoxLicense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxLicense.Name = "txtBoxLicense";
            this.txtBoxLicense.Size = new System.Drawing.Size(216, 22);
            this.txtBoxLicense.TabIndex = 3;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new System.Drawing.Point(36, 148);
            this.lblLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(87, 17);
            this.lblLicense.TabIndex = 4;
            this.lblLicense.Text = "License key:";
            // 
            // txtBoxPassw
            // 
            this.txtBoxPassw.Location = new System.Drawing.Point(153, 84);
            this.txtBoxPassw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPassw.Name = "txtBoxPassw";
            this.txtBoxPassw.PasswordChar = '*';
            this.txtBoxPassw.Size = new System.Drawing.Size(216, 22);
            this.txtBoxPassw.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(153, 202);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 50);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(275, 181);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(94, 17);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "WRONG KEY";
            this.lblError.Visible = false;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 278);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtBoxPassw);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.txtBoxLicense);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.lblPassw);
            this.Controls.Add(this.lblUser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewUserForm";
            this.Text = "NewUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassw;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.TextBox txtBoxLicense;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.TextBox txtBoxPassw;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblError;
    }
}