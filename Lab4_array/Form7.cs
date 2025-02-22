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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private int[] SortArray(int[] numbers, bool descending)
        {
            if (descending)
            {
                return numbers.OrderByDescending(n => n).ToArray();
            }
            else
            {
                return numbers.OrderBy(n => n).ToArray();
            }
        }
        private void btnSortAscending_Click(object sender, EventArgs e)
        {
            int[] numbers = textBoxNumbers.Text.Split(',')
                               .Select(n => int.Parse(n.Trim()))
                               .ToArray();

            int[] sortedNumbers = SortArray(numbers, false);
            textBoxOutput.Text = string.Join(", ", sortedNumbers);
        }

        private void btnSortDescending_Click(object sender, EventArgs e)
        {
            int[] numbers = textBoxNumbers.Text.Split(',')
                               .Select(n => int.Parse(n.Trim()))
                               .ToArray();

            int[] sortedNumbers = SortArray(numbers, true);
            textBoxOutput.Text = string.Join(", ", sortedNumbers);
        }
    }
}
