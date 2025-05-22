namespace Getter_Setter
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
            get = new Button();
            OpenForm2 = new Button();
            Set = new Button();
            SuspendLayout();
            // 
            // get
            // 
            get.Location = new Point(12, 12);
            get.Name = "get";
            get.Size = new Size(75, 23);
            get.TabIndex = 0;
            get.Text = "Get";
            get.UseVisualStyleBackColor = true;
            get.Click += button1_Click;
            // 
            // OpenForm2
            // 
            OpenForm2.Location = new Point(93, 12);
            OpenForm2.Name = "OpenForm2";
            OpenForm2.Size = new Size(75, 23);
            OpenForm2.TabIndex = 1;
            OpenForm2.Text = "Form2";
            OpenForm2.UseVisualStyleBackColor = true;
            OpenForm2.Click += OpenForm2_Click;
            // 
            // Set
            // 
            Set.Location = new Point(12, 41);
            Set.Name = "Set";
            Set.Size = new Size(75, 23);
            Set.TabIndex = 2;
            Set.Text = "Set";
            Set.UseVisualStyleBackColor = true;
            Set.Click += Set_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(171, 73);
            Controls.Add(Set);
            Controls.Add(OpenForm2);
            Controls.Add(get);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button get;
        private Button OpenForm2;
        private Button Set;
    }
}
