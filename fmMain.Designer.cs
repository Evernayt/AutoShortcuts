namespace AutoShortcuts
{
    partial class fmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblCurrentMonth = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pSettings = new System.Windows.Forms.Panel();
            this.lblMainFolder = new System.Windows.Forms.Label();
            this.tbxMainPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSelectMainPath = new System.Windows.Forms.Button();
            this.tbxMonthPath = new System.Windows.Forms.TextBox();
            this.btnSelectMonthPath = new System.Windows.Forms.Button();
            this.pMain = new System.Windows.Forms.Panel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pSettings.SuspendLayout();
            this.pMain.SuspendLayout();
            this.cmsNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(11, 59);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(275, 29);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Создать ярлыки вручную";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblCurrentMonth
            // 
            this.lblCurrentMonth.AutoSize = true;
            this.lblCurrentMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurrentMonth.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentMonth.Location = new System.Drawing.Point(7, 5);
            this.lblCurrentMonth.Name = "lblCurrentMonth";
            this.lblCurrentMonth.Size = new System.Drawing.Size(194, 28);
            this.lblCurrentMonth.TabIndex = 1;
            this.lblCurrentMonth.Text = "Месяц: не указано";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.White;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(292, 59);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(29, 29);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Location = new System.Drawing.Point(8, 33);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(190, 20);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Папка месяца: не указано";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // pSettings
            // 
            this.pSettings.Controls.Add(this.lblMainFolder);
            this.pSettings.Controls.Add(this.tbxMainPath);
            this.pSettings.Controls.Add(this.label1);
            this.pSettings.Controls.Add(this.btnSave);
            this.pSettings.Controls.Add(this.btnSelectMainPath);
            this.pSettings.Controls.Add(this.tbxMonthPath);
            this.pSettings.Controls.Add(this.btnSelectMonthPath);
            this.pSettings.Location = new System.Drawing.Point(0, 0);
            this.pSettings.Name = "pSettings";
            this.pSettings.Size = new System.Drawing.Size(333, 98);
            this.pSettings.TabIndex = 5;
            this.pSettings.Visible = false;
            // 
            // lblMainFolder
            // 
            this.lblMainFolder.AutoSize = true;
            this.lblMainFolder.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMainFolder.Location = new System.Drawing.Point(20, 6);
            this.lblMainFolder.Name = "lblMainFolder";
            this.lblMainFolder.Size = new System.Drawing.Size(105, 17);
            this.lblMainFolder.TabIndex = 7;
            this.lblMainFolder.Text = "Основная папка";
            // 
            // tbxMainPath
            // 
            this.tbxMainPath.BackColor = System.Drawing.Color.White;
            this.tbxMainPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMainPath.Location = new System.Drawing.Point(12, 19);
            this.tbxMainPath.Name = "tbxMainPath";
            this.tbxMainPath.ReadOnly = true;
            this.tbxMainPath.Size = new System.Drawing.Size(239, 27);
            this.tbxMainPath.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Папка месяца";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(292, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(29, 68);
            this.btnSave.TabIndex = 9;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelectMainPath
            // 
            this.btnSelectMainPath.BackColor = System.Drawing.Color.White;
            this.btnSelectMainPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectMainPath.ForeColor = System.Drawing.Color.Black;
            this.btnSelectMainPath.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectMainPath.Image")));
            this.btnSelectMainPath.Location = new System.Drawing.Point(257, 19);
            this.btnSelectMainPath.Name = "btnSelectMainPath";
            this.btnSelectMainPath.Size = new System.Drawing.Size(29, 27);
            this.btnSelectMainPath.TabIndex = 9;
            this.btnSelectMainPath.UseVisualStyleBackColor = false;
            this.btnSelectMainPath.Click += new System.EventHandler(this.btnSelectMainPath_Click);
            // 
            // tbxMonthPath
            // 
            this.tbxMonthPath.BackColor = System.Drawing.Color.White;
            this.tbxMonthPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMonthPath.Location = new System.Drawing.Point(12, 60);
            this.tbxMonthPath.Name = "tbxMonthPath";
            this.tbxMonthPath.ReadOnly = true;
            this.tbxMonthPath.Size = new System.Drawing.Size(239, 27);
            this.tbxMonthPath.TabIndex = 11;
            // 
            // btnSelectMonthPath
            // 
            this.btnSelectMonthPath.BackColor = System.Drawing.Color.White;
            this.btnSelectMonthPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectMonthPath.ForeColor = System.Drawing.Color.Black;
            this.btnSelectMonthPath.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectMonthPath.Image")));
            this.btnSelectMonthPath.Location = new System.Drawing.Point(257, 60);
            this.btnSelectMonthPath.Name = "btnSelectMonthPath";
            this.btnSelectMonthPath.Size = new System.Drawing.Size(29, 27);
            this.btnSelectMonthPath.TabIndex = 12;
            this.btnSelectMonthPath.UseVisualStyleBackColor = false;
            this.btnSelectMonthPath.Click += new System.EventHandler(this.btnSelectMonthPath_Click);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.btnCreate);
            this.pMain.Controls.Add(this.lblInfo);
            this.pMain.Controls.Add(this.btnSettings);
            this.pMain.Controls.Add(this.lblCurrentMonth);
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(333, 98);
            this.pMain.TabIndex = 13;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.cmsNotify;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Auto Shortcuts";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // cmsNotify
            // 
            this.cmsNotify.BackColor = System.Drawing.Color.White;
            this.cmsNotify.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.autorunToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.cmsNotify.Name = "cmsNotify";
            this.cmsNotify.ShowImageMargin = false;
            this.cmsNotify.Size = new System.Drawing.Size(163, 82);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.showToolStripMenuItem.Text = "Показать";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // autorunToolStripMenuItem
            // 
            this.autorunToolStripMenuItem.Name = "autorunToolStripMenuItem";
            this.autorunToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.autorunToolStripMenuItem.Text = "Автозапуск: Вкл";
            this.autorunToolStripMenuItem.Click += new System.EventHandler(this.autorunToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.closeToolStripMenuItem.Text = "Выход";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 99);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pSettings);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Auto Shortcuts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            this.pSettings.ResumeLayout(false);
            this.pSettings.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.cmsNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblCurrentMonth;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMainFolder;
        private System.Windows.Forms.TextBox tbxMonthPath;
        private System.Windows.Forms.TextBox tbxMainPath;
        private System.Windows.Forms.Button btnSelectMonthPath;
        private System.Windows.Forms.Button btnSelectMainPath;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip cmsNotify;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorunToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}