using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageApp.DataBase
{
    interface IDataSet<T>
    {
        void Add(T item);
        void Update(T item);
        void Remove(int id);
        IEnumerable<T> GetItems();
        bool Contains(int id);
    }
}
