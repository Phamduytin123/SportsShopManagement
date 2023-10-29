
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDetailDAO : IDAO<OrderDetail, int>
    {
        Db dataBase = new Db();
        public void Delete(int data)
        {
            //dataBase.OpenConnection();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "delete from OrderDetail where ID = " + data;
            sqlCommand.Connection = dataBase.sqlCon;
            sqlCommand.ExecuteNonQuery();
        }

        public List<OrderDetail> GetAll()
        {
  
            //dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select * from OrderDetail";
            sqlCommand.Connection = dataBase.sqlCon;

            List<OrderDetail> Result = new List<OrderDetail>();

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                int ID = reader.GetInt32(0);
                int UserId = reader.GetInt32(1);
                int ProductId = reader.GetInt32(2);
                int OrderQuantity = reader.GetInt32(3);
                DateTime date= reader.GetDateTime(4);
                Result.Add(new OrderDetail(ID, UserId, ProductId, OrderQuantity, date));
            }
            reader.Close();
            return Result;
        }

        public OrderDetail GetById(int id)
        {
           
            //dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select * from OrderDetail where ID = " + id + "";
            sqlCommand.Connection = dataBase.sqlCon;

            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                int ID = reader.GetInt32(0);
                int UserId = reader.GetInt32(1);
                int ProductId = reader.GetInt32(2);
                int OrderQuantity = reader.GetInt32(3);
                DateTime date = reader.GetDateTime(4);
                return new OrderDetail(ID, UserId, ProductId, OrderQuantity, date);
            }
            reader.Close();

            return new OrderDetail();
        }

        public void Insert(OrderDetail data)
        {
            
            //dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "insert into OrderDetail(ID, UserID, ProductID, OrderQuantity, DayTime) values('" + data.Id + "', '" + data.UserID + "', '" + data.ProductID + "', '" + data.OrderQuantity + "', '" + data.date + "')";
            sqlCommand.Connection = dataBase.sqlCon;
            sqlCommand.ExecuteNonQuery();
        }

        public void Update(OrderDetail data)
        {
           
            //dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "update OrderDetail set UserID = '" + data.UserID + "', ProductID = '" + data.ProductID + "', OrderQuantity = '" + data.OrderQuantity + "', DayTime = '" + data.date+ "' where ID = " + data.Id;
            sqlCommand.Connection = dataBase.sqlCon;
            sqlCommand.ExecuteNonQuery();
        }
    }
}
