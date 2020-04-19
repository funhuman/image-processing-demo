using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageShow
{
    public partial class Form1 : Form
    {
        Bitmap img1, img2;
        Color color, colorNew;
        bool isSave = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            灰色ToolStripMenuItem.Enabled = false;
            反色ToolStripMenuItem.Enabled = false;
            黑白ToolStripMenuItem.Enabled = false;
            变暗ToolStripMenuItem.Enabled = false;
            马赛克ToolStripMenuItem.Enabled = false;
            毛玻璃ToolStripMenuItem.Enabled = false;
            水平翻转ToolStripMenuItem.Enabled = false;
            垂直翻转ToolStripMenuItem.Enabled = false;
            另存为ToolStripMenuItem.Enabled = false;
        }
        // 文件方法
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    img1 = new Bitmap(ofd.FileName);
                    img2 = new Bitmap(ofd.FileName);
                }
                catch (ArgumentException)
                {
                    打开ToolStripMenuItem_Click(sender, e);
                }
            }
            if (img1 != null)
            {
                灰色ToolStripMenuItem.Enabled = true;
                反色ToolStripMenuItem.Enabled = true;
                黑白ToolStripMenuItem.Enabled = true;
                变暗ToolStripMenuItem.Enabled = true;
                马赛克ToolStripMenuItem.Enabled = true;
                毛玻璃ToolStripMenuItem.Enabled = true;
                水平翻转ToolStripMenuItem.Enabled = true;
                垂直翻转ToolStripMenuItem.Enabled = true;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // 点击图片框1时调用打开图片方法
            打开ToolStripMenuItem_Click(sender, e);
        }
        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSave == true)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Image files|*.jpg;*.jpeg;*.png";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    img2.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // 点击图片框2时调用打开另存为方法
            另存为ToolStripMenuItem_Click(sender, e);
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        // 编辑方法
        // 灰色 R/G/B -> avg(R,G,B)/avg(R,G,B)/avg(R,G,B)
        private void 灰色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    color = img1.GetPixel(i, j);
                    // 方法 1
                    int c = (color.R + color.G + color.B) / 3;
                    // 方法 2
                    // int c = (int)(0.3 * color.R + 0.59 * color.G + 0.11 * color.B) / 3;
                    colorNew = Color.FromArgb(c, c, c);
                    img2.SetPixel(i, j, colorNew);
                }
            }
            // 显示修改后的图形，下同
            Save();
        }
        // 反色 R/G/B -> 255-R/255-G/255-B
        private void 反色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cr, cg, cb;
            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    color = img1.GetPixel(i, j);
                    cr = 0xFF - color.R;
                    cg = 0xFF - color.G;
                    cb = 0xFF - color.B;
                    colorNew = Color.FromArgb(cr, cg, cb);
                    img2.SetPixel(i, j, colorNew);
                }
            }
            Save();
        }
        // 黑白 RGB之和大于128为黑点，反之为白点
        private void 黑白ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c;
            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    color = img1.GetPixel(i, j);
                    if (((color.R + color.G + color.B) / 3) < 128)
                    {
                        c = 0;
                    }
                    else
                    {
                        c = 255;
                    }
                    colorNew = Color.FromArgb(c, c, c);
                    img2.SetPixel(i, j, colorNew);
                }
            }
            Save();
        }
        // 变暗 R/G/B -> 0.6*R/0.6*G/0.6*B
        private void 变暗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cr, cg, cb;
            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    color = img1.GetPixel(i, j);
                    cr = (int)(0.6 * color.R);
                    cg = (int)(0.6 * color.G);
                    cb = (int)(0.6 * color.B);
                    colorNew = Color.FromArgb(cr, cg, cb);
                    img2.SetPixel(i, j, colorNew);
                }
            }
            Save();
        }
        private void 马赛克ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MOSAIC_SIZE = 7;
            int cr, cg, cb, count;
            for (int i = 0; i < pictureBox1.Image.Width; i += MOSAIC_SIZE)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j += MOSAIC_SIZE)
                {
                    count = cr = cg = cb = 0;
                    for (int m = i; m < i + MOSAIC_SIZE
                        && m < pictureBox1.Image.Width; m++)
                    {
                        for (int n = j; n < j + MOSAIC_SIZE
                            && n < pictureBox1.Image.Height; n++)
                        {
                            color = img1.GetPixel(m, n);
                            cr += color.R;
                            cg += color.G;
                            cb += color.B;
                            count++;
                        }
                    }
                    cr = cr / count;
                    cg = cg / count;
                    cb = cb / count;
                    for (int m = i; m < i + MOSAIC_SIZE
                        && m < pictureBox1.Image.Width; m++)
                    {
                        for (int n = j; n < j + MOSAIC_SIZE
                            && n < pictureBox1.Image.Height; n++)
                        {
                            colorNew = Color.FromArgb(cr, cg, cb);
                            img2.SetPixel(m, n, colorNew);
                        }
                    }
                }
            }
            Save();
        }
        private void 毛玻璃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int GRASS_SIZE = 3;
            int cr, cg, cb, count;
            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    count = cr = cg = cb = 0;
                    for (int m = i; m < i + GRASS_SIZE
                        && m < pictureBox1.Image.Width; m++)
                    {
                        for (int n = j; n < j + GRASS_SIZE
                            && n < pictureBox1.Image.Height; n++)
                        {
                            color = img1.GetPixel(m, n);
                            cr += color.R;
                            cg += color.G;
                            cb += color.B;
                            count++;
                        }
                    }
                    cr = cr / count;
                    cg = cg / count;
                    cb = cb / count;
                    colorNew = Color.FromArgb(cr, cg, cb);
                    img2.SetPixel(i, j, colorNew);
                }
            }
            Save();
        }
        private void 水平翻转ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    color = img1.GetPixel(pictureBox1.Image.Width - i - 1, j);
                    img2.SetPixel(i, j, color);
                }
            }
            Save();
        }
        private void 垂直翻转ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    color = img1.GetPixel(i, pictureBox1.Image.Height - j - 1);
                    img2.SetPixel(i, j, color);
                }
            }
            Save();
        }
        // 生成图片
        private void Save()
        {
            isSave = true;
            pictureBox2.Image = img2;
            另存为ToolStripMenuItem.Enabled = true;
        }
    }
}
