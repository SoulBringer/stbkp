namespace PostageApp
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnWorkmanNew = new System.Windows.Forms.TabControl();
            this.Postage = new System.Windows.Forms.TabPage();
            this.dtDelieredOn = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbWorkman = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClientID = new System.Windows.Forms.ComboBox();
            this.cbPostageType = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.btnPostageRemove = new System.Windows.Forms.Button();
            this.btnPostageUpdate = new System.Windows.Forms.Button();
            this.btnPostageNew = new System.Windows.Forms.Button();
            this.lstPostage = new System.Windows.Forms.ListBox();
            this.Client = new System.Windows.Forms.TabPage();
            this.btnClientRemove = new System.Windows.Forms.Button();
            this.btnClientUpdate = new System.Windows.Forms.Button();
            this.btnClientNew = new System.Windows.Forms.Button();
            this.txtcaddress = new System.Windows.Forms.TextBox();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstClient = new System.Windows.Forms.ListBox();
            this.Department = new System.Windows.Forms.TabPage();
            this.btnDepartmentRemove = new System.Windows.Forms.Button();
            this.btnDepartmentUpdate = new System.Windows.Forms.Button();
            this.btnDepartmentNew = new System.Windows.Forms.Button();
            this.txtdepindex = new System.Windows.Forms.TextBox();
            this.txtdepaddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lstDepartment = new System.Windows.Forms.ListBox();
            this.PostageType = new System.Windows.Forms.TabPage();
            this.btnPostTypeRemove = new System.Windows.Forms.Button();
            this.btnPostTypeUpdate = new System.Windows.Forms.Button();
            this.btnPostTypeNew = new System.Windows.Forms.Button();
            this.txtptname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnote = new System.Windows.Forms.TextBox();
            this.lstPostageType = new System.Windows.Forms.ListBox();
            this.Workman = new System.Windows.Forms.TabPage();
            this.btnWorkmanRemove = new System.Windows.Forms.Button();
            this.btnWorkmanUpdate = new System.Windows.Forms.Button();
            this.btnWorkman_New = new System.Windows.Forms.Button();
            this.txtwname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbwDepartment = new System.Windows.Forms.ComboBox();
            this.lstWorkman = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDBLoad = new System.Windows.Forms.ToolStripButton();
            this.btnDBSave = new System.Windows.Forms.ToolStripButton();
            this.dtHiredOn = new System.Windows.Forms.DateTimePicker();
            this.btnWorkmanNew.SuspendLayout();
            this.Postage.SuspendLayout();
            this.Client.SuspendLayout();
            this.Department.SuspendLayout();
            this.PostageType.SuspendLayout();
            this.Workman.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWorkmanNew
            // 
            this.btnWorkmanNew.Controls.Add(this.Postage);
            this.btnWorkmanNew.Controls.Add(this.Client);
            this.btnWorkmanNew.Controls.Add(this.Department);
            this.btnWorkmanNew.Controls.Add(this.PostageType);
            this.btnWorkmanNew.Controls.Add(this.Workman);
            this.btnWorkmanNew.Location = new System.Drawing.Point(12, 76);
            this.btnWorkmanNew.Name = "btnWorkmanNew";
            this.btnWorkmanNew.SelectedIndex = 0;
            this.btnWorkmanNew.Size = new System.Drawing.Size(771, 458);
            this.btnWorkmanNew.TabIndex = 0;
            this.btnWorkmanNew.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Postage
            // 
            this.Postage.Controls.Add(this.dtDelieredOn);
            this.Postage.Controls.Add(this.label3);
            this.Postage.Controls.Add(this.cbWorkman);
            this.Postage.Controls.Add(this.label15);
            this.Postage.Controls.Add(this.label14);
            this.Postage.Controls.Add(this.txtPrice);
            this.Postage.Controls.Add(this.txtWeight);
            this.Postage.Controls.Add(this.label13);
            this.Postage.Controls.Add(this.Price);
            this.Postage.Controls.Add(this.label2);
            this.Postage.Controls.Add(this.label1);
            this.Postage.Controls.Add(this.cbClientID);
            this.Postage.Controls.Add(this.cbPostageType);
            this.Postage.Controls.Add(this.cbDepartment);
            this.Postage.Controls.Add(this.btnPostageRemove);
            this.Postage.Controls.Add(this.btnPostageUpdate);
            this.Postage.Controls.Add(this.btnPostageNew);
            this.Postage.Controls.Add(this.lstPostage);
            this.Postage.Location = new System.Drawing.Point(4, 22);
            this.Postage.Name = "Postage";
            this.Postage.Padding = new System.Windows.Forms.Padding(3);
            this.Postage.Size = new System.Drawing.Size(763, 432);
            this.Postage.TabIndex = 0;
            this.Postage.Text = "Postage";
            this.Postage.UseVisualStyleBackColor = true;
            // 
            // dtDelieredOn
            // 
            this.dtDelieredOn.Location = new System.Drawing.Point(437, 315);
            this.dtDelieredOn.Name = "dtDelieredOn";
            this.dtDelieredOn.Size = new System.Drawing.Size(285, 20);
            this.dtDelieredOn.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Workman";
            // 
            // cbWorkman
            // 
            this.cbWorkman.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWorkman.FormattingEnabled = true;
            this.cbWorkman.Location = new System.Drawing.Point(437, 168);
            this.cbWorkman.Name = "cbWorkman";
            this.cbWorkman.Size = new System.Drawing.Size(285, 21);
            this.cbWorkman.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(434, 299);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Delivered On";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(437, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Client";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(437, 266);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(285, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(437, 219);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(285, 20);
            this.txtWeight.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(434, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Weight";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(434, 250);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 9;
            this.Price.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Postage Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Department";
            // 
            // cbClientID
            // 
            this.cbClientID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClientID.FormattingEnabled = true;
            this.cbClientID.Location = new System.Drawing.Point(437, 120);
            this.cbClientID.Name = "cbClientID";
            this.cbClientID.Size = new System.Drawing.Size(285, 21);
            this.cbClientID.TabIndex = 6;
            // 
            // cbPostageType
            // 
            this.cbPostageType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPostageType.FormattingEnabled = true;
            this.cbPostageType.Location = new System.Drawing.Point(437, 69);
            this.cbPostageType.Name = "cbPostageType";
            this.cbPostageType.Size = new System.Drawing.Size(285, 21);
            this.cbPostageType.TabIndex = 5;
            // 
            // cbDepartment
            // 
            this.cbDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(437, 20);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(285, 21);
            this.cbDepartment.TabIndex = 4;
            // 
            // btnPostageRemove
            // 
            this.btnPostageRemove.Image = global::PostageApp.Properties.Resources.Delete;
            this.btnPostageRemove.Location = new System.Drawing.Point(668, 369);
            this.btnPostageRemove.Name = "btnPostageRemove";
            this.btnPostageRemove.Size = new System.Drawing.Size(54, 54);
            this.btnPostageRemove.TabIndex = 3;
            this.btnPostageRemove.UseVisualStyleBackColor = true;
            this.btnPostageRemove.Click += new System.EventHandler(this.btnPostageRemove_Click);
            // 
            // btnPostageUpdate
            // 
            this.btnPostageUpdate.Image = global::PostageApp.Properties.Resources.Save;
            this.btnPostageUpdate.Location = new System.Drawing.Point(608, 369);
            this.btnPostageUpdate.Name = "btnPostageUpdate";
            this.btnPostageUpdate.Size = new System.Drawing.Size(54, 54);
            this.btnPostageUpdate.TabIndex = 2;
            this.btnPostageUpdate.UseVisualStyleBackColor = true;
            this.btnPostageUpdate.Click += new System.EventHandler(this.btnPostageUpdate_Click);
            // 
            // btnPostageNew
            // 
            this.btnPostageNew.Image = global::PostageApp.Properties.Resources.New;
            this.btnPostageNew.Location = new System.Drawing.Point(548, 369);
            this.btnPostageNew.Name = "btnPostageNew";
            this.btnPostageNew.Size = new System.Drawing.Size(54, 54);
            this.btnPostageNew.TabIndex = 1;
            this.btnPostageNew.UseVisualStyleBackColor = true;
            this.btnPostageNew.Click += new System.EventHandler(this.btnPostageNew_Click);
            // 
            // lstPostage
            // 
            this.lstPostage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstPostage.FormattingEnabled = true;
            this.lstPostage.Location = new System.Drawing.Point(3, 3);
            this.lstPostage.Name = "lstPostage";
            this.lstPostage.Size = new System.Drawing.Size(377, 420);
            this.lstPostage.TabIndex = 0;
            this.lstPostage.SelectedIndexChanged += new System.EventHandler(this.lstPostage_SelectedIndexChanged);
            // 
            // Client
            // 
            this.Client.Controls.Add(this.btnClientRemove);
            this.Client.Controls.Add(this.btnClientUpdate);
            this.Client.Controls.Add(this.btnClientNew);
            this.Client.Controls.Add(this.txtcaddress);
            this.Client.Controls.Add(this.txtcname);
            this.Client.Controls.Add(this.label5);
            this.Client.Controls.Add(this.label4);
            this.Client.Controls.Add(this.lstClient);
            this.Client.Location = new System.Drawing.Point(4, 22);
            this.Client.Name = "Client";
            this.Client.Padding = new System.Windows.Forms.Padding(3);
            this.Client.Size = new System.Drawing.Size(763, 432);
            this.Client.TabIndex = 1;
            this.Client.Text = "Client";
            this.Client.UseVisualStyleBackColor = true;
            // 
            // btnClientRemove
            // 
            this.btnClientRemove.Image = global::PostageApp.Properties.Resources.Delete;
            this.btnClientRemove.Location = new System.Drawing.Point(676, 369);
            this.btnClientRemove.Name = "btnClientRemove";
            this.btnClientRemove.Size = new System.Drawing.Size(54, 54);
            this.btnClientRemove.TabIndex = 16;
            this.btnClientRemove.UseVisualStyleBackColor = true;
            this.btnClientRemove.Click += new System.EventHandler(this.btnClientRemove_Click);
            // 
            // btnClientUpdate
            // 
            this.btnClientUpdate.Image = global::PostageApp.Properties.Resources.Save;
            this.btnClientUpdate.Location = new System.Drawing.Point(616, 369);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(54, 54);
            this.btnClientUpdate.TabIndex = 15;
            this.btnClientUpdate.UseVisualStyleBackColor = true;
            this.btnClientUpdate.Click += new System.EventHandler(this.btnClientUpdate_Click);
            // 
            // btnClientNew
            // 
            this.btnClientNew.Image = global::PostageApp.Properties.Resources.New;
            this.btnClientNew.Location = new System.Drawing.Point(556, 369);
            this.btnClientNew.Name = "btnClientNew";
            this.btnClientNew.Size = new System.Drawing.Size(54, 54);
            this.btnClientNew.TabIndex = 14;
            this.btnClientNew.UseVisualStyleBackColor = true;
            this.btnClientNew.Click += new System.EventHandler(this.btnClientNew_Click);
            // 
            // txtcaddress
            // 
            this.txtcaddress.Location = new System.Drawing.Point(445, 228);
            this.txtcaddress.Name = "txtcaddress";
            this.txtcaddress.Size = new System.Drawing.Size(285, 20);
            this.txtcaddress.TabIndex = 13;
            // 
            // txtcname
            // 
            this.txtcname.Location = new System.Drawing.Point(445, 78);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(285, 20);
            this.txtcname.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // lstClient
            // 
            this.lstClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstClient.FormattingEnabled = true;
            this.lstClient.Location = new System.Drawing.Point(3, 3);
            this.lstClient.Name = "lstClient";
            this.lstClient.Size = new System.Drawing.Size(377, 420);
            this.lstClient.TabIndex = 1;
            this.lstClient.SelectedIndexChanged += new System.EventHandler(this.lstClient_SelectedIndexChanged);
            // 
            // Department
            // 
            this.Department.Controls.Add(this.btnDepartmentRemove);
            this.Department.Controls.Add(this.btnDepartmentUpdate);
            this.Department.Controls.Add(this.btnDepartmentNew);
            this.Department.Controls.Add(this.txtdepindex);
            this.Department.Controls.Add(this.txtdepaddress);
            this.Department.Controls.Add(this.label12);
            this.Department.Controls.Add(this.label11);
            this.Department.Controls.Add(this.lstDepartment);
            this.Department.Location = new System.Drawing.Point(4, 22);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(763, 432);
            this.Department.TabIndex = 2;
            this.Department.Text = "Department";
            this.Department.UseVisualStyleBackColor = true;
            // 
            // btnDepartmentRemove
            // 
            this.btnDepartmentRemove.Image = global::PostageApp.Properties.Resources.Delete;
            this.btnDepartmentRemove.Location = new System.Drawing.Point(677, 369);
            this.btnDepartmentRemove.Name = "btnDepartmentRemove";
            this.btnDepartmentRemove.Size = new System.Drawing.Size(54, 54);
            this.btnDepartmentRemove.TabIndex = 19;
            this.btnDepartmentRemove.UseVisualStyleBackColor = true;
            this.btnDepartmentRemove.Click += new System.EventHandler(this.btnDepartmentRemove_Click);
            // 
            // btnDepartmentUpdate
            // 
            this.btnDepartmentUpdate.Image = global::PostageApp.Properties.Resources.Save;
            this.btnDepartmentUpdate.Location = new System.Drawing.Point(617, 369);
            this.btnDepartmentUpdate.Name = "btnDepartmentUpdate";
            this.btnDepartmentUpdate.Size = new System.Drawing.Size(54, 54);
            this.btnDepartmentUpdate.TabIndex = 18;
            this.btnDepartmentUpdate.UseVisualStyleBackColor = true;
            this.btnDepartmentUpdate.Click += new System.EventHandler(this.btnDepartmentUpdate_Click);
            // 
            // btnDepartmentNew
            // 
            this.btnDepartmentNew.Image = global::PostageApp.Properties.Resources.New;
            this.btnDepartmentNew.Location = new System.Drawing.Point(557, 369);
            this.btnDepartmentNew.Name = "btnDepartmentNew";
            this.btnDepartmentNew.Size = new System.Drawing.Size(54, 54);
            this.btnDepartmentNew.TabIndex = 17;
            this.btnDepartmentNew.UseVisualStyleBackColor = true;
            this.btnDepartmentNew.Click += new System.EventHandler(this.btnDepartmentNew_Click);
            // 
            // txtdepindex
            // 
            this.txtdepindex.Location = new System.Drawing.Point(446, 244);
            this.txtdepindex.Name = "txtdepindex";
            this.txtdepindex.Size = new System.Drawing.Size(285, 20);
            this.txtdepindex.TabIndex = 16;
            // 
            // txtdepaddress
            // 
            this.txtdepaddress.Location = new System.Drawing.Point(446, 99);
            this.txtdepaddress.Name = "txtdepaddress";
            this.txtdepaddress.Size = new System.Drawing.Size(285, 20);
            this.txtdepaddress.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(443, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Index";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Address";
            // 
            // lstDepartment
            // 
            this.lstDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstDepartment.FormattingEnabled = true;
            this.lstDepartment.Location = new System.Drawing.Point(3, 3);
            this.lstDepartment.Name = "lstDepartment";
            this.lstDepartment.Size = new System.Drawing.Size(377, 420);
            this.lstDepartment.TabIndex = 1;
            this.lstDepartment.SelectedIndexChanged += new System.EventHandler(this.lstDepartment_SelectedIndexChanged);
            // 
            // PostageType
            // 
            this.PostageType.Controls.Add(this.btnPostTypeRemove);
            this.PostageType.Controls.Add(this.btnPostTypeUpdate);
            this.PostageType.Controls.Add(this.btnPostTypeNew);
            this.PostageType.Controls.Add(this.txtptname);
            this.PostageType.Controls.Add(this.label7);
            this.PostageType.Controls.Add(this.label6);
            this.PostageType.Controls.Add(this.txtnote);
            this.PostageType.Controls.Add(this.lstPostageType);
            this.PostageType.Location = new System.Drawing.Point(4, 22);
            this.PostageType.Name = "PostageType";
            this.PostageType.Size = new System.Drawing.Size(763, 432);
            this.PostageType.TabIndex = 3;
            this.PostageType.Text = "PostageType";
            this.PostageType.UseVisualStyleBackColor = true;
            // 
            // btnPostTypeRemove
            // 
            this.btnPostTypeRemove.Image = global::PostageApp.Properties.Resources.Delete;
            this.btnPostTypeRemove.Location = new System.Drawing.Point(668, 369);
            this.btnPostTypeRemove.Name = "btnPostTypeRemove";
            this.btnPostTypeRemove.Size = new System.Drawing.Size(54, 54);
            this.btnPostTypeRemove.TabIndex = 17;
            this.btnPostTypeRemove.UseVisualStyleBackColor = true;
            this.btnPostTypeRemove.Click += new System.EventHandler(this.btnPostTypeRemove_Click);
            // 
            // btnPostTypeUpdate
            // 
            this.btnPostTypeUpdate.Image = global::PostageApp.Properties.Resources.Save;
            this.btnPostTypeUpdate.Location = new System.Drawing.Point(608, 369);
            this.btnPostTypeUpdate.Name = "btnPostTypeUpdate";
            this.btnPostTypeUpdate.Size = new System.Drawing.Size(54, 54);
            this.btnPostTypeUpdate.TabIndex = 16;
            this.btnPostTypeUpdate.UseVisualStyleBackColor = true;
            this.btnPostTypeUpdate.Click += new System.EventHandler(this.btnPostTypeUpdate_Click);
            // 
            // btnPostTypeNew
            // 
            this.btnPostTypeNew.Image = global::PostageApp.Properties.Resources.New;
            this.btnPostTypeNew.Location = new System.Drawing.Point(548, 369);
            this.btnPostTypeNew.Name = "btnPostTypeNew";
            this.btnPostTypeNew.Size = new System.Drawing.Size(54, 54);
            this.btnPostTypeNew.TabIndex = 15;
            this.btnPostTypeNew.UseVisualStyleBackColor = true;
            this.btnPostTypeNew.Click += new System.EventHandler(this.btnPostTypeNew_Click);
            // 
            // txtptname
            // 
            this.txtptname.Location = new System.Drawing.Point(437, 94);
            this.txtptname.Name = "txtptname";
            this.txtptname.Size = new System.Drawing.Size(285, 20);
            this.txtptname.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Note";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Name";
            // 
            // txtnote
            // 
            this.txtnote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnote.Location = new System.Drawing.Point(437, 247);
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(285, 20);
            this.txtnote.TabIndex = 8;
            // 
            // lstPostageType
            // 
            this.lstPostageType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstPostageType.FormattingEnabled = true;
            this.lstPostageType.Location = new System.Drawing.Point(0, 3);
            this.lstPostageType.Name = "lstPostageType";
            this.lstPostageType.Size = new System.Drawing.Size(377, 420);
            this.lstPostageType.TabIndex = 1;
            this.lstPostageType.SelectedIndexChanged += new System.EventHandler(this.lstPostageType_SelectedIndexChanged);
            // 
            // Workman
            // 
            this.Workman.Controls.Add(this.dtHiredOn);
            this.Workman.Controls.Add(this.btnWorkmanRemove);
            this.Workman.Controls.Add(this.btnWorkmanUpdate);
            this.Workman.Controls.Add(this.btnWorkman_New);
            this.Workman.Controls.Add(this.txtwname);
            this.Workman.Controls.Add(this.label10);
            this.Workman.Controls.Add(this.label9);
            this.Workman.Controls.Add(this.label8);
            this.Workman.Controls.Add(this.cbwDepartment);
            this.Workman.Controls.Add(this.lstWorkman);
            this.Workman.Location = new System.Drawing.Point(4, 22);
            this.Workman.Name = "Workman";
            this.Workman.Size = new System.Drawing.Size(763, 432);
            this.Workman.TabIndex = 4;
            this.Workman.Text = "Workman";
            this.Workman.UseVisualStyleBackColor = true;
            // 
            // btnWorkmanRemove
            // 
            this.btnWorkmanRemove.Image = global::PostageApp.Properties.Resources.Delete;
            this.btnWorkmanRemove.Location = new System.Drawing.Point(662, 369);
            this.btnWorkmanRemove.Name = "btnWorkmanRemove";
            this.btnWorkmanRemove.Size = new System.Drawing.Size(54, 54);
            this.btnWorkmanRemove.TabIndex = 20;
            this.btnWorkmanRemove.UseVisualStyleBackColor = true;
            this.btnWorkmanRemove.Click += new System.EventHandler(this.btnWorkmanRemove_Click);
            // 
            // btnWorkmanUpdate
            // 
            this.btnWorkmanUpdate.Image = global::PostageApp.Properties.Resources.Save;
            this.btnWorkmanUpdate.Location = new System.Drawing.Point(602, 369);
            this.btnWorkmanUpdate.Name = "btnWorkmanUpdate";
            this.btnWorkmanUpdate.Size = new System.Drawing.Size(54, 54);
            this.btnWorkmanUpdate.TabIndex = 19;
            this.btnWorkmanUpdate.UseVisualStyleBackColor = true;
            this.btnWorkmanUpdate.Click += new System.EventHandler(this.btnWorkmanUpdate_Click);
            // 
            // btnWorkman_New
            // 
            this.btnWorkman_New.Image = global::PostageApp.Properties.Resources.New;
            this.btnWorkman_New.Location = new System.Drawing.Point(542, 369);
            this.btnWorkman_New.Name = "btnWorkman_New";
            this.btnWorkman_New.Size = new System.Drawing.Size(54, 54);
            this.btnWorkman_New.TabIndex = 18;
            this.btnWorkman_New.UseVisualStyleBackColor = true;
            this.btnWorkman_New.Click += new System.EventHandler(this.btnWorkman_New_Click);
            // 
            // txtwname
            // 
            this.txtwname.Location = new System.Drawing.Point(431, 38);
            this.txtwname.Name = "txtwname";
            this.txtwname.Size = new System.Drawing.Size(285, 20);
            this.txtwname.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(428, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hired On";
            // 
            // cbwDepartment
            // 
            this.cbwDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbwDepartment.FormattingEnabled = true;
            this.cbwDepartment.Location = new System.Drawing.Point(431, 140);
            this.cbwDepartment.Name = "cbwDepartment";
            this.cbwDepartment.Size = new System.Drawing.Size(285, 21);
            this.cbwDepartment.TabIndex = 9;
            // 
            // lstWorkman
            // 
            this.lstWorkman.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstWorkman.FormattingEnabled = true;
            this.lstWorkman.Location = new System.Drawing.Point(0, 3);
            this.lstWorkman.Name = "lstWorkman";
            this.lstWorkman.Size = new System.Drawing.Size(377, 420);
            this.lstWorkman.TabIndex = 1;
            this.lstWorkman.SelectedIndexChanged += new System.EventHandler(this.lstWorkman_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDBLoad,
            this.btnDBSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(795, 55);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDBLoad
            // 
            this.btnDBLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDBLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnDBLoad.Image")));
            this.btnDBLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDBLoad.Name = "btnDBLoad";
            this.btnDBLoad.Size = new System.Drawing.Size(52, 52);
            this.btnDBLoad.Text = "toolStripButton1";
            this.btnDBLoad.ToolTipText = "Load database";
            this.btnDBLoad.Click += new System.EventHandler(this.btnDBLoad_Click);
            // 
            // btnDBSave
            // 
            this.btnDBSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDBSave.Image = ((System.Drawing.Image)(resources.GetObject("btnDBSave.Image")));
            this.btnDBSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDBSave.Name = "btnDBSave";
            this.btnDBSave.Size = new System.Drawing.Size(52, 52);
            this.btnDBSave.Text = "toolStripButton2";
            this.btnDBSave.ToolTipText = "Save database";
            this.btnDBSave.Click += new System.EventHandler(this.btnDBSave_Click);
            // 
            // dtHiredOn
            // 
            this.dtHiredOn.Location = new System.Drawing.Point(431, 250);
            this.dtHiredOn.Name = "dtHiredOn";
            this.dtHiredOn.Size = new System.Drawing.Size(285, 20);
            this.dtHiredOn.TabIndex = 21;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 546);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnWorkmanNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Postage";
            this.btnWorkmanNew.ResumeLayout(false);
            this.Postage.ResumeLayout(false);
            this.Postage.PerformLayout();
            this.Client.ResumeLayout(false);
            this.Client.PerformLayout();
            this.Department.ResumeLayout(false);
            this.Department.PerformLayout();
            this.PostageType.ResumeLayout(false);
            this.PostageType.PerformLayout();
            this.Workman.ResumeLayout(false);
            this.Workman.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl btnWorkmanNew;
        private System.Windows.Forms.TabPage Postage;
        private System.Windows.Forms.ComboBox cbClientID;
        private System.Windows.Forms.ComboBox cbPostageType;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Button btnPostageRemove;
        private System.Windows.Forms.Button btnPostageUpdate;
        private System.Windows.Forms.Button btnPostageNew;
        private System.Windows.Forms.ListBox lstPostage;
        private System.Windows.Forms.TabPage Client;
        private System.Windows.Forms.ListBox lstClient;
        private System.Windows.Forms.TabPage Department;
        private System.Windows.Forms.ListBox lstDepartment;
        private System.Windows.Forms.TabPage PostageType;
        private System.Windows.Forms.ListBox lstPostageType;
        private System.Windows.Forms.TabPage Workman;
        private System.Windows.Forms.ListBox lstWorkman;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnote;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbwDepartment;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbWorkman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcaddress;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.TextBox txtdepindex;
        private System.Windows.Forms.TextBox txtdepaddress;
        private System.Windows.Forms.TextBox txtptname;
        private System.Windows.Forms.TextBox txtwname;
        private System.Windows.Forms.DateTimePicker dtDelieredOn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDBLoad;
        private System.Windows.Forms.ToolStripButton btnDBSave;
        private System.Windows.Forms.Button btnClientRemove;
        private System.Windows.Forms.Button btnClientUpdate;
        private System.Windows.Forms.Button btnClientNew;
        private System.Windows.Forms.Button btnDepartmentRemove;
        private System.Windows.Forms.Button btnDepartmentUpdate;
        private System.Windows.Forms.Button btnDepartmentNew;
        private System.Windows.Forms.Button btnPostTypeRemove;
        private System.Windows.Forms.Button btnPostTypeUpdate;
        private System.Windows.Forms.Button btnPostTypeNew;
        private System.Windows.Forms.Button btnWorkmanRemove;
        private System.Windows.Forms.Button btnWorkmanUpdate;
        private System.Windows.Forms.Button btnWorkman_New;
        private System.Windows.Forms.DateTimePicker dtHiredOn;
    }
}

