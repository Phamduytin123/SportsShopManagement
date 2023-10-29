using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Products
    {
        public int ID { get; set; }
        public string NameProduct { get; set; }
        public int Cost { get; set; }
        public int Quantity { get; set; }
        public Products() { }
        public Products(int ID, String NameProduct, int Cost,int Quantity)
        {
            this.ID = ID;
            this.NameProduct = NameProduct;
            this.Cost= Cost;
            this.Quantity = Quantity;
        }
    }
}
