using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
              

            }
        }

    }
}
