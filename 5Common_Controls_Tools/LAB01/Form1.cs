using System.Windows.Forms;

namespace LAB01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //textBox1.ReadOnly = true;
            //textBox1.Visible = true; // ซ่อน RichTextBox
            //textBox1.Enabled = true; // ปิดการใช้งาน TextBox1
            textBox1.Hide();
            textBox5.UseSystemPasswordChar = true; // ซ่อนรหัสผ่าน

            this.FormBorderStyle = FormBorderStyle.FixedSingle; // ล็อคขนาดขอบ
            this.MaximizeBox = false; // ปิดปุ่มขยายหน้าจอ
            this.MinimizeBox = true;  // (เลือกได้ว่าจะให้มีปุ่มย่อหน้าต่างหรือไม่)


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowPass(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox5.UseSystemPasswordChar = false;
            }
            else
            {
                textBox5.UseSystemPasswordChar = true;
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = "";
                }
            }
        }



        private void Exit_Program(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("คุณต้องการปิดโปรแกรมหรือไม่?", "ยืนยันการปิดโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) e.Cancel = true; // ยกเลิกการปิดฟอร์มเมื่อเลือก No

            // ถ้า Yes ก็ปล่อยให้โปรแกรมปิดตามปกติ
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string correctPassword = "1234"; // รหัสผ่านที่ถูกต้อง
            string Massage = "ชื่อ: " + textBox2.Text + "\n" +
                "นามสกุล: " + textBox3.Text + "\n" +
                "อายุ: " + textBox4.Text + "\n" +
                "รหัสผ่าน: " + textBox5.Text + "\n" +
                "วันเกิด: " + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "\n" +
                (radioButton1.Checked ? "เพศ : ชาย\n" : "เพศ : หญิง\n");

            if (checkBox1.Checked) Massage += "ความสามารถพิเศษ: ขับรถ\n";
            if (checkBox2.Checked) Massage += "ความสามารถพิเศษ: ขับเรือ\n";
            if (checkBox3.Checked) Massage += "ความสามารถพิเศษ: ขับยานบิน\n";

            // แสดงผลข้อความใน TextBox
            textBox1.Text = Massage;




            ////////////////////////////////////////////////////////////////////////////////////////////

            string userInput = Microsoft.VisualBasic.Interaction.InputBox(
                "กรุณากรอกรหัสผ่านเพื่อดูข้อมูล:", // ข้อความที่จะแสดง
                "กรอกรหัสผ่าน", // หัวข้อของกล่อง
                "",               // ค่าเริ่มต้น
                -1, -1            // ตำแหน่งของกล่อง (ไม่จำเป็น)
            );

            // ตรวจสอบว่าผู้ใช้กรอกรหัสผ่านตรงกับที่กำหนดไว้หรือไม่
            if (userInput == correctPassword)
            {
                MessageBox.Show("รหัสผ่านถูกต้อง! คุณสามารถดูข้อมูลได้.");
                textBox1.Show();
                // ทำการแสดงข้อมูลหรือดำเนินการต่อ
            }
            else
            {
                MessageBox.Show("รหัสผ่านไม่ถูกต้อง! กรุณาลองใหม่อีกครั้ง.");
            }
            ////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            MessageBox.Show("โปรแกรมนี้อยู่ที่: " + exePath);

        }
    }
}
