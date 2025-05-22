namespace OS_FILE
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
            menuStrip1 = new MenuStrip();
            fgsdfsdToolStripMenuItem = new ToolStripMenuItem();
            sdfsdfToolStripMenuItem = new ToolStripMenuItem();
            sdfsdfToolStripMenuItem1 = new ToolStripMenuItem();
            sdfsdfToolStripMenuItem2 = new ToolStripMenuItem();
            tesseractToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fgsdfsdToolStripMenuItem, editToolStripMenuItem, printToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(608, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fgsdfsdToolStripMenuItem
            // 
            fgsdfsdToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sdfsdfToolStripMenuItem, sdfsdfToolStripMenuItem1, sdfsdfToolStripMenuItem2, tesseractToolStripMenuItem });
            fgsdfsdToolStripMenuItem.Name = "fgsdfsdToolStripMenuItem";
            fgsdfsdToolStripMenuItem.Size = new Size(37, 20);
            fgsdfsdToolStripMenuItem.Text = "File";
            fgsdfsdToolStripMenuItem.Click += fgsdfsdToolStripMenuItem_Click;
            // 
            // sdfsdfToolStripMenuItem
            // 
            sdfsdfToolStripMenuItem.Name = "sdfsdfToolStripMenuItem";
            sdfsdfToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            sdfsdfToolStripMenuItem.Size = new Size(186, 22);
            sdfsdfToolStripMenuItem.Text = "Open";
            sdfsdfToolStripMenuItem.Click += sdfsdfToolStripMenuItem_Click;
            // 
            // sdfsdfToolStripMenuItem1
            // 
            sdfsdfToolStripMenuItem1.Name = "sdfsdfToolStripMenuItem1";
            sdfsdfToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.S;
            sdfsdfToolStripMenuItem1.Size = new Size(186, 22);
            sdfsdfToolStripMenuItem1.Text = "Save";
            sdfsdfToolStripMenuItem1.Click += sdfsdfToolStripMenuItem1_Click;
            // 
            // sdfsdfToolStripMenuItem2
            // 
            sdfsdfToolStripMenuItem2.Name = "sdfsdfToolStripMenuItem2";
            sdfsdfToolStripMenuItem2.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            sdfsdfToolStripMenuItem2.Size = new Size(186, 22);
            sdfsdfToolStripMenuItem2.Text = "Save As";
            sdfsdfToolStripMenuItem2.Click += sdfsdfToolStripMenuItem2_Click;
            // 
            // tesseractToolStripMenuItem
            // 
            tesseractToolStripMenuItem.Name = "tesseractToolStripMenuItem";
            tesseractToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            tesseractToolStripMenuItem.Size = new Size(186, 22);
            tesseractToolStripMenuItem.Text = "Tesseract";
            tesseractToolStripMenuItem.Click += tesseractToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            fontToolStripMenuItem.Size = new Size(138, 22);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(44, 20);
            printToolStripMenuItem.Text = "Print";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click_1;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel2, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(608, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(38, 17);
            toolStripStatusLabel2.Text = "0 Line";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(72, 17);
            toolStripStatusLabel1.Text = "0 Characters";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(608, 398);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += TextCh;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 450);
            Controls.Add(textBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "NotePETPET";
            FormClosing += FormClos;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fgsdfsdToolStripMenuItem;
        private ToolStripMenuItem sdfsdfToolStripMenuItem;
        private ToolStripMenuItem sdfsdfToolStripMenuItem1;
        private ToolStripMenuItem sdfsdfToolStripMenuItem2;
        private ToolStripMenuItem printToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox textBox1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripMenuItem tesseractToolStripMenuItem;
    }
}
