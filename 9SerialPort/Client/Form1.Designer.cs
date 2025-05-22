namespace Client
{
    partial class Client
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
            button1 = new Button();
            TextArea = new TextBox();
            Enter_Data = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(427, 357);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TextArea
            // 
            TextArea.Location = new Point(12, 12);
            TextArea.Multiline = true;
            TextArea.Name = "TextArea";
            TextArea.Size = new Size(490, 233);
            TextArea.TabIndex = 1;
            TextArea.TextChanged += TextArea_TextChanged;
            // 
            // Enter_Data
            // 
            Enter_Data.Location = new Point(12, 251);
            Enter_Data.Multiline = true;
            Enter_Data.Name = "Enter_Data";
            Enter_Data.Size = new Size(490, 100);
            Enter_Data.TabIndex = 1;
            Enter_Data.TextChanged += Enter_Data_TextChanged;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 386);
            Controls.Add(Enter_Data);
            Controls.Add(TextArea);
            Controls.Add(button1);
            Name = "Client";
            Text = "Client";
            Load += Client_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox TextArea;
        private TextBox Enter_Data;
    }
}
