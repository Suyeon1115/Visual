﻿namespace 이수연20
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
               this.components = new System.ComponentModel.Container();
               System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "경기도",
            "수원"}, 0);
               System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "강원도",
            "춘천"}, 1);
               System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "전라도",
            "광주"}, 2);
               System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "경상도",
            "대구"}, 3);
               System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "제주도",
            "제주"}, 4);
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.radioButton1 = new System.Windows.Forms.RadioButton();
               this.radioButton2 = new System.Windows.Forms.RadioButton();
               this.radioButton3 = new System.Windows.Forms.RadioButton();
               this.radioButton4 = new System.Windows.Forms.RadioButton();
               this.listView1 = new System.Windows.Forms.ListView();
               this.imageList1 = new System.Windows.Forms.ImageList(this.components);
               this.imageList2 = new System.Windows.Forms.ImageList(this.components);
               this.button1 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.button4 = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.textBox2 = new System.Windows.Forms.TextBox();
               this.textBox3 = new System.Windows.Forms.TextBox();
               this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.groupBox1.SuspendLayout();
               this.SuspendLayout();
               // 
               // groupBox1
               // 
               this.groupBox1.Controls.Add(this.radioButton4);
               this.groupBox1.Controls.Add(this.radioButton3);
               this.groupBox1.Controls.Add(this.radioButton2);
               this.groupBox1.Controls.Add(this.radioButton1);
               this.groupBox1.Location = new System.Drawing.Point(27, 27);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(866, 89);
               this.groupBox1.TabIndex = 0;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "보기";
               // 
               // radioButton1
               // 
               this.radioButton1.AutoSize = true;
               this.radioButton1.Location = new System.Drawing.Point(29, 59);
               this.radioButton1.Name = "radioButton1";
               this.radioButton1.Size = new System.Drawing.Size(111, 22);
               this.radioButton1.TabIndex = 0;
               this.radioButton1.TabStop = true;
               this.radioButton1.Text = "큰 아이콘";
               this.radioButton1.UseVisualStyleBackColor = true;
               this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
               // 
               // radioButton2
               // 
               this.radioButton2.AutoSize = true;
               this.radioButton2.Location = new System.Drawing.Point(202, 59);
               this.radioButton2.Name = "radioButton2";
               this.radioButton2.Size = new System.Drawing.Size(129, 22);
               this.radioButton2.TabIndex = 0;
               this.radioButton2.TabStop = true;
               this.radioButton2.Text = "작은 아이콘";
               this.radioButton2.UseVisualStyleBackColor = true;
               this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
               // 
               // radioButton3
               // 
               this.radioButton3.AutoSize = true;
               this.radioButton3.Location = new System.Drawing.Point(389, 59);
               this.radioButton3.Name = "radioButton3";
               this.radioButton3.Size = new System.Drawing.Size(87, 22);
               this.radioButton3.TabIndex = 0;
               this.radioButton3.TabStop = true;
               this.radioButton3.Text = "간단히";
               this.radioButton3.UseVisualStyleBackColor = true;
               this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
               // 
               // radioButton4
               // 
               this.radioButton4.AutoSize = true;
               this.radioButton4.Location = new System.Drawing.Point(559, 59);
               this.radioButton4.Name = "radioButton4";
               this.radioButton4.Size = new System.Drawing.Size(87, 22);
               this.radioButton4.TabIndex = 0;
               this.radioButton4.TabStop = true;
               this.radioButton4.Text = "자세히";
               this.radioButton4.UseVisualStyleBackColor = true;
               this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
               // 
               // listView1
               // 
               this.listView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
               this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
               listViewItem1.Checked = true;
               listViewItem1.StateImageIndex = 1;
               this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
               this.listView1.LargeImageList = this.imageList2;
               this.listView1.Location = new System.Drawing.Point(31, 147);
               this.listView1.Name = "listView1";
               this.listView1.Size = new System.Drawing.Size(862, 269);
               this.listView1.SmallImageList = this.imageList1;
               this.listView1.TabIndex = 1;
               this.listView1.UseCompatibleStateImageBehavior = false;
               this.listView1.View = System.Windows.Forms.View.Details;
               // 
               // imageList1
               // 
               this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
               this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
               this.imageList1.Images.SetKeyName(0, "검정모자.png");
               this.imageList1.Images.SetKeyName(1, "루돌프눈사람.png");
               this.imageList1.Images.SetKeyName(2, "모자 눈사람.png");
               this.imageList1.Images.SetKeyName(3, "빨간모자.png");
               this.imageList1.Images.SetKeyName(4, "산타눈사람.png");
               // 
               // imageList2
               // 
               this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
               this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
               this.imageList2.Images.SetKeyName(0, "검정모자.png");
               this.imageList2.Images.SetKeyName(1, "루돌프눈사람.png");
               this.imageList2.Images.SetKeyName(2, "모자 눈사람.png");
               this.imageList2.Images.SetKeyName(3, "빨간모자.png");
               this.imageList2.Images.SetKeyName(4, "산타눈사람.png");
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(38, 436);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(92, 45);
               this.button1.TabIndex = 2;
               this.button1.Text = "추가";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // button2
               // 
               this.button2.Location = new System.Drawing.Point(36, 498);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(94, 39);
               this.button2.TabIndex = 3;
               this.button2.Text = "삭제";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button4
               // 
               this.button4.Location = new System.Drawing.Point(38, 557);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(92, 40);
               this.button4.TabIndex = 4;
               this.button4.Text = "교환";
               this.button4.UseVisualStyleBackColor = true;
               this.button4.Click += new System.EventHandler(this.button4_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(175, 488);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(44, 18);
               this.label1.TabIndex = 5;
               this.label1.Text = "도명";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(386, 488);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(62, 18);
               this.label2.TabIndex = 5;
               this.label2.Text = "소재지";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(642, 488);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(62, 18);
               this.label3.TabIndex = 5;
               this.label3.Text = "인덱스";
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(235, 488);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(125, 28);
               this.textBox1.TabIndex = 6;
               // 
               // textBox2
               // 
               this.textBox2.Location = new System.Drawing.Point(454, 488);
               this.textBox2.Name = "textBox2";
               this.textBox2.Size = new System.Drawing.Size(159, 28);
               this.textBox2.TabIndex = 7;
               // 
               // textBox3
               // 
               this.textBox3.Location = new System.Drawing.Point(710, 488);
               this.textBox3.Name = "textBox3";
               this.textBox3.Size = new System.Drawing.Size(183, 28);
               this.textBox3.TabIndex = 8;
               // 
               // columnHeader1
               // 
               this.columnHeader1.Text = "도명";
               this.columnHeader1.Width = 100;
               // 
               // columnHeader2
               // 
               this.columnHeader2.Text = "도청 소재지";
               this.columnHeader2.Width = 200;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(929, 641);
               this.Controls.Add(this.textBox3);
               this.Controls.Add(this.textBox2);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.button4);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.listView1);
               this.Controls.Add(this.groupBox1);
               this.Name = "Form1";
               this.Text = "Form1";
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.GroupBox groupBox1;
          private System.Windows.Forms.RadioButton radioButton4;
          private System.Windows.Forms.RadioButton radioButton3;
          private System.Windows.Forms.RadioButton radioButton2;
          private System.Windows.Forms.RadioButton radioButton1;
          private System.Windows.Forms.ListView listView1;
          private System.Windows.Forms.ColumnHeader columnHeader1;
          private System.Windows.Forms.ColumnHeader columnHeader2;
          private System.Windows.Forms.ImageList imageList2;
          private System.Windows.Forms.ImageList imageList1;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Button button4;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.TextBox textBox2;
          private System.Windows.Forms.TextBox textBox3;
     }
}

