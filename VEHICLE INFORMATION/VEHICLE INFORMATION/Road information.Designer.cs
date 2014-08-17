namespace VEHICLE_INFORMATION
{
    partial class roadParmit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(roadParmit));
            this.typeOfCarComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vehicleButton = new System.Windows.Forms.Button();
            this.partsButton = new System.Windows.Forms.Button();
            this.personButton = new System.Windows.Forms.Button();
            this.vendorsButton = new System.Windows.Forms.Button();
            this.roadParmitButton = new System.Windows.Forms.Button();
            this.roadNewButton = new System.Windows.Forms.Button();
            this.roadSaveButton = new System.Windows.Forms.Button();
            this.roadDeleteButton = new System.Windows.Forms.Button();
            this.roadSarchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showCarNameAndIdButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchLisenceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.carLisenceNumbertextBox = new System.Windows.Forms.TextBox();
            this.carRoadPermitTextBox = new System.Windows.Forms.TextBox();
            this.carIdTextBox = new System.Windows.Forms.TextBox();
            this.carNameAndIdlistView = new System.Windows.Forms.ListView();
            this.carId = new System.Windows.Forms.ColumnHeader();
            this.carLisenceNumber = new System.Windows.Forms.ColumnHeader();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.showRoadPermitTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeOfCarComboBox
            // 
            this.typeOfCarComboBox.FormattingEnabled = true;
            this.typeOfCarComboBox.Items.AddRange(new object[] {
            "privatCar",
            "miniBus",
            "bus",
            "track",
            "other"});
            this.typeOfCarComboBox.Location = new System.Drawing.Point(45, 35);
            this.typeOfCarComboBox.Name = "typeOfCarComboBox";
            this.typeOfCarComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeOfCarComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "typesOfCar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "VEHICLE MANAGEMENT";
            // 
            // vehicleButton
            // 
            this.vehicleButton.Location = new System.Drawing.Point(5, 3);
            this.vehicleButton.Name = "vehicleButton";
            this.vehicleButton.Size = new System.Drawing.Size(75, 40);
            this.vehicleButton.TabIndex = 3;
            this.vehicleButton.Text = "VEHICLE";
            this.vehicleButton.UseVisualStyleBackColor = true;
            this.vehicleButton.Click += new System.EventHandler(this.vehicleButton_Click);
            // 
            // partsButton
            // 
            this.partsButton.Location = new System.Drawing.Point(117, 3);
            this.partsButton.Name = "partsButton";
            this.partsButton.Size = new System.Drawing.Size(75, 40);
            this.partsButton.TabIndex = 4;
            this.partsButton.Text = "PARTS";
            this.partsButton.UseVisualStyleBackColor = true;
            this.partsButton.Click += new System.EventHandler(this.partsButton_Click);
            // 
            // personButton
            // 
            this.personButton.Location = new System.Drawing.Point(231, 2);
            this.personButton.Name = "personButton";
            this.personButton.Size = new System.Drawing.Size(75, 41);
            this.personButton.TabIndex = 5;
            this.personButton.Text = "PERSON";
            this.personButton.UseVisualStyleBackColor = true;
            this.personButton.Click += new System.EventHandler(this.personButton_Click);
            // 
            // vendorsButton
            // 
            this.vendorsButton.Location = new System.Drawing.Point(334, 3);
            this.vendorsButton.Name = "vendorsButton";
            this.vendorsButton.Size = new System.Drawing.Size(75, 40);
            this.vendorsButton.TabIndex = 6;
            this.vendorsButton.Text = "VENDORS";
            this.vendorsButton.UseVisualStyleBackColor = true;
            this.vendorsButton.Click += new System.EventHandler(this.vendorsButton_Click);
            // 
            // roadParmitButton
            // 
            this.roadParmitButton.Location = new System.Drawing.Point(424, 3);
            this.roadParmitButton.Name = "roadParmitButton";
            this.roadParmitButton.Size = new System.Drawing.Size(75, 40);
            this.roadParmitButton.TabIndex = 7;
            this.roadParmitButton.Text = "ROADPERMIT";
            this.roadParmitButton.UseVisualStyleBackColor = true;
            this.roadParmitButton.Click += new System.EventHandler(this.roadParmitButton_Click);
            // 
            // roadNewButton
            // 
            this.roadNewButton.Location = new System.Drawing.Point(10, 12);
            this.roadNewButton.Name = "roadNewButton";
            this.roadNewButton.Size = new System.Drawing.Size(75, 34);
            this.roadNewButton.TabIndex = 8;
            this.roadNewButton.Text = "NEW";
            this.roadNewButton.UseVisualStyleBackColor = true;
            this.roadNewButton.Click += new System.EventHandler(this.roadNewButton_Click);
            // 
            // roadSaveButton
            // 
            this.roadSaveButton.Location = new System.Drawing.Point(106, 12);
            this.roadSaveButton.Name = "roadSaveButton";
            this.roadSaveButton.Size = new System.Drawing.Size(75, 34);
            this.roadSaveButton.TabIndex = 9;
            this.roadSaveButton.Text = "SAVE";
            this.roadSaveButton.UseVisualStyleBackColor = true;
            this.roadSaveButton.Click += new System.EventHandler(this.roadSaveButton_Click);
            // 
            // roadDeleteButton
            // 
            this.roadDeleteButton.Location = new System.Drawing.Point(207, 12);
            this.roadDeleteButton.Name = "roadDeleteButton";
            this.roadDeleteButton.Size = new System.Drawing.Size(75, 35);
            this.roadDeleteButton.TabIndex = 10;
            this.roadDeleteButton.Text = "DELETE";
            this.roadDeleteButton.UseVisualStyleBackColor = true;
            this.roadDeleteButton.Click += new System.EventHandler(this.roadDeleteButton_Click);
            // 
            // roadSarchButton
            // 
            this.roadSarchButton.Location = new System.Drawing.Point(304, 13);
            this.roadSarchButton.Name = "roadSarchButton";
            this.roadSarchButton.Size = new System.Drawing.Size(75, 34);
            this.roadSarchButton.TabIndex = 11;
            this.roadSarchButton.Text = "SARCH";
            this.roadSarchButton.UseVisualStyleBackColor = true;
            this.roadSarchButton.Click += new System.EventHandler(this.roadSarchButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.showCarNameAndIdButton);
            this.panel1.Controls.Add(this.roadSaveButton);
            this.panel1.Controls.Add(this.roadNewButton);
            this.panel1.Controls.Add(this.roadSarchButton);
            this.panel1.Controls.Add(this.roadDeleteButton);
            this.panel1.Location = new System.Drawing.Point(1, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 49);
            this.panel1.TabIndex = 12;
            // 
            // showCarNameAndIdButton
            // 
            this.showCarNameAndIdButton.Location = new System.Drawing.Point(385, 18);
            this.showCarNameAndIdButton.Name = "showCarNameAndIdButton";
            this.showCarNameAndIdButton.Size = new System.Drawing.Size(129, 23);
            this.showCarNameAndIdButton.TabIndex = 12;
            this.showCarNameAndIdButton.Text = "SHOW CARNAME &ID";
            this.showCarNameAndIdButton.UseVisualStyleBackColor = true;
            this.showCarNameAndIdButton.Click += new System.EventHandler(this.showCarNameAndIdButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.partsButton);
            this.panel2.Controls.Add(this.vehicleButton);
            this.panel2.Controls.Add(this.roadParmitButton);
            this.panel2.Controls.Add(this.personButton);
            this.panel2.Controls.Add(this.vendorsButton);
            this.panel2.Location = new System.Drawing.Point(1, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 46);
            this.panel2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "carId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "roadPermit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "lisenceNumber";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.showRoadPermitTextBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.searchLisenceTextBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.carLisenceNumbertextBox);
            this.panel3.Controls.Add(this.carRoadPermitTextBox);
            this.panel3.Controls.Add(this.carIdTextBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.typeOfCarComboBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(1, 325);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 124);
            this.panel3.TabIndex = 17;
            // 
            // searchLisenceTextBox
            // 
            this.searchLisenceTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchLisenceTextBox.Location = new System.Drawing.Point(33, 78);
            this.searchLisenceTextBox.Name = "searchLisenceTextBox";
            this.searchLisenceTextBox.Size = new System.Drawing.Size(159, 20);
            this.searchLisenceTextBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "FOR SEARCH/DELETE";
            // 
            // carLisenceNumbertextBox
            // 
            this.carLisenceNumbertextBox.Location = new System.Drawing.Point(305, 36);
            this.carLisenceNumbertextBox.Name = "carLisenceNumbertextBox";
            this.carLisenceNumbertextBox.Size = new System.Drawing.Size(100, 20);
            this.carLisenceNumbertextBox.TabIndex = 19;
            // 
            // carRoadPermitTextBox
            // 
            this.carRoadPermitTextBox.Location = new System.Drawing.Point(414, 36);
            this.carRoadPermitTextBox.Name = "carRoadPermitTextBox";
            this.carRoadPermitTextBox.Size = new System.Drawing.Size(100, 20);
            this.carRoadPermitTextBox.TabIndex = 18;
            // 
            // carIdTextBox
            // 
            this.carIdTextBox.Location = new System.Drawing.Point(193, 36);
            this.carIdTextBox.Name = "carIdTextBox";
            this.carIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.carIdTextBox.TabIndex = 17;
            // 
            // carNameAndIdlistView
            // 
            this.carNameAndIdlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.carId,
            this.carLisenceNumber});
            this.carNameAndIdlistView.GridLines = true;
            this.carNameAndIdlistView.Location = new System.Drawing.Point(415, 183);
            this.carNameAndIdlistView.Name = "carNameAndIdlistView";
            this.carNameAndIdlistView.Size = new System.Drawing.Size(108, 136);
            this.carNameAndIdlistView.TabIndex = 18;
            this.carNameAndIdlistView.UseCompatibleStateImageBehavior = false;
            this.carNameAndIdlistView.View = System.Windows.Forms.View.Details;
            // 
            // carId
            // 
            this.carId.Text = "carId";
            this.carId.Width = 42;
            // 
            // carLisenceNumber
            // 
            this.carLisenceNumber.Text = "carLisenceNumber";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(332, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "SHOW CAR NAME&ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "CAR ROAD PERMIT";
            // 
            // showRoadPermitTextBox
            // 
            this.showRoadPermitTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.showRoadPermitTextBox.Location = new System.Drawing.Point(350, 91);
            this.showRoadPermitTextBox.Name = "showRoadPermitTextBox";
            this.showRoadPermitTextBox.Size = new System.Drawing.Size(149, 20);
            this.showRoadPermitTextBox.TabIndex = 23;
            // 
            // roadParmit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(527, 448);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.carNameAndIdlistView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "roadParmit";
            this.Text = "ROADPERMIT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeOfCarComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button vehicleButton;
        private System.Windows.Forms.Button partsButton;
        private System.Windows.Forms.Button personButton;
        private System.Windows.Forms.Button vendorsButton;
        private System.Windows.Forms.Button roadParmitButton;
        private System.Windows.Forms.Button roadNewButton;
        private System.Windows.Forms.Button roadSaveButton;
        private System.Windows.Forms.Button roadDeleteButton;
        private System.Windows.Forms.Button roadSarchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox carLisenceNumbertextBox;
        private System.Windows.Forms.TextBox carRoadPermitTextBox;
        private System.Windows.Forms.TextBox carIdTextBox;
        private System.Windows.Forms.TextBox searchLisenceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button showCarNameAndIdButton;
        private System.Windows.Forms.ListView carNameAndIdlistView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader carId;
        private System.Windows.Forms.ColumnHeader carLisenceNumber;
        private System.Windows.Forms.TextBox showRoadPermitTextBox;
        private System.Windows.Forms.Label label8;
    }
}