using PostageApp.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageApp.DataBase
{
    public abstract class BaseDataSet<T> : IDataSet<T> where T : IEntity
    {
        protected DataBase db;
        protected int maxID = 0;
        protected List<T> items = new List<T>();

        public abstract void Add(T item);
        public abstract void Update(T item);

        public BaseDataSet(DataBase db)
        {
            this.db = db;
        }

        public void Remove(int id)
        {
            var itemToRemove = items.FirstOrDefault(n => n.ID == id);
            if (itemToRemove == null)
                throw new ArgumentException($"{nameof(T)} with ID {id} is not exist");
            items.Remove(itemToRemove);
        }

        public IEnumerable<T> GetItems()
        {
            return items;
        }

        public bool Contains(int id)
        {
            return items.Exists(n => n.ID == id);
        }
    }
}
