﻿namespace 이수연_2018_10_23
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
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.menuStrip1 = new System.Windows.Forms.MenuStrip();
               this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
               this.menuStrip1.SuspendLayout();
               this.SuspendLayout();
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(18, 93);
               this.textBox1.Multiline = true;
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(446, 293);
               this.textBox1.TabIndex = 0;
               this.textBox1.Text = "프로세서와 메모리간의 속도 격차는 지속적으로 성능을 제한한다.\r\n\r\n프로세서와 메모리간의 속도 격차는 지속적으로 성능을 제한한다.\r\n\r\n프로세서와" +
    " 메모리간의 속도 격차는 지속적으로 성능을 제한한다.";
               // 
               // menuStrip1
               // 
               this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
               this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
               this.menuStrip1.Location = new System.Drawing.Point(0, 0);
               this.menuStrip1.Name = "menuStrip1";
               this.menuStrip1.Size = new System.Drawing.Size(476, 33);
               this.menuStrip1.TabIndex = 1;
               this.menuStrip1.Text = "편집";
               // 
               // toolStripMenuItem1
               // 
               this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
               this.toolStripMenuItem1.Name = "toolStripMenuItem1";
               this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 29);
               this.toolStripMenuItem1.Text = "편집";
               // 
               // toolStripMenuItem2
               // 
               this.toolStripMenuItem2.Name = "toolStripMenuItem2";
               this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 30);
               this.toolStripMenuItem2.Text = "찾아바꾸기";
               this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
               // 
               // toolStripMenuItem3
               // 
               this.toolStripMenuItem3.Name = "toolStripMenuItem3";
               this.toolStripMenuItem3.Size = new System.Drawing.Size(210, 30);
               this.toolStripMenuItem3.Text = "종료";
               this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(476, 416);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.menuStrip1);
               this.MainMenuStrip = this.menuStrip1;
               this.Name = "Form1";
               this.Text = "Form1";
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
          public System.Windows.Forms.TextBox textBox1;
     }
}

