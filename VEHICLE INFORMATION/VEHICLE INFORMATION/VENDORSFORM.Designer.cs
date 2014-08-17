namespace VEHICLE_INFORMATION
{
    partial class vendorsForm
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
            this.personButton = new System.Windows.Forms.Button();
            this.vendorsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vehicleButton = new System.Windows.Forms.Button();
            this.vendorsGroupBox = new System.Windows.Forms.GroupBox();
            this.vendorsStreetTextBox = new System.Windows.Forms.TextBox();
            this.vendorsPotalCodTextBox = new System.Windows.Forms.TextBox();
            this.vendosCityTextBox = new System.Windows.Forms.TextBox();
            this.vendorsNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.streetAddressTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vendorsListVew = new System.Windows.Forms.ListView();
            this.vendorsName = new System.Windows.Forms.ColumnHeader();
            this.streetAddress = new System.Windows.Forms.ColumnHeader();
            this.city = new System.Windows.Forms.ColumnHeader();
            this.postalCode = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showListViewButton = new System.Windows.Forms.Button();
            this.deletButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.vendorNamTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.roadPermitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.vendorsGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.roadPermitButton);
            this.panel1.Controls.Add(this.personButton);
            this.panel1.Controls.Add(this.vendorsButton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.vehicleButton);
            this.panel1.Location = new System.Drawing.Point(2, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 65);
            this.panel1.TabIndex = 0;
            // 
            // personButton
            // 
            this.personButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.personButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personButton.Location = new System.Drawing.Point(349, 11);
            this.personButton.Name = "personButton";
            this.personButton.Size = new System.Drawing.Size(111, 38);
            this.personButton.TabIndex = 3;
            this.personButton.Text = "PERSON";
            this.personButton.UseVisualStyleBackColor = false;
            this.personButton.Click += new System.EventHandler(this.personButton_Click);
            // 
            // vendorsButton
            // 
            this.vendorsButton.BackColor = System.Drawing.Color.Cyan;
            this.vendorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorsButton.Location = new System.Drawing.Point(497, 11);
            this.vendorsButton.Name = "vendorsButton";
            this.vendorsButton.Size = new System.Drawing.Size(114, 38);
            this.vendorsButton.TabIndex = 2;
            this.vendorsButton.Text = "VENDORS";
            this.vendorsButton.UseVisualStyleBackColor = false;
            this.vendorsButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(186, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "PARTS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vehicleButton
            // 
            this.vehicleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.vehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleButton.Location = new System.Drawing.Point(31, 11);
            this.vehicleButton.Name = "vehicleButton";
            this.vehicleButton.Size = new System.Drawing.Size(129, 38);
            this.vehicleButton.TabIndex = 0;
            this.vehicleButton.Text = "VEHICLE";
            this.vehicleButton.UseVisualStyleBackColor = false;
            this.vehicleButton.Click += new System.EventHandler(this.vehicleButton_Click);
            // 
            // vendorsGroupBox
            // 
            this.vendorsGroupBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.vendorsGroupBox.Controls.Add(this.vendorsStreetTextBox);
            this.vendorsGroupBox.Controls.Add(this.vendorsPotalCodTextBox);
            this.vendorsGroupBox.Controls.Add(this.vendosCityTextBox);
            this.vendorsGroupBox.Controls.Add(this.vendorsNameTextBox);
            this.vendorsGroupBox.Controls.Add(this.label4);
            this.vendorsGroupBox.Controls.Add(this.label3);
            this.vendorsGroupBox.Controls.Add(this.streetAddressTextBox);
            this.vendorsGroupBox.Controls.Add(this.label1);
            this.vendorsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorsGroupBox.Location = new System.Drawing.Point(2, 356);
            this.vendorsGroupBox.Name = "vendorsGroupBox";
            this.vendorsGroupBox.Size = new System.Drawing.Size(583, 180);
            this.vendorsGroupBox.TabIndex = 1;
            this.vendorsGroupBox.TabStop = false;
            this.vendorsGroupBox.Text = "VENDORS INFORMATION";
            // 
            // vendorsStreetTextBox
            // 
            this.vendorsStreetTextBox.Location = new System.Drawing.Point(99, 125);
            this.vendorsStreetTextBox.Name = "vendorsStreetTextBox";
            this.vendorsStreetTextBox.Size = new System.Drawing.Size(174, 22);
            this.vendorsStreetTextBox.TabIndex = 7;
            // 
            // vendorsPotalCodTextBox
            // 
            this.vendorsPotalCodTextBox.Location = new System.Drawing.Point(398, 125);
            this.vendorsPotalCodTextBox.Name = "vendorsPotalCodTextBox";
            this.vendorsPotalCodTextBox.Size = new System.Drawing.Size(167, 22);
            this.vendorsPotalCodTextBox.TabIndex = 6;
            // 
            // vendosCityTextBox
            // 
            this.vendosCityTextBox.Location = new System.Drawing.Point(398, 53);
            this.vendosCityTextBox.Name = "vendosCityTextBox";
            this.vendosCityTextBox.Size = new System.Drawing.Size(167, 22);
            this.vendosCityTextBox.TabIndex = 5;
            // 
            // vendorsNameTextBox
            // 
            this.vendorsNameTextBox.Location = new System.Drawing.Point(99, 53);
            this.vendorsNameTextBox.Name = "vendorsNameTextBox";
            this.vendorsNameTextBox.Size = new System.Drawing.Size(174, 22);
            this.vendorsNameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "PostalCode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // streetAddressTextBox
            // 
            this.streetAddressTextBox.AutoSize = true;
            this.streetAddressTextBox.Location = new System.Drawing.Point(10, 104);
            this.streetAddressTextBox.Name = "streetAddressTextBox";
            this.streetAddressTextBox.Size = new System.Drawing.Size(107, 16);
            this.streetAddressTextBox.TabIndex = 1;
            this.streetAddressTextBox.Text = "StreetAddress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "VendorsName";
            // 
            // vendorsListVew
            // 
            this.vendorsListVew.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.vendorsListVew.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vendorsName,
            this.streetAddress,
            this.city,
            this.postalCode});
            this.vendorsListVew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorsListVew.GridLines = true;
            this.vendorsListVew.Location = new System.Drawing.Point(-3, 135);
            this.vendorsListVew.Name = "vendorsListVew";
            this.vendorsListVew.Size = new System.Drawing.Size(812, 165);
            this.vendorsListVew.TabIndex = 2;
            this.vendorsListVew.UseCompatibleStateImageBehavior = false;
            this.vendorsListVew.View = System.Windows.Forms.View.Details;
            // 
            // vendorsName
            // 
            this.vendorsName.Text = "VendorsName";
            this.vendorsName.Width = 136;
            // 
            // streetAddress
            // 
            this.streetAddress.Text = "StreetAddress";
            this.streetAddress.Width = 141;
            // 
            // city
            // 
            this.city.Text = "City";
            this.city.Width = 171;
            // 
            // postalCode
            // 
            this.postalCode.Text = "PostalCode";
            this.postalCode.Width = 186;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.showListViewButton);
            this.panel2.Controls.Add(this.deletButton);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.newButton);
            this.panel2.Location = new System.Drawing.Point(2, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 46);
            this.panel2.TabIndex = 3;
            // 
            // showListViewButton
            // 
            this.showListViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showListViewButton.Location = new System.Drawing.Point(497, 0);
            this.showListViewButton.Name = "showListViewButton";
            this.showListViewButton.Size = new System.Drawing.Size(157, 43);
            this.showListViewButton.TabIndex = 3;
            this.showListViewButton.Text = "ShowListView";
            this.showListViewButton.UseVisualStyleBackColor = true;
            this.showListViewButton.Click += new System.EventHandler(this.showListViewButton_Click);
            // 
            // deletButton
            // 
            this.deletButton.BackColor = System.Drawing.Color.Red;
            this.deletButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletButton.Location = new System.Drawing.Point(305, 4);
            this.deletButton.Name = "deletButton";
            this.deletButton.Size = new System.Drawing.Size(75, 40);
            this.deletButton.TabIndex = 2;
            this.deletButton.Text = "DELETE";
            this.deletButton.UseVisualStyleBackColor = false;
            this.deletButton.Click += new System.EventHandler(this.deletButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(146, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 40);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.DarkOrange;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(10, 4);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 40);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "NEW";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(599, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "deleteVendorname";
            // 
            // vendorNamTextBox
            // 
            this.vendorNamTextBox.Location = new System.Drawing.Point(671, 398);
            this.vendorNamTextBox.Name = "vendorNamTextBox";
            this.vendorNamTextBox.Size = new System.Drawing.Size(100, 20);
            this.vendorNamTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label5.Location = new System.Drawing.Point(196, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "VEHICLE MANAGEMENT";
            // 
            // roadPermitButton
            // 
            this.roadPermitButton.Location = new System.Drawing.Point(669, 13);
            this.roadPermitButton.Name = "roadPermitButton";
            this.roadPermitButton.Size = new System.Drawing.Size(75, 37);
            this.roadPermitButton.TabIndex = 4;
            this.roadPermitButton.Text = "roadPermit";
            this.roadPermitButton.UseVisualStyleBackColor = true;
            this.roadPermitButton.Click += new System.EventHandler(this.roadPermitButton_Click);
            // 
            // vendorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 539);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vendorNamTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.vendorsListVew);
            this.Controls.Add(this.vendorsGroupBox);
            this.Controls.Add(this.panel1);
            this.Name = "vendorsForm";
            this.Text = "VENDORSFORM";
            this.panel1.ResumeLayout(false);
            this.vendorsGroupBox.ResumeLayout(false);
            this.vendorsGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button personButton;
        private System.Windows.Forms.Button vendorsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button vehicleButton;
        private System.Windows.Forms.GroupBox vendorsGroupBox;
        private System.Windows.Forms.ListView vendorsListVew;
        private System.Windows.Forms.ColumnHeader vendorsName;
        private System.Windows.Forms.ColumnHeader streetAddress;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.ColumnHeader postalCode;
        private System.Windows.Forms.TextBox vendorsStreetTextBox;
        private System.Windows.Forms.TextBox vendorsPotalCodTextBox;
        private System.Windows.Forms.TextBox vendosCityTextBox;
        private System.Windows.Forms.TextBox vendorsNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label streetAddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deletButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button showListViewButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vendorNamTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button roadPermitButton;
    }
}