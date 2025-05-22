namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        //public static Form2 instance; 
        // กำหนดคุณสมบัติของ Form2 สำหรับเก็บข้อมูลผู้ใช้
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }

        public Form2()
        {
            InitializeComponent();

            // ตั้งค่าให้ textBox2 และ textBox3 ซ่อนรหัสผ่าน
            textBox2.UseSystemPasswordChar = true; // ซ่อนรหัสผ่าน
            textBox3.UseSystemPasswordChar = true; // ซ่อนรหัสผ่าน
            this.FormBorderStyle = FormBorderStyle.FixedSingle;  // กำหนดกรอบให้คงที่
            this.MaximizeBox = false;                            // ปิดปุ่มขยายหน้าจอ (Maximize)
            this.MinimizeBox = true;                             // ปุ่มย่อจอ (Minimize) ให้แสดง
            //instance = this; // เก็บ instance ของ Form2 (ถูกคอมเมนต์ออก)
        }

        // อีเวนต์ที่ไม่ใช้งานในตอนนี้
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // อีเวนต์ที่ไม่ใช้งานในตอนนี้
        private void textbox1(object sender, EventArgs e)
        {

        }

        // อีเวนต์ที่ไม่ใช้งานในตอนนี้
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // อีเวนต์สำหรับเช็คสถานะการเลือกของ RadioButton
        private void Radio_Click(object sender, EventArgs e)
        {
            if (showpassword.Checked) // ถ้าเลือก showpassword (แสดงรหัสผ่าน)
            {
                textBox2.UseSystemPasswordChar = false; // แสดงรหัสผ่าน
                textBox3.UseSystemPasswordChar = false; // แสดงรหัสผ่าน
            }
            else // ถ้าไม่ได้เลือก showpassword (ซ่อนรหัสผ่าน)
            {
                textBox2.UseSystemPasswordChar = true; // ซ่อนรหัสผ่าน
                textBox3.UseSystemPasswordChar = true; // ซ่อนรหัสผ่าน
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // อีเวนต์ที่ไม่ได้ใช้งานตอนนี้
        }

        // คลิกปุ่มที่ใช้ยืนยันการลงทะเบียนผู้ใช้
        private void button1_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่า fields ทั้งหมดไม่ว่างเปล่า
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                // ถ้าข้อมูลยังไม่ครบ
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // ตรวจสอบว่า password ใน textBox2 กับ textBox3 ตรงกัน
            else if (textBox2.Text != textBox3.Text)
            {
                // ถ้ารหัสผ่านไม่ตรงกัน
                MessageBox.Show("กรุณากรอกรหัสผ่านให้เหมือนกัน", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // ตรวจสอบความยาวของรหัสผ่าน
            else if (textBox2.Text.Length < 8)
            {
                // ถ้ารหัสผ่านน้อยกว่า 8 ตัวอักษร
                MessageBox.Show("รหัสผ่านต้องมีอย่างน้อย 8 ตัวอักษร", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // ถ้าผ่านการตรวจสอบทั้งหมด
                DialogResult result = MessageBox.Show(
                    "Username :" + textBox1.Text + "\n" +
                    "Password :" + textBox2.Text + "\n" +
                    "Birth Date :" + dateTimePicker1.Text + "\n" +
                    "ข้อมูลถูกต้องวหรือไม่้?",
                    "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes) // ถ้าผู้ใช้กด Yes
                {
                    // เก็บข้อมูลของผู้ใช้
                    Username = textBox1.Text;
                    Password = textBox2.Text;
                    BirthDate = dateTimePicker1.Value;

                    // เพิ่มผู้ใช้ใหม่ใน userList ของ Form1
                    Form1.instance.userList.Add(new Form1.User(Username, Password, BirthDate));

                    // สร้างข้อความแสดงข้อมูลผู้ใช้ทั้งหมด
                    string userInfo = "";
                    foreach (var user in Form1.instance.userList)
                    {
                        userInfo += $"Username: {user.Username}\nPassword: {user.Password}\nBirth Date: {user.BirthDate.ToShortDateString()}\n\n";
                    }

                    // แสดงข้อมูลผู้ใช้ทั้งหมด
                    MessageBox.Show(string.IsNullOrEmpty(userInfo) ? "ไม่มีข้อมูลผู้ใช้ในระบบ" : userInfo, "User List", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ปิด Form2
                    this.Close();
                }
                else // ถ้าผู้ใช้กด No
                {
                    // แสดงข้อความยกเลิก
                    MessageBox.Show("ยกเลิก");
                }
            }
        }
    }
}
