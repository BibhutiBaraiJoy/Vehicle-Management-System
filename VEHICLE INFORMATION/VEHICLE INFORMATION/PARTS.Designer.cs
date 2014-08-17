namespace VEHICLE_INFORMATION
{
    partial class PARTS
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
            this.roadpermitButton = new System.Windows.Forms.Button();
            this.vendorsButton = new System.Windows.Forms.Button();
            this.personButton = new System.Windows.Forms.Button();
            this.partsutton = new System.Windows.Forms.Button();
            this.VehicleButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showListviewButton = new System.Windows.Forms.Button();
            this.sarchButton = new System.Windows.Forms.Button();
            this.deletButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.partsInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.partsQuentityTextBox = new System.Windows.Forms.TextBox();
            this.partsPriceTextBox = new System.Windows.Forms.TextBox();
            this.partsNumberTextBox = new System.Windows.Forms.TextBox();
            this.partsNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.partsListView = new System.Windows.Forms.ListView();
            this.partsName = new System.Windows.Forms.ColumnHeader();
            this.partsNumber = new System.Windows.Forms.ColumnHeader();
            this.partsPrice = new System.Windows.Forms.ColumnHeader();
            this.partsQuentity = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.sarchPartsNumberTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.partsInformationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.roadpermitButton);
            this.panel1.Controls.Add(this.vendorsButton);
            this.panel1.Controls.Add(this.personButton);
            this.panel1.Controls.Add(this.partsutton);
            this.panel1.Controls.Add(this.VehicleButton);
            this.panel1.Location = new System.Drawing.Point(3, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 45);
            this.panel1.TabIndex = 6;
            // 
            // roadpermitButton
            // 
            this.roadpermitButton.Location = new System.Drawing.Point(569, 3);
            this.roadpermitButton.Name = "roadpermitButton";
            this.roadpermitButton.Size = new System.Drawing.Size(94, 37);
            this.roadpermitButton.TabIndex = 4;
            this.roadpermitButton.Text = "ROAD PERMIT";
            this.roadpermitButton.UseVisualStyleBackColor = true;
            this.roadpermitButton.Click += new System.EventHandler(this.roadpermitButton_Click);
            // 
            // vendorsButton
            // 
            this.vendorsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.vendorsButton.Location = new System.Drawing.Point(437, 3);
            this.vendorsButton.Name = "vendorsButton";
            this.vendorsButton.Size = new System.Drawing.Size(83, 38);
            this.vendorsButton.TabIndex = 3;
            this.vendorsButton.Text = "VENDORS";
            this.vendorsButton.UseVisualStyleBackColor = false;
            this.vendorsButton.Click += new System.EventHandler(this.vendorsButton_Click);
            // 
            // personButton
            // 
            this.personButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.personButton.Location = new System.Drawing.Point(302, 2);
            this.personButton.Name = "personButton";
            this.personButton.Size = new System.Drawing.Size(79, 40);
            this.personButton.TabIndex = 2;
            this.personButton.Text = "PERSON";
            this.personButton.UseVisualStyleBackColor = false;
            this.personButton.Click += new System.EventHandler(this.personButton_Click);
            // 
            // partsutton
            // 
            this.partsutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.partsutton.Location = new System.Drawing.Point(163, 3);
            this.partsutton.Name = "partsutton";
            this.partsutton.Size = new System.Drawing.Size(77, 37);
            this.partsutton.TabIndex = 1;
            this.partsutton.Text = "PARTS";
            this.partsutton.UseVisualStyleBackColor = false;
            this.partsutton.Click += new System.EventHandler(this.partsutton_Click);
            // 
            // VehicleButton
            // 
            this.VehicleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.VehicleButton.Location = new System.Drawing.Point(33, 3);
            this.VehicleButton.Name = "VehicleButton";
            this.VehicleButton.Size = new System.Drawing.Size(75, 37);
            this.VehicleButton.TabIndex = 0;
            this.VehicleButton.Text = "VEHICLE";
            this.VehicleButton.UseVisualStyleBackColor = false;
            this.VehicleButton.Click += new System.EventHandler(this.VehicleButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.showListviewButton);
            this.panel2.Controls.Add(this.sarchButton);
            this.panel2.Controls.Add(this.deletButton);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.newButton);
            this.panel2.Location = new System.Drawing.Point(3, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 40);
            this.panel2.TabIndex = 7;
            // 
            // showListviewButton
            // 
            this.showListviewButton.Location = new System.Drawing.Point(596, 0);
            this.showListviewButton.Name = "showListviewButton";
            this.showListviewButton.Size = new System.Drawing.Size(105, 38);
            this.showListviewButton.TabIndex = 4;
            this.showListviewButton.Text = "SHOWLISTITEM";
            this.showListviewButton.UseVisualStyleBackColor = true;
            this.showListviewButton.Click += new System.EventHandler(this.showListviewButton_Click);
            // 
            // sarchButton
            // 
            this.sarchButton.Location = new System.Drawing.Point(462, 3);
            this.sarchButton.Name = "sarchButton";
            this.sarchButton.Size = new System.Drawing.Size(75, 35);
            this.sarchButton.TabIndex = 3;
            this.sarchButton.Text = "SEARCH";
            this.sarchButton.UseVisualStyleBackColor = true;
            this.sarchButton.Click += new System.EventHandler(this.sarchButton_Click);
            // 
            // deletButton
            // 
            this.deletButton.BackColor = System.Drawing.Color.Red;
            this.deletButton.Location = new System.Drawing.Point(305, 3);
            this.deletButton.Name = "deletButton";
            this.deletButton.Size = new System.Drawing.Size(75, 35);
            this.deletButton.TabIndex = 2;
            this.deletButton.Text = "DElETE";
            this.deletButton.UseVisualStyleBackColor = false;
            this.deletButton.Click += new System.EventHandler(this.deletButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Lime;
            this.saveButton.Location = new System.Drawing.Point(162, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 35);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.Yellow;
            this.newButton.Location = new System.Drawing.Point(32, 3);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 35);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "NEW";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // partsInformationGroupBox
            // 
            this.partsInformationGroupBox.BackColor = System.Drawing.Color.LightCyan;
            this.partsInformationGroupBox.Controls.Add(this.partsQuentityTextBox);
            this.partsInformationGroupBox.Controls.Add(this.partsPriceTextBox);
            this.partsInformationGroupBox.Controls.Add(this.partsNumberTextBox);
            this.partsInformationGroupBox.Controls.Add(this.partsNameTextBox);
            this.partsInformationGroupBox.Controls.Add(this.label5);
            this.partsInformationGroupBox.Controls.Add(this.label3);
            this.partsInformationGroupBox.Controls.Add(this.label2);
            this.partsInformationGroupBox.Controls.Add(this.label1);
            this.partsInformationGroupBox.Location = new System.Drawing.Point(456, 230);
            this.partsInformationGroupBox.Name = "partsInformationGroupBox";
            this.partsInformationGroupBox.Size = new System.Drawing.Size(312, 262);
            this.partsInformationGroupBox.TabIndex = 8;
            this.partsInformationGroupBox.TabStop = false;
            this.partsInformationGroupBox.Text = "partsInformation";
            // 
            // partsQuentityTextBox
            // 
            this.partsQuentityTextBox.Location = new System.Drawing.Point(82, 222);
            this.partsQuentityTextBox.Name = "partsQuentityTextBox";
            this.partsQuentityTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsQuentityTextBox.TabIndex = 8;
            // 
            // partsPriceTextBox
            // 
            this.partsPriceTextBox.Location = new System.Drawing.Point(52, 162);
            this.partsPriceTextBox.Name = "partsPriceTextBox";
            this.partsPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsPriceTextBox.TabIndex = 7;
            // 
            // partsNumberTextBox
            // 
            this.partsNumberTextBox.Location = new System.Drawing.Point(67, 113);
            this.partsNumberTextBox.Name = "partsNumberTextBox";
            this.partsNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsNumberTextBox.TabIndex = 6;
            // 
            // partsNameTextBox
            // 
            this.partsNameTextBox.Location = new System.Drawing.Point(52, 42);
            this.partsNameTextBox.Name = "partsNameTextBox";
            this.partsNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsNameTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "PARTS QUENTITY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PARTS PRICE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PARTS NUMBER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARTS NAME";
            // 
            // partsListView
            // 
            this.partsListView.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.partsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.partsName,
            this.partsNumber,
            this.partsPrice,
            this.partsQuentity});
            this.partsListView.FullRowSelect = true;
            this.partsListView.GridLines = true;
            this.partsListView.Location = new System.Drawing.Point(3, 230);
            this.partsListView.Name = "partsListView";
            this.partsListView.Size = new System.Drawing.Size(439, 262);
            this.partsListView.TabIndex = 9;
            this.partsListView.UseCompatibleStateImageBehavior = false;
            this.partsListView.View = System.Windows.Forms.View.Details;
            // 
            // partsName
            // 
            this.partsName.Text = "PartsName";
            this.partsName.Width = 100;
            // 
            // partsNumber
            // 
            this.partsNumber.Text = "PartsNumber";
            this.partsNumber.Width = 100;
            // 
            // partsPrice
            // 
            this.partsPrice.Text = "PartsPrice";
            this.partsPrice.Width = 100;
            // 
            // partsQuentity
            // 
            this.partsQuentity.Text = "PartsQuentity";
            this.partsQuentity.Width = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "SEARCHPartsNumber";
            // 
            // sarchPartsNumberTextBox
            // 
            this.sarchPartsNumberTextBox.Location = new System.Drawing.Point(423, 204);
            this.sarchPartsNumberTextBox.Name = "sarchPartsNumberTextBox";
            this.sarchPartsNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.sarchPartsNumberTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(169, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(411, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "VEHICLE MANAGEMENT";
            // 
            // PARTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VEHICLE_INFORMATION.Properties.Resources._0__8_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(780, 494);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sarchPartsNumberTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.partsListView);
            this.Controls.Add(this.partsInformationGroupBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PARTS";
            this.Text = "PARTS";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.partsInformationGroupBox.ResumeLayout(false);
            this.partsInformationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox partsInformationGroupBox;
        private System.Windows.Forms.TextBox partsQuentityTextBox;
        private System.Windows.Forms.TextBox partsPriceTextBox;
        private System.Windows.Forms.TextBox partsNumberTextBox;
        private System.Windows.Forms.TextBox partsNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView partsListView;
        private System.Windows.Forms.ColumnHeader partsName;
        private System.Windows.Forms.ColumnHeader partsNumber;
        private System.Windows.Forms.ColumnHeader partsPrice;
        private System.Windows.Forms.ColumnHeader partsQuentity;
        private System.Windows.Forms.Button vendorsButton;
        private System.Windows.Forms.Button personButton;
        private System.Windows.Forms.Button partsutton;
        private System.Windows.Forms.Button VehicleButton;
        private System.Windows.Forms.Button deletButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button sarchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sarchPartsNumberTextBox;
        private System.Windows.Forms.Button showListviewButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button roadpermitButton;
    }
}