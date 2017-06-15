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
        protected int maxID = 1;
        protected List<T> items = new List<T>();

        protected abstract void Validate(T item);

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

        public int Add(T item)
        {
            Validate(item);
            item.ID = maxID++;
            items.Add(item);
            return item.ID;
        }

        public void Update(T item)
        {
            var itemToUpdate = items.FirstOrDefault(n => n.ID == item.ID);
            if (itemToUpdate == null)
                throw new ArgumentException($"{nameof(T)} with ID {item.ID} does not exist");

            Validate(item);
            items.Remove(itemToUpdate);
            items.Add(item);
        }
    }
}
