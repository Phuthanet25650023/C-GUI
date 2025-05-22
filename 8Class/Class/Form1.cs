using System;
using Microsoft.VisualBasic;

namespace Class
{
    public partial class Form1 : Form
    {
        
        class Car
        {
            public string name;
            public string color;
            public int year;
            public int price;
            public Car(string name, string color, int year, int price)
            {
                this.name = name;
                this.color = color;
                this.year = year;
                this.price = price;
            }
        }
        private float price = 0;
        List<Car> cars = new List<Car>();
        public Form1()
        {

            InitializeComponent();
        }
        private void UpdateArea()
        {
            textBox1.Clear();
            price = 0;
            foreach (Car car in cars)
            {
                textBox1.AppendText("Name: " + car.name + "   color: " + car.color + "   year: " + car.year + "   price: " + car.price + Environment.NewLine);
                price += car.price;
            }
            label1.Text = "Price : " + price;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Car car = new Car("BMW", "Black", 2020, 50000);
                cars.Add(car);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Car car = new Car("Mercedes", "White", 2021, 60000);
                cars.Add(car);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Car car = new Car("Audi", "Red", 2019, 55000);
                cars.Add(car);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Car car = new Car("Toyota", "Blue", 2018, 30000);
                cars.Add(car);
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                Car car = new Car("Honda", "Green", 2022, 35000);
                cars.Add(car);
            }
            UpdateArea();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Enter the index of the car you want to remove: ", "Remove Car", "0");

            if (int.TryParse(input, out int index))
            {
                try
                {
                    cars.RemoveAt(index);
                    // เคลียร์และแสดงใหม่
                    UpdateArea();
                }
                catch (Exception ex) { MessageBox.Show("NoData", "Error"); }

            }
            else
            {
                MessageBox.Show("Enter Number Only");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit_Car();
        }

        private void Edit_Car()
        {
            string input = Interaction.InputBox("Enter the index of the car you want to Edit: ", "Edit Car", "0");

            if (int.TryParse(input, out int index))// เช็คว่าเป็นตัวเลข
            {
                try
                {
                    Car carToEdit = cars[index];
                    // แสดง InputBox เพื่อให้ผู้ใช้กรอกข้อมูลใหม่
                    string newName = Interaction.InputBox("Enter the new name of the car: ", "Edit Name", carToEdit.name);
                    string newColor = Interaction.InputBox("Enter the new color of the car: ", "Edit Color", carToEdit.color);
                    string newYear = Interaction.InputBox("Enter the new year of the car: ", "Edit Year", carToEdit.year.ToString());
                    string newPrice = Interaction.InputBox("Enter the new price of the car: ", "Edit Price", carToEdit.price.ToString());

                    if (int.TryParse(newYear, out int setYear) && int.TryParse(newPrice, out int setprice))
                    {
                        // อัปเดตข้อมูลของรถ
                        carToEdit.name = newName;
                        carToEdit.color = newColor;
                        carToEdit.year = setYear;
                        carToEdit.price = setprice;
                    }
                    UpdateArea();



                }
                catch (Exception ex) { MessageBox.Show("NoData", "Error"); }

            }
            else
            {
                MessageBox.Show("Enter Number Only");
            }
        }
    }
}
