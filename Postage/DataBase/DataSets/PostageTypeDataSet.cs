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

        protected override void Validate(PostageType item)
        {
            throw new NotImplementedException();
        }
    }
}
