using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Elderly_Information_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //Method
        private static void UsernameMethod(TextBox username)
        {
            if (username.Text != "admin")
            {
                username.Text = "Username";
                username.ForeColor = Color.DimGray;
            }
        }

        private static void PassMethod(TextBox pass , CheckBox ckBox )
        {
            if (pass.Text != "admin")
            {
                pass.Text = "Password";
                pass.ForeColor = Color.DimGray;
                pass.UseSystemPasswordChar = false;
                ckBox.Enabled = false;
            }
            else
            {
                ckBox.Enabled = true;
            } 
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CbxShowPass.Enabled = false;
        }

        private void TbxUsername_Enter(object sender, EventArgs e)
        {
            if (TbxUsername.Text == "Username")
            {
                TbxUsername.Text = "";
                TbxUsername.ForeColor = Color.Black;
            }
        }

        private void TbxPassword_Enter(object sender, EventArgs e)
        {
            if (TbxPass.Text == "Password")
            {
                TbxPass.Text = "";
                TbxPass.ForeColor = Color.Black;
                TbxPass.UseSystemPasswordChar = true;
            }
        }

        private void TbxUsername_Leave(object sender, EventArgs e)
        {
            if (TbxUsername.Text == "")
            {
                TbxUsername.Text = "Username";
                TbxUsername.ForeColor = Color.DimGray;
            }
        }

        private void CbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxShowPass.Checked)
            {
                TbxPass.UseSystemPasswordChar = false;
            }
            else
            {
                TbxPass.UseSystemPasswordChar = true;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM login WHERE username = '" + TbxUsername.Text + "' AND pass = '" + TbxPass.Text + "'";
            MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connect);
            command.CommandTimeout = 60;

            try
            {
                connect.Open();

                if (query != "SELECT * FROM login WHERE username = 'admin' AND pass = 'admin'")
                {
                    if (TbxPass.Text == "Password" && TbxUsername.Text == "Username")
                    {
                        MessageBox.Show("Please Input  Username and Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (TbxPass.Text == "Password")
                    {
                        MessageBox.Show("Please Input Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (TbxUsername.Text == "Username")
                    {
                        MessageBox.Show("Please Input Username", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (TbxPass.Text != "admin" && TbxUsername.Text != "admin")
                    {
                        MessageBox.Show("Wrong Username and Password", "Invalid", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        UsernameMethod(TbxUsername);
                        PassMethod(TbxPass, CbxShowPass);
                    }
                    else if (TbxPass.Text != "admin")
                    {
                        MessageBox.Show("Wrong Password", "Invalid", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        PassMethod(TbxPass, CbxShowPass);
                    }
                    else if (TbxUsername.Text != "admin")
                    {
                        MessageBox.Show("Wrong Username", "Invalid", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        UsernameMethod(TbxUsername);
                    }
                }
                else
                {
                    MainForm mf = new MainForm();
                    this.Hide();
                    mf.Show();
                }


            }
            catch (Exception x)
            {
                MessageBox.Show("Query error: " + x.Message);
            }
        }

        private void TbxPass_MouseLeave(object sender, EventArgs e)
        {
            if (TbxPass.Text == "")
            {
                TbxPass.Text = "Password";
                TbxPass.ForeColor = Color.DimGray;
                TbxPass.UseSystemPasswordChar = false;
                CbxShowPass.Enabled = false;
            }
            else
            {
                CbxShowPass.Enabled = true;
            } 
        }

        private void TbxPass_Leave(object sender, EventArgs e)
        {
            if (TbxPass.Text == "")
            {
                TbxPass.Text = "Password";
                TbxPass.ForeColor = Color.DimGray;
                TbxPass.UseSystemPasswordChar = false;
                CbxShowPass.Enabled = false;
            }
            else
            {
                CbxShowPass.Enabled = true;
            }
        }

        private void TbxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string query = "SELECT * FROM login WHERE username = '" + TbxUsername.Text + "' AND pass = '" + TbxPass.Text + "'";
                MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
                MySqlCommand command = new MySqlCommand(query, connect);
                command.CommandTimeout = 60;

                try
                {
                    connect.Open();

                    if (query != "SELECT * FROM login WHERE username = 'admin' AND pass = 'admin'")
                    {
                        if (TbxPass.Text == "Password" && TbxUsername.Text == "Username")
                        {
                            MessageBox.Show("Please Input  Username and Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (TbxPass.Text == "Password" && TbxUsername.Text == "")
                        {
                            MessageBox.Show("Please Input  Username and Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (TbxPass.Text == "" && TbxUsername.Text == "Username")
                        {
                            MessageBox.Show("Please Input  Username and Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (TbxPass.Text == "Password")
                        {
                            MessageBox.Show("Please Input Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (TbxUsername.Text == "Username")
                        {
                            MessageBox.Show("Please Input Username", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (TbxPass.Text != "admin" && TbxUsername.Text != "admin")
                        {
                            MessageBox.Show("Wrong Username and Password", "Invalid", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                            UsernameMethod(TbxUsername);
                            PassMethod(TbxPass, CbxShowPass);
                        }
                        else if (TbxPass.Text != "admin")
                        {
                            MessageBox.Show("Wrong Password", "Invalid", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                            PassMethod(TbxPass, CbxShowPass);
                        }
                        else if (TbxUsername.Text != "admin")
                        {
                            MessageBox.Show("Wrong Username", "Invalid", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                            UsernameMethod(TbxUsername);
                        }
                    }
                    else
                    {
                        MainForm mf = new MainForm();
                        this.Hide();
                        mf.Show();
                    }


                }
                catch (Exception x)
                {
                    MessageBox.Show("Query error: " + x.Message);
                }
            }
        }
    }
}
