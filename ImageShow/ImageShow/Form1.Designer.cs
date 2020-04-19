namespace ImageShow
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.灰色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑白ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.变暗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.马赛克ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.毛玻璃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平翻转ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直翻转ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(137, 28);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(137, 28);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(137, 28);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.灰色ToolStripMenuItem,
            this.反色ToolStripMenuItem,
            this.黑白ToolStripMenuItem,
            this.变暗ToolStripMenuItem,
            this.马赛克ToolStripMenuItem,
            this.毛玻璃ToolStripMenuItem,
            this.水平翻转ToolStripMenuItem,
            this.垂直翻转ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.编辑ToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 灰色ToolStripMenuItem
            // 
            this.灰色ToolStripMenuItem.Name = "灰色ToolStripMenuItem";
            this.灰色ToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
            this.灰色ToolStripMenuItem.Text = "灰色";
            this.灰色ToolStripMenuItem.Click += new System.EventHandler(this.灰色ToolStripMenuItem_Click);
            // 
            // 反色ToolStripMenuItem
            // 
            this.反色ToolStripMenuItem.Name = "反色ToolStripMenuItem";
            this.反色ToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
            this.反色ToolStripMenuItem.Text = "反色";
            this.反色ToolStripMenuItem.Click += new System.EventHandler(this.反色ToolStripMenuItem_Click);
            // 
            // 黑白ToolStripMenuItem
            // 
            this.黑白ToolStripMenuItem.Name = "黑白ToolStripMenuItem";
            this.黑白ToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
            this.黑白ToolStripMenuItem.Text = "黑白";
            this.黑白ToolStripMenuItem.Click += new System.EventHandler(this.黑白ToolStripMenuItem_Click);
            // 
            // 变暗ToolStripMenuItem
            // 
            this.变暗ToolStripMenuItem.Name = "变暗ToolStripMenuItem";
            this.变暗ToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
            this.变暗ToolStripMenuItem.Text = "变暗";
            this.变暗ToolStripMenuItem.Click += new System.EventHandler(this.变暗ToolStripMenuItem_Click);
            // 
            // 马赛克ToolStripMenuItem
            // 
            this.马赛克ToolStripMenuItem.Name = "马赛克ToolStripMenuItem";
            this.马赛克ToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
            this.马赛克ToolStripMenuItem.Text = "马赛克";
            this.马赛克ToolStripMenuItem.Click += new System.EventHandler(this.马赛克ToolStripMenuItem_Click);
            // 
            // 毛玻璃ToolStripMenuItem
            // 
            this.毛玻璃ToolStripMenuItem.Name = "毛玻璃ToolStripMenuItem";
            this.毛玻璃ToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
            this.毛玻璃ToolStripMenuItem.Text = "毛玻璃";
            this.毛玻璃ToolStripMenuItem.Click += new System.EventHandler(this.毛玻璃ToolStripMenuItem_Click);
            // 
            // 水平翻转ToolStripMenuItem
            // 
            this.水平翻转ToolStripMenuItem.Name = "水平翻转ToolStripMenuItem";
            this.水平翻转ToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
            this.水平翻转ToolStripMenuItem.Text = "水平翻转";
            this.水平翻转ToolStripMenuItem.Click += new System.EventHandler(this.水平翻转ToolStripMenuItem_Click);
            // 
            // 垂直翻转ToolStripMenuItem
            // 
            this.垂直翻转ToolStripMenuItem.Name = "垂直翻转ToolStripMenuItem";
            this.垂直翻转ToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
            this.垂直翻转ToolStripMenuItem.Text = "垂直翻转";
            this.垂直翻转ToolStripMenuItem.Click += new System.EventHandler(this.垂直翻转ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 414);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(420, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(380, 414);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "图像展示";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 灰色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黑白ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 变暗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 马赛克ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平翻转ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直翻转ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 毛玻璃ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

