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
     public partial class Form2 : Form
     {
          private Form1 dlg;
          bool result_flag = true;
          int count = 0;
          int find = 0;
          public Form2(Form1 a)
          {
               InitializeComponent();
               dlg = a;
          }

          private void button2_Click(object sender, EventArgs e)//모두 바꾸기
          {
               string str1 = dlg.textBox1.Text;
               string str2 = textBox1.Text;//찾을 단어
               string str3 = textBox2.Text;//바꿀 단어
               string str4 = str1.Replace(str2, str3);
               dlg.textBox1.Text = str4;
          } 

          private void button1_Click(object sender, EventArgs e)//바꾸기
          {

               string str1 = dlg.textBox1.Text;
               string str2 = textBox1.Text;//찾을 단어
               string str3 = textBox2.Text;//바꿀 단어
               int len = str2.Length;//찾을단어 길이 

               dlg.textBox1.Focus();

               if (count == 0)//처음 클릭 할 때 '찾을단어' 선택
               {
                    // 밑줄 표시 
                    result_flag = false;
                    for (int i = 0; i < str1.Length; i++)//문서 전체 돌리기
                    {
                         
                         if (str1[i] == str2[0])//첫번째 단어 같을때
                         {
                              for (int j = 0; j < len; j++)//찾을단어길이만큼 for문 돌리기
                              {
                                   if (str1[i + j] == str2[j])//첫음절부터 끝음절까지 
                                   {
                                        result_flag = true;
                                   }
                                   else
                                   {
                                        result_flag = false;
                                        break;
                                   }
                              }
                              //검사완료
                              if (result_flag)//result_flag가 참일때
                              {
                                   dlg.textBox1.Select(i, len);//선택 밑줄
                                   find = i;
                                   count++;
                                   break;
                              }
                         }  
                    }
                  
               }
               else
               {
                    str1 = str1.Remove(find, len);
                    str1 = str1.Insert(find, textBox2.Text);
                    dlg.textBox1.Text = str1;

                    result_flag = false;
                    for (int i = 0; i < str1.Length; i++)//문서 전체 돌리기
                    {

                         if (str1[i] == str2[0])//첫번째 단어 같을때
                         {
                              for (int j = 0; j < len; j++)//찾을단어길이만큼 for문 돌리기
                              {
                                   if (str1[i + j] == str2[j])//첫음절부터 끝음절까지 
                                   {
                                        result_flag = true;
                                   }
                                   else
                                   {
                                        result_flag = false; //틀림
                                        break;
                                   }
                              }
                              //검사완료
                              if (result_flag)//result_flag가 참일때
                              {
                                   dlg.textBox1.Select(i, len);//선택 밑줄
                                   find = i;
                                   count++;
                                   break;
                              }
                         }
                    }
                    if (result_flag == false)
                    {
                         MessageBox.Show("문서의 끝까지 바꾸기를 수행했습니다.");
                         textBox1.Select(0, 0);
                    }
               }
          }

          private void button3_Click(object sender, EventArgs e)//종료
          {
               Close();
          }
     }
}
