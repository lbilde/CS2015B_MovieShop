using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieShopDll.Entities;

namespace MovieShopDll
{
    public interface IManager<T> where T : AbstractEntity
    {
        List<T> Read();
        T Read(int id);
        T Create(T t);
        T Update(T t);
        bool Delete(int id);
    }
}
