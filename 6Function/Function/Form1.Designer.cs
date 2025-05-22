namespace Function
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 13);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "คะแนนที่ได้";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 13);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "หน่วยกิจ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(340, 31);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 31);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 23);
            textBox3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 13);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 1;
            label3.Text = "ชื่อวิชา";
            // 
            // button1
            // 
            button1.Location = new Point(504, 31);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 4;
            button1.Text = "เพิ่ม";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 60);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(581, 352);
            textBox4.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 415);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 5;
            label4.Text = "GPA : 0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 415);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 5;
            label5.Text = "หน่วยกิจ :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(482, 415);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 6;
            label6.Text = "สถานะ :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 444);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Function";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
