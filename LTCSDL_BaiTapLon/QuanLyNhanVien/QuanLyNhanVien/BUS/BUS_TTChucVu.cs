using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanVien.DAO;

namespace QuanLyNhanVien.BUS
{
    internal class BUS_TTChucVu
    {
        DAO_TTChucVu dao_TTChucVu;

        public BUS_TTChucVu()
        {
            dao_TTChucVu = new DAO_TTChucVu();
        }
        public void ListTTChucVu(ComboBox cb)
        {
            cb.DataSource = dao_TTChucVu.ListTTChucVu();
            cb.DisplayMember = "TenChucVu";
            cb.ValueMember = "MaChucVu";
        }
    }
}
