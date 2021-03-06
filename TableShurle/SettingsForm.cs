﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TableShurle
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void tbSize_Scroll(object sender, EventArgs e)
        {
            lblSize.Text = Convert.ToString(tbSize.Value) + " х " + Convert.ToString(tbSize.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetSettings_Click(object sender, EventArgs e)
        {
			Data.SizeTable = tbSize.Value;
			Data.ColoredNumber = cbColoredNumber.Checked;
			Data.ControlResult = cbControlResult.Checked;
            this.Close();

        }
         
        private void frmSettings_Load(object sender, EventArgs e)
        {
            tbSize.Value = Data.SizeTable;
			cbColoredNumber.Checked = Data.ColoredNumber;
			cbControlResult.Checked = Data.ControlResult;
            lblSize.Text = Convert.ToString(tbSize.Value) + " x " + Convert.ToString(tbSize.Value);
        }

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
