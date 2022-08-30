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
    public partial class QuanLyNhanVien : Form
    {
        BUS_NhanVien bus_NhanVien;
        public String MaNhanVien, Ho, Ten, SDT, TenCV, dtpNS;
        public int signal;
        public QuanLyNhanVien()
        {
            InitializeComponent();
            bus_NhanVien = new BUS_NhanVien();
        }

        

        //Load Data Grid Viewe
        private void loadingDGV()
        {
            dGVDSNV.DataSource = null;
            bus_NhanVien.ListNhanVien(dGVDSNV);

            dGVDSNV.Columns[0].Width = (int)(dGVDSNV.Width * 0.15);
            dGVDSNV.Columns[1].Width = (int)(dGVDSNV.Width * 0.15);
            dGVDSNV.Columns[2].Width = (int)(dGVDSNV.Width * 0.2);
            dGVDSNV.Columns[3].Width = (int)(dGVDSNV.Width * 0.15);
            dGVDSNV.Columns[4].Width = (int)(dGVDSNV.Width * 0.15);
            dGVDSNV.Columns[5].Width = (int)(dGVDSNV.Width * 0.18);
        }

        private void enabledAllButtons()
        {
            this.btnChiTiet.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
        }

        public void refreshDGV()
        {
            loadingDGV();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loadingDGV();
        }

        private void dGVDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGVDSNV.Rows.Count)
            {
                enabledAllButtons();

                MaNhanVien = dGVDSNV.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
                Ho = dGVDSNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                Ten = dGVDSNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNS = dGVDSNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                SDT = dGVDSNV.Rows[e.RowIndex].Cells[4].Value.ToString();
                TenCV = dGVDSNV.Rows[e.RowIndex].Cells[5].Value.ToString();
               
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
           
            NhanVienForms.FThongTinCaNhan f = new NhanVienForms.FThongTinCaNhan();
            f.signal = 1;
            f.MaNV = MaNhanVien;
            f.Ho = Ho;
            f.Ten = Ten;
            f.dtpNS = dtpNS;
            f.SoDienThoai = SDT;
            f.TenChucVu = TenCV;
            f.ShowDialog();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVienForms.FThongTinCaNhan f = new NhanVienForms.FThongTinCaNhan();
            f.parentForm = this;
            f.signal = 2;
            f.MaNV = MaNhanVien;
            f.Ho = Ho;
            f.Ten = Ten;
            f.dtpNS = dtpNS;
            f.SoDienThoai = SDT;
            f.TenChucVu = TenCV;
            f.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVienForms.FThongTinCaNhan f = new NhanVienForms.FThongTinCaNhan();
            f.parentForm = this;
            f.signal = 3;
            f.MaNV = MaNhanVien;
            f.Ho = Ho;
            f.Ten = Ten;
            f.dtpNS = dtpNS;
            f.SoDienThoai = SDT;
            f.TenChucVu = TenCV;
            f.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVienForms.FThongTinCaNhan f = new NhanVienForms.FThongTinCaNhan();
            f.parentForm = this;
            f.signal = 4;
            f.MaNV = MaNhanVien;
            f.Ho = Ho;
            f.Ten = Ten;
            f.dtpNS = dtpNS;
            f.SoDienThoai = SDT;
            f.TenChucVu = TenCV;
            f.ShowDialog();
        }
    }
}
