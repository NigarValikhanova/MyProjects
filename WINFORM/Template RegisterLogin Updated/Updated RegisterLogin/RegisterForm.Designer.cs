namespace Updated_RegisterLogin
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbxConPassword = new System.Windows.Forms.TextBox();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelToGoLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.labelToGoLogin);
            this.panel1.Controls.Add(this.txtbxConPassword);
            this.panel1.Controls.Add(this.txtbxUsername);
            this.panel1.Controls.Add(this.txtbxEmail);
            this.panel1.Controls.Add(this.txtbxLastName);
            this.panel1.Controls.Add(this.btnCreateAccount);
            this.panel1.Controls.Add(this.txtbxPassword);
            this.panel1.Controls.Add(this.txtbxFirstName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 557);
            this.panel1.TabIndex = 1;
            // 
            // txtbxConPassword
            // 
            this.txtbxConPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxConPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtbxConPassword.Location = new System.Drawing.Point(53, 374);
            this.txtbxConPassword.Name = "txtbxConPassword";
            this.txtbxConPassword.Size = new System.Drawing.Size(526, 40);
            this.txtbxConPassword.TabIndex = 10;
            this.txtbxConPassword.Text = "confirm password";
            this.txtbxConPassword.Enter += new System.EventHandler(this.txtbxConPassword_Enter);
            this.txtbxConPassword.Leave += new System.EventHandler(this.txtbxConPassword_Leave);
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtbxUsername.Location = new System.Drawing.Point(53, 256);
            this.txtbxUsername.Multiline = true;
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(526, 40);
            this.txtbxUsername.TabIndex = 9;
            this.txtbxUsername.Text = "username";
            this.txtbxUsername.Enter += new System.EventHandler(this.txtbxUsername_Enter);
            this.txtbxUsername.Leave += new System.EventHandler(this.txtbxUsername_Leave);
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtbxEmail.Location = new System.Drawing.Point(53, 198);
            this.txtbxEmail.Multiline = true;
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(526, 40);
            this.txtbxEmail.TabIndex = 8;
            this.txtbxEmail.Text = "email address";
            this.txtbxEmail.Enter += new System.EventHandler(this.txtbxEmail_Enter);
            this.txtbxEmail.Leave += new System.EventHandler(this.txtbxEmail_Leave);
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtbxLastName.Location = new System.Drawing.Point(319, 137);
            this.txtbxLastName.Multiline = true;
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(260, 40);
            this.txtbxLastName.TabIndex = 7;
            this.txtbxLastName.Text = "last name";
            this.txtbxLastName.Enter += new System.EventHandler(this.txtbxLastName_Enter);
            this.txtbxLastName.Leave += new System.EventHandler(this.txtbxLastName_Leave);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(53, 443);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(526, 50);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "CREATE ACCOUNT";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtbxPassword.Location = new System.Drawing.Point(53, 315);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(526, 40);
            this.txtbxPassword.TabIndex = 5;
            this.txtbxPassword.Text = "password";
            this.txtbxPassword.Enter += new System.EventHandler(this.txtbxPassword_Enter);
            this.txtbxPassword.Leave += new System.EventHandler(this.txtbxPassword_Leave);
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxFirstName.ForeColor = System.Drawing.Color.Gray;
            this.txtbxFirstName.Location = new System.Drawing.Point(53, 137);
            this.txtbxFirstName.Multiline = true;
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(260, 40);
            this.txtbxFirstName.TabIndex = 3;
            this.txtbxFirstName.Text = "first name";
            this.txtbxFirstName.Enter += new System.EventHandler(this.txtbxFirstName_Enter);
            this.txtbxFirstName.Leave += new System.EventHandler(this.txtbxFirstName_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 100);
            this.panel2.TabIndex = 1;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(612, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(20, 23);
            this.labelClose.TabIndex = 1;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREATE YOUR ACCOUNT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelToGoLogin
            // 
            this.labelToGoLogin.AutoSize = true;
            this.labelToGoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToGoLogin.ForeColor = System.Drawing.Color.White;
            this.labelToGoLogin.Location = new System.Drawing.Point(223, 513);
            this.labelToGoLogin.Name = "labelToGoLogin";
            this.labelToGoLogin.Size = new System.Drawing.Size(149, 13);
            this.labelToGoLogin.TabIndex = 11;
            this.labelToGoLogin.Text = "Already Have Account? Login";
            this.labelToGoLogin.Click += new System.EventHandler(this.labelToGoLogin_Click);
            this.labelToGoLogin.MouseEnter += new System.EventHandler(this.labelToGoLogin_MouseEnter);
            this.labelToGoLogin.MouseLeave += new System.EventHandler(this.labelToGoLogin_MouseLeave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 557);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.TextBox txtbxFirstName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.TextBox txtbxConPassword;
        private System.Windows.Forms.Label labelToGoLogin;
    }
}