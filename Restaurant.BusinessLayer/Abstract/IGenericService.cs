using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TAdd(T entity);
        void TRemove(T entity);
        void TUpdate(T entity);
        List<T> TGetList();
        T TGetById(int id);
    }
}
