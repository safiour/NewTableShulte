namespace TableShurle
{
    partial class frmSettings
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
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbSize = new System.Windows.Forms.TrackBar();
			this.lblSize = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnSetSettings = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cbColoredNumber = new System.Windows.Forms.CheckBox();
			this.cbControlResult = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbSize)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(284, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Задайте размер таблицы:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tbSize);
			this.panel1.Controls.Add(this.lblSize);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 19);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(284, 61);
			this.panel1.TabIndex = 3;
			// 
			// tbSize
			// 
			this.tbSize.AutoSize = false;
			this.tbSize.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbSize.Location = new System.Drawing.Point(0, 0);
			this.tbSize.Maximum = 12;
			this.tbSize.Minimum = 5;
			this.tbSize.Name = "tbSize";
			this.tbSize.Size = new System.Drawing.Size(284, 26);
			this.tbSize.TabIndex = 4;
			this.tbSize.Value = 5;
			this.tbSize.Scroll += new System.EventHandler(this.tbSize_Scroll);
			// 
			// lblSize
			// 
			this.lblSize.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSize.Location = new System.Drawing.Point(0, 25);
			this.lblSize.Name = "lblSize";
			this.lblSize.Size = new System.Drawing.Size(284, 36);
			this.lblSize.TabIndex = 3;
			this.lblSize.Text = "3 х 3";
			this.lblSize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnSetSettings);
			this.panel2.Controls.Add(this.btnCancel);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 136);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(284, 40);
			this.panel2.TabIndex = 4;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// btnSetSettings
			// 
			this.btnSetSettings.Location = new System.Drawing.Point(112, 8);
			this.btnSetSettings.Name = "btnSetSettings";
			this.btnSetSettings.Size = new System.Drawing.Size(75, 23);
			this.btnSetSettings.TabIndex = 1;
			this.btnSetSettings.Text = "Применить";
			this.btnSetSettings.UseVisualStyleBackColor = true;
			this.btnSetSettings.Click += new System.EventHandler(this.btnSetSettings_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(200, 8);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "Отменить";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// cbColoredNumber
			// 
			this.cbColoredNumber.AutoSize = true;
			this.cbColoredNumber.Checked = true;
			this.cbColoredNumber.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbColoredNumber.Location = new System.Drawing.Point(8, 80);
			this.cbColoredNumber.Name = "cbColoredNumber";
			this.cbColoredNumber.Size = new System.Drawing.Size(160, 17);
			this.cbColoredNumber.TabIndex = 5;
			this.cbColoredNumber.Text = "Окрашивать четные числа";
			this.cbColoredNumber.UseVisualStyleBackColor = true;
			// 
			// cbControlResult
			// 
			this.cbControlResult.AutoSize = true;
			this.cbControlResult.Checked = true;
			this.cbControlResult.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbControlResult.Location = new System.Drawing.Point(8, 96);
			this.cbControlResult.Name = "cbControlResult";
			this.cbControlResult.Size = new System.Drawing.Size(131, 17);
			this.cbControlResult.TabIndex = 6;
			this.cbControlResult.Text = "Измерять результат";
			this.cbControlResult.UseVisualStyleBackColor = true;
			// 
			// frmSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 176);
			this.Controls.Add(this.cbControlResult);
			this.Controls.Add(this.cbColoredNumber);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "frmSettings";
			this.Text = "Настройки";
			this.Load += new System.EventHandler(this.frmSettings_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tbSize)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar tbSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSetSettings;
        private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.CheckBox cbColoredNumber;
		private System.Windows.Forms.CheckBox cbControlResult;
	}
}