using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Thay đổi tên project
using QuanLyNhanVien.BUS;

namespace QuanLyNhanVien.NhanVienForms
{
    public partial class QuanLyTaiKhoan : Form
    {
        BUS_NhanVien bus_NhanVien;
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            bus_NhanVien = new BUS_NhanVien();

        }

        //Load Data Grid Viewe
        private void loadingDGV()
        {
            dGVDSNV.DataSource = null;
            bus_NhanVien.ListNhanVien2(dGVDSNV);

            dGVDSNV.Columns[0].Width = (int)(dGVDSNV.Width * 0.15);
            dGVDSNV.Columns[1].Width = (int)(dGVDSNV.Width * 0.15);
            dGVDSNV.Columns[2].Width = (int)(dGVDSNV.Width * 0.2);
            dGVDSNV.Columns[3].Width = (int)(dGVDSNV.Width * 0.15);
            dGVDSNV.Columns[4].Width = (int)(dGVDSNV.Width * 0.15);
            dGVDSNV.Columns[5].Width = (int)(dGVDSNV.Width * 0.18);
        }

        private void enabledAllButtons()
        {
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            loadingDGV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //public Register f = new Register(FORM GI DO);
            

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           // public UserInfo f = new UserInfo(call < Form gi do trong Login)
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //
            //Chon trong data grid view roi xoa ma chua co data nen chua lam,
          
        }

        private void dGVDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGVDSNV.Rows.Count)
            {
                enabledAllButtons();



            }
        }
    }
}
