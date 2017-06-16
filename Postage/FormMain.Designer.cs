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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Postage = new System.Windows.Forms.TabPage();
            this.Price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClientID = new System.Windows.Forms.ComboBox();
            this.cbPostageType = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstPostage = new System.Windows.Forms.ListBox();
            this.Client = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lstClient = new System.Windows.Forms.ListBox();
            this.Department = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.lstDepartment = new System.Windows.Forms.ListBox();
            this.PostageType = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.txtnote = new System.Windows.Forms.TextBox();
            this.lstPostageType = new System.Windows.Forms.ListBox();
            this.Workman = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.cbwDepartment = new System.Windows.Forms.ComboBox();
            this.lstWorkman = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbWorkman = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.txtcaddress = new System.Windows.Forms.TextBox();
            this.txtdepaddress = new System.Windows.Forms.TextBox();
            this.txtdepindex = new System.Windows.Forms.TextBox();
            this.txtptname = new System.Windows.Forms.TextBox();
            this.txtwname = new System.Windows.Forms.TextBox();
            this.dtDelieredOn = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.Postage.SuspendLayout();
            this.Client.SuspendLayout();
            this.Department.SuspendLayout();
            this.PostageType.SuspendLayout();
            this.Workman.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Postage);
            this.tabControl1.Controls.Add(this.Client);
            this.tabControl1.Controls.Add(this.Department);
            this.tabControl1.Controls.Add(this.PostageType);
            this.tabControl1.Controls.Add(this.Workman);
            this.tabControl1.Location = new System.Drawing.Point(12, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 429);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            this.Postage.Controls.Add(this.button3);
            this.Postage.Controls.Add(this.button2);
            this.Postage.Controls.Add(this.button1);
            this.Postage.Controls.Add(this.lstPostage);
            this.Postage.Location = new System.Drawing.Point(4, 22);
            this.Postage.Name = "Postage";
            this.Postage.Padding = new System.Windows.Forms.Padding(3);
            this.Postage.Size = new System.Drawing.Size(763, 403);
            this.Postage.TabIndex = 0;
            this.Postage.Text = "Postage";
            this.Postage.UseVisualStyleBackColor = true;
            this.Postage.Click += new System.EventHandler(this.Postage_Click);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(706, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 46);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(649, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 46);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 46);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstPostage
            // 
            this.lstPostage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstPostage.FormattingEnabled = true;
            this.lstPostage.Location = new System.Drawing.Point(3, 3);
            this.lstPostage.Name = "lstPostage";
            this.lstPostage.Size = new System.Drawing.Size(377, 394);
            this.lstPostage.TabIndex = 0;
            this.lstPostage.SelectedIndexChanged += new System.EventHandler(this.lstPostage_SelectedIndexChanged);
            // 
            // Client
            // 
            this.Client.Controls.Add(this.txtcaddress);
            this.Client.Controls.Add(this.txtcname);
            this.Client.Controls.Add(this.label5);
            this.Client.Controls.Add(this.label4);
            this.Client.Controls.Add(this.button6);
            this.Client.Controls.Add(this.button5);
            this.Client.Controls.Add(this.button4);
            this.Client.Controls.Add(this.lstClient);
            this.Client.Location = new System.Drawing.Point(4, 22);
            this.Client.Name = "Client";
            this.Client.Padding = new System.Windows.Forms.Padding(3);
            this.Client.Size = new System.Drawing.Size(763, 403);
            this.Client.TabIndex = 1;
            this.Client.Text = "Client";
            this.Client.UseVisualStyleBackColor = true;
            this.Client.Click += new System.EventHandler(this.Client_Click);
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
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(592, 351);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 46);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(649, 351);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 46);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(706, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 46);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lstClient
            // 
            this.lstClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstClient.FormattingEnabled = true;
            this.lstClient.Location = new System.Drawing.Point(3, 3);
            this.lstClient.Name = "lstClient";
            this.lstClient.Size = new System.Drawing.Size(377, 394);
            this.lstClient.TabIndex = 1;
            this.lstClient.SelectedIndexChanged += new System.EventHandler(this.lstClient_SelectedIndexChanged);
            // 
            // Department
            // 
            this.Department.Controls.Add(this.txtdepindex);
            this.Department.Controls.Add(this.txtdepaddress);
            this.Department.Controls.Add(this.label12);
            this.Department.Controls.Add(this.label11);
            this.Department.Controls.Add(this.button9);
            this.Department.Controls.Add(this.button8);
            this.Department.Controls.Add(this.button7);
            this.Department.Controls.Add(this.lstDepartment);
            this.Department.Location = new System.Drawing.Point(4, 22);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(763, 403);
            this.Department.TabIndex = 2;
            this.Department.Text = "Department";
            this.Department.UseVisualStyleBackColor = true;
            this.Department.Click += new System.EventHandler(this.Department_Click);
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
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(595, 354);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 46);
            this.button9.TabIndex = 4;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(652, 354);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 46);
            this.button8.TabIndex = 3;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(709, 354);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 46);
            this.button7.TabIndex = 2;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // lstDepartment
            // 
            this.lstDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstDepartment.FormattingEnabled = true;
            this.lstDepartment.Location = new System.Drawing.Point(3, 3);
            this.lstDepartment.Name = "lstDepartment";
            this.lstDepartment.Size = new System.Drawing.Size(377, 394);
            this.lstDepartment.TabIndex = 1;
            // 
            // PostageType
            // 
            this.PostageType.Controls.Add(this.txtptname);
            this.PostageType.Controls.Add(this.label7);
            this.PostageType.Controls.Add(this.label6);
            this.PostageType.Controls.Add(this.button12);
            this.PostageType.Controls.Add(this.button11);
            this.PostageType.Controls.Add(this.button10);
            this.PostageType.Controls.Add(this.txtnote);
            this.PostageType.Controls.Add(this.lstPostageType);
            this.PostageType.Location = new System.Drawing.Point(4, 22);
            this.PostageType.Name = "PostageType";
            this.PostageType.Size = new System.Drawing.Size(763, 403);
            this.PostageType.TabIndex = 3;
            this.PostageType.Text = "PostageType";
            this.PostageType.UseVisualStyleBackColor = true;
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
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(586, 351);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(51, 46);
            this.button12.TabIndex = 11;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(643, 351);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(51, 46);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(700, 351);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(51, 46);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = true;
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
            this.lstPostageType.Size = new System.Drawing.Size(377, 394);
            this.lstPostageType.TabIndex = 1;
            this.lstPostageType.SelectedIndexChanged += new System.EventHandler(this.lstPostageType_SelectedIndexChanged);
            // 
            // Workman
            // 
            this.Workman.Controls.Add(this.txtwname);
            this.Workman.Controls.Add(this.label10);
            this.Workman.Controls.Add(this.label9);
            this.Workman.Controls.Add(this.label8);
            this.Workman.Controls.Add(this.button15);
            this.Workman.Controls.Add(this.button14);
            this.Workman.Controls.Add(this.button13);
            this.Workman.Controls.Add(this.cbwDepartment);
            this.Workman.Controls.Add(this.lstWorkman);
            this.Workman.Location = new System.Drawing.Point(4, 22);
            this.Workman.Name = "Workman";
            this.Workman.Size = new System.Drawing.Size(763, 403);
            this.Workman.TabIndex = 4;
            this.Workman.Text = "Workman";
            this.Workman.UseVisualStyleBackColor = true;
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
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(586, 351);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(51, 46);
            this.button15.TabIndex = 12;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(643, 351);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(51, 46);
            this.button14.TabIndex = 13;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(700, 351);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(51, 46);
            this.button13.TabIndex = 12;
            this.button13.UseVisualStyleBackColor = true;
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
            this.lstWorkman.Size = new System.Drawing.Size(377, 394);
            this.lstWorkman.TabIndex = 1;
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
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(437, 219);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(285, 20);
            this.txtWeight.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(437, 266);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(285, 20);
            this.txtPrice.TabIndex = 12;
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(434, 299);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Delivered On";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Workman";
            // 
            // txtcname
            // 
            this.txtcname.Location = new System.Drawing.Point(445, 78);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(285, 20);
            this.txtcname.TabIndex = 12;
            // 
            // txtcaddress
            // 
            this.txtcaddress.Location = new System.Drawing.Point(445, 228);
            this.txtcaddress.Name = "txtcaddress";
            this.txtcaddress.Size = new System.Drawing.Size(285, 20);
            this.txtcaddress.TabIndex = 13;
            // 
            // txtdepaddress
            // 
            this.txtdepaddress.Location = new System.Drawing.Point(446, 99);
            this.txtdepaddress.Name = "txtdepaddress";
            this.txtdepaddress.Size = new System.Drawing.Size(285, 20);
            this.txtdepaddress.TabIndex = 15;
            // 
            // txtdepindex
            // 
            this.txtdepindex.Location = new System.Drawing.Point(446, 244);
            this.txtdepindex.Name = "txtdepindex";
            this.txtdepindex.Size = new System.Drawing.Size(285, 20);
            this.txtdepindex.TabIndex = 16;
            // 
            // txtptname
            // 
            this.txtptname.Location = new System.Drawing.Point(437, 94);
            this.txtptname.Name = "txtptname";
            this.txtptname.Size = new System.Drawing.Size(285, 20);
            this.txtptname.TabIndex = 14;
            // 
            // txtwname
            // 
            this.txtwname.Location = new System.Drawing.Point(431, 38);
            this.txtwname.Name = "txtwname";
            this.txtwname.Size = new System.Drawing.Size(285, 20);
            this.txtwname.TabIndex = 17;
            // 
            // dtDelieredOn
            // 
            this.dtDelieredOn.Location = new System.Drawing.Point(437, 315);
            this.dtDelieredOn.Name = "dtDelieredOn";
            this.dtDelieredOn.Size = new System.Drawing.Size(285, 20);
            this.dtDelieredOn.TabIndex = 19;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 492);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Postage";
            this.tabControl1.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Postage;
        private System.Windows.Forms.ComboBox cbClientID;
        private System.Windows.Forms.ComboBox cbPostageType;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox txtnote;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
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
    }
}

