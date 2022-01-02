using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPickerCSharp
{
    public partial class Form1 : Form
    {
        private int R_val, G_val, B_val;

        public Form1()
        {
            this.R_val = 150;
            this.G_val = 150;
            this.B_val = 150;
            InitializeComponent();
            SetValue();

        }

        private void R_trackBar_Scroll(object sender, EventArgs e)
        {
            this.R_val = this.R_trackBar.Value;
            SetValue();
            setTextColor();
        }

        private void G_trackBar_Scroll(object sender, EventArgs e)
        {
            this.G_val = this.G_trackBar.Value;
            SetValue();
            setTextColor();
        }

        private void B_trackBar_Scroll(object sender, EventArgs e)
        {
            this.B_val = this.B_trackBar.Value;
            SetValue();
            setTextColor();
        }

        public void SetValue()
        {
            string s_rgb = "rgb(" + this.R_val + "," + this.G_val + "," + this.B_val + ")";
            this.rgb_text.Text = s_rgb;
            string s_hexa = "#" + toHexa(this.R_val, this.G_val, this.B_val);
            this.hexa_text.Text = s_hexa;
            this.BackColor = Color.FromArgb(this.R_val, this.G_val, this.B_val);
            this.label1.BackColor = Color.FromArgb(this.R_val, this.G_val, this.B_val);
            this.label2.BackColor = Color.FromArgb(this.R_val, this.G_val, this.B_val);
            this.label3.BackColor = Color.FromArgb(this.R_val, this.G_val, this.B_val);
            this.label4.BackColor = Color.FromArgb(this.R_val, this.G_val, this.B_val);
            this.label5.BackColor = Color.FromArgb(this.R_val, this.G_val, this.B_val);
            this.menuStrip1.BackColor = Color.FromArgb(this.R_val, this.G_val, this.B_val);
        }

        public void setTextColor()
        {
            if(this.B_val < 20 || this.R_val < 20 || this.G_val < 20)
            {
                this.label1.ForeColor = Color.White;
                this.label2.ForeColor = Color.White;
                this.label3.ForeColor = Color.White;
                this.label4.ForeColor = Color.White;
                this.label5.ForeColor = Color.White;
                this.menuStrip1.ForeColor = Color.White;
            }
            if (this.B_val > 240 || this.R_val > 240 || this.G_val > 240)
            {
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.label3.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label5.ForeColor = Color.Black;
                this.menuStrip1.ForeColor = Color.Black;
            }

        }

        private void button1_cp_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.rgb_text.Text);
            MessageBox.Show("value copied to the clipboard");
        }

        private void button2_cp_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.hexa_text.Text);
            MessageBox.Show("value copied to the clipboard");
        }

        private void menu_tile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on the color you want to get code");
        }

        private void menu_copy_rgb_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.rgb_text.Text);
            MessageBox.Show("value copied to the clipboard", "Success");
        }

        private void menu_copy_hex_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.hexa_text.Text);
            MessageBox.Show("value copied to the clipboard", "Success");
        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Color Picker \nDeveloped with C# \nVerison 1.1", "Info");
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by RHJA 01-11-2021", "Info");
        }

        public string toHexa(int r, int g, int b)
        {
            return decToHex(r) + decToHex(g) + decToHex(b);
        }

        public string decToHex(int dec)
        {
            string hexaDeciNum = "";
            int r = 0;
            r = dec % 16;
            string reste = "";
            if (r > 10)
            {
                string sr = "";
                switch (r)
                {
                    case 10:
                        sr = "A";
                        break;
                    case 11:
                        sr = "B";
                        break;
                    case 12:
                        sr = "C";
                        break;
                    case 13:
                        sr = "D";
                        break;
                    case 14:
                        sr = "E";
                        break;
                    case 15:
                        sr = "F";
                        break;
                    default:
                        break;
                }
                reste = sr;
            }
            else
            {
                reste = r.ToString();
            }
            double d = 0;
            d = dec / 16;
            double fd = Math.Floor(d);
            if (fd < 10)
            {
                hexaDeciNum = fd.ToString() + reste;
            }
            else
            {
                string s = "";
                switch (fd.ToString())
                {
                    case "10":
                        s = "A";
                        break;
                    case "11":
                        s = "B";
                        break;
                    case "12":
                        s = "C";
                        break;
                    case "13":
                        s = "D";
                        break;
                    case "14":
                        s = "E";
                        break;
                    case "15":
                        s = "F";
                        break;
                    default:
                        break;
                }
                hexaDeciNum = s + reste;
            }

            return hexaDeciNum;
        }
    }
}
