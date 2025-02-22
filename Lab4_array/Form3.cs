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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSplitName_Click(object sender, EventArgs e)
        {
            string fullName = textBoxFullName.Text.Trim();  // รับค่าชื่อเต็มและตัด space หน้า-หลัง
            string title = "";
            string firstName = "";
            string lastName = "";

            // รายการคำหน้าที่รองรับ
            string[] knownTitles = { "นาย", "นาง", "นางสาว", "เด็กชาย", "เด็กหญิง",
                                     "ด.ช.", "ด.ญ.", "น.ส.", "ด.ต.", "ต.ต.", "พ.ต.ต.",
                                     "ร.ต.ต.", "ดร.", "มรว.", "ผศ.", "ดร.", "ศ." };

            string[] parts = fullName.Split(' '); // แยกคำตามช่องว่าง

            if (parts.Length >= 2)
            {
                if (knownTitles.Contains(parts[0]))  // ตรวจสอบว่าคำแรกเป็นคำหน้าหรือไม่
                {
                    title = parts[0];  // คำหน้า
                    firstName = parts[1];  // ชื่อจริง
                    lastName = string.Join(" ", parts.Skip(2)); // นามสกุล (รวม space)
                }
                else
                {
                    firstName = parts[0]; // ไม่มีคำนำหน้า
                    lastName = string.Join(" ", parts.Skip(1));
                }
            }
            else
            {
                firstName = fullName;
                lastName = "ไม่พบข้อมูลนามสกุล";
            }

            textBoxTitle.Text = title;
            textBoxFirstName.Text = firstName;
            textBoxLastName.Text = lastName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
