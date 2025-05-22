using System.Drawing.Printing;  // นำเข้าไลบรารีสำหรับการพิมพ์เอกสาร
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Tesseract;

namespace OS_FILE
{
    public partial class Form1 : Form  // ประกาศคลาสฟอร์มชื่อ Form1 ซึ่งสืบทอดจาก Form
    {
        private PrintDocument printDoc = new PrintDocument(); // สร้างอ็อบเจ็กต์สำหรับจัดการงานพิมพ์เอกสาร
        private string currentFilePath = "";  // ตัวแปรเก็บพาธของไฟล์ที่เปิดหรือบันทึกล่าสุด

        public Form1()  // ตัว constructor ของฟอร์ม
        {
            InitializeComponent();  // เรียกเมธอดที่สร้าง UI และตั้งค่าต่าง ๆ ที่ออกแบบไว้ใน Designer


            // กำหนดให้ textBox1 ขยายเต็มฟอร์มทั้งแนวตั้งและแนวนอนเวลาเปลี่ยนขนาดฟอร์ม
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // ผูกเหตุการณ์ PrintPage ของ printDoc ให้เรียกเมธอด PrintPage เมื่อเริ่มพิมพ์เอกสาร
            printDoc.PrintPage += new PrintPageEventHandler(this.PrintPage);
        }

        // เมธอดเปล่าสำหรับ event คลิกเมนูชื่อ fgsdfsdToolStripMenuItem (ยังไม่ได้เขียนโค้ด)
        private void fgsdfsdToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        // เมธอดเปล่าสำหรับ event คลิก toolStripStatusLabel1 (ยังไม่ได้เขียนโค้ด)
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }

        // เมธอดที่ถูกเรียกตอนฟอร์มโหลด (ยังไม่ได้เขียนโค้ดเพิ่มเติม)
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // เมธอดที่ถูกเรียกเมื่อข้อความใน textBox1 มีการเปลี่ยนแปลง
        private void TextCh(object sender, EventArgs e)
        {
            // แสดงจำนวนตัวอักษรใน textBox1 บน toolStripStatusLabel1
            toolStripStatusLabel1.Text = textBox1.Text.Length.ToString() + "  Characters";

            // แสดงจำนวนบรรทัดใน textBox1 บน toolStripStatusLabel2
            toolStripStatusLabel2.Text = textBox1.Lines.Length.ToString() + "  Line";
        }

        // เมธอดเปล่าสำหรับ event คลิกเมนู printToolStripMenuItem (ยังไม่ได้เขียนโค้ด)
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        // เมธอดสำหรับเปลี่ยนฟอนต์ข้อความใน textBox1
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();  // สร้างกล่องโต้ตอบเลือกฟอนต์
            fontDialog1.Font = textBox1.Font;           // ตั้งฟอนต์เริ่มต้นใน dialog เป็นฟอนต์ของ textBox1 ปัจจุบัน

            if (fontDialog1.ShowDialog() == DialogResult.OK)  // ถ้าผู้ใช้กดตกลงเลือกฟอนต์ใหม่
            {
                textBox1.Font = fontDialog1.Font;  // เปลี่ยนฟอนต์ใน textBox1 เป็นฟอนต์ที่เลือก
            }
        }

        // เมธอดที่ทำงานตอนพิมพ์เอกสาร (รับผิดชอบวาดข้อความลงบนกระดาษ)
        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            string text = textBox1.Text;        // ดึงข้อความทั้งหมดใน textBox1
            Font font = textBox1.Font;          // ใช้ฟอนต์เดียวกับใน textBox1
            // วาดข้อความลงบนหน้ากระดาษในตำแหน่งมุมบนซ้ายของพื้นที่ที่กำหนด (MarginBounds)
            ev.Graphics.DrawString(text, font, Brushes.Black, ev.MarginBounds.Left, ev.MarginBounds.Top);
        }

        // เมธอดคลิกเมนู printToolStripMenuItem_Click_1 เพื่อแสดงตัวอย่างพิมพ์ (Print Preview)
        private void printToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // ส่วนโค้ดสำหรับ PrintDialog ถูก comment ไว้ (ไม่ใช้งาน)
            /*
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDoc;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print(); // เริ่มพิมพ์จริง
            }
            */

            // สร้างและแสดงหน้าต่างพรีวิวการพิมพ์
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDoc;   // กำหนดเอกสารที่จะแสดงพรีวิว
            previewDialog.Width = 800;            // กำหนดความกว้างของหน้าต่างพรีวิว
            previewDialog.Height = 600;           // กำหนดความสูงของหน้าต่างพรีวิว
            previewDialog.ShowDialog();           // แสดงหน้าต่างพรีวิว (แบบ modal)
        }

        // เมธอดคลิกเมนู Save (บันทึกไฟล์)
        private void sdfsdfToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")  // เช็คว่ามีข้อความใน textBox1 หรือไม่
            {
                MessageBox.Show("กรุณาใส่ข้อความก่อน");  // ถ้าไม่มี แจ้งเตือนให้ใส่ข้อความ
                return;  // หยุดการทำงานต่อ
            }
            else if (currentFilePath == "")  // ถ้ายังไม่เคยบันทึกหรือเปิดไฟล์ (ไม่มีพาธไฟล์)
            {
                save();  // เรียกเมธอด save() เพื่อเลือกบันทึกไฟล์ใหม่
            }
            else
            {
                // ถ้ามีพาธไฟล์อยู่แล้ว บันทึกทับไฟล์เดิมทันที
                System.IO.File.WriteAllText(currentFilePath, textBox1.Text);
                MessageBox.Show("บันทึกไฟล์เรียบร้อย: " + currentFilePath);  // แจ้งบันทึกสำเร็จ
            }
        }

        // ฟังก์ชันสำหรับบันทึกไฟล์โดยให้ผู้ใช้เลือกตำแหน่งและชื่อไฟล์
        private void save()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();  // สร้าง dialog เลือกตำแหน่งบันทึกไฟล์
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";  // กรองประเภทไฟล์
            saveFileDialog1.DefaultExt = "txt";   // ตั้งนามสกุลไฟล์เริ่มต้น
            saveFileDialog1.AddExtension = true;  // ถ้าผู้ใช้ไม่ใส่นามสกุลให้เพิ่มให้อัตโนมัติ

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)  // ถ้าผู้ใช้เลือกไฟล์และกดตกลง
            {
                string filename = saveFileDialog1.FileName;  // เก็บชื่อไฟล์
                System.IO.File.WriteAllText(filename, textBox1.Text);  // บันทึกข้อความลงไฟล์
                MessageBox.Show("บันทึกไฟล์เรียบร้อย: " + filename);  // แจ้งบันทึกสำเร็จ
            }
        }

        // เมธอดคลิกเมนู Open (เปิดไฟล์)
        private void sdfsdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();  // สร้าง dialog เปิดไฟล์
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);  // เริ่มที่ Desktop
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";  // กรองไฟล์ .txt เป็นหลัก

            if (openFileDialog1.ShowDialog() == DialogResult.OK)  // ถ้าผู้ใช้เลือกไฟล์และกดตกลง
            {
                string filePath = openFileDialog1.FileName;  // เก็บพาธไฟล์ที่เลือก
                currentFilePath = filePath;  // เก็บพาธไว้ใช้เวลาบันทึกต่อไป
                textBox1.Text = System.IO.File.ReadAllText(filePath);  // โหลดข้อความจากไฟล์มาแสดงใน textBox1
                MessageBox.Show("เปิดไฟล์: " + filePath);  // แจ้งเปิดไฟล์สำเร็จ
            }
        }

        // เมธอดคลิกเมนู Save As (บันทึกเป็นไฟล์ใหม่)
        private void sdfsdfToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")  // ถ้าไม่มีข้อความ
            {
                MessageBox.Show("กรุณาใส่ข้อความก่อน");  // แจ้งเตือนให้ใส่ข้อความก่อนบันทึก
                return;
            }
            else
                save();  // เรียกฟังก์ชัน save() เพื่อเลือกตำแหน่งบันทึกไฟล์ใหม่
        }

        // เมธอดคลิกเมนู Exit (ปิดโปรแกรม) - ยังไม่มีโค้ด
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        // เมธอดที่ทำงานตอนฟอร์มกำลังจะปิด (เช็คว่าต้องการบันทึกหรือไม่)
        private void FormClos(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Text != "")  // ถ้ามีข้อความใน textBox1
            {
                // แสดงกล่องถามผู้ใช้ว่าจะบันทึกไฟล์ก่อนปิดหรือไม่
                DialogResult result = MessageBox.Show("คุณต้องการบันทึกไฟล์ก่อนออกจากโปรแกรมหรือไม่?", "ยืนยัน", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)  // ถ้าตอบ Yes ให้บันทึกไฟล์ก่อนปิด
                {
                    save();
                    // หลังบันทึกแล้วปล่อยให้ปิดโปรแกรมต่อ
                }
                else if (result == DialogResult.No)  // ถ้าตอบ No ให้ปิดโปรแกรมทันที
                {
                    // ปิดโปรแกรมเลย ไม่บันทึกไฟล์
                }
                else if (result == DialogResult.Cancel)  // ถ้าตอบ Cancel ให้ยกเลิกการปิดโปรแกรม
                {
                    e.Cancel = true; // ยกเลิกการปิดหน้าต่าง (โปรแกรมยังไม่ปิด)
                }
            }
        }

        private void tesseractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.png;*.jpg;*.jpeg;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                try
                {
                    string tessdataPath = Path.Combine(Application.StartupPath, "tessdata");
                    using (var engine = new TesseractEngine(tessdataPath, "eng", EngineMode.Default))

                    {
                        using (var img = Pix.LoadFromFile(imagePath))
                        {
                            using (var page = engine.Process(img))
                            {
                                string text = page.GetText();
                                textBox1.Text = text;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


    }
}
