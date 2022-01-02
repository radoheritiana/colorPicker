namespace ColorPickerCSharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.R_trackBar = new System.Windows.Forms.TrackBar();
            this.G_trackBar = new System.Windows.Forms.TrackBar();
            this.B_trackBar = new System.Windows.Forms.TrackBar();
            this.rgb_text = new System.Windows.Forms.TextBox();
            this.hexa_text = new System.Windows.Forms.TextBox();
            this.button1_cp = new System.Windows.Forms.Button();
            this.button2_cp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_copy_rgb = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_copy_hex = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.R_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_trackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("NSimSun", 16F);
            this.label1.Location = new System.Drawing.Point(63, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("NSimSun", 16F);
            this.label2.Location = new System.Drawing.Point(63, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("NSimSun", 16F);
            this.label3.Location = new System.Drawing.Point(63, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "B";
            // 
            // R_trackBar
            // 
            this.R_trackBar.BackColor = System.Drawing.SystemColors.Control;
            this.R_trackBar.Location = new System.Drawing.Point(108, 33);
            this.R_trackBar.Maximum = 255;
            this.R_trackBar.Name = "R_trackBar";
            this.R_trackBar.Size = new System.Drawing.Size(232, 45);
            this.R_trackBar.TabIndex = 3;
            this.R_trackBar.Value = 150;
            this.R_trackBar.Scroll += new System.EventHandler(this.R_trackBar_Scroll);
            // 
            // G_trackBar
            // 
            this.G_trackBar.BackColor = System.Drawing.SystemColors.Control;
            this.G_trackBar.Location = new System.Drawing.Point(108, 110);
            this.G_trackBar.Maximum = 255;
            this.G_trackBar.Name = "G_trackBar";
            this.G_trackBar.Size = new System.Drawing.Size(232, 45);
            this.G_trackBar.TabIndex = 4;
            this.G_trackBar.Value = 150;
            this.G_trackBar.Scroll += new System.EventHandler(this.G_trackBar_Scroll);
            // 
            // B_trackBar
            // 
            this.B_trackBar.BackColor = System.Drawing.SystemColors.Control;
            this.B_trackBar.Location = new System.Drawing.Point(108, 190);
            this.B_trackBar.Maximum = 255;
            this.B_trackBar.Name = "B_trackBar";
            this.B_trackBar.Size = new System.Drawing.Size(232, 45);
            this.B_trackBar.TabIndex = 5;
            this.B_trackBar.Value = 150;
            this.B_trackBar.Scroll += new System.EventHandler(this.B_trackBar_Scroll);
            // 
            // rgb_text
            // 
            this.rgb_text.Enabled = false;
            this.rgb_text.Font = new System.Drawing.Font("NSimSun", 11F);
            this.rgb_text.Location = new System.Drawing.Point(359, 74);
            this.rgb_text.Name = "rgb_text";
            this.rgb_text.Size = new System.Drawing.Size(137, 24);
            this.rgb_text.TabIndex = 6;
            this.rgb_text.Text = "rgb(0, 0, 0)";
            // 
            // hexa_text
            // 
            this.hexa_text.Enabled = false;
            this.hexa_text.Location = new System.Drawing.Point(359, 153);
            this.hexa_text.Name = "hexa_text";
            this.hexa_text.Size = new System.Drawing.Size(137, 26);
            this.hexa_text.TabIndex = 7;
            this.hexa_text.Text = "#000000";
            // 
            // button1_cp
            // 
            this.button1_cp.Location = new System.Drawing.Point(502, 74);
            this.button1_cp.Name = "button1_cp";
            this.button1_cp.Size = new System.Drawing.Size(75, 26);
            this.button1_cp.TabIndex = 8;
            this.button1_cp.Text = "Copy";
            this.button1_cp.UseVisualStyleBackColor = true;
            this.button1_cp.Click += new System.EventHandler(this.button1_cp_Click);
            // 
            // button2_cp
            // 
            this.button2_cp.Location = new System.Drawing.Point(502, 153);
            this.button2_cp.Name = "button2_cp";
            this.button2_cp.Size = new System.Drawing.Size(75, 26);
            this.button2_cp.TabIndex = 9;
            this.button2_cp.Text = "Copy";
            this.button2_cp.UseVisualStyleBackColor = true;
            this.button2_cp.Click += new System.EventHandler(this.button2_cp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(356, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "RGB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(356, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hexadecimal";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_tile,
            this.menu_copy_rgb,
            this.menu_copy_hex,
            this.menu_exit});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // menu_tile
            // 
            this.menu_tile.Name = "menu_tile";
            this.menu_tile.Size = new System.Drawing.Size(124, 22);
            this.menu_tile.Text = "Tile";
            this.menu_tile.Click += new System.EventHandler(this.menu_tile_Click);
            // 
            // menu_copy_rgb
            // 
            this.menu_copy_rgb.Name = "menu_copy_rgb";
            this.menu_copy_rgb.Size = new System.Drawing.Size(124, 22);
            this.menu_copy_rgb.Text = "Copy rgb";
            this.menu_copy_rgb.Click += new System.EventHandler(this.menu_copy_rgb_Click);
            // 
            // menu_copy_hex
            // 
            this.menu_copy_hex.Name = "menu_copy_hex";
            this.menu_copy_hex.Size = new System.Drawing.Size(124, 22);
            this.menu_copy_hex.Text = "Copy hex";
            this.menu_copy_hex.Click += new System.EventHandler(this.menu_copy_hex_Click);
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(124, 22);
            this.menu_exit.Text = "Exit";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.creditToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.creditToolStripMenuItem.Text = "Credit";
            this.creditToolStripMenuItem.Click += new System.EventHandler(this.creditToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 257);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2_cp);
            this.Controls.Add(this.button1_cp);
            this.Controls.Add(this.hexa_text);
            this.Controls.Add(this.rgb_text);
            this.Controls.Add(this.B_trackBar);
            this.Controls.Add(this.G_trackBar);
            this.Controls.Add(this.R_trackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 200);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.R_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_trackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar R_trackBar;
        private System.Windows.Forms.TrackBar G_trackBar;
        private System.Windows.Forms.TrackBar B_trackBar;
        private System.Windows.Forms.TextBox rgb_text;
        private System.Windows.Forms.TextBox hexa_text;
        private System.Windows.Forms.Button button1_cp;
        private System.Windows.Forms.Button button2_cp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_tile;
        private System.Windows.Forms.ToolStripMenuItem menu_copy_rgb;
        private System.Windows.Forms.ToolStripMenuItem menu_copy_hex;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
    }
}

