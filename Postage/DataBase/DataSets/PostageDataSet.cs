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

        public override void Add(Postage item)
        {
            Validate(item);
            item.ID = maxID++;
            items.Add(item);
        }

        public override void Update(Postage item)
        {
            var itemToUpdate = items.FirstOrDefault(n => n.ID == item.ID);
            if (itemToUpdate == null)
                throw new ArgumentException($"Postage with ID {item.ID} does not exist");

            Validate(item);
            itemToUpdate.WorkmanID = item.WorkmanID;
            itemToUpdate.ClientID = item.ClientID;
            itemToUpdate.PostageTypeID = item.PostageTypeID;
            itemToUpdate.DepartmentID = item.DepartmentID;
            itemToUpdate.Weight = item.Weight;
            itemToUpdate.Price = item.Price;
            itemToUpdate.DeliveredOn = item.DeliveredOn;
        }

        private void Validate(Postage item)
        {
            if (db.Workmans.Contains(item.WorkmanID) == false)
                throw new ArgumentException($"Workman with ID {item.WorkmanID} does not exist");

            if (db.Workmans.Contains(item.ClientID) == false)
                throw new ArgumentException($"Client with ID {item.ClientID} does not exist");

            if (db.Workmans.Contains(item.PostageTypeID) == false)
                throw new ArgumentException($"PostageType with ID {item.PostageTypeID} does not exist");

            if (db.Workmans.Contains(item.DepartmentID) == false)
                throw new ArgumentException($"Department with ID {item.DepartmentID} does not exist");
        }
    }
}
