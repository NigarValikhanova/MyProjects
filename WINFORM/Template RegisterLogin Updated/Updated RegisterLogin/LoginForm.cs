using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Updated_RegisterLogin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.txtbxPassword.AutoSize = false;
            this.txtbxPassword.Size = new Size(this.txtbxPassword.Width, 50);
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }
        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = txtbxUsername.Text;
            String password = txtbxPassword.Text;
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select *from UserTable where username = @usn and password = @pass", db.getConnection());
            command.Parameters.Add("@usn", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // check if the user exists or not
            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                if (username.Trim().Equals("") && password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username and Password", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void labelToGoSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void labelToGoSignUp_MouseEnter(object sender, EventArgs e)
        {
            labelToGoSignUp.ForeColor = Color.Yellow;
        }

        private void labelToGoSignUp_MouseLeave(object sender, EventArgs e)
        {
            labelToGoSignUp.ForeColor = Color.White;
        }
    }
}
