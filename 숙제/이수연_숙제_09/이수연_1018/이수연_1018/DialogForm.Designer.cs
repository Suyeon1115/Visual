namespace 이수연_1018
{
     partial class DialogForm
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.button1 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.textBox2 = new System.Windows.Forms.TextBox();
               this.textBox3 = new System.Windows.Forms.TextBox();
               this.textBox4 = new System.Windows.Forms.TextBox();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(19, 55);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(44, 18);
               this.label1.TabIndex = 0;
               this.label1.Text = "이름";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(19, 121);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(44, 18);
               this.label2.TabIndex = 0;
               this.label2.Text = "주소";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(19, 181);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(80, 18);
               this.label3.TabIndex = 0;
               this.label3.Text = "전화번호";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(19, 249);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(116, 18);
               this.label4.TabIndex = 0;
               this.label4.Text = "이미지인덱스";
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(51, 303);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(103, 40);
               this.button1.TabIndex = 1;
               this.button1.Text = "확인";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // button2
               // 
               this.button2.Location = new System.Drawing.Point(237, 306);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(103, 40);
               this.button2.TabIndex = 1;
               this.button2.Text = "종료";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(175, 52);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(195, 28);
               this.textBox1.TabIndex = 2;
               // 
               // textBox2
               // 
               this.textBox2.Location = new System.Drawing.Point(175, 111);
               this.textBox2.Name = "textBox2";
               this.textBox2.Size = new System.Drawing.Size(195, 28);
               this.textBox2.TabIndex = 2;
               // 
               // textBox3
               // 
               this.textBox3.Location = new System.Drawing.Point(175, 171);
               this.textBox3.Name = "textBox3";
               this.textBox3.Size = new System.Drawing.Size(195, 28);
               this.textBox3.TabIndex = 2;
               // 
               // textBox4
               // 
               this.textBox4.Location = new System.Drawing.Point(175, 246);
               this.textBox4.Name = "textBox4";
               this.textBox4.Size = new System.Drawing.Size(195, 28);
               this.textBox4.TabIndex = 2;
               // 
               // DialogForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(434, 358);
               this.Controls.Add(this.textBox4);
               this.Controls.Add(this.textBox3);
               this.Controls.Add(this.textBox2);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Name = "DialogForm";
               this.Text = "주소입력";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.TextBox textBox2;
          private System.Windows.Forms.TextBox textBox3;
          private System.Windows.Forms.TextBox textBox4;
     }
}