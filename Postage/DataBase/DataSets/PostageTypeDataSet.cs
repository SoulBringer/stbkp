using PostageApp.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageApp.DataBase
{
    public class PostageTypeDataSet : BaseDataSet<PostageType>
    {
        public PostageTypeDataSet(DataBase db) : base(db)
        {
        }

        public override void Add(PostageType item)
        {
            throw new NotImplementedException();
        }

        public override void Update(PostageType item)
        {
            throw new NotImplementedException();
        }
    }
}
