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

        protected override void Validate(Client item)
        {
            if (string.IsNullOrEmpty(item.Name))
                throw new ArgumentException("Name can't be empty");

            if (Validator.IsValidName(item.Name) == false)
                throw new ArgumentException("Name should contain letters only");

            if (string.IsNullOrEmpty(item.Address))
                throw new ArgumentException("Address can't be empty");

        }
    }
}
