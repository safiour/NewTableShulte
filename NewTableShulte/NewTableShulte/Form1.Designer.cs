namespace NewTableShulte
{
	partial class FRM_MainForm
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
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_Settings = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_NewTable = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_Users = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_NewUser = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.TSMI_ChangeUser = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_LastUser1 = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_LastUser2 = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_LastUser3 = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_Results = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.TSMI_NewTable,
            this.TSMI_Users});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(377, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Settings,
            this.TSMI_Results,
            this.toolStripMenuItem1,
            this.TSMI_Exit});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
			// 
			// TSMI_Exit
			// 
			this.TSMI_Exit.Name = "TSMI_Exit";
			this.TSMI_Exit.Size = new System.Drawing.Size(152, 22);
			this.TSMI_Exit.Text = "Выход";
			this.TSMI_Exit.Click += new System.EventHandler(this.TSMI_Exit_Click);
			// 
			// TSMI_Settings
			// 
			this.TSMI_Settings.Name = "TSMI_Settings";
			this.TSMI_Settings.Size = new System.Drawing.Size(152, 22);
			this.TSMI_Settings.Text = "Настройки...";
			// 
			// TSMI_NewTable
			// 
			this.TSMI_NewTable.Name = "TSMI_NewTable";
			this.TSMI_NewTable.Size = new System.Drawing.Size(101, 20);
			this.TSMI_NewTable.Text = "Новая таблица";
			// 
			// TSMI_Users
			// 
			this.TSMI_Users.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_NewUser,
            this.TSMI_ChangeUser,
            this.toolStripMenuItem2,
            this.TSMI_LastUser1,
            this.TSMI_LastUser2,
            this.TSMI_LastUser3});
			this.TSMI_Users.Name = "TSMI_Users";
			this.TSMI_Users.Size = new System.Drawing.Size(60, 20);
			this.TSMI_Users.Text = "Игроки";
			// 
			// TSMI_NewUser
			// 
			this.TSMI_NewUser.Name = "TSMI_NewUser";
			this.TSMI_NewUser.Size = new System.Drawing.Size(171, 22);
			this.TSMI_NewUser.Text = "Новый игрок...";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 6);
			// 
			// TSMI_ChangeUser
			// 
			this.TSMI_ChangeUser.Name = "TSMI_ChangeUser";
			this.TSMI_ChangeUser.Size = new System.Drawing.Size(171, 22);
			this.TSMI_ChangeUser.Text = "Выбрать игрока...";
			// 
			// TSMI_LastUser1
			// 
			this.TSMI_LastUser1.Name = "TSMI_LastUser1";
			this.TSMI_LastUser1.Size = new System.Drawing.Size(171, 22);
			this.TSMI_LastUser1.Text = "1.";
			// 
			// TSMI_LastUser2
			// 
			this.TSMI_LastUser2.Name = "TSMI_LastUser2";
			this.TSMI_LastUser2.Size = new System.Drawing.Size(171, 22);
			this.TSMI_LastUser2.Text = "2.";
			// 
			// TSMI_LastUser3
			// 
			this.TSMI_LastUser3.Name = "TSMI_LastUser3";
			this.TSMI_LastUser3.Size = new System.Drawing.Size(171, 22);
			this.TSMI_LastUser3.Text = "3.";
			// 
			// TSMI_Results
			// 
			this.TSMI_Results.Name = "TSMI_Results";
			this.TSMI_Results.Size = new System.Drawing.Size(152, 22);
			this.TSMI_Results.Text = "Результаты...";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 320);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(377, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(377, 296);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// FRM_MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 342);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FRM_MainForm";
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
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem TSMI_Exit;
		private System.Windows.Forms.ToolStripMenuItem TSMI_Settings;
		private System.Windows.Forms.ToolStripMenuItem TSMI_NewTable;
		private System.Windows.Forms.ToolStripMenuItem TSMI_Users;
		private System.Windows.Forms.ToolStripMenuItem TSMI_NewUser;
		private System.Windows.Forms.ToolStripMenuItem TSMI_ChangeUser;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem TSMI_LastUser1;
		private System.Windows.Forms.ToolStripMenuItem TSMI_LastUser2;
		private System.Windows.Forms.ToolStripMenuItem TSMI_LastUser3;
		private System.Windows.Forms.ToolStripMenuItem TSMI_Results;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}

