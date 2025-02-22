namespace Lab4_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numbers = new int[10]; // Array เก็บจำนวนเต็ม 10 ตัว
        double[] scores = new double[15]; // Array เก็บเลขทศนิยม 15 ตัว
        bool[] flags = new bool[99]; // Array เก็บค่าจริง/เท็จ 99 ตัว
        string[] animals = { "สมเสร็จ", "สิงโต", "แรคดำ", "เสือโคร่ง", "เสือโคร่ง", "ยีราฟ", "หมาป่า" };

        // ประกาศตัวแปร Array 2 มิติ
        int[,] matrixInt = new int[3, 3];  // เก็บจำนวนเต็ม
        double[,] matrixDouble = new double[2, 4];  // เก็บเลขทศนิยม
        string[,] matrixString =
        {
            { "สุนัข", "แมว", "แพนด้า" },
            { "เสือโคร่ง", "หนูป่า", "ม้าลาย" }
        };
        // ประกาศ Jagged Array (ข้อมูลสัตว์แต่ละประเภท)
        string[][] jaggedAnimals = new string[3][]
        {
            new string[] { "สุนัข", "แมว" },  // แถวที่ 0 มี 2 ตัว
            new string[] { "แพนด้า", "เสือโคร่ง", "หนูป่า" }, // แถวที่ 1 มี 3 ตัว
            new string[] { "ม้าลาย" } // แถวที่ 2 มี 1 ตัว
        };
        // ประกาศตัวแปรแบบ Array 2 มิติ (5 คน x 2 คอลัมน์)
        string[,] users = new string[5, 2]
        {
            { "user1", "pass123" },
            { "user2", "qwerty" },
            { "user3", "abc123" },
            { "user4", "password" },
            { "user5", "letmein" }
        };
        // ประกาศ Jagged Array สำหรับเก็บข้อมูลผู้ใช้
        string[][] jaggedUsers = new string[5][]
        {
            new string[] { "user1", "pass123", "Admin" },   // ผู้ใช้ที่เป็น Admin
            new string[] { "user2", "qwerty", "Editor" },   // ผู้ใช้ที่เป็น Editor
            new string[] { "user3", "abc123" },             // ผู้ใช้ทั่วไป
            new string[] { "user4", "password", "Guest" },  // ผู้ใช้ที่เป็น Guest
            new string[] { "user5", "letmein", "Member" }   // สมาชิกปกติ
        };




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(animals);
            listBox1.Items.AddRange(animals);
            checkedListBox1.Items.AddRange(animals);
        }

        private void btnSaveToArray_Click(object sender, EventArgs e)
        {
            string[] lines = textBox1.Lines;
            listBox1.Items.AddRange(lines);
            comboBox1.Items.AddRange((string[])lines);
            checkedListBox1.Items.AddRange((string[])lines);

            MessageBox.Show("ข้อมูลถูกเก็บใน Array แล้ว!", "Success");
        }

        private void btnShowJaggedArray_Click(object sender, EventArgs e)
        {
            string message = "ข้อมูลใน Jagged Array:\n";
            for (int i = 0; i < jaggedAnimals.Length; i++)
            {
                message += $"Row {i}: ";
                for (int j = 0; j < jaggedAnimals[i].Length; j++)
                {
                    message += jaggedAnimals[i][j] + " ";
                }
                message += "\n";
            }
            MessageBox.Show(message, "ข้อมูล Jagged Array");
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            string message = "ข้อมูลใน Array 2 มิติ:\n";
            for (int i = 0; i < users.GetLength(0); i++)
            {
                message += $"User: {users[i, 0]}, Pass: {users[i, 1]}\n";
            }
            MessageBox.Show(message, "Users (2D Array)");
        }

        private void btnShowJaggedUsers_Click(object sender, EventArgs e)
        {
            string message = "ข้อมูลใน Jagged Array:\n";
            for (int i = 0; i < jaggedUsers.Length; i++)
            {
                message += string.Join(", ", jaggedUsers[i]) + "\n";
            }
            MessageBox.Show(message, "Users (Jagged Array)");
        }
        // Array 2 มิติ
        int[,] matrix2D = new int[3, 4]; // 3 แถว 4 คอลัมน์

        // Jagged Array
        int[][] jaggedArray = new int[3][]
        {
            new int[] { 1, 2 },
            new int[] { 3, 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };
        private void btnArraySize_Click(object sender, EventArgs e)
        {
            int rowCount = matrix2D.GetLength(0);
            int columnCount = matrix2D.GetLength(1);
            MessageBox.Show($"ขนาดของ Array 2 มิติ: \nแถว: {rowCount} \nคอลัมน์: {columnCount}");
        }

        private void btnJaggedSize_Click(object sender, EventArgs e)
        {
            string message = "ขนาดของสมาชิกแต่ละแถวใน Jagged Array:\n";
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                message += $"แถว {i}: {jaggedArray[i].Length} สมาชิก\n";
            }
            MessageBox.Show(message, "ขนาดของ Jagged Array");
        }

        private void btnDeleteToArray_Click(object sender, EventArgs e)
        {
            // ลบข้อมูลจาก ComboBox
            if (comboBox1.SelectedItem != null)
            {
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            }

            // ลบข้อมูลจาก ListBox
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

            // ลบข้อมูลจาก CheckedListBox
            if (checkedListBox1.SelectedItem != null)
            {
                checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
            }

            MessageBox.Show("ลบข้อมูลที่เลือกแล้ว!", "Success");
        }

        private void btnStringOperations_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;  // รับข้อความจาก TextBox

            int length = text.Length;
            string upper = text.ToUpper();
            string lower = text.ToLower();
            string trimmed = text.Trim();

            MessageBox.Show($"ความยาวของข้อความ: {length}\n" +
                            $"ตัวพิมพ์ใหญ่: {upper}\n" +
                            $"ตัวพิมพ์เล็ก: {lower}\n" +
                            $"ตัดช่องว่าง: [{trimmed}]");
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;  // รับข้อความจาก TextBox
            string searchChar = textBox2.Text;  // ตัวอักษรที่ต้องการค้นหา

            if (text.Length >= 5)
            {
                string subText = text.Substring(0, 5);  // ดึง 5 ตัวแรก
                MessageBox.Show($"ข้อความที่ดึงมา: {subText}");
            }
            else
            {
                MessageBox.Show("กรุณาป้อนข้อความที่มีอย่างน้อย 5 ตัวอักษร");
            }

        }

        private void btnFindIndex_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;  // รับข้อความจาก TextBox
            string searchChar = textBox2.Text;  // ตัวอักษรที่ต้องการค้นหา

            if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(searchChar))
            {
                int index = text.IndexOf(searchChar);
                if (index != -1)
                {
                    MessageBox.Show($"ตัวอักษร '{searchChar}' อยู่ที่ตำแหน่ง {index}");
                }
                else
                {
                    MessageBox.Show($"ไม่พบตัวอักษร '{searchChar}' ในข้อความ");
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อความและตัวอักษรที่ต้องการค้นหา");
            }
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void CodingForm_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
