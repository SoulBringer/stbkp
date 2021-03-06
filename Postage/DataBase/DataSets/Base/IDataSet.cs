﻿using PostageApp.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageApp.DataBase
{
    interface IDataSet<T>
    {
        int Add(T item);
        void Update(T item);
        void Remove(int id);
        T GetItem(int id);
        IEnumerable<T> GetItems();
        bool Contains(int id);
        bool IsEntityInUse(IEntity entity);
        }
}
