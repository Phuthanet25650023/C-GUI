using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Getter_Setter
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + Form1.instance.GetName() + "\nAge: " + Form1.instance.GetAge());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.instance.SetName(Interaction.InputBox("Enter your name", "Name"));
            Form1.instance.SetAge(Convert.ToInt32(Interaction.InputBox("Enter your age", "Age")));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.instance.SetAge(25); // Set age to 30
            Form1.instance.SetName("Phuthanet");// Set name to "John Doe"
            //Form1.instance._name = "TEST";
            //Form1.instance._age = "TEST";
        }
    }
}
