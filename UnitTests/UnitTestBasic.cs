using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageApp.DataBase;
using PostageApp.DataBase.Entities;

namespace UnitTests
{
    [TestClass]
    public class UnitTestBasic
    {
        [TestMethod]
        public void ClientAddOkTest()
        {
            var db = new DataBase();
            var clientID = db.Clients.Add(new Client() { Name = "Vasya", Address = "Keletska 97/2" });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ClientAddFail1Test()
        {
            var db = new DataBase();
            var clientID = db.Clients.Add(new Client() { Name = "", Address = "Keletska 97/2" });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ClientAddFail2Test()
        {
            var db = new DataBase();
            var clientID = db.Clients.Add(new Client() { Name = "Petya", Address = "" });
        }

        [TestMethod]
        public void IsImplementedTest()
        {
            var db = new DataBase();
            var clientID = db.Clients.Add(new Client() { Name = "Vasya", Address = "Keletska 97/2" });
            var depID = db.Departments.Add(new Department() { PostalIndex = "21000", Address = "Kosmo 14/88" });
            var typeID = db.PostageTypes.Add(new PostageType() { Name = "Priority mail", Note = "Just an ordinary mail"});
            var workmnID = db.Workmans.Add(new Workman() { Name = "Inokentiy", HiredOn = new DateTime(2016, 05, 09), DepartmentID = depID });

            var postageID = db.Postages.Add(
                new Postage() {
                    ClientID = clientID,
                    DepartmentID = depID,
                    PostageTypeID = typeID,
                    WorkmanID = workmnID,
                    DeliveredOn = new DateTime(2017,01,01),
                    Price = 1000,
                    Weight = 500
                }
            );
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteItemInUseTest()
        {
            var db = new DataBase();
            var clientID = db.Clients.Add(new Client() { Name = "Vasya", Address = "Keletska 97/2" });
            var depID = db.Departments.Add(new Department() { PostalIndex = "21000", Address = "Kosmo 14/88" });
            var typeID = db.PostageTypes.Add(new PostageType() { Name = "Priority mail", Note = "Just an ordinary mail" });
            var workmnID = db.Workmans.Add(new Workman() { Name = "Inokentiy", HiredOn = new DateTime(2016, 05, 09), DepartmentID = depID });

            var postageID = db.Postages.Add(
                new Postage()
                {
                    ClientID = clientID,
                    DepartmentID = depID,
                    PostageTypeID = typeID,
                    WorkmanID = workmnID,
                    DeliveredOn = new DateTime(2017, 01, 01),
                    Price = 1000,
                    Weight = 500
                }
            );

            db.Departments.Remove(depID);
        }
    }
}
