using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SerialPort
{
    public partial class Form1 : Form
    {
        TcpListener server; // TCP server
        Thread serverThread; // Thread for the server

        public Form1()
        {
            InitializeComponent();
            StartServer(); // เปิดการใช้งาน TCP server
        }

        private void StartServer()
        {
            //เทรดการทำงานของ TCP server ใน Thread ใหม่
            serverThread = new Thread(() =>
            {
                server = new TcpListener(IPAddress.Any, 9000); //IPAddress.Any คือ IP Address ของเครื่องที่รันโปรแกรมนี้
                server.Start();
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();// รอการเชื่อมต่อจาก Client
                    NetworkStream stream = client.GetStream();// สร้าง NetworkStream สำหรับการสื่อสาร
                    byte[] buffer = new byte[1024];//กำหนดขนาด buffer สำหรับรับข้อมูล
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);//อ่านข้อมูลจาก Client
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);//   แปลงข้อมูลที่อ่านได้เป็นข้อความ

                    // อัพเดต UI จาก Thread หลัก
                    Invoke(new Action(() =>
                    {
                        TextArea.AppendText("Client: " + message + Environment.NewLine);// แสดงข้อความที่ได้รับใน TextArea
                        TextArea.ScrollToCaret();  // เลื่อน Scrollbar ไปยังข้อความล่าสุด
                    }));

                    client.Close();// ปิดการเชื่อมต่อกับ Client
                }
            });
            serverThread.IsBackground = true;// ตั้งค่า Thread เป็น Background Thread
            serverThread.Start();// เริ่ม Thread
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            server?.Stop(); // ปิด TCP server
            serverThread?.Abort(); // ปิด Thread
        }

        private void TextArea_TextChanged(object sender, EventArgs e)
        {
            // เพิ่มการจัดการกรณีการเปลี่ยนแปลงข้อความใน TextArea หากต้องการ
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
