using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {   //แยกข้อความ, ค้นหา, แทนที่, ตัดเว้นวรรค, แปลงตัวพิมพ์
            string massage = "Computer Engineering CPE#16"; // ประกาศตัวแปร name และกำหนด
            //Console.WriteLine(massage); // แสดงผลข้อความในตัวแปร name
            //Console.WriteLine("Data Position  :"+massage[2] + massage[7]+ massage[14]);
            //Console.WriteLine("Data Position  :"+massage.Substring(3));
            //Console.WriteLine("Data Position  :"+massage.Substring(9, 15));

            //Console.WriteLine("Length Data :"+massage.Length);
            //Console.WriteLine(massage.ToUpper()); 
            //Console.WriteLine(massage.ToLower()); 
            //Console.WriteLine(massage.Contains("Computer")); 
            //Console.WriteLine(massage.IndexOf("CPE"));
            //Console.WriteLine(massage.Replace("Computer", "C#")); 
            //Console.WriteLine(massage.Trim()); 

            string[] parts = massage.Split(' ');
            //Console.WriteLine(parts[0]+" " + parts[1] + " " + parts[2]);

            //Console.WriteLine(massage.Insert(3, "TEST "));  
            //Console.WriteLine(massage.Remove(3, 9));       

            string first = "Hello";
            string second = "World";
            string result = first + " " + second;
            //Console.WriteLine(result); // "Hello World"
            
            // รอให้ผู้ใช้กดปุ่มก่อนปิดหน้าต่างคอนโซล  Console.ReadLine(); & Console.ReadKey();

        }
    }
}