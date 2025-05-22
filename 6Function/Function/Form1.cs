namespace Function
{
    public partial class Form1 : Form
    {
        string[] subjects = new string[0];
        float[] scores = new float[0];
        int[] numbers = new int[0];
        float GPA = 0.0f;
        public Form1()
        {
            InitializeComponent();
        }

        void InputData(string sj, float Sco, int num)
        {
            int sub_Num = subjects.Length;

            // สร้าง Array ใหม่ขนาด +1
            string[] newSubjects = new string[sub_Num + 1];
            float[] newScores = new float[sub_Num + 1];
            int[] newNumbers = new int[sub_Num + 1];

            // คัดลอกข้อมูลเก่า
            for (int i = 0; i < sub_Num; i++)
            {
                newSubjects[i] = subjects[i];
                newScores[i] = scores[i];
                newNumbers[i] = numbers[i];
            }

            // เพิ่มข้อมูลใหม่ที่ช่องสุดท้าย
            newSubjects[sub_Num] = sj;
            newScores[sub_Num] = Sco;
            newNumbers[sub_Num] = num;

            // เปลี่ยน pointer ให้ชี้ Array ใหม่
            subjects = newSubjects;
            scores = newScores;
            numbers = newNumbers;
        }

        string GetData(int index)
        {
            string data = $"วิชา : {subjects[index]} คะแนน : {scores[index]}  หน่วยกิจ : {numbers[index]}";
            return data;
        }
        void Get_GPA()
        {
            float totalnumber = 0.0f;
            float totalscore = 0.0f;

            for (int i = 0; i < scores.Length; i++)
            {
                totalscore += ConvertScoreToGPA(scores[i]) * numbers[i];  // คะแนน × หน่วยกิต
                totalnumber += numbers[i];             // รวมหน่วยกิต
            }

            GPA = totalscore / totalnumber;
            label4.Text = "GPA : " + GPA.ToString("0.00");
        }

        float ConvertScoreToGPA(float score)
        {
            if (score >= 80) return 4.0f;
            else if (score >= 75) return 3.5f;
            else if (score >= 70) return 3.0f;
            else if (score >= 65) return 2.5f;
            else if (score >= 60) return 2.0f;
            else if (score >= 55) return 1.5f;
            else if (score >= 50) return 1.0f;
            else return 0.0f;
        }
        void status()
        {
            if (GPA < 2.0f) label6.Text = "สถานะ : Fail";
            else if (GPA >= 2.0f && GPA < 3.0f) label6.Text = "สถานะ : Pass";
            else if (GPA >= 3.0f && GPA < 3.5f) label6.Text = "สถานะ : Good";
            else if (GPA >= 3.5f && GPA < 4.0f) label6.Text = "สถานะ : Very Good";
            else if (GPA == 4.0f)
                label6.Text = "สถานะ : Error";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int Total = 0;
            InputData(textBox3.Text, float.Parse(textBox1.Text), int.Parse(textBox2.Text));

            textBox4.Text = "";
            for (int i = 0;  i < subjects.Length; i++)
            {
                textBox4.Text += GetData(i) + Environment.NewLine;
            }

            label5.Text = "หน่วยกิจ : ";
            foreach (int numbers in numbers) Total += numbers;
            label5.Text = "หน่วยกิจ :" + Total.ToString();

            Get_GPA();
            status();
        }
    }
}
