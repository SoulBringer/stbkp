using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostageApp.DataBase;
using PostageApp.DataBase.Entities;

namespace PostageApp
{
    public partial class FormMain : Form
    {
        private DataBase.DataBase db = new DataBase.DataBase();

        public FormMain()
        {
            InitializeComponent();
            InitializeDatabase();
            tabControl1_SelectedIndexChanged(this, null);
        }

        private void InitializeDatabase()
        {
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
        }

        private void Postage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lstClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var postages = db.Postages.GetItems().ToArray();
            var postageTypes = db.PostageTypes.GetItems().ToArray();
            var departments = db.Departments.GetItems().ToArray();
            var clients = db.Clients.GetItems().ToArray();
            var workmans = db.Workmans.GetItems().ToArray();

            // Update list boxes with fresh values
            lstPostage.Items.Clear();
            lstPostageType.Items.Clear();
            lstDepartment.Items.Clear();
            lstClient.Items.Clear();
            lstWorkman.Items.Clear();

            lstPostage.Items.AddRange(postages);
            lstPostageType.Items.AddRange(postageTypes);
            lstDepartment.Items.AddRange(departments);
            lstClient.Items.AddRange(clients);
            lstWorkman.Items.AddRange(workmans);

            // Update comboboxes with up-to-date values
            cbDepartment.Items.Clear();
            cbPostageType.Items.Clear();
            cbClientID.Items.Clear();
            cbwDepartment.Items.Clear();

            cbDepartment.Items.AddRange(departments);
            cbPostageType.Items.AddRange(postageTypes);
            cbClientID.Items.AddRange(clients);
            cbWorkman.Items.AddRange(workmans);
            cbwDepartment.Items.AddRange(departments);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lstPostageType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void lstPostage_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = lstPostage.SelectedItem as Postage;
            if (item != null)
            {
                cbClientID.SelectedItem = db.Clients.GetItem(item.ClientID);
                cbDepartment.SelectedItem = db.Departments.GetItem(item.DepartmentID);
                cbPostageType.SelectedItem = db.PostageTypes.GetItem(item.PostageTypeID);
                cbWorkman.SelectedItem = db.Workmans.GetItem(item.WorkmanID);

                txtPrice.Text = item.Price.ToString();
                txtWeight.Text = item.Weight.ToString();
                dtDelieredOn.Value = item.DeliveredOn;
            }
        }

        private void Client_Click(object sender, EventArgs e)
        {

        }

        private void Department_Click(object sender, EventArgs e)
        {

        }
    }
}
