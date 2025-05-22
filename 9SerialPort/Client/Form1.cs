
using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void TextArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_Data_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serverIP = "127.0.0.1"; // IP Address ของ Server
            int port = 9000;
            string message = Enter_Data.Text.Trim(); // ข้อความที่ต้องการส่ง

            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("กรุณากรอกข้อความก่อนส่ง", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning); // แจ้งเตือนหากข้อความว่าง
                return;
            }

            try
            {
                // เชื่อมต่อไปยัง Server
                using (TcpClient client = new TcpClient(serverIP, port))
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                }

                // แสดงข้อความที่ส่งไปแล้ว
                TextArea.AppendText("Me: " + message + Environment.NewLine);
                Enter_Data.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }
    }
}
