namespace WinFormsApp1
{
    // กำหนด namespace สำหรับแอพพลิเคชันนี้ (WinFormsApp1)

    public partial class Form1 : Form
    {
        // สร้างคลาส Form1 ซึ่งเป็นหน้าหลักของแอพพลิเคชันที่สืบทอดมาจาก Form

        public static Form1 instance;
        // สร้างตัวแปร instance เพื่อเก็บ reference ของ Form1
        // เพื่อให้สามารถเข้าถึง Form1 จากที่อื่นได้ เช่น Form2

        public List<User> userList = new List<User>();
        // สร้าง List เพื่อเก็บข้อมูลผู้ใช้ (Username, Password, BirthDate)

        public class User
        {
            // สร้าง class User ที่เก็บข้อมูลของผู้ใช้

            public string Username;
            // กำหนดตัวแปรเพื่อเก็บชื่อผู้ใช้

            public string Password;
            // กำหนดตัวแปรเพื่อเก็บรหัสผ่าน

            public DateTime BirthDate;
            // กำหนดตัวแปรเพื่อเก็บวันเกิดของผู้ใช้

            public User(string username, string password, DateTime birthDate)
            {
                // Constructor ของ class User เพื่อกำหนดค่าของตัวแปร
                Username = username;
                Password = password;
                BirthDate = birthDate;
            }
        }

        public Form1()
        {
            InitializeComponent();
            // เรียกใช้ฟังก์ชัน InitializeComponent() เพื่อเริ่มการตั้งค่าของฟอร์ม

            Password.UseSystemPasswordChar = true;
            // ตั้งค่ารหัสผ่านให้เป็นแบบซ่อนตัวอักษร

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // กำหนดกรอบของฟอร์มเป็นแบบคงที่ (ไม่สามารถขยายหรือย่อขนาดได้)

            this.MaximizeBox = false;
            // ปิดปุ่มขยายฟอร์ม (ไม่สามารถกด Maximize ได้)

            this.MinimizeBox = true;
            // เปิดปุ่มย่อฟอร์ม (สามารถย่อขนาดได้)

            userList.Add(new User("admin", "1234", DateTime.Now));
            // เพิ่มผู้ใช้ตัวอย่างเข้าสู่ userList โดยใช้ชื่อ "admin", รหัสผ่าน "1234", วันเกิดเป็นวันที่ปัจจุบัน

            instance = this;
            // เก็บ reference ของ Form1 ในตัวแปร instance เพื่อให้สามารถเข้าถึงจากที่อื่นได้
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // ฟังก์ชันที่ถูกเรียกใช้เมื่อฟอร์มโหลดเสร็จ (ยังไม่ได้ใช้ในโค้ดนี้)
        }
        public User FindUser(string enteredUsername, string enteredPassword)
        {
            // ใช้ลูป foreach เพื่อวนลูปเช็คแต่ละผู้ใช้ใน userList
            foreach (var user in userList)
            {
                // ตรวจสอบว่า Username และ Password ตรงกันหรือไม่ StringComparison.OrdinalIgnoreCase เทียบ ไม่สนใจพิมะพ์ใหญ่เล็ก
                if (user.Username.Equals(enteredUsername, StringComparison.OrdinalIgnoreCase) && user.Password == enteredPassword)
                {
                    return user; // ถ้าตรงกันจะคืนค่าผู้ใช้
                }
            }
            return null; // ถ้าไม่พบผู้ใช้ที่ตรงกัน คืนค่า null
        }
        private void LoginBT_Click(object sender, EventArgs e)
        {
            // ฟังก์ชันที่ถูกเรียกใช้เมื่อคลิกปุ่ม LoginBT (ปุ่มเข้าสู่ระบบ)

            string enteredUsername = textBox1.Text.Trim();
            // รับค่า Username ที่ผู้ใช้กรอกจาก textBox1 และลบช่องว่าง (Trim) ออก

            string enteredPassword = Password.Text.Trim();
            // รับค่า Password ที่ผู้ใช้กรอกจากช่อง Password และลบช่องว่าง (Trim) ออก

            // ตรวจสอบค่าที่ถูกต้องจาก userList โดยใช้ LINQ
            User matchedUser = FindUser(enteredUsername, enteredPassword);
            //var matchedUser = userList.FirstOrDefault(user => user.Username.Equals(enteredUsername, StringComparison.OrdinalIgnoreCase) && user.Password == enteredPassword);

            // ตรวจสอบว่า matchedUser มีค่าหรือไม่
            if (matchedUser == null)
            {
                // ถ้าไม่พบผู้ใช้ที่ตรงกับ Username และ Password
                MessageBox.Show("Error: Username หรือ Password ไม่ถูกต้อง", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // แสดงข้อความข้อผิดพลาด

                textBox1.Clear();
                Password.Clear();
                // เคลียร์ช่องกรอก Username และ Password
            }
            else
            {
                // ถ้าพบผู้ใช้ที่ตรงกับ Username และ Password
                MessageBox.Show("Login Success\n" + "Username = " + matchedUser.Username + "\nBirth Date = " + matchedUser.BirthDate.ToShortDateString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // แสดงข้อความว่าเข้าสู่ระบบสำเร็จ พร้อมชื่อผู้ใช้และวันเกิด

                textBox1.Clear();
                Password.Clear();
                // เคลียร์ช่องกรอก Username และ Password
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // ฟังก์ชันที่ถูกเรียกใช้เมื่อคลิกปุ่ม button2

            this.Hide();
            // ซ่อน Form1 (ทำให้หน้าต่างนี้ไม่แสดง)

            Form2 form2 = new Form2();
            // สร้างฟอร์มใหม่ (Form2)

            form2.FormClosed += (s, args) => this.Show();
            // เมื่อ Form2 ปิด ฟอร์ม1 จะถูกแสดงขึ้นอีกครั้ง

            form2.Show();
            // แสดง Form2
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // ฟังก์ชันที่ถูกเรียกใช้เมื่อสถานะของ checkBox1 เปลี่ยน

            if (checkBox1.Checked)
            {
                Password.UseSystemPasswordChar = false;
                // ถ้าตัวเลือกใน checkBox1 ถูกเลือก (checked) ให้แสดงรหัสผ่าน

            }
            else
            {
                Password.UseSystemPasswordChar = true;
                // ถ้าตัวเลือกใน checkBox1 ถูกยกเลิก (unchecked) ให้ซ่อนรหัสผ่าน
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
