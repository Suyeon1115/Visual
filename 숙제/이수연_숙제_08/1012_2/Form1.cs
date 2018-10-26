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

namespace _1012_2
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }
          ArrayList al = new ArrayList();
          ADDR_CARD card;

          public void Input()
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
          public void Search()
          {
               bool find=false;
               foreach (ADDR_CARD item in al)
               {
                    if(item.name == textBox1.Text)
                    {
                         textBox2.Text = item.address;
                         textBox3.Text = item.phone;
                         find = true;
                         break;
                    }
               }
               if(find == false)
               {
                    MessageBox.Show(textBox1,Text+"명단에 없습니다.");
               }
          }
          public void Remove()
          {
               int find= -1;
               foreach (ADDR_CARD i in al)
               {
                    if (i.name == textBox1.Text)
                    {
                         find = al.IndexOf(i);
                         break;
                    }
                }
               if (find == -1)
               {
                    MessageBox.Show(textBox1.Text+"명단에 없습니다.");
               }
               else if( find != al.Count-1)
               {
                    al.RemoveAt(find);
                    textBox1.Text = ((ADDR_CARD)al[find]).name;
                    textBox2.Text = ((ADDR_CARD)al[find]).address;
                    textBox3.Text = ((ADDR_CARD)al[find]).phone;
               }

               else
               {
                    al.RemoveAt(find);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    MessageBox.Show("다음요소는 없습니다.");
               }
               
          }
          public void Previous()
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
               if(find ==0 )
               {
                    MessageBox.Show("처음 데이터입니다.");
               }
               if(find != -1 && find != 0)
               {
                    textBox1.Text = ((ADDR_CARD)al[find - 1]).name;
                    textBox2.Text = ((ADDR_CARD)al[find - 1]).address;
                    textBox3.Text = ((ADDR_CARD)al[find - 1]).phone;
               }
          }

          public void Next()
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
               if (find == al.Count-1)
               {
                    MessageBox.Show("마지막 데이터입니다.");
               }
               if (find != -1 && find != al.Count-1)
               {
                    textBox1.Text = ((ADDR_CARD)al[find + 1]).name;
                    textBox2.Text = ((ADDR_CARD)al[find + 1]).address;
                    textBox3.Text = ((ADDR_CARD)al[find + 1]).phone;
               }
          }

          public void Start()
          {
               textBox1.Text = ((ADDR_CARD)al[0]).name;
               textBox2.Text = ((ADDR_CARD)al[0]).address;
               textBox3.Text = ((ADDR_CARD)al[0]).phone;
          }

          private void button1_Click(object sender, EventArgs e)//1
          {
               Input();
          }

          private void button2_Click(object sender, EventArgs e)//2
          {
               Search();
          }

          private void button3_Click(object sender, EventArgs e)//3
          {
               Remove();
          }

          private void button4_Click(object sender, EventArgs e)//4
          {
               Previous();
          }

          private void button5_Click(object sender, EventArgs e)//5
          {
               Next();
          }

          private void button6_Click(object sender, EventArgs e)//6
          {
               Start();
          }

      

          private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
          {
               switch (contextMenuStrip1.Items.IndexOf(e.ClickedItem))
               {
                    case 0: Input(); break;
                    case 1: Search(); break;
                    case 2: Remove(); break;
                    case 3: Previous(); break;
                    case 4: Next(); break;
                    case 5: Start(); break;
               }
          }

          private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
          {
               switch (toolStrip1.Items.IndexOf(e.ClickedItem))
               {
                    case 0: Input(); break;
                    case 1: Search(); break;
                    case 2: Remove(); break;
                    case 3: Previous(); break;
                    case 4: Next(); break;
                    case 5: Start(); break;
               }
          }

          private void toolStripMenuItem1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
          {
               switch (toolStripMenuItem1.DropDownItems.IndexOf(e.ClickedItem))
               {
                    case 0: Input(); break;
                    case 1: Search(); break;
                    case 2: Remove(); break;
                    case 3: Previous(); break;
                    case 4: Next(); break;
                    case 5: Start(); break;
               }
          }
     }
}
