using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VEHICLE_INFORMATION
{
    public partial class startingVehicleForm : Form
    {
        public startingVehicleForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            this.Hide();
            main.Show();


        }
    }
}
