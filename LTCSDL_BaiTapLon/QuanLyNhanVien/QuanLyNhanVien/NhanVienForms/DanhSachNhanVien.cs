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
    public partial class DanhSachNhanVien : Form
    {
        BUS_NhanVien bus_NhanVien;
        public DanhSachNhanVien()
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


        // Xử lý objects trong form
        #region 

        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            loadingDGV();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbTimKiem_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTimKiem.Text != null)
            {
                if (this.txtBTimKiem.ReadOnly)
                {
                    this.txtBTimKiem.ReadOnly = false;
                }

                if (this.txtBTimKiem.Text != "")
                {

                    if (cbTimKiem.Text == "Theo mã NV")  //Tìm kiếm theo mã NV

                    {
                        dGVDSNV.DataSource = null;
                        bus_NhanVien.ListNhanVienSearchByMaNV(dGVDSNV,txtBTimKiem.Text);
                    }
                    else if (cbTimKiem.Text == "Theo họ tên") // Tìm kiếm theo họ tên
                    {
                        dGVDSNV.DataSource = null;
                        bus_NhanVien.ListNhanVienSearchByHoTen(dGVDSNV, txtBTimKiem.Text);
                    }
                    else if (cbTimKiem.Text == "Theo chức vụ") // Tìm kiếm theo chức vụ
                    {
                        dGVDSNV.DataSource = null;
                        bus_NhanVien.ListNhanVienSearchByChucVu(dGVDSNV, txtBTimKiem.Text);

                    }
                }
                else
                {
                    bus_NhanVien.ListNhanVien(dGVDSNV);
                }

                dGVDSNV.Columns[0].Width = (int)(dGVDSNV.Width * 0.15);
                dGVDSNV.Columns[1].Width = (int)(dGVDSNV.Width * 0.15);
                dGVDSNV.Columns[2].Width = (int)(dGVDSNV.Width * 0.2);
                dGVDSNV.Columns[3].Width = (int)(dGVDSNV.Width * 0.15);
                dGVDSNV.Columns[4].Width = (int)(dGVDSNV.Width * 0.15);
                dGVDSNV.Columns[5].Width = (int)(dGVDSNV.Width * 0.2);
            }
        }



        //Chi tiết nhân viên 
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Tìm kiếm
        private void txtBTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBTimKiem.Text != "")
            {

                if (cbTimKiem.Text == "Theo mã NV")  //Tìm kiếm theo mã NV

                {
                    dGVDSNV.DataSource = null;
                    bus_NhanVien.ListNhanVienSearchByMaNV(dGVDSNV, txtBTimKiem.Text);
                }
                else if (cbTimKiem.Text == "Theo họ tên") // Tìm kiếm theo họ tên
                {
                    dGVDSNV.DataSource = null;
                    bus_NhanVien.ListNhanVienSearchByHoTen(dGVDSNV, txtBTimKiem.Text);
                }
                else if (cbTimKiem.Text == "Theo chức vụ") // Tìm kiếm theo chức vụ
                {
                    dGVDSNV.DataSource = null;
                    bus_NhanVien.ListNhanVienSearchByChucVu(dGVDSNV, txtBTimKiem.Text);

                }

                dGVDSNV.Columns[0].Width = (int)(dGVDSNV.Width * 0.15);
                dGVDSNV.Columns[1].Width = (int)(dGVDSNV.Width * 0.15);
                dGVDSNV.Columns[2].Width = (int)(dGVDSNV.Width * 0.2);
                dGVDSNV.Columns[3].Width = (int)(dGVDSNV.Width * 0.15);
                dGVDSNV.Columns[4].Width = (int)(dGVDSNV.Width * 0.15);
                dGVDSNV.Columns[5].Width = (int)(dGVDSNV.Width * 0.2);
            }
            else
            {
                bus_NhanVien.ListNhanVien(dGVDSNV);

                dGVDSNV.Columns[0].Width = (int)(dGVDSNV.Width * 0.15);
                dGVDSNV.Columns[1].Width = (int)(dGVDSNV.Width * 0.15);
                dGVDSNV.Columns[2].Width = (int)(dGVDSNV.Width * 0.2);
                dGVDSNV.Columns[3].Width = (int)(dGVDSNV.Width * 0.15);
                dGVDSNV.Columns[4].Width = (int)(dGVDSNV.Width * 0.15);
                dGVDSNV.Columns[5].Width = (int)(dGVDSNV.Width * 0.2);
            }

        }

        #endregion

        //Xử lý các method
        #region 

        #endregion
    }
}
