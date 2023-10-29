using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserAccount
    {
        public int ID { set; get; }
        public string UserName{ set; get; }
        public string UserPassword { set; get; }
        public byte UserRole { set; get; }
        public UserAccount(int iD, string userAccount, string userPassword, byte userRole)
        {
            ID = iD;
            UserName = userAccount;
            UserPassword = userPassword;
            UserRole = userRole;
        }
        public UserAccount(){}
    }
}
