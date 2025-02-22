using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4_array
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void ShowMessage()
        {
            MessageBox.Show("นี่คือตัวอย่างของ Void Method!", "Void Method");
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCallVoidMethod_Click(object sender, EventArgs e)
        {
            ShowMessage();
        }

        private void btnExplainModifier_Click(object sender, EventArgs e)
        {
            string explanation = "Modifier เป็นตัวกำหนดการเข้าถึง Method หรือ Class เช่น \n" +
                                 " - public: ใช้ได้จากทุกที่\n" +
                                 " - private: ใช้ได้เฉพาะภายใน Class นั้น ๆ\n" +
                                 " - protected: ใช้ได้เฉพาะใน Class นั้น ๆ และ Class ที่สืบทอด";
            MessageBox.Show(explanation, "Modifier");
        }
        private string GetGreeting(string name)
        {
            return "สวัสดี, " + name + "!";
        }
        private void btnCallMethod_Click(object sender, EventArgs e)
        {
            string message = GetGreeting("สมชาย");
            MessageBox.Show(message, "วิธีเรียกใช้ Method");
        }

        private void btnMethodBenefits_Click(object sender, EventArgs e)
        {
            string benefits = "ประโยชน์ของ Method คือ:\n" +
                              " 1. ช่วยให้โค้ดอ่านง่ายขึ้น\n" +
                              " 2. ลดความซ้ำซ้อนของโค้ด\n" +
                              " 3. ใช้งานซ้ำได้ในหลายส่วนของโปรแกรม\n" +
                              " 4. ช่วยให้โปรแกรมเป็นระเบียบ";
            MessageBox.Show(benefits, "ประโยชน์ของ Method");
        }

        private void btnExplainParameter_Click(object sender, EventArgs e)
        {
            string explanation = "Parameter คือค่าที่ส่งเข้าไปใน Method \n" +
                                 " ตัวอย่างเช่น:\n" +
                                 " void Greet(string name) { MessageBox.Show(\"สวัสดี \" + name); }\n" +
                                 " ในที่นี้ name คือ Parameter";
            MessageBox.Show(explanation, "Parameter ของ Method");
        }

        private void btnExplainOverloadMethod_Click(object sender, EventArgs e)
        {
            string explanation = "Overload Method คือ Method ที่มีชื่อเหมือนกัน แต่รับพารามิเตอร์ต่างกัน\n" +
                                " ตัวอย่างเช่น:\n" +
                                " int Add(int a, int b) { return a + b; }\n" +
                                " double Add(double a, double b) { return a + b; }\n" +
                                " ทั้งสอง Method ชื่อ Add แต่รับค่าต่างกัน";
            MessageBox.Show(explanation, "Overload Method");
        }
        // Method ที่รับ Parameter
        private void Greet(string name)
        {
            MessageBox.Show("สวัสดี " + name, "Welcome");
        }
        // Method ที่รับค่าตัวเลข 2 ตัว และคืนค่าผลรวม
        private int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        private void btnSendParameter_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;  // รับค่าจาก TextBox
            Greet(name);  // เรียก Method และส่งค่า
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int sum = AddNumbers(num1, num2);

            MessageBox.Show($"ผลรวมคือ: {sum}", "ผลลัพธ์");
        }

        //24
        private void UpdateValue(int number)
        {
            number = 100; // เปลี่ยนค่าภายใน Method
        }

        private void btnByValue_Click(object sender, EventArgs e)
        {
            int myNumber = 50;
            UpdateValue(myNumber);
            MessageBox.Show("ค่าของ myNumber หลังจากเรียกใช้ Method: " + myNumber);
        }
        //25
        private void UpdateReference(ref int number)
        {
            number = 100; // เปลี่ยนค่าจริง
        }

        private void btnByReference_Click(object sender, EventArgs e)
        {
            int myNumber = 50;
            UpdateReference(ref myNumber);
            MessageBox.Show("ค่าของ myNumber หลังจากเรียกใช้ Method: " + myNumber);
        }
        //26
        private void ShowMessage(string message = "Hello, World!")
        {
            MessageBox.Show(message);
        }

        private void btnOptionalParameter_Click(object sender, EventArgs e)
        {
            ShowMessage();
            ShowMessage("สวัสดีครับ!"); // ใช้ค่าที่กำหนดใหม่
        }
        //27
        private void ShowArrayValues(int[] numbers)
        {
            string result = "ค่าทั้งหมดใน Array:\n";
            foreach (int num in numbers)
            {
                result += num + "\n";
            }
            MessageBox.Show(result, "Array Values");
        }

        private void btnArrayParameter_Click(object sender, EventArgs e)
        {
            int[] myNumbers = { 10, 20, 30, 40, 50 };
            ShowArrayValues(myNumbers);
        }
        //การใช้ Method
        private void MultiplyArrayElements(ref int[] numbers, int multiplier)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= multiplier; // คูณทุกค่าด้วย multiplier
            }
        }

        private void btnModifyArray_Click(object sender, EventArgs e)
        {
            int[] myNumbers = { 1, 2, 3, 4, 5 };
            MultiplyArrayElements(ref myNumbers, 2);

            string result = "ค่าหลังจากคูณด้วย 2:\n";
            foreach (int num in myNumbers)
            {
                result += num + "\n";
            }
            MessageBox.Show(result, "Array Modified");
        }
        //28
        private int AddNumbersSum(int a, int b)
        {
            return a + b; // ส่งค่าผลรวมกลับไป
        }

    }
}
