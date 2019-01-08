using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFontend.DAL
{
    public interface IRepos<T>
    {
        List<T> GetAll();
        T Insert(T obj);
        void Delete(T obj);
        void Update(T obj);
        T GetByID(string id);

    }
}
