using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;

namespace BLL
{
    public class UserBLL
    {
        UserDAO UserDAL = new UserDAO();
        public static UserBLL instance = new UserBLL();

        public Boolean CheckUser(string UserName, string UserPassword)
        {
            if (UserDAL.GetByUser(UserName,UserPassword).UserName == null)
            {
                return false;
            }
            return true;
        }
        public List<UserAccount> GetAll()
        {
            return UserDAL.GetAll();
        }
        public Boolean AddUser(UserAccount user)
        {
            if (user.ID == 0 || user.UserName == "" || user.UserPassword == "" || user.UserRole > 2)
            {
                return false;
            }
            UserDAL.Insert(user);
            return true;
        }
        public Boolean UpdateUser(UserAccount user)
        {
            if (user.ID == 0 || user.UserName == "" || user.UserPassword == "" || user.UserRole > 2)
            {
                return false;
            }
            UserDAL.Update(user);
            return true;
        }

        public Boolean DeleteUser(int id)
        {
            if (id == 0)
            {
                return false;
            }
            UserDAL.Delete(id);
            return true;
        }
        public UserAccount GetUser(string UserName,string UserPassword) 
        {
            return UserDAL.GetByUser(UserName, UserPassword);
        }
        public UserAccount GetbyId(int id)
        {
            return UserDAL.GetById(id);
        }
        public UserAccount GetbyUsername(string username)
        {
            return UserDAL.GetByUsername(username);
        }
        public List<string> GetListUserName()
        {
            return UserDAL.GetAllUsername();
        }
    }
}