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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private double CalculateAverageFor(int[] numbers)
        {
            if (numbers.Length == 0) return 0;

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return (double)sum / numbers.Length;
        }

        private double CalculateAverageForeach(int[] numbers)
        {
            if (numbers.Length == 0) return 0;

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return (double)sum / numbers.Length;
        }
        private void btnCalculateFor_Click(object sender, EventArgs e)
        {
            int[] numbers = textBoxNumbers.Text.Split(',')
                                .Select(n => int.Parse(n.Trim()))
                                .ToArray();

            double avg = CalculateAverageFor(numbers);
            MessageBox.Show($"ค่าเฉลี่ย (ใช้ for): {avg}");
        }

        private void btnCalculateForeach_Click(object sender, EventArgs e)
        {
            int[] numbers = textBoxNumbers.Text.Split(',')
                                .Select(n => int.Parse(n.Trim()))
                                .ToArray();

            double avg = CalculateAverageForeach(numbers);
            MessageBox.Show($"ค่าเฉลี่ย (ใช้ foreach): {avg}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }
    }
}
