namespace VEHICLE_INFORMATION
{
    partial class PERSON
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.roadPermitButton = new System.Windows.Forms.Button();
            this.vendorsButton = new System.Windows.Forms.Button();
            this.personButton = new System.Windows.Forms.Button();
            this.partsButton = new System.Windows.Forms.Button();
            this.vehicleButton = new System.Windows.Forms.Button();
            this.personListView = new System.Windows.Forms.ListView();
            this.personNumber = new System.Windows.Forms.ColumnHeader();
            this.personLastName = new System.Windows.Forms.ColumnHeader();
            this.personFirstName = new System.Windows.Forms.ColumnHeader();
            this.personAddress = new System.Windows.Forms.ColumnHeader();
            this.personMobailNumber = new System.Windows.Forms.ColumnHeader();
            this.personPostalCode = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.personDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.personFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.PersonPostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.personAddressTextBox = new System.Windows.Forms.TextBox();
            this.personMobailNumberTextBox = new System.Windows.Forms.TextBox();
            this.personLastNameTextBox = new System.Windows.Forms.TextBox();
            this.personNumberTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showListButton = new System.Windows.Forms.Button();
            this.personSarchButton = new System.Windows.Forms.Button();
            this.deletButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.sarchPersonTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.roadPermitButton);
            this.panel1.Controls.Add(this.vendorsButton);
            this.panel1.Controls.Add(this.personButton);
            this.panel1.Controls.Add(this.partsButton);
            this.panel1.Controls.Add(this.vehicleButton);
            this.panel1.Location = new System.Drawing.Point(2, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 55);
            this.panel1.TabIndex = 0;
            // 
            // roadPermitButton
            // 
            this.roadPermitButton.Location = new System.Drawing.Point(567, 10);
            this.roadPermitButton.Name = "roadPermitButton";
            this.roadPermitButton.Size = new System.Drawing.Size(99, 42);
            this.roadPermitButton.TabIndex = 4;
            this.roadPermitButton.Text = "ROAD PERMIT";
            this.roadPermitButton.UseVisualStyleBackColor = true;
            this.roadPermitButton.Click += new System.EventHandler(this.roadPermitButton_Click);
            // 
            // vendorsButton
            // 
            this.vendorsButton.BackColor = System.Drawing.Color.Cyan;
            this.vendorsButton.Location = new System.Drawing.Point(456, 10);
            this.vendorsButton.Name = "vendorsButton";
            this.vendorsButton.Size = new System.Drawing.Size(75, 42);
            this.vendorsButton.TabIndex = 3;
            this.vendorsButton.Text = "VENDORS";
            this.vendorsButton.UseVisualStyleBackColor = false;
            this.vendorsButton.Click += new System.EventHandler(this.vendorsButton_Click);
            // 
            // personButton
            // 
            this.personButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.personButton.Location = new System.Drawing.Point(304, 10);
            this.personButton.Name = "personButton";
            this.personButton.Size = new System.Drawing.Size(75, 42);
            this.personButton.TabIndex = 2;
            this.personButton.Text = "PERSON";
            this.personButton.UseVisualStyleBackColor = false;
            this.personButton.Click += new System.EventHandler(this.personButton_Click);
            // 
            // partsButton
            // 
            this.partsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.partsButton.Location = new System.Drawing.Point(163, 10);
            this.partsButton.Name = "partsButton";
            this.partsButton.Size = new System.Drawing.Size(75, 42);
            this.partsButton.TabIndex = 1;
            this.partsButton.Text = "PARTS";
            this.partsButton.UseVisualStyleBackColor = false;
            this.partsButton.Click += new System.EventHandler(this.partsButton_Click);
            // 
            // vehicleButton
            // 
            this.vehicleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.vehicleButton.Location = new System.Drawing.Point(22, 10);
            this.vehicleButton.Name = "vehicleButton";
            this.vehicleButton.Size = new System.Drawing.Size(75, 42);
            this.vehicleButton.TabIndex = 0;
            this.vehicleButton.Text = "VEHICLE";
            this.vehicleButton.UseVisualStyleBackColor = false;
            this.vehicleButton.Click += new System.EventHandler(this.vehicleButton_Click);
            // 
            // personListView
            // 
            this.personListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.personNumber,
            this.personLastName,
            this.personFirstName,
            this.personAddress,
            this.personMobailNumber,
            this.personPostalCode,
            this.date});
            this.personListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personListView.GridLines = true;
            this.personListView.Location = new System.Drawing.Point(2, 114);
            this.personListView.Name = "personListView";
            this.personListView.Size = new System.Drawing.Size(760, 181);
            this.personListView.TabIndex = 1;
            this.personListView.UseCompatibleStateImageBehavior = false;
            this.personListView.View = System.Windows.Forms.View.Details;
            // 
            // personNumber
            // 
            this.personNumber.Text = "PersonNumber";
            this.personNumber.Width = 109;
            // 
            // personLastName
            // 
            this.personLastName.Text = "personLastName";
            this.personLastName.Width = 119;
            // 
            // personFirstName
            // 
            this.personFirstName.Text = "personFirstName";
            this.personFirstName.Width = 117;
            // 
            // personAddress
            // 
            this.personAddress.Text = "personAddress";
            this.personAddress.Width = 98;
            // 
            // personMobailNumber
            // 
            this.personMobailNumber.Text = "personMobailNumber";
            this.personMobailNumber.Width = 137;
            // 
            // personPostalCode
            // 
            this.personPostalCode.Text = "personPostalCode";
            this.personPostalCode.Width = 122;
            // 
            // date
            // 
            this.date.Text = "date";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.personDateTimePicker1);
            this.groupBox1.Controls.Add(this.personFirstNameTextBox);
            this.groupBox1.Controls.Add(this.PersonPostalCodeTextBox);
            this.groupBox1.Controls.Add(this.personAddressTextBox);
            this.groupBox1.Controls.Add(this.personMobailNumberTextBox);
            this.groupBox1.Controls.Add(this.personLastNameTextBox);
            this.groupBox1.Controls.Add(this.personNumberTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person information";
            // 
            // personDateTimePicker1
            // 
            this.personDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.personDateTimePicker1.Location = new System.Drawing.Point(404, 50);
            this.personDateTimePicker1.Name = "personDateTimePicker1";
            this.personDateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.personDateTimePicker1.TabIndex = 13;
            // 
            // personFirstNameTextBox
            // 
            this.personFirstNameTextBox.Location = new System.Drawing.Point(248, 98);
            this.personFirstNameTextBox.Name = "personFirstNameTextBox";
            this.personFirstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.personFirstNameTextBox.TabIndex = 12;
            // 
            // PersonPostalCodeTextBox
            // 
            this.PersonPostalCodeTextBox.Location = new System.Drawing.Point(248, 152);
            this.PersonPostalCodeTextBox.Name = "PersonPostalCodeTextBox";
            this.PersonPostalCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.PersonPostalCodeTextBox.TabIndex = 11;
            // 
            // personAddressTextBox
            // 
            this.personAddressTextBox.Location = new System.Drawing.Point(248, 41);
            this.personAddressTextBox.Name = "personAddressTextBox";
            this.personAddressTextBox.Size = new System.Drawing.Size(100, 22);
            this.personAddressTextBox.TabIndex = 10;
            // 
            // personMobailNumberTextBox
            // 
            this.personMobailNumberTextBox.Location = new System.Drawing.Point(61, 152);
            this.personMobailNumberTextBox.Name = "personMobailNumberTextBox";
            this.personMobailNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.personMobailNumberTextBox.TabIndex = 9;
            // 
            // personLastNameTextBox
            // 
            this.personLastNameTextBox.Location = new System.Drawing.Point(61, 98);
            this.personLastNameTextBox.Name = "personLastNameTextBox";
            this.personLastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.personLastNameTextBox.TabIndex = 8;
            // 
            // personNumberTextBox
            // 
            this.personNumberTextBox.Location = new System.Drawing.Point(61, 41);
            this.personNumberTextBox.Name = "personNumberTextBox";
            this.personNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.personNumberTextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "PostalCode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "MobailNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person Number";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.showListButton);
            this.panel2.Controls.Add(this.personSarchButton);
            this.panel2.Controls.Add(this.deletButton);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.newButton);
            this.panel2.Location = new System.Drawing.Point(2, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 40);
            this.panel2.TabIndex = 3;
            // 
            // showListButton
            // 
            this.showListButton.Location = new System.Drawing.Point(607, 0);
            this.showListButton.Name = "showListButton";
            this.showListButton.Size = new System.Drawing.Size(79, 37);
            this.showListButton.TabIndex = 4;
            this.showListButton.Text = "SHOW LISTVIEW";
            this.showListButton.UseVisualStyleBackColor = true;
            this.showListButton.Click += new System.EventHandler(this.showListButton_Click);
            // 
            // personSarchButton
            // 
            this.personSarchButton.Location = new System.Drawing.Point(479, 6);
            this.personSarchButton.Name = "personSarchButton";
            this.personSarchButton.Size = new System.Drawing.Size(75, 31);
            this.personSarchButton.TabIndex = 3;
            this.personSarchButton.Text = "SEARCH";
            this.personSarchButton.UseVisualStyleBackColor = true;
            this.personSarchButton.Click += new System.EventHandler(this.personSarchButton_Click);
            // 
            // deletButton
            // 
            this.deletButton.BackColor = System.Drawing.Color.Red;
            this.deletButton.Location = new System.Drawing.Point(329, 6);
            this.deletButton.Name = "deletButton";
            this.deletButton.Size = new System.Drawing.Size(75, 34);
            this.deletButton.TabIndex = 2;
            this.deletButton.Text = "DELETE";
            this.deletButton.UseVisualStyleBackColor = false;
            this.deletButton.Click += new System.EventHandler(this.deletButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Lime;
            this.saveButton.Location = new System.Drawing.Point(162, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 34);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.Orange;
            this.newButton.Location = new System.Drawing.Point(25, 4);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 33);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "NEW";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(642, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "sarchPerson";
            // 
            // sarchPersonTextBox
            // 
            this.sarchPersonTextBox.Location = new System.Drawing.Point(645, 418);
            this.sarchPersonTextBox.Name = "sarchPersonTextBox";
            this.sarchPersonTextBox.Size = new System.Drawing.Size(100, 20);
            this.sarchPersonTextBox.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(186, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(411, 37);
            this.label9.TabIndex = 6;
            this.label9.Text = "VEHICLE MANAGEMENT";
            // 
            // PERSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 546);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sarchPersonTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.personListView);
            this.Controls.Add(this.panel1);
            this.Name = "PERSON";
            this.Text = "PERSON";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button vendorsButton;
        private System.Windows.Forms.Button personButton;
        private System.Windows.Forms.Button partsButton;
        private System.Windows.Forms.Button vehicleButton;
        private System.Windows.Forms.ListView personListView;
        private System.Windows.Forms.ColumnHeader personNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox personFirstNameTextBox;
        private System.Windows.Forms.TextBox PersonPostalCodeTextBox;
        private System.Windows.Forms.TextBox personAddressTextBox;
        private System.Windows.Forms.TextBox personMobailNumberTextBox;
        private System.Windows.Forms.TextBox personLastNameTextBox;
        private System.Windows.Forms.TextBox personNumberTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker personDateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deletButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.ColumnHeader personLastName;
        private System.Windows.Forms.ColumnHeader personFirstName;
        private System.Windows.Forms.ColumnHeader personAddress;
        private System.Windows.Forms.ColumnHeader personMobailNumber;
        private System.Windows.Forms.ColumnHeader personPostalCode;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Button personSarchButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sarchPersonTextBox;
        private System.Windows.Forms.Button showListButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button roadPermitButton;
    }
}