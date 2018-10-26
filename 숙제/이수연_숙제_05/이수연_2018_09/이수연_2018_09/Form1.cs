using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 이수연_2018_09
{
     public partial class Form1 : Form
     {
          ArrayList al;
          public Form1()
          {
               InitializeComponent();
               al = new ArrayList();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               ADDR_CARD card = new ADDR_CARD();
               card.name = textBox1.Text;
               card.address = textBox2.Text;
               card.phone = textBox3.Text;
               al.Add(card);
          }

          private void button2_Click(object sender, EventArgs e)
          {
               bool find = false;
               foreach (ADDR_CARD i in al)
               {
                    if(i.name==textBox1.Text)
                    {
                         textBox2.Text = i.address;
                         textBox3.Text = i.phone;
                         find = true;
                         break;
                    }    
               }
               if (find == false)
               {
                    MessageBox.Show("데이터 없음");
               }
          }

          private void button3_Click(object sender, EventArgs e)
          {
               ADDR_CARD a = (ADDR_CARD)al[0];
               textBox1.Text = a.name;
               textBox2.Text = a.address;
               textBox3.Text = a.phone;
          }
     }
}
