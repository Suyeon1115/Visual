using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 이수연_1018
{
     public partial class DialogForm : Form
     {
          private Form1 input;
          public DialogForm(Form1 a)
          {
               InitializeComponent();
               input = a;
          }

          private void button1_Click(object sender, EventArgs e)
          {
               ListViewItem item = new ListViewItem(textBox1.Text, int.Parse(textBox4.Text));
               item.SubItems.Add(textBox2.Text);
               item.SubItems.Add(textBox3.Text);
               input.listView1.Items.Add(item);

               textBox1.Text = "";
               textBox2.Text = "";
               textBox3.Text = "";
               textBox4.Text = "";
          }

          private void button2_Click(object sender, EventArgs e)
          {
               Close();
          }
     }
}
