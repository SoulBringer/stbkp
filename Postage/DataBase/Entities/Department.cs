using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageApp.DataBase.Entities
{
    public class Department : IEntity
    {
        public int ID { get; set; }
        public string PostalIndex { get; set; }
        public string Address { get; set; }
    }
}
