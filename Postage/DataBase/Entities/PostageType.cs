using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageApp.DataBase.Entities
{
    public class PostageType : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
    }
}
