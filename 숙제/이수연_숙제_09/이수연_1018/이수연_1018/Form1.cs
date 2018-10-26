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
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void toolStripMenuItem1_Click(object sender, EventArgs e)
          {
               DialogForm input = new DialogForm(this);
               input.Show();
          }

          private void toolStripMenuItem2_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
          {
               switch (toolStripMenuItem2.DropDownItems.IndexOf(e.ClickedItem))
               {
                    case 0:
                         listView1.View = View.LargeIcon;     
                         break;
                    case 1:
                         listView1.View = View.SmallIcon;
                         break;
                    case 2:
                         listView1.View = View.List;
                         break;
                    case 3:
                         listView1.View = View.Details;
                         break;
               }
          }
     }
}
