using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductBLL
    {
        ProductsDAO productsDAL = new ProductsDAO();
        public static ProductBLL instance = new ProductBLL();
        
        public List<Products> getAll()
        {
            return productsDAL.GetAll();
        }
        public Products GetById(int id)
        {
            return productsDAL.GetById(id);
        }
        public Products GetProducts(string name)
        {
            return productsDAL.GetByName(name);
        }
        public List<string> GetListProductsName()
        {
            return productsDAL.GetListName();
        }

        public bool AddProduct(Products products)
        {
            if (products.ID == 0 || products.NameProduct == "" || products.Cost == 0 || products.Quantity == 0)
            {
                return false;
            }
            productsDAL.Insert(products);
            return true;
        }
        public bool UpdateProduct(Products products)
        {
            if (products.ID == 0 || products.NameProduct == "" || products.Cost == 0 || products.Quantity == 0)
            {
                return false;
            }
            productsDAL.Update(products);
            return true;
        }
        public bool DeleteProduct(int id)
        {
            if (id == 0)
            {
                return false;
            }
            productsDAL.Delete(id);
            return true;
        }
    }
}
