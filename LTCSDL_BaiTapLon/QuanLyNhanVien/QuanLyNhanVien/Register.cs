using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanVien.BUS;

namespace QuanLyNhanVien
{
    public partial class Register : Form
    {
        private login mainf = null;
        public Account regisUser = null;
        BUS_User busRegister;
        public Register(Form call)
        {
            mainf = call as login;
            busRegister = new BUS_User();
            InitializeComponent();
            display();
        }
        public void display()
        {
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.TabStop = false;
            btnLogin.FlatStyle = FlatStyle.Flat;

            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.TabStop = false;
            btnRegister.FlatStyle = FlatStyle.Flat;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        public bool checkValidInfo()
        {
            bool result = true;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPass = txtConfirmPass.Text.Trim();
            string role = cbRoles.SelectedValue.ToString().Trim();

            if (checkUserName(username) == false) result = false;
            if (checkPassword(password) == false) result = false;
            if (checkConfirmPass(confirmPass, password) == false) result = false;

            return result;
        }
        public bool checkUserName(string username)
        {
            bool result = true;
            Regex rg = new Regex("[^a-zA-Z0-9_]");
            if (username.Equals(""))
            {
                errorProvider.SetError(txtUsername, "Username cannot be null");
                result = false;
            }
            else if (username.Length < 4 || username.Length > 24)
            {
                errorProvider.SetError(txtUsername, "Username between 4 and 24 characters");
                result = false;
            }
            else if (Char.IsDigit(username[0]))
            {
                errorProvider.SetError(txtUsername, "Username must start with the letter");
                result = false;
            }
            else if (rg.IsMatch(username) == true)
            {
                errorProvider.SetError(txtUsername, "Username only contain a-zA-Z0-9 and '_'");
                result = false;
            }
            else errorProvider.SetError(txtUsername, "");

            return result;
        }
        public bool checkPassword(string password)
        {
            bool result = true;
            Regex rg = new Regex("\\s");
            if (rg.IsMatch(password))
            {
                errorProvider.SetError(txtPassword, "Password not contain whitespace");
                result = false;
            }
            else if (password.Length < 8 || password.Length > 24)
            {
                errorProvider.SetError(txtPassword, "Password between 8 and 24 characters");
                result = false;
            }
            else errorProvider.SetError(txtPassword, "");
            return result;
        }
        public bool checkConfirmPass(string confirmPass, string pass)
        {
            if (confirmPass.Equals(""))
            {
                errorProvider.SetError(txtConfirmPass, "Confirm Password cannot be null");
                return false;
            }
            if (confirmPass.Equals(pass))
            {
                errorProvider.SetError(txtConfirmPass, "");
                return true;
            }
            else
            {
                errorProvider.SetError(txtConfirmPass, "Password does not match");
                return false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (checkValidInfo() == false)
                MessageBox.Show("Register failed, please check again",
                    "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //kiem tra user co ton tai chua
                if (busRegister.CheckUserByUsername(txtUsername.Text.ToString().Trim()) == false)
                {
                    Account u = new Account();

                    u.userID = Guid.NewGuid().ToString();
                    u.username = txtUsername.Text.Trim();
                    u.password = txtPassword.Text.Trim();
                    u.MaNhanVien = cbRoles.SelectedValue.ToString().Trim();
                    string pass = BCrypt.Net.BCrypt.HashString(u.password);//hash
                    u.password = pass;
                    if (busRegister.AddUser(u))
                    {
                        MessageBox.Show("Add new user successful");
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtConfirmPass.Text = "";
                        regisUser = u;
                    }
                    else MessageBox.Show("Register failed, please check again"
                        , "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    errorProvider.SetError(txtUsername, "Username already exists");
                    MessageBox.Show("Register failed, please check again"
                        , "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            busRegister.RolesList(cbRoles);
        }
    }
}
