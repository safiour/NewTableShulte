using System;
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
		DateTime ControlTimer;// = new DateTime(0, 0);

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
			this.Hide();
            SetSizePanel();
			GenerateArray();
			ControlTimer = new DateTime(0, 0);
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
			tsslTimer.Text = "Таймер: 00:00:00";
			tspbProgress.Value = Data.ControlCount;
			tspbProgress.Maximum = Data.SizeTable * Data.SizeTable;
			this.Show();
			timer1.Enabled = true;
			timer1.Start();

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
				tsslLastNumber.Text = "Победа!";
				MessageBox.Show("Ты победил, чувак!\nТвой результат: пока не знаю как посчитать:)" );
            }
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
			#region Old Timer

			//Data.SecondCount++;
			//if (Data.SecondCount < 10)
			//{
			//	if (Data.MinuteCount < 10)
			//	{
			//		tsslTimer.Text = "t 0:0" + Convert.ToString(Data.MinuteCount) + ":0" + Convert.ToString(Data.SecondCount);
			//	}
			//	else tsslTimer.Text = "t 0:" + Convert.ToString(Data.MinuteCount) + ":0" + Convert.ToString(Data.SecondCount);

			//}
			//else if (Data.SecondCount < 60)
			//{
			//	if (Data.MinuteCount < 10)
			//	{
			//		tsslTimer.Text = "t 0:0" + Convert.ToString(Data.MinuteCount) + ":" + Convert.ToString(Data.SecondCount);
			//	}
			//	else tsslTimer.Text = "t 0:" + Convert.ToString(Data.MinuteCount) + ":" + Convert.ToString(Data.SecondCount);
			//}
			//else if (Data.SecondCount == 60 && Data.MinuteCount < 59)
			//{
			//	Data.MinuteCount++;
			//	Data.SecondCount -= 60;
			//	if (Data.MinuteCount < 10)
			//	{
			//		tsslTimer.Text = "t 0:0" + Convert.ToString(Data.MinuteCount) + ":00";
			//	}
			//	else tsslTimer.Text = "t 0:" + Convert.ToString(Data.MinuteCount) + ":00";

			//}
			//else
			//{
			//	timer1.Stop();
			//	timer1.Enabled = false;
			//	Data.SecondCount = 0;
			//	Data.MinuteCount = 0;
			//	MessageBox.Show("Ты проиграл!");
			//}
			#endregion

			#region New Timer
			ControlTimer = ControlTimer.AddSeconds(1);
			tsslTimer.Text = "Таймер: " + (ControlTimer).ToString("HH:mm:ss");
			#endregion

		}
	}
}
