namespace Lab4_array
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSplitName = new Button();
            textBoxFullName = new TextBox();
            textBoxTitle = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnSplitName
            // 
            btnSplitName.Location = new Point(542, 47);
            btnSplitName.Name = "btnSplitName";
            btnSplitName.Size = new Size(94, 29);
            btnSplitName.TabIndex = 0;
            btnSplitName.Text = "แยก";
            btnSplitName.UseVisualStyleBackColor = true;
            btnSplitName.Click += btnSplitName_Click;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(191, 49);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(325, 27);
            textBoxFullName.TabIndex = 1;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(191, 138);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(125, 27);
            textBoxTitle.TabIndex = 2;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(191, 188);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(125, 27);
            textBoxFirstName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(191, 237);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(125, 27);
            textBoxLastName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 56);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 5;
            label1.Text = "ชื่อนามสกุลเต็ม";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 145);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 5;
            label2.Text = "คำนำหน้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 195);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 5;
            label3.Text = "ชื่อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 244);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 5;
            label4.Text = "นามสกุล";
            // 
            // button1
            // 
            button1.Location = new Point(719, 492);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Next30";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 533);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxFullName);
            Controls.Add(btnSplitName);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSplitName;
        private TextBox textBoxFullName;
        private TextBox textBoxTitle;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}