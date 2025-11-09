namespace DoMin
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGameMode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEasy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLightMode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDarkMode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHow = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHome,
            this.mnuGameMode,
            this.mnuView,
            this.mnuThoat,
            this.mnuHow,
            this.musicToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // mnuHome
            // 
            this.mnuHome.Image = global::DoMin.Properties.Resources.home;
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(84, 24);
            this.mnuHome.Text = "Home";
            this.mnuHome.Click += new System.EventHandler(this.mnuHome_Click);
            // 
            // mnuGameMode
            // 
            this.mnuGameMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEasy,
            this.mnuMedium,
            this.mnuHard});
            this.mnuGameMode.Image = ((System.Drawing.Image)(resources.GetObject("mnuGameMode.Image")));
            this.mnuGameMode.Name = "mnuGameMode";
            this.mnuGameMode.Size = new System.Drawing.Size(121, 24);
            this.mnuGameMode.Text = "GameMode";
            this.mnuGameMode.Click += new System.EventHandler(this.mnuGameMode_Click);
            // 
            // mnuEasy
            // 
            this.mnuEasy.Name = "mnuEasy";
            this.mnuEasy.Size = new System.Drawing.Size(147, 26);
            this.mnuEasy.Text = "Easy";
            this.mnuEasy.Click += new System.EventHandler(this.mnuEasy_Click);
            // 
            // mnuMedium
            // 
            this.mnuMedium.Name = "mnuMedium";
            this.mnuMedium.Size = new System.Drawing.Size(147, 26);
            this.mnuMedium.Text = "Medium";
            this.mnuMedium.Click += new System.EventHandler(this.mnuMedium_Click);
            // 
            // mnuHard
            // 
            this.mnuHard.Name = "mnuHard";
            this.mnuHard.Size = new System.Drawing.Size(147, 26);
            this.mnuHard.Text = "Hard";
            this.mnuHard.Click += new System.EventHandler(this.mnuHard_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLightMode,
            this.mnuDarkMode});
            this.mnuView.Image = global::DoMin.Properties.Resources.show_1_;
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(75, 24);
            this.mnuView.Text = "View";
            this.mnuView.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuLightMode
            // 
            this.mnuLightMode.Enabled = false;
            this.mnuLightMode.Name = "mnuLightMode";
            this.mnuLightMode.Size = new System.Drawing.Size(168, 26);
            this.mnuLightMode.Text = "Light Mode";
            this.mnuLightMode.Click += new System.EventHandler(this.mnuLightMode_Click);
            // 
            // mnuDarkMode
            // 
            this.mnuDarkMode.Name = "mnuDarkMode";
            this.mnuDarkMode.Size = new System.Drawing.Size(168, 26);
            this.mnuDarkMode.Text = "Dark Mode";
            this.mnuDarkMode.Click += new System.EventHandler(this.mnuDarkMode_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = ((System.Drawing.Image)(resources.GetObject("mnuThoat.Image")));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(67, 24);
            this.mnuThoat.Text = "Exit";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuHow
            // 
            this.mnuHow.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuHow.Image = global::DoMin.Properties.Resources.question_sign;
            this.mnuHow.Name = "mnuHow";
            this.mnuHow.Size = new System.Drawing.Size(94, 24);
            this.mnuHow.Text = "Tutorial";
            this.mnuHow.Click += new System.EventHandler(this.mnuHow_Click);
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.musicToolStripMenuItem.Image = global::DoMin.Properties.Resources.music;
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.musicToolStripMenuItem.Text = "Music";
            this.musicToolStripMenuItem.Click += new System.EventHandler(this.musicToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::DoMin.Properties.Resources.anh_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dò Mìn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Click += new System.EventHandler(this.frmMain_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuGameMode;
        private System.Windows.Forms.ToolStripMenuItem mnuEasy;
        private System.Windows.Forms.ToolStripMenuItem mnuMedium;
        private System.Windows.Forms.ToolStripMenuItem mnuHard;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuLightMode;
        private System.Windows.Forms.ToolStripMenuItem mnuDarkMode;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem mnuHow;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
    }
}