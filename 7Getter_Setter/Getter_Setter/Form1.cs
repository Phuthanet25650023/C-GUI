using Microsoft.VisualBasic;

namespace Getter_Setter
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        private string _name = "Phuthanet";
        private int _age = 25;

        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetAge(int age)
        {
            _age = age;
        }
        public int GetAge()
        {
            return _age;
        }
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + _name + "\nAge: " + _age);
        }

        private void Set_Click(object sender, EventArgs e)
        {
            SetName(Interaction.InputBox("Enter your name", "Name", _name));
            SetAge(Convert.ToInt32(Interaction.InputBox("Enter your age", "Age", _age.ToString())));
        }

        private void OpenForm2_Click(object sender, EventArgs e)
        {
            this.Hide(); // ซ่อน Form1

            Form2 form2 = new Form2();

            // เพิ่ม event handler เมื่อ Form2 ถูกปิด
            form2.FormClosed += (s, args) =>
            {
                this.Show(); // แสดง Form1 กลับมา
            };

            form2.Show();
        }
    }
}
