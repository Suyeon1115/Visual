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

namespace 이수연_10_04
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          ArrayList al = new ArrayList();
          ADDR_CARD card;

          private void button1_Click(object sender, EventArgs e)
          {
               card = new ADDR_CARD();
               card.name = textBox1.Text;
               card.address = textBox2.Text;
               card.phone = textBox3.Text;
               al.Add(card);

               textBox1.Text = ""; 
               textBox2.Text = "";
               textBox3.Text = "";
          }

          private void button2_Click(object sender, EventArgs e)
          {
               bool find = false;
               foreach (ADDR_CARD item in al)
               {
                    if (item.name == textBox1.Text) 
                    {
                         textBox2.Text = item.address;
                         textBox3.Text = item.phone;
                         find = true;
                         break;
                    }
               }
               if (find == false)
               {
                    MessageBox.Show(textBox1.Text +"은 명단에 없습니다.");                 
               }
          }

          private void button3_Click(object sender, EventArgs e)//제거
          {
               int i = -1;
               foreach  (ADDR_CARD item in al)
               {
                    if(item.name==textBox1.Text)
                    {
                         i = al.IndexOf(item);
                         break;
                    }
               }
               if (i==-1)
               {
                    MessageBox.Show(textBox1.Text + "은 명단에 없습니다.");
               }
               if (i != (al.Count-1))
               {
                    al.RemoveAt(i);
                    textBox1.Text = ((ADDR_CARD)al[i]).name;
                    textBox2.Text = ((ADDR_CARD)al[i]).address;
                    textBox3.Text = ((ADDR_CARD)al[i]).phone;
               }
               if (i == (al.Count - 1))
               {
                    al.RemoveAt(i);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    MessageBox.Show("다음 요소가 없습니다.");  
               }
          }
          private void button4_Click(object sender, EventArgs e)//이전
          {
               int find = -1;
               foreach (ADDR_CARD item in al)
               {
                    if (item.name == textBox1.Text)
                    {
                         find = al.IndexOf(item);
                         break;
                    }
               }
               if(find !=0)
               {
                    textBox1.Text = ((ADDR_CARD)al[find - 1]).name;
                    textBox2.Text = ((ADDR_CARD)al[find - 1]).address;
                    textBox3.Text = ((ADDR_CARD)al[find - 1]).phone;
               }
               if (find == 0)
               {
                    MessageBox.Show("처음 데이터입니다.");
               }
          }
          private void button5_Click(object sender, EventArgs e)//다음
          {
               int find = -1;
               foreach (ADDR_CARD item in al)
               {
                    if (item.name == textBox1.Text)
                    {
                         find = al.IndexOf(item);
                         break;
                    }
               }
               if (find != (al.Count - 1))
               {
                    textBox1.Text = ((ADDR_CARD)al[find+1]).name;
                    textBox2.Text = ((ADDR_CARD)al[find+1]).address;
                    textBox3.Text = ((ADDR_CARD)al[find+1]).phone;
               }
               if(find == (al.Count - 1))
               {
                    MessageBox.Show("마지막 데이터입니다.");
               }
          }
          private void button6_Click(object sender, EventArgs e)
          {
               ADDR_CARD a = (ADDR_CARD)al[0];
               textBox1.Text = a.name;
               textBox2.Text = a.address;
               textBox3.Text = a.phone;
          }
     }
}
