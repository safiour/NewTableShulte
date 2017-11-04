namespace TableShurle
{
    partial class frmMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsmuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNewTable = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpTableShulte = new System.Windows.Forms.TableLayoutPanel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsslTimer = new System.Windows.Forms.ToolStripStatusLabel();
			this.tspbProgress = new System.Windows.Forms.ToolStripProgressBar();
			this.tsslLastNumber = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmuMainMenu,
            this.tsmiNewTable});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.ShowItemToolTips = true;
			this.menuStrip1.Size = new System.Drawing.Size(290, 24);
			this.menuStrip1.Stretch = false;
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsmuMainMenu
			// 
			this.tsmuMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSettings,
            this.toolStripMenuItem2,
            this.tsmiExit});
			this.tsmuMainMenu.Name = "tsmuMainMenu";
			this.tsmuMainMenu.Size = new System.Drawing.Size(53, 20);
			this.tsmuMainMenu.Text = "Меню";
			// 
			// tsmiSettings
			// 
			this.tsmiSettings.Name = "tsmiSettings";
			this.tsmiSettings.Size = new System.Drawing.Size(143, 22);
			this.tsmiSettings.Text = "Настройки...";
			this.tsmiSettings.Click += new System.EventHandler(this.tsmiSettings_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(140, 6);
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(143, 22);
			this.tsmiExit.Text = "Выход";
			this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// tsmiNewTable
			// 
			this.tsmiNewTable.Name = "tsmiNewTable";
			this.tsmiNewTable.Size = new System.Drawing.Size(101, 20);
			this.tsmiNewTable.Text = "Новая таблица";
			this.tsmiNewTable.Click += new System.EventHandler(this.tsmiNewTable_Click);
			// 
			// tlpTableShulte
			// 
			this.tlpTableShulte.AutoSize = true;
			this.tlpTableShulte.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tlpTableShulte.ColumnCount = 1;
			this.tlpTableShulte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tlpTableShulte.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpTableShulte.Location = new System.Drawing.Point(0, 24);
			this.tlpTableShulte.Name = "tlpTableShulte";
			this.tlpTableShulte.RowCount = 1;
			this.tlpTableShulte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tlpTableShulte.Size = new System.Drawing.Size(290, 133);
			this.tlpTableShulte.TabIndex = 1;
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTimer,
            this.tspbProgress,
            this.tsslLastNumber});
			this.statusStrip1.Location = new System.Drawing.Point(0, 157);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(290, 22);
			this.statusStrip1.TabIndex = 2;
			// 
			// tsslTimer
			// 
			this.tsslTimer.Name = "tsslTimer";
			this.tsslTimer.Size = new System.Drawing.Size(50, 17);
			this.tsslTimer.Text = "t 0:00:00";
			// 
			// tspbProgress
			// 
			this.tspbProgress.Name = "tspbProgress";
			this.tspbProgress.Size = new System.Drawing.Size(100, 16);
			// 
			// tsslLastNumber
			// 
			this.tsslLastNumber.Name = "tsslLastNumber";
			this.tsslLastNumber.Size = new System.Drawing.Size(54, 17);
			this.tsslLastNumber.Text = "Ищем: 0";
			// 
			// frmMainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(290, 179);
			this.Controls.Add(this.tlpTableShulte);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.statusStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "frmMainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Таблица Шульте";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewTable;
        private System.Windows.Forms.TableLayoutPanel tlpTableShulte;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsslTimer;
		private System.Windows.Forms.ToolStripProgressBar tspbProgress;
		private System.Windows.Forms.ToolStripStatusLabel tsslLastNumber;
	}
}

