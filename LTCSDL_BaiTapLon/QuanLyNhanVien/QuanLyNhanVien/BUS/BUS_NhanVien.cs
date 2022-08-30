using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Thay thế tên 
using QuanLyNhanVien.DAO;
namespace QuanLyNhanVien.BUS
{
    internal class BUS_NhanVien
    {
        DAO_NhanVien dao_NhanVien;

        public BUS_NhanVien()
        {
            dao_NhanVien = new DAO_NhanVien();
        }

        public void ListNhanVien(DataGridView dgv)
        {
            dgv.DataSource = dao_NhanVien.ListNhanVienShowInDGW();
        }

        public void ListNhanVien2(DataGridView dgv)
        {
            dgv.DataSource = dao_NhanVien.ListNhanVienShowInDGWTaiKhoan();

        }

        public void ListNhanVienSearchByMaNV(DataGridView dgv, String maNV)
        {
            dgv.DataSource = dao_NhanVien.ListNhanVienSearchByMaNV(maNV);
        }

        public void ListNhanVienSearchByHoTen(DataGridView dgv, String txtBox)
        {
            dgv.DataSource = dao_NhanVien.ListNhanVienSearchByHoTen(txtBox);
        }

        public void ListNhanVienSearchByChucVu(DataGridView dgv, String tenChucVu)
        {
            dgv.DataSource = dao_NhanVien.ListNhanVienSearchByChucVu(tenChucVu);
        }

        public void getCMNDByMaNV(TextBox txtBox, String maNV)
        {
            txtBox.Text = dao_NhanVien.getCMNDByMaNV(maNV).ToString();
        }

        public void getDiaChiByMaNV(TextBox txtBox, String maNV)
        {
            txtBox.Text = dao_NhanVien.getDiaChiByMaNV(maNV);
        }

        public void getMaCVByMaNV(TextBox txtBox, String maNV)
        {
            txtBox.Text = dao_NhanVien.getMaCVByMaNV(maNV).ToString();
        }

        public bool isMaNhanVienExist(String maNV)
        {
            return dao_NhanVien.isMaNhanVienExist(maNV);
        }

        public bool isNhanVienExist(QLNhanVien QLNV)
        {
            return dao_NhanVien.isNhanVienExist(QLNV);
        }

        public bool InsertNhanVien(QLNhanVien QLNV)
        {
            try
            {
                dao_NhanVien.InsertNhanVien(QLNV);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditNhanVien(QLNhanVien QLNV)
        {
            try
            {
                dao_NhanVien.EditNhanVien(QLNV);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteNhanVien(String MaNV)
        {
            try
            {
                dao_NhanVien.DeleteNhanVien(MaNV);
                return true;
            }
            catch (Exception)//DbUpdateException ex
            {
                return false;
            }
        }
    }
}

