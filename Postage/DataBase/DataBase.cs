﻿using PostageApp.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageApp.DataBase
{
    public class DataBase
    {
        public ClientDataSet Clients { get; }
        public DepartmentDataSet Departments { get; }
        public PostageDataSet Postages { get; }
        public PostageTypeDataSet PostageTypes { get; }
        public WorkmanDataSet Workmans { get; }


        public DataBase()
        {
            Clients = new ClientDataSet(this);
            Departments = new DepartmentDataSet(this);
            Postages = new PostageDataSet(this);
            PostageTypes = new PostageTypeDataSet(this);
            Workmans = new WorkmanDataSet(this);
        }

        public bool IsEntityInUse(IEntity entity)
        {
            return
                Clients.IsEntityInUse(entity) ||
                Departments.IsEntityInUse(entity) ||
                Postages.IsEntityInUse(entity) ||
                PostageTypes.IsEntityInUse(entity) ||
                Workmans.IsEntityInUse(entity);
        }
    }
}
