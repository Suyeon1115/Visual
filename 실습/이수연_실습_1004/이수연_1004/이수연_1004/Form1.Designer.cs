namespace 이수연_1004
{
     partial class Form1
     {
          /// <summary>
          /// 필수 디자이너 변수입니다.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// 사용 중인 모든 리소스를 정리합니다.
          /// </summary>
          /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form 디자이너에서 생성한 코드

          /// <summary>
          /// 디자이너 지원에 필요한 메서드입니다. 
          /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
          /// </summary>
          private void InitializeComponent()
          {
               this.tabControl1 = new System.Windows.Forms.TabControl();
               this.tabPage1 = new System.Windows.Forms.TabPage();
               this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
               this.tabPage2 = new System.Windows.Forms.TabPage();
               this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
               this.tabPage3 = new System.Windows.Forms.TabPage();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.radioButton4 = new System.Windows.Forms.RadioButton();
               this.radioButton3 = new System.Windows.Forms.RadioButton();
               this.radioButton2 = new System.Windows.Forms.RadioButton();
               this.radioButton1 = new System.Windows.Forms.RadioButton();
               this.tabPage4 = new System.Windows.Forms.TabPage();
               this.groupBox2 = new System.Windows.Forms.GroupBox();
               this.radioButton7 = new System.Windows.Forms.RadioButton();
               this.radioButton6 = new System.Windows.Forms.RadioButton();
               this.radioButton5 = new System.Windows.Forms.RadioButton();
               this.label1 = new System.Windows.Forms.Label();
               this.tabControl1.SuspendLayout();
               this.tabPage1.SuspendLayout();
               this.tabPage2.SuspendLayout();
               this.tabPage3.SuspendLayout();
               this.groupBox1.SuspendLayout();
               this.tabPage4.SuspendLayout();
               this.groupBox2.SuspendLayout();
               this.SuspendLayout();
               // 
               // tabControl1
               // 
               this.tabControl1.Controls.Add(this.tabPage1);
               this.tabControl1.Controls.Add(this.tabPage2);
               this.tabControl1.Controls.Add(this.tabPage3);
               this.tabControl1.Controls.Add(this.tabPage4);
               this.tabControl1.Location = new System.Drawing.Point(31, 23);
               this.tabControl1.Name = "tabControl1";
               this.tabControl1.SelectedIndex = 0;
               this.tabControl1.Size = new System.Drawing.Size(830, 782);
               this.tabControl1.TabIndex = 0;
               // 
               // tabPage1
               // 
               this.tabPage1.Controls.Add(this.dateTimePicker1);
               this.tabPage1.Location = new System.Drawing.Point(4, 28);
               this.tabPage1.Name = "tabPage1";
               this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
               this.tabPage1.Size = new System.Drawing.Size(822, 750);
               this.tabPage1.TabIndex = 0;
               this.tabPage1.Text = "날짜";
               this.tabPage1.UseVisualStyleBackColor = true;
               // 
               // dateTimePicker1
               // 
               this.dateTimePicker1.Location = new System.Drawing.Point(31, 38);
               this.dateTimePicker1.Name = "dateTimePicker1";
               this.dateTimePicker1.Size = new System.Drawing.Size(291, 28);
               this.dateTimePicker1.TabIndex = 0;
               this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
               // 
               // tabPage2
               // 
               this.tabPage2.Controls.Add(this.monthCalendar1);
               this.tabPage2.Location = new System.Drawing.Point(4, 28);
               this.tabPage2.Name = "tabPage2";
               this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
               this.tabPage2.Size = new System.Drawing.Size(367, 352);
               this.tabPage2.TabIndex = 1;
               this.tabPage2.Text = "달력";
               this.tabPage2.UseVisualStyleBackColor = true;
               // 
               // monthCalendar1
               // 
               this.monthCalendar1.Location = new System.Drawing.Point(28, 28);
               this.monthCalendar1.Name = "monthCalendar1";
               this.monthCalendar1.TabIndex = 0;
               this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
               // 
               // tabPage3
               // 
               this.tabPage3.Controls.Add(this.groupBox1);
               this.tabPage3.Location = new System.Drawing.Point(4, 28);
               this.tabPage3.Name = "tabPage3";
               this.tabPage3.Size = new System.Drawing.Size(822, 750);
               this.tabPage3.TabIndex = 2;
               this.tabPage3.Text = "위치";
               this.tabPage3.UseVisualStyleBackColor = true;
               // 
               // groupBox1
               // 
               this.groupBox1.Controls.Add(this.radioButton4);
               this.groupBox1.Controls.Add(this.radioButton3);
               this.groupBox1.Controls.Add(this.radioButton2);
               this.groupBox1.Controls.Add(this.radioButton1);
               this.groupBox1.Location = new System.Drawing.Point(70, 37);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(220, 258);
               this.groupBox1.TabIndex = 0;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "위치";
               // 
               // radioButton4
               // 
               this.radioButton4.AutoSize = true;
               this.radioButton4.Location = new System.Drawing.Point(28, 177);
               this.radioButton4.Name = "radioButton4";
               this.radioButton4.Size = new System.Drawing.Size(51, 22);
               this.radioButton4.TabIndex = 0;
               this.radioButton4.TabStop = true;
               this.radioButton4.Text = "우";
               this.radioButton4.UseVisualStyleBackColor = true;
               this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
               // 
               // radioButton3
               // 
               this.radioButton3.AutoSize = true;
               this.radioButton3.Location = new System.Drawing.Point(28, 131);
               this.radioButton3.Name = "radioButton3";
               this.radioButton3.Size = new System.Drawing.Size(51, 22);
               this.radioButton3.TabIndex = 0;
               this.radioButton3.TabStop = true;
               this.radioButton3.Text = "좌";
               this.radioButton3.UseVisualStyleBackColor = true;
               this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
               // 
               // radioButton2
               // 
               this.radioButton2.AutoSize = true;
               this.radioButton2.Location = new System.Drawing.Point(28, 83);
               this.radioButton2.Name = "radioButton2";
               this.radioButton2.Size = new System.Drawing.Size(69, 22);
               this.radioButton2.TabIndex = 0;
               this.radioButton2.TabStop = true;
               this.radioButton2.Text = "아래";
               this.radioButton2.UseVisualStyleBackColor = true;
               this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
               // 
               // radioButton1
               // 
               this.radioButton1.AutoSize = true;
               this.radioButton1.Checked = true;
               this.radioButton1.Location = new System.Drawing.Point(28, 41);
               this.radioButton1.Name = "radioButton1";
               this.radioButton1.Size = new System.Drawing.Size(51, 22);
               this.radioButton1.TabIndex = 0;
               this.radioButton1.TabStop = true;
               this.radioButton1.Text = "위";
               this.radioButton1.UseVisualStyleBackColor = true;
               this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
               // 
               // tabPage4
               // 
               this.tabPage4.Controls.Add(this.groupBox2);
               this.tabPage4.Location = new System.Drawing.Point(4, 28);
               this.tabPage4.Name = "tabPage4";
               this.tabPage4.Size = new System.Drawing.Size(822, 750);
               this.tabPage4.TabIndex = 3;
               this.tabPage4.Text = "모양";
               this.tabPage4.UseVisualStyleBackColor = true;
               // 
               // groupBox2
               // 
               this.groupBox2.Controls.Add(this.radioButton7);
               this.groupBox2.Controls.Add(this.radioButton6);
               this.groupBox2.Controls.Add(this.radioButton5);
               this.groupBox2.Location = new System.Drawing.Point(73, 41);
               this.groupBox2.Name = "groupBox2";
               this.groupBox2.Size = new System.Drawing.Size(199, 264);
               this.groupBox2.TabIndex = 0;
               this.groupBox2.TabStop = false;
               this.groupBox2.Text = "모양";
               // 
               // radioButton7
               // 
               this.radioButton7.AutoSize = true;
               this.radioButton7.Location = new System.Drawing.Point(29, 151);
               this.radioButton7.Name = "radioButton7";
               this.radioButton7.Size = new System.Drawing.Size(105, 22);
               this.radioButton7.TabIndex = 0;
               this.radioButton7.TabStop = true;
               this.radioButton7.Text = "프렛버튼";
               this.radioButton7.UseVisualStyleBackColor = true;
               this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
               // 
               // radioButton6
               // 
               this.radioButton6.AutoSize = true;
               this.radioButton6.Location = new System.Drawing.Point(29, 94);
               this.radioButton6.Name = "radioButton6";
               this.radioButton6.Size = new System.Drawing.Size(69, 22);
               this.radioButton6.TabIndex = 0;
               this.radioButton6.TabStop = true;
               this.radioButton6.Text = "버튼";
               this.radioButton6.UseVisualStyleBackColor = true;
               this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
               // 
               // radioButton5
               // 
               this.radioButton5.AutoSize = true;
               this.radioButton5.Checked = true;
               this.radioButton5.Location = new System.Drawing.Point(29, 43);
               this.radioButton5.Name = "radioButton5";
               this.radioButton5.Size = new System.Drawing.Size(69, 22);
               this.radioButton5.TabIndex = 0;
               this.radioButton5.TabStop = true;
               this.radioButton5.Text = "보통";
               this.radioButton5.UseVisualStyleBackColor = true;
               this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(100, 808);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(41, 18);
               this.label1.TabIndex = 1;
               this.label1.Text = "time";
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(895, 869);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.tabControl1);
               this.Name = "Form1";
               this.Text = "Form1";
               this.tabControl1.ResumeLayout(false);
               this.tabPage1.ResumeLayout(false);
               this.tabPage2.ResumeLayout(false);
               this.tabPage3.ResumeLayout(false);
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               this.tabPage4.ResumeLayout(false);
               this.groupBox2.ResumeLayout(false);
               this.groupBox2.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TabControl tabControl1;
          private System.Windows.Forms.TabPage tabPage1;
          private System.Windows.Forms.TabPage tabPage2;
          private System.Windows.Forms.TabPage tabPage3;
          private System.Windows.Forms.DateTimePicker dateTimePicker1;
          private System.Windows.Forms.MonthCalendar monthCalendar1;
          private System.Windows.Forms.GroupBox groupBox1;
          private System.Windows.Forms.RadioButton radioButton4;
          private System.Windows.Forms.RadioButton radioButton3;
          private System.Windows.Forms.RadioButton radioButton2;
          private System.Windows.Forms.RadioButton radioButton1;
          private System.Windows.Forms.TabPage tabPage4;
          private System.Windows.Forms.GroupBox groupBox2;
          private System.Windows.Forms.RadioButton radioButton7;
          private System.Windows.Forms.RadioButton radioButton6;
          private System.Windows.Forms.RadioButton radioButton5;
          private System.Windows.Forms.Label label1;
     }
}

