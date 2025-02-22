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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private string GeneratePattern(char symbol, int size, char patternType)
        {
            string result = "";

            switch (patternType)
            {
                case 'A': // แบบ A
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                                result += symbol;
                            else
                                result += " ";
                        }
                        result += "\n";
                    }
                    break;

                case 'B': // แบบ B
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                                result += symbol;
                            else
                                result += i;
                        }
                        result += "\n";
                    }
                    break;

                case 'C': // แบบ C
                    for (int i = 1; i <= size; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            result += symbol + " ";
                        }
                        result += "\n";
                    }
                    break;

                default:
                    result = "ไม่พบรูปแบบที่ต้องการ!";
                    break;
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char symbol = textBoxSymbol.Text[0];  // รับตัวอักษร
            int size = int.Parse(textBoxSize.Text);  // รับขนาดของรูป
            char patternType = comboBoxPattern.Text[0];  // รับรูปแบบ A, B, C

            string pattern = GeneratePattern(symbol, size, patternType);
            label1.Text = pattern;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }
    }
}
