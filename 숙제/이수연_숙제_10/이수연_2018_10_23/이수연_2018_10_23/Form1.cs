using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 이수연_2018_10_23
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
               textBox1.Select(0, 0);
          }

          private void toolStripMenuItem3_Click(object sender, EventArgs e)
          {
               Close();
          }

          private void toolStripMenuItem2_Click(object sender, EventArgs e)
          {
               Form2 x = new Form2(this);
               x.Show();

          }
     }
}
