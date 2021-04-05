
namespace SomerenUI
{
    partial class PasswordForgottenForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.txtBoxAnswer = new System.Windows.Forms.TextBox();
            this.lblPassw = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(29, 143);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(111, 17);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Secret question:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(140, 196);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 50);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(164, 42);
            this.txtBoxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(201, 22);
            this.txtBoxUser.TabIndex = 3;
            // 
            // txtBoxAnswer
            // 
            this.txtBoxAnswer.Location = new System.Drawing.Point(164, 139);
            this.txtBoxAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxAnswer.Name = "txtBoxAnswer";
            this.txtBoxAnswer.Size = new System.Drawing.Size(201, 22);
            this.txtBoxAnswer.TabIndex = 4;
            // 
            // lblPassw
            // 
            this.lblPassw.AutoSize = true;
            this.lblPassw.Location = new System.Drawing.Point(35, 95);
            this.lblPassw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassw.Name = "lblPassw";
            this.lblPassw.Size = new System.Drawing.Size(103, 17);
            this.lblPassw.TabIndex = 5;
            this.lblPassw.Text = "New password:";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(164, 91);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(201, 22);
            this.txtBoxPassword.TabIndex = 6;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(232, 167);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(127, 17);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "WRONG ANSWER";
            this.lblError.Visible = false;
            // 
            // PasswordForgottenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 273);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblPassw);
            this.Controls.Add(this.txtBoxAnswer);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PasswordForgottenForm";
            this.Text = "PasswordForgottenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.TextBox txtBoxAnswer;
        private System.Windows.Forms.Label lblPassw;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblError;
    }
}