using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 이수연_1004
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
          {
               label1.Text = dateTimePicker1.Value.ToString();
          }

          private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
          {
               label1.Text = monthCalendar1.SelectionRange.Start.ToString();
          }

          private void radioButton1_CheckedChanged(object sender, EventArgs e)
          {
               tabControl1.Alignment = TabAlignment.Top;
          }

          private void radioButton2_CheckedChanged(object sender, EventArgs e)
          {
               tabControl1.Alignment = TabAlignment.Bottom;
          }

          private void radioButton3_CheckedChanged(object sender, EventArgs e)
          {
               tabControl1.Alignment = TabAlignment.Left;
          }

          private void radioButton4_CheckedChanged(object sender, EventArgs e)
          {
               tabControl1.Alignment = TabAlignment.Right ;
          }

          private void radioButton5_CheckedChanged(object sender, EventArgs e)
          {
               tabControl1.Appearance = TabAppearance.Normal;
          }

          private void radioButton6_CheckedChanged(object sender, EventArgs e)
          {
               tabControl1.Appearance = TabAppearance.Buttons;
          }

          private void radioButton7_CheckedChanged(object sender, EventArgs e)
          {
               tabControl1.Appearance = TabAppearance.FlatButtons;
          }
     }
}
