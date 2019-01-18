using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Run_In_Rain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Double p = Convert.ToDouble(this.textBox1.Text);
            Double D = Convert.ToDouble(this.textBox2.Text);
            Double h = Convert.ToDouble(this.textBox3.Text);
            Double R = Convert.ToDouble(this.textBox4.Text);
            Double rx = Convert.ToDouble(this.textBox5.Text);
            Double ry = Convert.ToDouble(this.textBox6.Text);
            Double rz = Convert.ToDouble(this.textBox7.Text);
            Double pi = 3.1415926;

            this.textBox8.Text = (Math.Sqrt(rx * rx + ry * ry + rz * rz)).ToString(".00");
            if (ry <= 0)
            {
                this.textBox9.Text = "  你应当尽量快地奔跑，假设你以 6 米/秒的速度猛跑，则你的淋雨量 C 与所用时间 t 分别为";
                this.textBox10.Text = (D * pi * R * p / 6 * (R * rz + h * Math.Sqrt(rx * rx + (ry - 6) * (ry - 6)))).ToString(".00");
                this.textBox11.Text = (1000 * D / 6).ToString(".00");
            }
            else
            {
                this.textBox9.Text = "  你应当以雨滴下落速度在你前进方向上的分速度即 ry 的速度行走，此时你的淋雨量 C 与所用时间 t 分别为";
                this.textBox10.Text = (D * pi * R * p / ry * (R * rz + h * Math.Sqrt(rx * rx))).ToString(".00");
                this.textBox11.Text = (1000 * D / ry).ToString(".00");
            }
        }
    }
}
