namespace VEHICLE_INFORMATION
{
    partial class mainForm
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
            this.vehicleButton = new System.Windows.Forms.Button();
            this.partButton = new System.Windows.Forms.Button();
            this.personalButton = new System.Windows.Forms.Button();
            this.vendorButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roadPermitButton = new System.Windows.Forms.Button();
            this.vehicleListView = new System.Windows.Forms.ListView();
            this.modelYear = new System.Windows.Forms.ColumnHeader();
            this.department = new System.Windows.Forms.ColumnHeader();
            this.vehicleNumber = new System.Windows.Forms.ColumnHeader();
            this.color = new System.Windows.Forms.ColumnHeader();
            this.enginNumber = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showListBoxButton = new System.Windows.Forms.Button();
            this.vehicleSarchButton = new System.Windows.Forms.Button();
            this.deletButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vehicleModelYearTextBox = new System.Windows.Forms.TextBox();
            this.vehicleModelNumberTextBox = new System.Windows.Forms.TextBox();
            this.vehicleNumberTextBox = new System.Windows.Forms.TextBox();
            this.vehicleVenNumTextBox = new System.Windows.Forms.TextBox();
            this.departmentCcomboBox = new System.Windows.Forms.ComboBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vehicleTrilSizeTextBox = new System.Windows.Forms.TextBox();
            this.vehicleTranansmistionTextBox = new System.Windows.Forms.TextBox();
            this.vehicleEnginNumberYextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.vehicleCompnyTextBox = new System.Windows.Forms.TextBox();
            this.vehicleAccountTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ff = new System.Windows.Forms.Label();
            this.vehicleSarchTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicleButton
            // 
            this.vehicleButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.vehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleButton.Location = new System.Drawing.Point(3, 0);
            this.vehicleButton.Name = "vehicleButton";
            this.vehicleButton.Size = new System.Drawing.Size(148, 40);
            this.vehicleButton.TabIndex = 0;
            this.vehicleButton.Text = "VEHICLE";
            this.vehicleButton.UseVisualStyleBackColor = false;
            this.vehicleButton.Click += new System.EventHandler(this.vehicleButton_Click);
            // 
            // partButton
            // 
            this.partButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.partButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partButton.Location = new System.Drawing.Point(157, 1);
            this.partButton.Name = "partButton";
            this.partButton.Size = new System.Drawing.Size(141, 41);
            this.partButton.TabIndex = 1;
            this.partButton.Text = "PART";
            this.partButton.UseVisualStyleBackColor = false;
            this.partButton.Click += new System.EventHandler(this.partButton_Click);
            // 
            // personalButton
            // 
            this.personalButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.personalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalButton.Location = new System.Drawing.Point(304, 0);
            this.personalButton.Name = "personalButton";
            this.personalButton.Size = new System.Drawing.Size(133, 41);
            this.personalButton.TabIndex = 2;
            this.personalButton.Text = "PERSONAL";
            this.personalButton.UseVisualStyleBackColor = false;
            this.personalButton.Click += new System.EventHandler(this.personalButton_Click);
            // 
            // vendorButton
            // 
            this.vendorButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.vendorButton.Location = new System.Drawing.Point(444, 3);
            this.vendorButton.Name = "vendorButton";
            this.vendorButton.Size = new System.Drawing.Size(150, 40);
            this.vendorButton.TabIndex = 3;
            this.vendorButton.Text = "VENDORS";
            this.vendorButton.UseVisualStyleBackColor = false;
            this.vendorButton.Click += new System.EventHandler(this.vendorButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.roadPermitButton);
            this.panel1.Controls.Add(this.vehicleButton);
            this.panel1.Controls.Add(this.vendorButton);
            this.panel1.Controls.Add(this.partButton);
            this.panel1.Controls.Add(this.personalButton);
            this.panel1.Location = new System.Drawing.Point(2, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 42);
            this.panel1.TabIndex = 4;
            // 
            // roadPermitButton
            // 
            this.roadPermitButton.Location = new System.Drawing.Point(613, 4);
            this.roadPermitButton.Name = "roadPermitButton";
            this.roadPermitButton.Size = new System.Drawing.Size(113, 35);
            this.roadPermitButton.TabIndex = 4;
            this.roadPermitButton.Text = "ROADpERMIT";
            this.roadPermitButton.UseVisualStyleBackColor = true;
            this.roadPermitButton.Click += new System.EventHandler(this.roadPermitButton_Click);
            // 
            // vehicleListView
            // 
            this.vehicleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.modelYear,
            this.department,
            this.vehicleNumber,
            this.color,
            this.enginNumber});
            this.vehicleListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleListView.GridLines = true;
            this.vehicleListView.Location = new System.Drawing.Point(-4, 184);
            this.vehicleListView.Name = "vehicleListView";
            this.vehicleListView.Size = new System.Drawing.Size(307, 331);
            this.vehicleListView.TabIndex = 5;
            this.vehicleListView.UseCompatibleStateImageBehavior = false;
            this.vehicleListView.View = System.Windows.Forms.View.Details;
            // 
            // modelYear
            // 
            this.modelYear.Text = "ModelYear";
            // 
            // department
            // 
            this.department.Text = "DepartMent";
            // 
            // vehicleNumber
            // 
            this.vehicleNumber.Text = "VehicleNumber";
            this.vehicleNumber.Width = 73;
            // 
            // color
            // 
            this.color.Text = "Color";
            // 
            // enginNumber
            // 
            this.enginNumber.Text = "enginNumber";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.showListBoxButton);
            this.panel2.Controls.Add(this.vehicleSarchButton);
            this.panel2.Controls.Add(this.deletButton);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.newButton);
            this.panel2.Location = new System.Drawing.Point(2, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 41);
            this.panel2.TabIndex = 6;
            // 
            // showListBoxButton
            // 
            this.showListBoxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showListBoxButton.Location = new System.Drawing.Point(476, 0);
            this.showListBoxButton.Name = "showListBoxButton";
            this.showListBoxButton.Size = new System.Drawing.Size(115, 38);
            this.showListBoxButton.TabIndex = 7;
            this.showListBoxButton.Text = "ShowListBox";
            this.showListBoxButton.UseVisualStyleBackColor = true;
            this.showListBoxButton.Click += new System.EventHandler(this.showListBoxButton_Click);
            // 
            // vehicleSarchButton
            // 
            this.vehicleSarchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleSarchButton.Location = new System.Drawing.Point(347, 4);
            this.vehicleSarchButton.Name = "vehicleSarchButton";
            this.vehicleSarchButton.Size = new System.Drawing.Size(108, 34);
            this.vehicleSarchButton.TabIndex = 6;
            this.vehicleSarchButton.Text = "sarch";
            this.vehicleSarchButton.UseVisualStyleBackColor = true;
            this.vehicleSarchButton.Click += new System.EventHandler(this.vehicleSarchButton_Click);
            // 
            // deletButton
            // 
            this.deletButton.BackColor = System.Drawing.Color.Red;
            this.deletButton.Location = new System.Drawing.Point(222, 3);
            this.deletButton.Name = "deletButton";
            this.deletButton.Size = new System.Drawing.Size(119, 35);
            this.deletButton.TabIndex = 5;
            this.deletButton.Text = "DELETE";
            this.deletButton.UseVisualStyleBackColor = false;
            this.deletButton.Click += new System.EventHandler(this.deletButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Lime;
            this.saveButton.Location = new System.Drawing.Point(120, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 34);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.Yellow;
            this.newButton.Location = new System.Drawing.Point(3, 4);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(111, 34);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "NEW";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.vehicleModelYearTextBox);
            this.groupBox1.Controls.Add(this.vehicleModelNumberTextBox);
            this.groupBox1.Controls.Add(this.vehicleNumberTextBox);
            this.groupBox1.Controls.Add(this.vehicleVenNumTextBox);
            this.groupBox1.Controls.Add(this.departmentCcomboBox);
            this.groupBox1.Controls.Add(this.colorComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(312, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 168);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VEHICLE INFORMATION";
            // 
            // vehicleModelYearTextBox
            // 
            this.vehicleModelYearTextBox.Location = new System.Drawing.Point(53, 32);
            this.vehicleModelYearTextBox.Name = "vehicleModelYearTextBox";
            this.vehicleModelYearTextBox.Size = new System.Drawing.Size(121, 20);
            this.vehicleModelYearTextBox.TabIndex = 11;
            // 
            // vehicleModelNumberTextBox
            // 
            this.vehicleModelNumberTextBox.Location = new System.Drawing.Point(329, 134);
            this.vehicleModelNumberTextBox.Name = "vehicleModelNumberTextBox";
            this.vehicleModelNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleModelNumberTextBox.TabIndex = 10;
            // 
            // vehicleNumberTextBox
            // 
            this.vehicleNumberTextBox.Location = new System.Drawing.Point(329, 84);
            this.vehicleNumberTextBox.Name = "vehicleNumberTextBox";
            this.vehicleNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleNumberTextBox.TabIndex = 9;
            // 
            // vehicleVenNumTextBox
            // 
            this.vehicleVenNumTextBox.Location = new System.Drawing.Point(329, 32);
            this.vehicleVenNumTextBox.Name = "vehicleVenNumTextBox";
            this.vehicleVenNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleVenNumTextBox.TabIndex = 8;
            // 
            // departmentCcomboBox
            // 
            this.departmentCcomboBox.FormattingEnabled = true;
            this.departmentCcomboBox.Items.AddRange(new object[] {
            "Administrator",
            "Manejer",
            "Engineer"});
            this.departmentCcomboBox.Location = new System.Drawing.Point(53, 84);
            this.departmentCcomboBox.Name = "departmentCcomboBox";
            this.departmentCcomboBox.Size = new System.Drawing.Size(121, 21);
            this.departmentCcomboBox.TabIndex = 7;
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Red",
            "Black",
            "White"});
            this.colorComboBox.Location = new System.Drawing.Point(53, 133);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 21);
            this.colorComboBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DEPARTMENT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "VEHICLE NUMBER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "VIN NUMBER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "COLOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MODEL NUMBER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODEL YEAR";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.vehicleTrilSizeTextBox);
            this.groupBox2.Controls.Add(this.vehicleTranansmistionTextBox);
            this.groupBox2.Controls.Add(this.vehicleEnginNumberYextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(309, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 157);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MACCINE INFORMATION";
            // 
            // vehicleTrilSizeTextBox
            // 
            this.vehicleTrilSizeTextBox.Location = new System.Drawing.Point(74, 132);
            this.vehicleTrilSizeTextBox.Name = "vehicleTrilSizeTextBox";
            this.vehicleTrilSizeTextBox.Size = new System.Drawing.Size(135, 20);
            this.vehicleTrilSizeTextBox.TabIndex = 5;
            // 
            // vehicleTranansmistionTextBox
            // 
            this.vehicleTranansmistionTextBox.Location = new System.Drawing.Point(74, 86);
            this.vehicleTranansmistionTextBox.Name = "vehicleTranansmistionTextBox";
            this.vehicleTranansmistionTextBox.Size = new System.Drawing.Size(135, 20);
            this.vehicleTranansmistionTextBox.TabIndex = 4;
            // 
            // vehicleEnginNumberYextBox
            // 
            this.vehicleEnginNumberYextBox.Location = new System.Drawing.Point(74, 40);
            this.vehicleEnginNumberYextBox.Name = "vehicleEnginNumberYextBox";
            this.vehicleEnginNumberYextBox.Size = new System.Drawing.Size(135, 20);
            this.vehicleEnginNumberYextBox.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "TRIL SIZE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "TRANSMISTION";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "ENGIN NUMBER";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.vehicleCompnyTextBox);
            this.groupBox3.Controls.Add(this.vehicleAccountTextBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(530, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 140);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "INSURANSE";
            // 
            // vehicleCompnyTextBox
            // 
            this.vehicleCompnyTextBox.Location = new System.Drawing.Point(96, 46);
            this.vehicleCompnyTextBox.Name = "vehicleCompnyTextBox";
            this.vehicleCompnyTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleCompnyTextBox.TabIndex = 5;
            // 
            // vehicleAccountTextBox
            // 
            this.vehicleAccountTextBox.Location = new System.Drawing.Point(107, 113);
            this.vehicleAccountTextBox.Name = "vehicleAccountTextBox";
            this.vehicleAccountTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleAccountTextBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "ACCOUNT NUMBER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "COMPANY";
            // 
            // ff
            // 
            this.ff.AutoSize = true;
            this.ff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ff.Location = new System.Drawing.Point(509, 161);
            this.ff.Name = "ff";
            this.ff.Size = new System.Drawing.Size(116, 16);
            this.ff.TabIndex = 10;
            this.ff.Text = "sachForVehicle";
            // 
            // vehicleSarchTextBox
            // 
            this.vehicleSarchTextBox.Location = new System.Drawing.Point(637, 160);
            this.vehicleSarchTextBox.Name = "vehicleSarchTextBox";
            this.vehicleSarchTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleSarchTextBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(149, -5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(439, 39);
            this.label9.TabIndex = 12;
            this.label9.Text = "VEHICLE MANAGEMENT";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::VEHICLE_INFORMATION.Properties.Resources._0__128_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(762, 520);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.vehicleSarchTextBox);
            this.Controls.Add(this.ff);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.vehicleListView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "mainForm";
            this.Text = "MAIN FORM";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vehicleButton;
        private System.Windows.Forms.Button partButton;
        private System.Windows.Forms.Button personalButton;
        private System.Windows.Forms.Button vendorButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView vehicleListView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vehicleModelNumberTextBox;
        private System.Windows.Forms.TextBox vehicleNumberTextBox;
        private System.Windows.Forms.TextBox vehicleVenNumTextBox;
        private System.Windows.Forms.ComboBox departmentCcomboBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox vehicleTrilSizeTextBox;
        private System.Windows.Forms.TextBox vehicleTranansmistionTextBox;
        private System.Windows.Forms.TextBox vehicleEnginNumberYextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox vehicleCompnyTextBox;
        private System.Windows.Forms.TextBox vehicleAccountTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox vehicleModelYearTextBox;
        private System.Windows.Forms.Button deletButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.ColumnHeader modelYear;
        private System.Windows.Forms.ColumnHeader department;
        private System.Windows.Forms.ColumnHeader vehicleNumber;
        private System.Windows.Forms.ColumnHeader color;
        private System.Windows.Forms.ColumnHeader enginNumber;
        private System.Windows.Forms.Label ff;
        private System.Windows.Forms.Button vehicleSarchButton;
        private System.Windows.Forms.TextBox vehicleSarchTextBox;
        private System.Windows.Forms.Button showListBoxButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button roadPermitButton;
    }
}

