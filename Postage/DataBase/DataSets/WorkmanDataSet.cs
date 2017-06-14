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

        public override void Add(Workman item)
        {
            throw new NotImplementedException();
        }

        public override void Update(Workman item)
        {
            throw new NotImplementedException();
        }
    }
}
