namespace 이수연_1018
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
            "강동원",
            "서울",
            "111-233"}, 0);
               System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "신민아",
            "인천",
            "111-222"}, "여자.png");
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
               this.menuStrip1 = new System.Windows.Forms.MenuStrip();
               this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
               this.listView1 = new System.Windows.Forms.ListView();
               this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
               this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.imageList1 = new System.Windows.Forms.ImageList(this.components);
               this.imageList2 = new System.Windows.Forms.ImageList(this.components);
               this.menuStrip1.SuspendLayout();
               this.SuspendLayout();
               // 
               // menuStrip1
               // 
               this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
               this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
               this.menuStrip1.Location = new System.Drawing.Point(0, 0);
               this.menuStrip1.Name = "menuStrip1";
               this.menuStrip1.Size = new System.Drawing.Size(645, 33);
               this.menuStrip1.TabIndex = 0;
               this.menuStrip1.Text = "menuStrip1";
               // 
               // toolStripMenuItem1
               // 
               this.toolStripMenuItem1.Name = "toolStripMenuItem1";
               this.toolStripMenuItem1.Size = new System.Drawing.Size(96, 29);
               this.toolStripMenuItem1.Text = "대화상자";
               this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
               // 
               // toolStripMenuItem2
               // 
               this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
               this.toolStripMenuItem2.Name = "toolStripMenuItem2";
               this.toolStripMenuItem2.Size = new System.Drawing.Size(60, 29);
               this.toolStripMenuItem2.Text = "보기";
               this.toolStripMenuItem2.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenuItem2_DropDownItemClicked);
               // 
               // listView1
               // 
               this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
               this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
               this.listView1.LargeImageList = this.imageList2;
               this.listView1.Location = new System.Drawing.Point(12, 50);
               this.listView1.Name = "listView1";
               this.listView1.Size = new System.Drawing.Size(608, 314);
               this.listView1.SmallImageList = this.imageList1;
               this.listView1.TabIndex = 1;
               this.listView1.UseCompatibleStateImageBehavior = false;
               this.listView1.View = System.Windows.Forms.View.Details;
               // 
               // toolStripMenuItem3
               // 
               this.toolStripMenuItem3.Name = "toolStripMenuItem3";
               this.toolStripMenuItem3.Size = new System.Drawing.Size(186, 30);
               this.toolStripMenuItem3.Text = "큰 아이콘";
               // 
               // toolStripMenuItem4
               // 
               this.toolStripMenuItem4.Name = "toolStripMenuItem4";
               this.toolStripMenuItem4.Size = new System.Drawing.Size(186, 30);
               this.toolStripMenuItem4.Text = "작은아이콘";
               // 
               // toolStripMenuItem5
               // 
               this.toolStripMenuItem5.Name = "toolStripMenuItem5";
               this.toolStripMenuItem5.Size = new System.Drawing.Size(186, 30);
               this.toolStripMenuItem5.Text = "간단히";
               // 
               // toolStripMenuItem6
               // 
               this.toolStripMenuItem6.Name = "toolStripMenuItem6";
               this.toolStripMenuItem6.Size = new System.Drawing.Size(186, 30);
               this.toolStripMenuItem6.Text = "자세히";
               // 
               // columnHeader1
               // 
               this.columnHeader1.Text = "이름";
               this.columnHeader1.Width = 100;
               // 
               // columnHeader2
               // 
               this.columnHeader2.Text = "주소";
               this.columnHeader2.Width = 200;
               // 
               // columnHeader3
               // 
               this.columnHeader3.Text = "전화번호";
               this.columnHeader3.Width = 150;
               // 
               // imageList1
               // 
               this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
               this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
               this.imageList1.Images.SetKeyName(0, "남자1.png");
               this.imageList1.Images.SetKeyName(1, "여자.png");
               // 
               // imageList2
               // 
               this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
               this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
               this.imageList2.Images.SetKeyName(0, "남자1.png");
               this.imageList2.Images.SetKeyName(1, "여자.png");
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(645, 384);
               this.Controls.Add(this.listView1);
               this.Controls.Add(this.menuStrip1);
               this.MainMenuStrip = this.menuStrip1;
               this.Name = "Form1";
               this.Text = "Form";
               this.menuStrip1.ResumeLayout(false);
               this.menuStrip1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.MenuStrip menuStrip1;
          private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
          private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
          private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
          private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
          private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
          private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
          private System.Windows.Forms.ColumnHeader columnHeader1;
          private System.Windows.Forms.ColumnHeader columnHeader2;
          private System.Windows.Forms.ColumnHeader columnHeader3;
          private System.Windows.Forms.ImageList imageList2;
          private System.Windows.Forms.ImageList imageList1;
          public System.Windows.Forms.ListView listView1;
     }
}

