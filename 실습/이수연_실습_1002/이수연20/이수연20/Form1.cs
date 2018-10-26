using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 이수연20
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void radioButton1_CheckedChanged(object sender, EventArgs e)
          {
               listView1.View = View.LargeIcon;
          }

          private void radioButton2_CheckedChanged(object sender, EventArgs e)
          {
               listView1.View = View.SmallIcon;
          }

          private void radioButton3_CheckedChanged(object sender, EventArgs e)
          {
               listView1.View = View.List;
          }

          private void radioButton4_CheckedChanged(object sender, EventArgs e)
          {
               listView1.View = View.Details;
          }

          private void button1_Click(object sender, EventArgs e)//추가
          {
               ListViewItem item = new ListViewItem(textBox1.Text, int.Parse(textBox3.Text));
               item.SubItems.Add(textBox2.Text);
               listView1.Items.Add(item);
          }

          private void button2_Click(object sender, EventArgs e)//삭제
          {
               foreach (ListViewItem i in listView1.SelectedItems)
               {
                    listView1.Items.Remove(i);
               }
          }

          private void button4_Click(object sender, EventArgs e)//교환
          {
               int i = listView1.SelectedIndices[0];

               foreach (ListViewItem ob1 in listView1.SelectedItems)//삭제 
               {
                    listView1.Items.Remove(ob1);
               }

               ListViewItem item = new ListViewItem(textBox1.Text,int.Parse(textBox3.Text));//추가
               item.SubItems.Add(textBox2.Text);

               listView1.Items.Insert(i, item);//삽입
          }
     }
}
