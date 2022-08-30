using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanVien.BUS;

namespace QuanLyNhanVien
{
    public partial class login : Form
    {
        private bool FlagRegister = false;//when it true,after login with admin, redirec to register
        private bool FlagUserInfo = false;
        public Account activeUser = null;
        BUS_User busLogin;
        public login()
        {
            busLogin = new BUS_User();
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.TabStop = false;
            btnLogin.FlatStyle = FlatStyle.Flat;
      

            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.TabStop = false;
            btnLogout.FlatStyle = FlatStyle.Flat;

            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.TabStop = false;
            btnExit.FlatStyle = FlatStyle.Flat;

            btnLogout.Visible = false;


            btnLogin.Visible = true;
            activeUser = null;
            lbText.Text = "";
            txtPassword.Visible = true;
            txtUsername.Visible = true;
            lbTitle.Text = "Login User";
            label1.Visible = label2.Visible = true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account u = new Account();
            u.username = txtUsername.Text.Trim();
            u.password = txtPassword.Text.Trim();

            u = busLogin.loginUser(u.username, u.password);
            if (u != null)
            {
                activeUser = u;
                MessageBox.Show("Login successful");
                lbTitle.Text = "Welcome " + activeUser.username;
                btnLogin.Visible = false;
                btnLogout.Visible = true;
                if (FlagRegister)
                {
                    if (activeUser.QLNhanVien.MaChucVu == 1)
                       {

                        this.Hide();
                        var register = new Register(this);
                        register.Closed += (s, args) => this.Close();
                        register.Show();
                        FlagRegister = false;

                    }
                }
                else if (FlagUserInfo)
                {
                    //btnUserInfo_Click(sender, e);
                    FlagUserInfo = false;
                }
                txtPassword.Visible = false;
                txtUsername.Visible = false;
                txtPassword.Text = "";
                txtUsername.Text = "";
                label1.Visible = label2.Visible = false;

            }
            else MessageBox.Show("UserName Or Password is Incorrect");

        }

        

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to exit app ?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogin.Visible = true;
            activeUser = null;
            lbText.Text = "";
            txtPassword.Visible = true;
            txtUsername.Visible = true;
            lbTitle.Text = "Login User";
            label1.Visible = label2.Visible = true;
        }

        
    }
}
