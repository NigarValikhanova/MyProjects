using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updated_RegisterLogin
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // remove the focus from the textboxes
            this.ActiveControl = label1;
        }

        private void txtbxFirstName_Enter(object sender, EventArgs e)
        {
            string fname = txtbxFirstName.Text;
            if (fname.ToLower().Trim().Equals("first name"))
            {
                txtbxFirstName.Text = "";
                txtbxFirstName.ForeColor = Color.Black;
            }
        }

        private void txtbxFirstName_Leave(object sender, EventArgs e)
        {
            string fname = txtbxFirstName.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.ToLower().Trim().Equals(""))
            {
                txtbxFirstName.Text = "first name";
                txtbxFirstName.ForeColor = Color.Gray;
            }
        }

        private void txtbxLastName_Enter(object sender, EventArgs e)
        {
            string lname = txtbxLastName.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                txtbxLastName.Text = "";
                txtbxLastName.ForeColor = Color.Black;
            }
        }

        private void txtbxLastName_Leave(object sender, EventArgs e)
        {
            string lname = txtbxLastName.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.ToLower().Trim().Equals(""))
            {
                txtbxLastName.Text = "last name";
                txtbxLastName.ForeColor = Color.Gray;
            }
        }

        private void txtbxEmail_Enter(object sender, EventArgs e)
        {
            string email = txtbxEmail.Text;
            if (email.ToLower().Trim().Equals("email address"))
            {
                txtbxEmail.Text = "";
                txtbxEmail.ForeColor = Color.Black;
            }
        }

        private void txtbxEmail_Leave(object sender, EventArgs e)
        {
            string email = txtbxEmail.Text;
            if (email.ToLower().Trim().Equals("email adress") || email.ToLower().Trim().Equals(""))
            {
                txtbxEmail.Text = "email address";
                txtbxEmail.ForeColor = Color.Gray;
            }
        }

        private void txtbxUsername_Enter(object sender, EventArgs e)
        {
            string username = txtbxUsername.Text;
            if (username.ToLower().Trim().Equals("username"))
            {
                txtbxUsername.Text = "";
                txtbxUsername.ForeColor = Color.Black;
            }
        }

        private void txtbxUsername_Leave(object sender, EventArgs e)
        {
            string username = txtbxUsername.Text;
            if (username.ToLower().Trim().Equals("username") || username.ToLower().Trim().Equals(""))
            {
                txtbxUsername.Text = "username";
                txtbxUsername.ForeColor = Color.Gray;
            }
        }

        private void txtbxPassword_Enter(object sender, EventArgs e)
        {
            string password = txtbxPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                txtbxPassword.Text = "";
                txtbxPassword.UseSystemPasswordChar = true;
                txtbxPassword.ForeColor = Color.Black;
            }
        }

        private void txtbxPassword_Leave(object sender, EventArgs e)
        {
            string password = txtbxPassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                txtbxPassword.Text = "password";
                txtbxPassword.UseSystemPasswordChar = false;
                txtbxPassword.ForeColor = Color.Gray;
            }
        }

        private void txtbxConPassword_Enter(object sender, EventArgs e)
        {
            string conpassword = txtbxConPassword.Text;
            if (conpassword.ToLower().Trim().Equals("confirm password"))
            {
                txtbxConPassword.Text = "";
                txtbxConPassword.UseSystemPasswordChar = true;
                txtbxConPassword.ForeColor = Color.Black;
            }
        }

        private void txtbxConPassword_Leave(object sender, EventArgs e)
        {
            string conpassword = txtbxConPassword.Text;
            if (conpassword.ToLower().Trim().Equals("confirm password") ||
                conpassword.ToLower().Trim().Equals("password") ||
                conpassword.Trim().Equals(""))
            {
                txtbxConPassword.Text = "confirm password";
                txtbxConPassword.UseSystemPasswordChar = false;
                txtbxConPassword.ForeColor = Color.Gray;
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // add a new user
            DB db = new DB();
            SqlCommand command = new SqlCommand("INSERT INTO UserTable(firstName, lastName, emailAddress, username, [password]) VALUES (@fn, @ln, @email, @usn, @pass)", db.getConnection());
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = txtbxFirstName.Text;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = txtbxLastName.Text;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtbxEmail.Text;
            command.Parameters.Add("@usn", SqlDbType.NVarChar).Value = txtbxUsername.Text;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = txtbxPassword.Text;
            // open the connection
            db.openConnection();
            // check if the textboxes contains the default values
            if (!CheckTextBoxesValues())
            {
                // check if password equal the confirm password
                if (txtbxPassword.Text.Equals(txtbxConPassword.Text))
                {
                    // check if this username already exists
                    if (CheckUsername())
                    {
                        MessageBox.Show("THIS USERNAME ALREADY EXISTS, SELECT A DIFFERENT ONE", "Dublicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // check if this email address already exists
                        if(CheckEmailAddress())
                        {
                            MessageBox.Show("THIS EMAIL ADDRESS ALREADY EXISTS, SELECT A DIFFERENT ONE", "Dublicate Email", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                        }
                        else
                        {
                            // execute the query
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("YOUR ACCOUNT HAS BEEN CREATED", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("ERROR");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("PASSWORD DOES NOT MATCH, RE-ENTER PLEASE", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ENTER YOUR INFORMATION FIRST", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            // close the connection
            db.closeConnection();
        }
        public bool CheckUsername()
        {
            DB db = new DB();

            String username = txtbxUsername.Text;
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select *from UserTable where username = @usn", db.getConnection());
            command.Parameters.Add("@usn", SqlDbType.NVarChar).Value = username;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // check if this username already exists in the database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckEmailAddress()
        {
            DB db = new DB();

            String email = txtbxEmail.Text;
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select *from UserTable where emailAddress = @email", db.getConnection());
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // check if this username already exists in the database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // check if the textboxes contains the default values
        public bool CheckTextBoxesValues()
        {
            string fname = txtbxFirstName.Text;
            string lname = txtbxLastName.Text;
            string email = txtbxEmail.Text;
            string uname = txtbxUsername.Text;
            string pass = txtbxPassword.Text;

            if (fname.Equals("first name") || lname.Equals("last name") ||
                email.Equals("email address") || uname.Equals("usernam") ||
                pass.Equals("password"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void labelToGoLogin_MouseEnter(object sender, EventArgs e)
        {
            labelToGoLogin.ForeColor = Color.Yellow;
        }

        private void labelToGoLogin_MouseLeave(object sender, EventArgs e)
        {
            labelToGoLogin.ForeColor = Color.White;
        }

        private void labelToGoLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
