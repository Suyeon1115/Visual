using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 이수연72
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void button2_Click(object sender, EventArgs e)//추가
          {
               listBox1.Items.Add(textBox1.Text);
               textBox1.Text = "";
          }

          private void button1_Click(object sender, EventArgs e)//삽입
          {
               listBox1.Items.Insert(listBox1.SelectedIndex,textBox1.Text);
               textBox1.Text = "";
          }

          private void button3_Click(object sender, EventArgs e)//선택삭제
          {
               int cnt = listBox1.SelectedIndices.Count;
               for (int i = 0; i<cnt; i++)
               {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
               }
          }

          private void button4_Click(object sender, EventArgs e)//정렬
          {
               listBox1.Sorted = true;
          }
     }
}
