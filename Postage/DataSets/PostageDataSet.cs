using PostageApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageApp.DataSets
{
    public class PostageDataSet
    {
        private int maxID = 1;
        public List<Client> ClientList { get; set; }
        public List<Department> DepartmentList { get; set; }
        public List<Postage> PostageList { get; set; }
        public List<PostageType> PostageTypeList { get; set; }
        public List<Workman> WorkmanList { get; set; }


        public void AddPostage(int WorkmanID, int ClientID, int PostageTypeID, int DepartmentID, int Weight, int Price, DateTime DeliveredOn)
        {
            if (!WorkmanList.Exists(n => n.ID == WorkmanID))
                throw new InvalidOperationException($"Workman with ID {WorkmanID} does not exist");

            if (!ClientList.Exists(n => n.ID == ClientID))
                throw new InvalidOperationException($"Client with ID {ClientID} does not exist");

            if (!PostageTypeList.Exists(n => n.ID == PostageTypeID))
                throw new InvalidOperationException($"PostageType with ID {PostageTypeID} does not exist");

            if (!DepartmentList.Exists(n => n.ID == DepartmentID))
                throw new InvalidOperationException($"Department with ID {DepartmentID} does not exist");

            var id = maxID++;
            PostageList.Add(new Postage() {
                ID = id,
                WorkmanID = WorkmanID,
                ClientID = ClientID,
                PostageTypeID = PostageTypeID,
                DepartmentID = DepartmentID,
                Weight = Weight,
                Price = Price,
                DeliveredOn = DeliveredOn,
            });
        }

        public void RemovePostage(int id)
        {
            var postageToRemove = PostageList.FirstOrDefault(n => n.ID == id);

            if (postageToRemove == null)
                throw new InvalidOperationException($"Postage with ID {id} does not exist");

            PostageList.Remove(postageToRemove);
        }

        public void UpdatePostage(int id, int WorkmanID, int ClientID, int PostageTypeID, int DepartmentID, int Weight, int Price, DateTime DeliveredOn)
        {
            var postageToUpdate = PostageList.FirstOrDefault(n => n.ID == id);
            if (postageToUpdate == null)
                throw new InvalidOperationException($"Postage with ID {id} does not exist");

            if (!WorkmanList.Exists(n => n.ID == WorkmanID))
                throw new InvalidOperationException($"Workman with ID {WorkmanID} does not exist");

            if (!ClientList.Exists(n => n.ID == ClientID))
                throw new InvalidOperationException($"Client with ID {ClientID} does not exist");

            if (!PostageTypeList.Exists(n => n.ID == PostageTypeID))
                throw new InvalidOperationException($"PostageType with ID {PostageTypeID} does not exist");

            if (!DepartmentList.Exists(n => n.ID == DepartmentID))
                throw new InvalidOperationException($"Department with ID {DepartmentID} does not exist");

            postageToUpdate.WorkmanID = WorkmanID;
            postageToUpdate.ClientID = ClientID;
            postageToUpdate.PostageTypeID = PostageTypeID;
            postageToUpdate.DepartmentID = DepartmentID;
            postageToUpdate.Weight = Weight;
            postageToUpdate.Price = Price;
            postageToUpdate.DeliveredOn = DeliveredOn;
        }

    }
}
