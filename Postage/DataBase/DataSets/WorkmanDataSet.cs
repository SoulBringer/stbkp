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
            throw new NotImplementedException();
        }
    }
}
