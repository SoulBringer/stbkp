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
            if (string.IsNullOrEmpty(item.Name))
                throw new ArgumentException("Name can't be empty");
            if (string.IsNullOrEmpty(item.Note))
                throw new ArgumentException("Note can't be empty");
        }
    }
}
