using PostageApp.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageApp.DataBase
{
    public class ClientDataSet : BaseDataSet<Client>
    {
        public ClientDataSet(DataBase db) : base(db)
        {
        }

        public override void Add(Client item)
        {
            throw new NotImplementedException();
        }

        public override void Update(Client item)
        {
            throw new NotImplementedException();
        }
    }
}
