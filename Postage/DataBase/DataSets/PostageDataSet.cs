using PostageApp.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageApp.DataBase
{
    public class PostageDataSet : BaseDataSet<Postage>
    {
        public PostageDataSet(DataBase db) : base(db)
        {
        }

        protected override void Validate(Postage item)
        {
            if (db.Workmans.Contains(item.WorkmanID) == false)
                throw new ArgumentException($"Workman with ID {item.WorkmanID} does not exist");

            if (db.Workmans.Contains(item.ClientID) == false)
                throw new ArgumentException($"Client with ID {item.ClientID} does not exist");

            if (db.Workmans.Contains(item.PostageTypeID) == false)
                throw new ArgumentException($"PostageType with ID {item.PostageTypeID} does not exist");

            if (db.Workmans.Contains(item.DepartmentID) == false)
                throw new ArgumentException($"Department with ID {item.DepartmentID} does not exist");

            if (item.Price < 0)
                throw new ArgumentException($"Price should be positive number");

            if (item.Weight < 0)
                throw new ArgumentException($"Weight should be positive number");

            if (item.DeliveredOn > DateTime.Now)
                throw new ArgumentException($"DeliveredOn can't be future date");
        }
    }
}
