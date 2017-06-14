using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageApp.DataBase.Entities
{
    public class Postage : IEntity
    {
        public int ID { get; set; }
        public int WorkmanID { get; set; }
        public int ClientID { get; set; }
        public int PostageTypeID { get; set; }
        public int DepartmentID { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
        public DateTime DeliveredOn { get; set; }
    }
}
