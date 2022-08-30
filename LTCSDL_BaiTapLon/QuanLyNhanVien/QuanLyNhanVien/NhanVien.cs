using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class NhanVien : Form
    {

        private Button selectedBtn;
        private Form selectedForm;

        public Color currentBtnBackColor;
        public Color currentBtnBoldBackColor;
         
        public NhanVien()
        {
            InitializeComponent();
            currentBtnBackColor = Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            currentBtnBoldBackColor = Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));

        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            loadForm(new NhanVienForms.DanhSachNhanVien(), this.btnDSNV);
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            loadForm(new NhanVienForms.QuanLyTaiKhoan(), this.btnDSNV);

        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            loadForm(new NhanVienForms.QuanLyNhanVien(), this.btnQLNV);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            loadForm(new NhanVienForms.DanhSachNhanVien(), this.btnDSNV);

        }

        private void activateBtn(object btnSender)
        {
            if (btnSender != null)
            {
                if (selectedBtn != (Button)btnSender)
                {
                    disableBtn();
                    Color color = currentBtnBoldBackColor;
                    selectedBtn = (Button)btnSender;
                    selectedBtn.BackColor = color;
                    selectedBtn.ForeColor = Color.Black;
                    selectedBtn.Font = new Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);

                }
            }
        }
        private void disableBtn()
        {
            foreach (Control previousBtn in MenuPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = currentBtnBackColor;
                    previousBtn.ForeColor = Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
                    previousBtn.Font = new Font("Times New Roman", 13F);
                }
            }
        }
        private void loadForm(Form f, object btnSender)
        {
            if (selectedForm != null)
            {
                selectedForm.Close();
            }
            activateBtn(btnSender);
            selectedForm = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.AutoSize = true;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;

            f.BringToFront();
            f.Show();
        }

        
    }
}
