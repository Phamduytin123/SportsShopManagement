using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal interface IDAO <T,U>
    {
        List<T> GetAll();
        T GetById(U id);
        void Insert(T data);
        void Update(T data);
        void Delete(U data);
    }
}
