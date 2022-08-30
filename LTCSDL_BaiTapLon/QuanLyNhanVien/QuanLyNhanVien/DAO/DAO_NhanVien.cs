using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DAO
{
    internal class DAO_NhanVien
    {
        CafeEntities db;

        public DAO_NhanVien()
        {
            db = new CafeEntities();
        }

        public dynamic ListNhanVienShowInDGW()
        {
            var ds = db.QLNhanViens.Select(s => new
            {
                    s.MaNhanVien,
                    s.Ho,
                    s.Ten,
                    s.NgaySinh,
                    s.SoDienThoai,
                    s.TTChucVu.TenChucVu

            }).ToList();


            return ds;
        }

        public dynamic ListNhanVienShowInDGWTaiKhoan()
        {
            var ds = db.QLNhanViens.Where(s => s.MaChucVu == 1 || s.MaChucVu == 2).Select(s => new
            {
                s.MaNhanVien,
                s.Ho,
                s.Ten,
                s.NgaySinh,
                s.SoDienThoai,
                s.TTChucVu.TenChucVu

            }).ToList();


            return ds;
        }

        public dynamic ListNhanVienSearchByMaNV(String maNV)
        {

            var ds = db.QLNhanViens.Where(s => maNV.Contains(s.MaNhanVien.Substring(0, maNV.Length))).Select(s => new
            {
                s.MaNhanVien,
                s.Ho,
                s.Ten,
                s.NgaySinh,
                s.SoDienThoai,
                s.TTChucVu.TenChucVu
            }).ToList();
                
            return ds;
        }
        public dynamic ListNhanVienSearchByHoTen(String Txtbox)
        {
            var ds = db.QLNhanViens.Where(s => Txtbox.Contains(s.Ho.Substring(0,Txtbox.Length)) || Txtbox.Contains(s.Ten.Substring(0, Txtbox.Length))).Select(s => new
            {
                s.MaNhanVien,
                s.Ho,
                s.Ten,
                s.NgaySinh,
                s.SoDienThoai,
                s.TTChucVu.TenChucVu
            }).ToList();

            return ds;
        }
        public dynamic ListNhanVienSearchByChucVu(String TenChucVu)
        {
            var ds = db.QLNhanViens.Where(s => TenChucVu.Contains(s.TTChucVu.TenChucVu.Substring(0, TenChucVu.Length))).Select(s => new
            {
                s.MaNhanVien,
                s.Ho,
                s.Ten,
                s.NgaySinh,
                s.SoDienThoai,
                s.TTChucVu.TenChucVu
            }).ToList();

            return ds;
        }

        public dynamic getCMNDByMaNV(String maNV)
        {
            var rs = db.QLNhanViens.Where(s => maNV == s.MaNhanVien).Select(s => s.CMND).FirstOrDefault();

            return rs;
        }

        public dynamic getDiaChiByMaNV(String maNV)
        {
            var rs = db.QLNhanViens.Where(s => maNV == s.MaNhanVien).Select(s => s.DiaChi).FirstOrDefault();

            return rs;
        }

        public dynamic getMaCVByMaNV(String maNV)
        {
            var rs = db.QLNhanViens.Where(s => maNV == s.MaNhanVien).Select(s => s.MaChucVu).FirstOrDefault();

            return rs;
        }

        //Find data is exist
        public bool isMaNhanVienExist(String maNV)
        {
            QLNhanVien check = db.QLNhanViens.Find(maNV);
            if (check != null)
            {
                return true;
            }
            return false;
        }

        public bool isNhanVienExist(QLNhanVien QLNV)
        {
            QLNhanVien check = new QLNhanVien();
            check = db.QLNhanViens.Where(s => s.Ho == QLNV.Ho && s.Ten == QLNV.Ten && s.CMND == QLNV.CMND).FirstOrDefault();

            if (check != null)
                return true;
            return false;
        }

        public void InsertNhanVien(QLNhanVien QLNV)
        {
            db.QLNhanViens.Add(QLNV);
            db.SaveChanges();
        }

        public void EditNhanVien(QLNhanVien QLNV)
        {
            QLNhanVien editedQLNV = db.QLNhanViens.Find(QLNV.MaNhanVien);
            editedQLNV.Ho = QLNV.Ho;
            editedQLNV.Ten = QLNV.Ten;
            editedQLNV.NgaySinh = QLNV.NgaySinh;
            editedQLNV.DiaChi = QLNV.DiaChi;
            editedQLNV.SoDienThoai = QLNV.SoDienThoai;
            editedQLNV.MaChucVu = QLNV.MaChucVu;

            db.SaveChanges();
        }

        public void DeleteNhanVien(String MaNV)
        {
            QLNhanVien qlnv = db.QLNhanViens.Find(MaNV);
            db.QLNhanViens.Remove(qlnv);

            db.SaveChanges();
        }
    }
}

