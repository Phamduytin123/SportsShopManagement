using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime date { get; set; }

        public OrderDetail() { }
        public OrderDetail(int id, int userID, int productID, int orderQuantity,DateTime date)
        {
            Id = id;
            UserID = userID;
            ProductID = productID;
            OrderQuantity = orderQuantity;
            this.date = date;
        }
    }
    
       
}
