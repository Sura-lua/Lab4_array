using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_array
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        // คำนวณพื้นที่สี่เหลี่ยมผืนผ้า
        private double RectangleArea(double width, double height)
        {
            return width * height;
        }

        // คำนวณพื้นที่วงกลม
        private double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double width = double.Parse(textBoxWidth.Text);
            double height = double.Parse(textBoxHeight.Text);
            double area = RectangleArea(width, height);
            MessageBox.Show($"พื้นที่สี่เหลี่ยมผืนผ้า: {area} ตารางหน่วย", "ผลลัพธ์");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(textBoxRadius.Text);
            double area = CircleArea(radius);
            MessageBox.Show($"พื้นที่วงกลม: {area} ตารางหน่วย", "ผลลัพธ์");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
    }
}
