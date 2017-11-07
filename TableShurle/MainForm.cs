﻿using System;
using System.IO;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace TableShurle
{
    public partial class frmMainForm : Form
    {
		int[,] TableMassive; 
		Random rand = new Random();

		public frmMainForm()
        {
            InitializeComponent();
			SetSizePanel();
		}

		/*--- Close program ---*/
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		/*--- Open settings form ---*/
        private void tsmiSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.ShowDialog();
            
        }

		/*--- Generated new Table ---*/
		private void tsmiNewTable_Click(object sender, EventArgs e)
        {
			this.Hide(); // hide the form because it blinks when you create a table
			SetSizePanel();
			GenerateArray();
			Data.ControlCount = 0;
			Data.SecondCount = 0;
			Data.MinuteCount = 0;
            
         /*--- Create LABEL's in TabelLayoutPanel for input Massive ---*/
            for (int i = 0; i < Data.SizeTable; i++)
            {
                for (int j = 0; j < Data.SizeTable; j++)
                {
                    Label labelXY = new Label();
                    tlpTableShulte.Controls.Add(labelXY, i, j);
                    labelXY.Dock = DockStyle.Fill;
                    labelXY.TextAlign = ContentAlignment.MiddleCenter;
                    labelXY.Font = new Font("Tahoma", 14, FontStyle.Regular);
                    labelXY.Click += new EventHandler(LabelClick);
					if (Data.ColoredNumber == true)
					if (TableMassive[i, j] % 2 == 0) labelXY.ForeColor = Color.Red;
                    labelXY.Text = TableMassive[i, j].ToString();
                }
            }
			tsslLastNumber.Text = "Ищем: 1";
			tspbProgress.Value = Data.ControlCount;
			tspbProgress.Maximum = Data.SizeTable * Data.SizeTable;
			this.Show();

			this.Show(); //Show the form

		}
        
		/*--- To set the size our table and create contaner ---*/
		private void SetSizePanel()
		{
			tlpTableShulte.Controls.Clear();
			tlpTableShulte.RowCount = Data.SizeTable ;
			tlpTableShulte.ColumnCount = Data.SizeTable;
            for (int i = 0; i < Data.SizeTable; i++)
            {
                this.tlpTableShulte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
                this.tlpTableShulte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            }
		}

        /*--- Generate a random array of integers ---*/
        private void GenerateArray()
		{
            int[] arr = new int[Data.SizeTable * Data.SizeTable];

            // Mix up the array
            for (int i = 1; i < arr.Length+1; i++) arr[i-1] = i;
            TableMassive = new int[Data.SizeTable, Data.SizeTable];
            for (int i = 0; i < Data.SizeTable; i++)
            {
                for (int j = 0; j < Data.SizeTable; j++)
                {
                    int n = rand.Next(0, arr.Length);
                    TableMassive[i, j] = arr[n];
                    arr[n] = 0;
                    Array.Sort(arr);
                    Array.Reverse(arr);
                    Array.Resize(ref arr, arr.Length - 1);
                }
            }
        }

        /*--- Mouse click on label ---*/
        public void LabelClick(object sender, EventArgs e)
        {
                if ((Data.ControlCount + 1) == Convert.ToInt32(((Label)sender).Text))
                {
                Data.ControlCount++;
				tsslLastNumber.Text = "Ищем: " + Convert.ToString(Data.ControlCount + 1);
				tspbProgress.Value = Data.ControlCount;
                //((Label)sender).BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    SystemSounds.Beep.Play();
                }
            if (Data.ControlCount == Data.SizeTable * Data.SizeTable)
            {
				timer1.Stop();
				timer1.Enabled = false;
				Data.SecondCount = 0;
				Data.MinuteCount = 0;
				tsslLastNumber.Text = "Победа!";
				MessageBox.Show("Ты победил, чувак!\nТвой результат: пока не знаю как посчитать:)" );
            }
			else
			{
				timer1.Stop();
				timer1.Enabled = false;
				Data.SecondCount = 0;
				Data.MinuteCount = 0;
				MessageBox.Show("Ты проиграл!");
			}
		}
	}
}
