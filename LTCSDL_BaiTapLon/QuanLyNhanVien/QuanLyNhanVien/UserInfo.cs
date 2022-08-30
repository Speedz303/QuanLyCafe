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
    public partial class UserInfo : Form
    {
        private login mainf = null;
        private Account currentUser = null;
        BUS_User busUserInfo = new BUS_User();

        public UserInfo(Form call)
        {
            mainf = call as login;
            currentUser = mainf.activeUser;

            InitializeComponent();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            lbTitle.Text += "  " + mainf.activeUser.username;
            btnPass.FlatAppearance.BorderSize = 0;
            btnPass.TabStop = false;
            btnPass.FlatStyle = FlatStyle.Flat;

            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.TabStop = false;
            btnExit.FlatStyle = FlatStyle.Flat;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {

            string oldPass = txtOldPass.Text.Trim();
            string newPass = txtNewPass.Text.Trim();
            string confirm = txtConfirm.Text.Trim();

            if (checkMatchPassword(oldPass, newPass, confirm) == true)
            {
                string pass = BCrypt.Net.BCrypt.HashString(newPass);
                currentUser.password = pass;

                if (ChangePassword(currentUser))
                {
                    MessageBox.Show("Change Password Successful");
                    txtOldPass.Text = "";
                    txtNewPass.Text = "";
                    txtConfirm.Text = "";
                }
            }

        }

        private bool ChangePassword(Account u)
        {
            if (u != null)
            {
                busUserInfo.EditUser(u);
                return true;
            }
            return false;
        }

        public bool checkPassword(string password)
        {
            bool result = true;
            Regex rg = new Regex("\\s");
            if (rg.IsMatch(password))
            {
                errorProvider.SetError(txtNewPass, "Password not contain whitespace");
                result = false;
            }
            else if (password.Length < 8 || password.Length > 24)
            {
                errorProvider.SetError(txtNewPass, "Password between 8 and 24 characters");
                result = false;
            }
            else errorProvider.SetError(txtNewPass, "");
            return result;
        }

        //check confirm is true and match ?
        public bool checkConfirmPass(string confirmPass, string pass)
        {
            if (confirmPass.Equals(""))
            {
                errorProvider.SetError(txtConfirm, "Confirm Password cannot be null");
                return false;
            }
            if (confirmPass.Equals(pass))
            {
                errorProvider.SetError(txtConfirm, "");
                return true;
            }
            else
            {
                errorProvider.SetError(txtConfirm, "Password does not match");
                return false;
            }
        }


        //check Old Pass is true ? , new pass is true ? and confirm is match?
        private bool checkMatchPassword(string oldPass, string newPass, string ConfirmPass)
        {
            if (BCrypt.Net.BCrypt.Verify(oldPass, currentUser.password) == false)
            {
                errorProvider.SetError(txtOldPass, "Old Password is incorrect");
                return false;
            }
            else errorProvider.SetError(txtOldPass, "");
            if (checkPassword(newPass) == false) return false;
            if (checkConfirmPass(ConfirmPass, newPass) == false) return false;
            return true;
        }


    }
}
