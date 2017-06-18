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
            //InitializeDefaultDatabase();//
            tabControl1_SelectedIndexChanged(this, null);
        }

        private void InitializeDefaultDatabase()
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

        private void btnDBLoad_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog() { InitialDirectory = Application.StartupPath, Filter = "JSON|*.json|All Files|*.*" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var newDB = DataBase.DataBase.LoadFromFile(dialog.FileName);
                    db = newDB;
                    tabControl1_SelectedIndexChanged(this, null);
                    MessageBox.Show("Database is loaded", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Can't load file as a valid database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDBSave_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog() { InitialDirectory = Application.StartupPath, Filter = "JSON|*.json|All Files|*.*" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    db.SaveToFile(dialog.FileName);
                    MessageBox.Show("Database is saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Can't load file as a valid database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            cbDepartment.SelectedItem = null;
            cbPostageType.SelectedItem = null;
            cbClientID.SelectedItem = null;
            cbWorkman.SelectedItem = null;
            cbwDepartment.SelectedItem = null;

            cbDepartment.Items.Clear();
            cbPostageType.Items.Clear();
            cbClientID.Items.Clear();
            cbWorkman.Items.Clear();
            cbwDepartment.Items.Clear();

            cbDepartment.Items.AddRange(departments);
            cbPostageType.Items.AddRange(postageTypes);
            cbClientID.Items.AddRange(clients);
            cbWorkman.Items.AddRange(workmans);
            cbwDepartment.Items.AddRange(departments);

            // Clear text fields
            txtPrice.Text = "";
            txtWeight.Text = "";
            txtcaddress.Text = "";
            txtcname.Text = "";
            txtdepindex.Text = "";
            txtdepaddress.Text = "";
            txtptname.Text = "";
            txtwname.Text = "";
        }



        private int GetSelectedId(ComboBox cbClientID)
        {
            var item = cbClientID.SelectedItem as IEntity;
            if (item != null)
                return item.ID;
            return -1;
        }


        #region Postage

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

        private void btnPostageNew_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new Postage()
                {
                    ClientID = GetSelectedId(cbClientID),
                    DepartmentID = GetSelectedId(cbDepartment),
                    PostageTypeID = GetSelectedId(cbPostageType),
                    WorkmanID = GetSelectedId(cbWorkman),
                    Price = int.Parse(txtPrice.Text),   // TODO: consider change to NumericUpDown
                    Weight = int.Parse(txtWeight.Text), // TODO: consider change to NumericUpDown
                    DeliveredOn = dtDelieredOn.Value
                };
                db.Postages.Add(item);
                tabControl1_SelectedIndexChanged(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPostageUpdate_Click(object sender, EventArgs e)
        {
            try
            { 
                var item = lstPostage.SelectedItem as Postage;
                if (item != null)
                {
                    item = db.Clone(item);
                    item.ClientID = GetSelectedId(cbClientID);
                    item.DepartmentID = GetSelectedId(cbDepartment);
                    item.PostageTypeID = GetSelectedId(cbPostageType);
                    item.WorkmanID = GetSelectedId(cbWorkman);
                    item.Price = int.Parse(txtPrice.Text);
                    item.Weight = int.Parse(txtWeight.Text);
                    item.DeliveredOn = dtDelieredOn.Value;

                    db.Postages.Update(item);
                    tabControl1_SelectedIndexChanged(this, null);
                }
                else
                    MessageBox.Show("Select some entity in list");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPostageRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var item = lstPostage.SelectedItem as Postage;
                if (item != null)
                {
                    if (MessageBox.Show("Delete selected entity?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.Postages.Remove(item.ID);
                        tabControl1_SelectedIndexChanged(this, null);
                    }
                }
                else
                    MessageBox.Show("Select some entity in list");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Client

        private void lstClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = lstClient.SelectedItem as Client;
            if (item != null)
            {
                txtcname.Text = item.Name;
                txtcaddress.Text = item.Address;
            }
        }

        private void btnClientNew_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new Client()
                {
                    Name = txtcname.Text,
                    Address = txtcaddress.Text
                };
                db.Clients.Add(item);
                tabControl1_SelectedIndexChanged(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClientUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var item = lstClient.SelectedItem as Client;
                if (item != null)
                {
                    item.Name = txtcname.Text;
                    item.Address = txtcaddress.Text;

                    db.Clients.Update(item);
                    tabControl1_SelectedIndexChanged(this, null);
                }
                else
                    MessageBox.Show("Select some entity in list");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClientRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var item = lstClient.SelectedItem as Client;
                if (item != null)
                {
                    if (MessageBox.Show("Delete selected entity?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.Clients.Remove(item.ID);
                        tabControl1_SelectedIndexChanged(this, null);
                    }
                }
                else
                    MessageBox.Show("Select some entity in list");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void lstDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

            var item = lstDepartment.SelectedItem as Department;
            if (item != null)
            {
                txtdepaddress.Text = item.Address;
                txtdepindex.Text = item.PostalIndex;
            }

        }

        private void btnDepartmentNew_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new Department()
                {
                    PostalIndex = txtdepindex.Text,
                    Address = txtdepaddress.Text
                };
                db.Departments.Add(item);
                tabControl1_SelectedIndexChanged(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDepartmentUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var item = lstDepartment.SelectedItem as Department;
                if (item != null)
                {
                    item.PostalIndex = txtdepindex.Text;
                    item.Address = txtdepaddress.Text;

                    db.Departments.Update(item);
                    tabControl1_SelectedIndexChanged(this, null);
                }
                else
                    MessageBox.Show("Select some entity in list");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDepartmentRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var item = lstDepartment.SelectedItem as Department;
                if (item != null)
                {
                    if (MessageBox.Show("Delete selected entity?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.Departments.Remove(item.ID);
                        tabControl1_SelectedIndexChanged(this, null);
                    }
                }
                else
                    MessageBox.Show("Select some entity in list");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lstPostageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = lstPostageType.SelectedItem as PostageType;
            if (item != null)
            {
                txtptname.Text = item.Name;
                txtnote.Text = item.Note;
            }
        }

        private void btnPostTypeNew_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new PostageType()
                {
                    Name = txtptname.Text,
                    Note = txtnote.Text
                };
                db.PostageTypes.Add(item);
                tabControl1_SelectedIndexChanged(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPostTypeUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var item = lstPostageType.SelectedItem as PostageType;
                if (item != null)
                {
                    item.Name = txtptname.Text;
                    item.Note = txtnote.Text;

                    db.PostageTypes.Update(item);
                    tabControl1_SelectedIndexChanged(this, null);
                }
                else
                    MessageBox.Show("Select some entity in list");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPostTypeRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var item = lstPostageType.SelectedItem as PostageType;
                if (item != null)
                {
                    if (MessageBox.Show("Delete selected entity?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.PostageTypes.Remove(item.ID);
                        tabControl1_SelectedIndexChanged(this, null);
                    }
                }
                else
                    MessageBox.Show("Select some entity in list");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lstWorkman_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = lstWorkman.SelectedItem as Workman;
            if (item != null)
            {
                txtwname.Text = item.Name;
                cbwDepartment.SelectedItem = db.Departments.GetItem(item.DepartmentID);
                dtHiredOn.Value = item.HiredOn;
            }
        }

        private void btnWorkman_New_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new Workman()
                {
                    Name = txtwname.Text,
                    DepartmentID = GetSelectedId(cbwDepartment),
                    HiredOn = dtHiredOn.Value
                };
                db.Workmans.Add(item);
                tabControl1_SelectedIndexChanged(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWorkmanUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var item = lstWorkman.SelectedItem as Workman;
                if (item != null)
                {
                    item.Name = txtwname.Text;
                    item.DepartmentID = GetSelectedId(cbwDepartment);
                    item.HiredOn = dtHiredOn.Value;

                    db.Workmans.Update(item);
                    tabControl1_SelectedIndexChanged(this, null);
                }
                else
                    MessageBox.Show("Select some entity in list");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWorkmanRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var item = lstWorkman.SelectedItem as Workman;
                if (item != null)
                {
                    if (MessageBox.Show("Delete selected entity?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.Workmans.Remove(item.ID);
                        tabControl1_SelectedIndexChanged(this, null);
                    }
                }
                else
                    MessageBox.Show("Select some entity in list");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
