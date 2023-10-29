using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

using DTO;


namespace DAL
{
    public class UserDAO : IDAO<UserAccount, int>
    {
        public void Delete(int data)
        {
            Db dataBase = new Db();
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "delete from UserAccount where ID = " + data;
            sqlCommand.Connection = dataBase.sqlCon;
            sqlCommand.ExecuteNonQuery();

        }

        public List<UserAccount> GetAll()
        {
            Db dataBase = new Db();
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select * from UserAccount";
            sqlCommand.Connection = dataBase.sqlCon;

            List<UserAccount> Result = new List<UserAccount>();

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                int ID = reader.GetInt32(0);
                string Username = reader.GetString(1);
                string Password = reader.GetString(2);
                byte Role = reader.GetByte(3);
                Result.Add(new UserAccount(ID, Username, Password, Role));
            }
            reader.Close();
            return Result;

        }
        public List<string> GetAllUsername()
        {
            Db dataBase = new Db();
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select UserName from UserAccount";
            sqlCommand.Connection = dataBase.sqlCon;

            List<string> Result = new List<string>();

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                
                string Username = reader.GetString(0);
                
                Result.Add( Username);
            }
            reader.Close();
            return Result;

        }

        public UserAccount GetById(int id)
        {

            Db dataBase = new Db();
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select * from UserAccount where ID = " + id + "";
            sqlCommand.Connection = dataBase.sqlCon;

            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                int ID = reader.GetInt32(0);
                string UserName = reader.GetString(1);
                String UserPassword = reader.GetString(2);
                byte UserRole = reader.GetByte(3);
                return new UserAccount(id, UserName, UserPassword, UserRole);
            }
            reader.Close();

            return new UserAccount();
        }
        public UserAccount GetByUsername(string username)
        {

            Db dataBase = new Db();
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select * from UserAccount where UserName = '" + username + "'";
            sqlCommand.Connection = dataBase.sqlCon;

            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                int ID = reader.GetInt32(0);
                string UserName = reader.GetString(1);
                string UserPassword = reader.GetString(2);
                byte UserRole = reader.GetByte(3);
                return new UserAccount(ID, UserName, UserPassword, UserRole);
            }
            reader.Close();

            return new UserAccount();
        }

        public void Insert(UserAccount data)
        {

            Db dataBase = new Db();
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "insert into UserAccount(ID, UserName, UserPassword, UserRole) values('" + data.ID + "', '" + data.UserName + "', '" + data.UserPassword + "', '" + data.UserRole + "')";
            sqlCommand.Connection = dataBase.sqlCon;
            sqlCommand.ExecuteNonQuery();

        }

        public void Update(UserAccount data)
        {

            Db dataBase = new Db();
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "update UserAccount set UserName = '" + data.UserName + "', UserPassword = '" + data.UserPassword + "', UserRole = '" + data.UserRole + "' where ID = " + data.ID;
            sqlCommand.Connection = dataBase.sqlCon;
            sqlCommand.ExecuteNonQuery();
        }
        public UserAccount GetByUser(string UserName, string UserPassword)
        {
            Db dataBase = new Db();
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select * from UserAccount where UserName = '" + UserName + "' and UserPassword = '" + UserPassword + "'";
            sqlCommand.Connection = dataBase.sqlCon;

            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                int ID = reader.GetInt32(0);
                string userName = reader.GetString(1);
                string userPassword = reader.GetString(2);
                byte Role = reader.GetByte(3);
                return new UserAccount(ID, userName, userPassword, Role);
            }
            return new UserAccount();
        }
    }
}
