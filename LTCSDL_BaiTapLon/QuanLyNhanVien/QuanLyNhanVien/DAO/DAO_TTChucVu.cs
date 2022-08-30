using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DAO
{
    internal class DAO_TTChucVu
    {
        CafeEntities db;

        public DAO_TTChucVu()
        {
            db = new CafeEntities();
        }

        public dynamic ListTTChucVu()
        {
            dynamic ds = db.TTChucVus.Select(s => new
            {
                s.MaChucVu,
                s.TenChucVu
            }).ToList();

            return ds;
        }
    }
}
