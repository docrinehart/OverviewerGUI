namespace OverviewerGUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.pROGRAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsMain = new System.Windows.Forms.TabControl();
            this.tabPage_Basic = new System.Windows.Forms.TabPage();
            this.tabPage_Dynamic = new System.Windows.Forms.TabPage();
            this.txtConfigDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.txtSourceDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.tabsMain.SuspendLayout();
            this.tabPage_Basic.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(469, 376);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(103, 23);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Start Rendering";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(364, 376);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close GUI";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROGRAMToolStripMenuItem,
            this.hELPToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(584, 24);
            this.MainMenu.TabIndex = 8;
            this.MainMenu.Text = "menuStrip1";
            // 
            // pROGRAMToolStripMenuItem
            // 
            this.pROGRAMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.pROGRAMToolStripMenuItem.Name = "pROGRAMToolStripMenuItem";
            this.pROGRAMToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.pROGRAMToolStripMenuItem.Text = "PROGRAM";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hELPToolStripMenuItem.Text = "HELP";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            this.documentationToolStripMenuItem.Click += new System.EventHandler(this.documentationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabsMain
            // 
            this.tabsMain.Controls.Add(this.tabPage_Basic);
            this.tabsMain.Controls.Add(this.tabPage_Dynamic);
            this.tabsMain.Location = new System.Drawing.Point(12, 27);
            this.tabsMain.Name = "tabsMain";
            this.tabsMain.SelectedIndex = 0;
            this.tabsMain.Size = new System.Drawing.Size(560, 343);
            this.tabsMain.TabIndex = 9;
            // 
            // tabPage_Basic
            // 
            this.tabPage_Basic.Controls.Add(this.txtConfigDir);
            this.tabPage_Basic.Controls.Add(this.label3);
            this.tabPage_Basic.Controls.Add(this.txtOutputDir);
            this.tabPage_Basic.Controls.Add(this.txtSourceDir);
            this.tabPage_Basic.Controls.Add(this.label2);
            this.tabPage_Basic.Controls.Add(this.label1);
            this.tabPage_Basic.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Basic.Name = "tabPage_Basic";
            this.tabPage_Basic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Basic.Size = new System.Drawing.Size(552, 317);
            this.tabPage_Basic.TabIndex = 0;
            this.tabPage_Basic.Text = "BASIC";
            this.tabPage_Basic.UseVisualStyleBackColor = true;
            // 
            // tabPage_Dynamic
            // 
            this.tabPage_Dynamic.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Dynamic.Name = "tabPage_Dynamic";
            this.tabPage_Dynamic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Dynamic.Size = new System.Drawing.Size(528, 309);
            this.tabPage_Dynamic.TabIndex = 1;
            this.tabPage_Dynamic.Text = "DYNAMIC";
            this.tabPage_Dynamic.UseVisualStyleBackColor = true;
            // 
            // txtConfigDir
            // 
            this.txtConfigDir.Location = new System.Drawing.Point(104, 178);
            this.txtConfigDir.Name = "txtConfigDir";
            this.txtConfigDir.Size = new System.Drawing.Size(406, 20);
            this.txtConfigDir.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Config File";
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Location = new System.Drawing.Point(104, 76);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.Size = new System.Drawing.Size(406, 20);
            this.txtOutputDir.TabIndex = 11;
            // 
            // txtSourceDir
            // 
            this.txtSourceDir.Location = new System.Drawing.Point(104, 50);
            this.txtSourceDir.Name = "txtSourceDir";
            this.txtSourceDir.Size = new System.Drawing.Size(406, 20);
            this.txtSourceDir.TabIndex = 10;
            this.txtSourceDir.Text = "%appdata%\\.minecraft\\saves\\<single-player-world-name>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Output Directory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Source Directory";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.tabsMain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overviewer GUI";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.tabsMain.ResumeLayout(false);
            this.tabPage_Basic.ResumeLayout(false);
            this.tabPage_Basic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem pROGRAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabsMain;
        private System.Windows.Forms.TabPage tabPage_Basic;
        private System.Windows.Forms.TextBox txtConfigDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutputDir;
        private System.Windows.Forms.TextBox txtSourceDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_Dynamic;
    }
}

