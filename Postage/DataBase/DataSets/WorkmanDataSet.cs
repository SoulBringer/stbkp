using PostageApp.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageApp.DataBase
{
    public class WorkmanDataSet : BaseDataSet<Workman>
    {
        public WorkmanDataSet(DataBase db) : base(db)
        {
        }

        protected override void Validate(Workman item)
        {
            if (db.Departments.Contains(item.DepartmentID) == false)
                throw new ArgumentException($"Department with ID {item.DepartmentID} does not exist");
            if (string.IsNullOrEmpty(item.Name))
                throw new ArgumentException("Name can't be empty");
            if (Validator.IsValidName(item.Name) == false)
                throw new ArgumentException("Name should contain letters only");
            if (item.HiredOn == null)
                throw new ArgumentException("HiredOn can't be empty");
            if (item.HiredOn < new DateTime(2010, 01, 01))
                throw new ArgumentException("HiredOn can't be before 2010.01.01");
            if (item.HiredOn > DateTime.Now)
                throw new ArgumentException("HiredOn can't be in future");
        }

        public override bool IsEntityInUse(IEntity entity)
        {
            if (entity is Department)
                return items.Exists(n => n.DepartmentID == entity.ID);
            return false;
        }
    }
}
