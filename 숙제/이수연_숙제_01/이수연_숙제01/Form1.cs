using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 이수연_숙제01
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               MessageBox.Show("확인 버튼을 클릭", "확인", MessageBoxButtons.OK);
          }

          private void button2_Click(object sender, EventArgs e)
          {
               MessageBox.Show("예-아니오 버튼을 클릭", "예-아니오", MessageBoxButtons.YesNo);
          }

          private void button3_Click(object sender, EventArgs e)
          {
               MessageBox.Show("중지-재시도-무시 버튼을 클릭", "중지-재시도-무시", MessageBoxButtons.AbortRetryIgnore);
          }

          private void button4_Click(object sender, EventArgs e)
          {
               MessageBox.Show("확인-취소 버튼을 클릭", "확인-취소", MessageBoxButtons.OKCancel);
          }

          private void button5_Click(object sender, EventArgs e)
          {
               MessageBox.Show("재시도-취소 버튼을 클릭", "재시도-취소", MessageBoxButtons.RetryCancel);
          }
     }
}
