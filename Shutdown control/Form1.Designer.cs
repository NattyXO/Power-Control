namespace Shutdown_control
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnshutdown = new System.Windows.Forms.Button();
            this.btnlock = new System.Windows.Forms.Button();
            this.btnsleep = new System.Windows.Forms.Button();
            this.btnlogoff = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnrestart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.amharicToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(450, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(75, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(299, 39);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ሀይል መቆጣጠርያ ቁልፍ";
            // 
            // btnshutdown
            // 
            this.btnshutdown.BackColor = System.Drawing.Color.Red;
            this.btnshutdown.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnshutdown.FlatAppearance.BorderSize = 58;
            this.btnshutdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnshutdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnshutdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnshutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshutdown.Location = new System.Drawing.Point(64, 94);
            this.btnshutdown.Name = "btnshutdown";
            this.btnshutdown.Size = new System.Drawing.Size(50, 32);
            this.btnshutdown.TabIndex = 2;
            this.btnshutdown.Text = "ዝጋ";
            this.btnshutdown.UseVisualStyleBackColor = false;
            this.btnshutdown.Click += new System.EventHandler(this.btnshutdown_Click);
            // 
            // btnlock
            // 
            this.btnlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnlock.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnlock.FlatAppearance.BorderSize = 58;
            this.btnlock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnlock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnlock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlock.Location = new System.Drawing.Point(330, 94);
            this.btnlock.Name = "btnlock";
            this.btnlock.Size = new System.Drawing.Size(58, 32);
            this.btnlock.TabIndex = 3;
            this.btnlock.Text = "ቆልፍ";
            this.btnlock.UseVisualStyleBackColor = false;
            this.btnlock.Click += new System.EventHandler(this.btnlock_Click);
            // 
            // btnsleep
            // 
            this.btnsleep.BackColor = System.Drawing.Color.Fuchsia;
            this.btnsleep.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsleep.FlatAppearance.BorderSize = 58;
            this.btnsleep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnsleep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnsleep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsleep.Location = new System.Drawing.Point(64, 145);
            this.btnsleep.Name = "btnsleep";
            this.btnsleep.Size = new System.Drawing.Size(50, 32);
            this.btnsleep.TabIndex = 4;
            this.btnsleep.Text = "ተኛ";
            this.btnsleep.UseVisualStyleBackColor = false;
            this.btnsleep.Click += new System.EventHandler(this.btnsleep_Click);
            // 
            // btnlogoff
            // 
            this.btnlogoff.BackColor = System.Drawing.Color.Yellow;
            this.btnlogoff.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnlogoff.FlatAppearance.BorderSize = 58;
            this.btnlogoff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnlogoff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnlogoff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogoff.Location = new System.Drawing.Point(331, 145);
            this.btnlogoff.Name = "btnlogoff";
            this.btnlogoff.Size = new System.Drawing.Size(80, 32);
            this.btnlogoff.TabIndex = 5;
            this.btnlogoff.Text = "ሎግ ኦፍ";
            this.btnlogoff.UseVisualStyleBackColor = false;
            this.btnlogoff.Click += new System.EventHandler(this.btnlogoff_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(27, 145);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(294, 145);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(160, 94);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // btnrestart
            // 
            this.btnrestart.BackColor = System.Drawing.Color.Lime;
            this.btnrestart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnrestart.FlatAppearance.BorderSize = 58;
            this.btnrestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnrestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnrestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestart.Location = new System.Drawing.Point(197, 94);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(72, 32);
            this.btnrestart.TabIndex = 11;
            this.btnrestart.Text = "እንደገና ጀምር";
            this.btnrestart.UseVisualStyleBackColor = false;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(293, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem1,
            this.amharicToolStripMenuItem1});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem1
            // 
            this.englishToolStripMenuItem1.Name = "englishToolStripMenuItem1";
            this.englishToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.englishToolStripMenuItem1.Text = "English";
            this.englishToolStripMenuItem1.Click += new System.EventHandler(this.englishToolStripMenuItem1_Click);
            // 
            // amharicToolStripMenuItem1
            // 
            this.amharicToolStripMenuItem1.Name = "amharicToolStripMenuItem1";
            this.amharicToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.amharicToolStripMenuItem1.Text = "Amharic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(450, 192);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnlogoff);
            this.Controls.Add(this.btnsleep);
            this.Controls.Add(this.btnlock);
            this.Controls.Add(this.btnshutdown);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Control Key";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnshutdown;
        private System.Windows.Forms.Button btnlock;
        private System.Windows.Forms.Button btnsleep;
        private System.Windows.Forms.Button btnlogoff;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem amharicToolStripMenuItem1;
    }
}

