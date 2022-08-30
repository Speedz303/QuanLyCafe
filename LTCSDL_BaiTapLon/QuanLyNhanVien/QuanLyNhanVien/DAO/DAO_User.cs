using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.DAO
{
    class DAO_User
    {
        CafeEntities db;

        public DAO_User()
        {
            db = new CafeEntities();
        }

        public dynamic UsersList()
        {
            var ds = db.Accounts.Select(u => new
            {
                u.userID,
                u.username,
                //u.password,
                u.MaNhanVien,
            }).ToList();
            return ds;
        }

        public dynamic UserListFind(string username)
        {
            var ds = db.Accounts.Where(s => s.username.Contains(username)).Select(u => new
            {
                u.userID,
                u.username,
                //u.password,
                u.MaNhanVien,
            }).ToList();
            return ds;
        }

        public Account GetAccount(string username)
        {
            Account u = db.Accounts.FirstOrDefault(s => s.username == username);
            return u;
        }
        public dynamic Login(string username, string password)
        {
            Account u = db.Accounts.FirstOrDefault(s => s.username == username);
            if (u != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, u.password)) return u;
            }
            return null;
        }
        public string getAccountID(string username)
        {
            Account u = db.Accounts.Find(username);
            if (u != null)
            {
                return u.userID;
            }
            else return "";
        }

        public void AddAccount(Account u)
        {
            db.Accounts.Add(u);
            db.SaveChanges();
        }

        public void EditAccount(Account u)
        {
            Account us = db.Accounts.FirstOrDefault(s => s.userID == u.userID);
            us.password = u.password;
            db.SaveChanges();
        }
        public void DeleteAccount(string username)
        {
            Account u = db.Accounts.FirstOrDefault(s => s.username == username);
            db.Accounts.Remove(u);
            db.SaveChanges();
        }
        public dynamic EmployeeList()
        {
            var ds = db.QLNhanViens.Select(r => new
            {
                r.MaChucVu,
                r.MaNhanVien
            }).ToList();
            //var itemToRemove = ds.Single(r => r.roleName.Equals("admin"));
            //ds.Remove(itemToRemove);
            return ds;
        }
        public bool checkAccountByUsername(string username)
        {
            Account u = null;
            u = db.Accounts.FirstOrDefault(s => s.username == username);
            if (u != null) return true;//co user
            return false;// chua co user
        }

    }
}
