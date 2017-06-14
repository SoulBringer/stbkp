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
            throw new NotImplementedException();
        }
    }
}
