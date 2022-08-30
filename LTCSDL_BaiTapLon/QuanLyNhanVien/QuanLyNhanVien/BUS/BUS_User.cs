using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanVien.DAO;

namespace QuanLyNhanVien.BUS
{
    class BUS_User
    {
        DAO_User daoUser;
        public BUS_User()
        {
            daoUser = new DAO_User();
        }
        public void ListAccount(DataGridView dg)
        {
            dg.DataSource = daoUser.UsersList();
        }

        public void ListAccountFind(DataGridView dg, string username)
        {
            dg.DataSource = daoUser.UserListFind(username);
        }

        public Account loginUser(string username, string password)
        {
            try
            {
                Account u = daoUser.Login(username, password);
                return u;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public void RolesList(ComboBox cb)
        {
            cb.DataSource = daoUser.EmployeeList();
            //cb.DisplayMember = "roleName";
            cb.ValueMember = "MaNV";
        }
        public bool AddUser(Account u)
        {
            try
            {
                daoUser.AddAccount(u);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool EditUser(Account u)
        {
            if (daoUser.GetAccount(u.username) != null)
            {
                try
                {
                    daoUser.EditAccount(u);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool CheckUserByUsername(string username)
        {
            if (daoUser.checkAccountByUsername(username)) return true;
            return false;
        }
        public bool DeleteUser(String username)
        {
            if (daoUser.checkAccountByUsername(username))
            {
                try
                {
                    daoUser.DeleteAccount(username);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
