using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 이수연_2018_09_27
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }
         
          double x,y,result;

          private void button1_Click(object sender, EventArgs e)// 지우기
          {
               textBox1.Text = "";
               textBox2.Text = "";
               textBox3.Text = "";
          }

          private void button3_Click(object sender, EventArgs e)// -
          {
               x = double.Parse(textBox1.Text);
               y = double.Parse(textBox2.Text);
               result = x - y;
               textBox3.Text = String.Format("{0:F3}", result);

          }

          private void button4_Click(object sender, EventArgs e)
          {
               x = double.Parse(textBox1.Text);
               y = double.Parse(textBox2.Text);
               result = x * y;
               textBox3.Text = String.Format("{0:F3}", result);
          }

          private void button5_Click(object sender, EventArgs e)
          {
               x = double.Parse(textBox1.Text);
               y = double.Parse(textBox2.Text);
               result = x / y;
               textBox3.Text = String.Format("{0:F3}", result);
          }

          private void button2_Click(object sender, EventArgs e)// +
          {
               
               x = double.Parse(textBox1.Text);
               y = double.Parse(textBox2.Text);
               result = x + y;
               textBox3.Text = String.Format("{0:F3}",result);
          }
     }
}
