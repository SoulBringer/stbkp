using PostageApp.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageApp.DataBase
{
    public class DepartmentDataSet : BaseDataSet<Department>
    {
        public DepartmentDataSet(DataBase db) : base(db)
        {
        }

        protected override void Validate(Department item)
        {
            if (string.IsNullOrEmpty(item.PostalIndex))
                throw new ArgumentException("PostalIndex can't be empty");
            if (string.IsNullOrEmpty(item.Address))
                throw new ArgumentException("Address can't be empty");
        }
    }
}
