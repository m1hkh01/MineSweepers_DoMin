namespace DoMin
{
    partial class frmEasy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEasy));
            this.lblTime = new System.Windows.Forms.Label();
            this.lblFlag = new System.Windows.Forms.Label();
            this.lblGridCount = new System.Windows.Forms.Label();
            this.lblBomb = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(415, 51);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(98, 38);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "00:00";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblFlag
            // 
            this.lblFlag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFlag.AutoSize = true;
            this.lblFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlag.Location = new System.Drawing.Point(562, 51);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(35, 38);
            this.lblFlag.TabIndex = 8;
            this.lblFlag.Text = "0";
            this.lblFlag.Click += new System.EventHandler(this.lblFlag_Click);
            // 
            // lblGridCount
            // 
            this.lblGridCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGridCount.AutoSize = true;
            this.lblGridCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridCount.Location = new System.Drawing.Point(338, 51);
            this.lblGridCount.Name = "lblGridCount";
            this.lblGridCount.Size = new System.Drawing.Size(71, 38);
            this.lblGridCount.TabIndex = 9;
            this.lblGridCount.Text = "100";
            this.lblGridCount.Click += new System.EventHandler(this.lblGridCount_Click);
            // 
            // lblBomb
            // 
            this.lblBomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBomb.AutoSize = true;
            this.lblBomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBomb.Location = new System.Drawing.Point(526, 12);
            this.lblBomb.Name = "lblBomb";
            this.lblBomb.Size = new System.Drawing.Size(53, 38);
            this.lblBomb.TabIndex = 14;
            this.lblBomb.Text = "10";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(489, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = global::DoMin.Properties.Resources.reset1;
            this.btnReset.Location = new System.Drawing.Point(397, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(40, 40);
            this.btnReset.TabIndex = 12;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.Paint += new System.Windows.Forms.PaintEventHandler(this.btnReset_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(297, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(443, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(511, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // frmEasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(917, 616);
            this.Controls.Add(this.lblBomb);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGridCount);
            this.Controls.Add(this.lblFlag);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTime);
            this.Name = "frmEasy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEasy";
            this.Load += new System.EventHandler(this.frmEasy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.Label lblGridCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblBomb;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}