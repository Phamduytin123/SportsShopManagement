
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductsDAO : IDAO<Products, int>
    {
        public void Delete(int data)
        {
            Db dataBase = new Db();
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "delete from Products where ID = " + data;
            sqlCommand.Connection = dataBase.sqlCon;
            sqlCommand.ExecuteNonQuery();
        }

        public List<Products> GetAll()
        {
            Db dataBase = new Db();
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select * from Products";
            sqlCommand.Connection = dataBase.sqlCon;

            List<Products> Result = new List<Products>();

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                int ID = reader.GetInt32(0);
                string NameProduct = reader.GetString(1);
                int Cost = reader.GetInt32(2);
                int Quantity = reader.GetInt32(3);
                Result.Add(new Products(ID, NameProduct, Cost, Quantity));
            }
            reader.Close();
            return Result;
        }
        public List<string> GetListName()
        {
            Db dataBase = new Db();
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select NameProduct from Products";
            sqlCommand.Connection = dataBase.sqlCon;

            List<string> Result = new List<string>();

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                
                string NameProduct = reader.GetString(0);
                
                Result.Add(NameProduct);
            }
            reader.Close();
            return Result;
        }
        public Products GetById(int id)
        {

            Db dataBase = new Db();
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select * from Products where ID = " + id + "";
            sqlCommand.Connection = dataBase.sqlCon;

            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                int ID = reader.GetInt32(0);
                string NameProduct = reader.GetString(1);
                int Cost = reader.GetInt32(2);
                int Quantity = reader.GetInt32(3);
                return new Products(ID, NameProduct, Cost, Quantity);
            }
            reader.Close();

            return new Products();

        }

        public void Insert(Products data)
        {
            Db dataBase = new Db();
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "insert into Products (ID, NameProduct, Cost, Quantity) values('" + data.ID + "', N'" + data.NameProduct + "', '" + data.Cost + "', '" + data.Quantity + "')";
            sqlCommand.Connection = dataBase.sqlCon;
            sqlCommand.ExecuteNonQuery();
        }

        public void Update(Products data)
        {
            Db dataBase = new Db();
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "update Products set NameProduct = N'" + data.NameProduct + "', Cost = '" + data.Cost + "', Quantity = '" + data.Quantity + "' where ID = " + data.ID; ;
            sqlCommand.Connection = dataBase.sqlCon;
            sqlCommand.ExecuteNonQuery();
        }
        public Products GetByName(string name)
        {
            Db dataBase = new Db();
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select * from Products where NameProduct = N'" + name + "'";
            sqlCommand.Connection = dataBase.sqlCon;

            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                int ID = reader.GetInt32(0);
                string NameProduct = reader.GetString(1);
                int Cost = reader.GetInt32(2);
                int Quantity = reader.GetInt32(3);
                return new Products(ID, NameProduct, Cost, Quantity);
            }
            reader.Close();

            return new Products();
        }
    }
}
