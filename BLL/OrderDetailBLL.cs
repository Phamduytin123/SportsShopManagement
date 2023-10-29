using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderDetailBLL
    {
        UserBLL user = new UserBLL();
        ProductBLL product = new ProductBLL();  
        OrderDetailDAO OrderDetailDAL = new OrderDetailDAO();
        public static OrderDetailBLL Instance = new OrderDetailBLL();
        public void AddHoaDon(string id, string username, string productname, int quantity, DateTime date)
        {
            Instance.AddOrder(new OrderDetail( Int32.Parse(id), 
                user.GetbyUsername(username).ID,
                product.GetProducts(productname).ID,
                quantity, date));
            
        }
        public void UpdateHoaDon(string id, string username, string productname, int quantity, DateTime date)
        {
            Instance.UpdateOrder(new OrderDetail(Int32.Parse(id),
                user.GetbyUsername(username).ID,
                product.GetProducts(productname).ID,
                quantity, date));
        }

        public List<OrderDetail> GetAll()
        {
            return OrderDetailDAL.GetAll();
        }
        public bool AddOrder(OrderDetail orderDetail)
        {
            if (orderDetail.Id == 0 || orderDetail.UserID == 0 || orderDetail.ProductID == 0 || orderDetail.OrderQuantity == 0 || orderDetail.date == null)
            {
                return false;
            }
            OrderDetailDAL.Insert(orderDetail);
            return true;
        }
        public bool UpdateOrder(OrderDetail orderDetail)
        {
            if (orderDetail.Id == 0 || orderDetail.UserID == 0 || orderDetail.ProductID == 0 || orderDetail.OrderQuantity == 0 || orderDetail.date == null)
            {
                return false;
            }
            OrderDetailDAL.Update(orderDetail);
            return true;
        }
        public bool DeleteOrder(int id)
        {
            if (id == 0)
            {
                return false;
            }
            OrderDetailDAL.Delete(id);
            return true;
        }
    }
}