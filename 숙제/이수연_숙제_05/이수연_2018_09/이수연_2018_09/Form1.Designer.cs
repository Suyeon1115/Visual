namespace 이수연_2018_09
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
               this.textBox2 = new System.Windows.Forms.TextBox();
               this.textBox3 = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.button1 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(125, 51);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(298, 28);
               this.textBox1.TabIndex = 0;
               // 
               // textBox2
               // 
               this.textBox2.Location = new System.Drawing.Point(125, 139);
               this.textBox2.Name = "textBox2";
               this.textBox2.Size = new System.Drawing.Size(297, 28);
               this.textBox2.TabIndex = 1;
               // 
               // textBox3
               // 
               this.textBox3.Location = new System.Drawing.Point(125, 239);
               this.textBox3.Name = "textBox3";
               this.textBox3.Size = new System.Drawing.Size(297, 28);
               this.textBox3.TabIndex = 2;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(46, 51);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(44, 18);
               this.label1.TabIndex = 3;
               this.label1.Text = "이름";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(46, 139);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(44, 18);
               this.label2.TabIndex = 4;
               this.label2.Text = "주소";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(46, 239);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(44, 18);
               this.label3.TabIndex = 5;
               this.label3.Text = "전화";
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(46, 394);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(96, 55);
               this.button1.TabIndex = 6;
               this.button1.Text = "입력";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // button2
               // 
               this.button2.Location = new System.Drawing.Point(185, 394);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(102, 55);
               this.button2.TabIndex = 7;
               this.button2.Text = "검색";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button3
               // 
               this.button3.Location = new System.Drawing.Point(336, 394);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(97, 54);
               this.button3.TabIndex = 8;
               this.button3.Text = "처음";
               this.button3.UseVisualStyleBackColor = true;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(478, 524);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.textBox3);
               this.Controls.Add(this.textBox2);
               this.Controls.Add(this.textBox1);
               this.Name = "Form1";
               this.Text = "Form1";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.TextBox textBox2;
          private System.Windows.Forms.TextBox textBox3;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Button button3;
     }
}

