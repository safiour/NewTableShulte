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

		public frmMainForm()
        {
            InitializeComponent();
			SetSizePanel();
		}


        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.ShowDialog();
            
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {

        }
        /*--- Generated new Table ---*/
        private void tsmiNewTable_Click(object sender, EventArgs e)
        {
			this.Hide();
            SetSizePanel();
			GenerateArray();
            
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
                    if (TableMassive[i, j] % 2 == 0) labelXY.ForeColor = Color.Red;
                    labelXY.Text = TableMassive[i, j].ToString();
                }
            }
            this.Show();
            
		}
        /*--- To set the size our table ---*/
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
                string fileName = "out.txt";
                string lines = "";
                FileStream aFile = new FileStream(fileName, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(aFile);
                aFile.Seek(0, SeekOrigin.End);



                for (int j = 0; j < Data.SizeTable; j++)
                {
                    int n = rand.Next(0, arr.Length);
                    TableMassive[i, j] = arr[n];
                    arr[n] = 0;
                    Array.Sort(arr);
                    Array.Reverse(arr);
                    Array.Resize(ref arr, arr.Length - 1);

                    lines = lines + " ["+Convert.ToString(i)+ "," + Convert.ToString(j) + "] "+ Convert.ToString(TableMassive[i, j]);
                }
                lines = lines + "\n";
                sw.WriteLine(lines);
                sw.Close();
            }
        }

        /*--- Mouse click on label ---*/
        public void LabelClick(object sender, EventArgs e)
        {
                if ((Data.ControlCount + 1) == Convert.ToInt32(((Label)sender).Text))
                {
                Data.ControlCount++;
                //((Label)sender).BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    SystemSounds.Beep.Play();
                }
            if (Data.ControlCount == Data.SizeTable * Data.SizeTable)
            {

                MessageBox.Show("Ты победил, чувак!\nТвой результат: Доделаю завтра:)" );
            }
        }

    }
}
