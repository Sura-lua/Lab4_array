namespace Lab4_array
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            checkedListBox1 = new CheckedListBox();
            textBox1 = new TextBox();
            btnSaveToArray = new Button();
            btnShowJaggedArray = new Button();
            btnShowUsers = new Button();
            btnShowJaggedUsers = new Button();
            btnArraySize = new Button();
            btnJaggedSize = new Button();
            btnDeleteToArray = new Button();
            btnStringOperations = new Button();
            btnSubstring = new Button();
            textBox2 = new TextBox();
            btnFindIndex = new Button();
            btnMethod = new Button();
            CodingForm = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(188, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 204);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(374, 21);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 202);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(649, 21);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 104);
            textBox1.TabIndex = 3;
            // 
            // btnSaveToArray
            // 
            btnSaveToArray.Location = new Point(715, 194);
            btnSaveToArray.Name = "btnSaveToArray";
            btnSaveToArray.Size = new Size(114, 29);
            btnSaveToArray.TabIndex = 4;
            btnSaveToArray.Text = "SaveToArray";
            btnSaveToArray.UseVisualStyleBackColor = true;
            btnSaveToArray.Click += btnSaveToArray_Click;
            // 
            // btnShowJaggedArray
            // 
            btnShowJaggedArray.Location = new Point(756, 277);
            btnShowJaggedArray.Name = "btnShowJaggedArray";
            btnShowJaggedArray.Size = new Size(146, 51);
            btnShowJaggedArray.TabIndex = 5;
            btnShowJaggedArray.Text = "ShowJaggedArray";
            btnShowJaggedArray.UseVisualStyleBackColor = true;
            btnShowJaggedArray.Click += btnShowJaggedArray_Click;
            // 
            // btnShowUsers
            // 
            btnShowUsers.Location = new Point(756, 334);
            btnShowUsers.Name = "btnShowUsers";
            btnShowUsers.Size = new Size(146, 43);
            btnShowUsers.TabIndex = 6;
            btnShowUsers.Text = "ShowUsers";
            btnShowUsers.UseVisualStyleBackColor = true;
            btnShowUsers.Click += btnShowUsers_Click;
            // 
            // btnShowJaggedUsers
            // 
            btnShowJaggedUsers.Location = new Point(756, 383);
            btnShowJaggedUsers.Name = "btnShowJaggedUsers";
            btnShowJaggedUsers.Size = new Size(146, 51);
            btnShowJaggedUsers.TabIndex = 7;
            btnShowJaggedUsers.Text = "ShowJaggedUsers";
            btnShowJaggedUsers.UseVisualStyleBackColor = true;
            btnShowJaggedUsers.Click += btnShowJaggedUsers_Click;
            // 
            // btnArraySize
            // 
            btnArraySize.Location = new Point(756, 440);
            btnArraySize.Name = "btnArraySize";
            btnArraySize.Size = new Size(146, 42);
            btnArraySize.TabIndex = 8;
            btnArraySize.Text = "ArraySize";
            btnArraySize.UseVisualStyleBackColor = true;
            btnArraySize.Click += btnArraySize_Click;
            // 
            // btnJaggedSize
            // 
            btnJaggedSize.Location = new Point(756, 488);
            btnJaggedSize.Name = "btnJaggedSize";
            btnJaggedSize.Size = new Size(146, 42);
            btnJaggedSize.TabIndex = 8;
            btnJaggedSize.Text = "JaggedSize";
            btnJaggedSize.UseVisualStyleBackColor = true;
            btnJaggedSize.Click += btnJaggedSize_Click;
            // 
            // btnDeleteToArray
            // 
            btnDeleteToArray.Location = new Point(715, 229);
            btnDeleteToArray.Name = "btnDeleteToArray";
            btnDeleteToArray.Size = new Size(114, 29);
            btnDeleteToArray.TabIndex = 9;
            btnDeleteToArray.Text = "DeleteToArray";
            btnDeleteToArray.UseVisualStyleBackColor = true;
            btnDeleteToArray.Click += btnDeleteToArray_Click;
            // 
            // btnStringOperations
            // 
            btnStringOperations.Location = new Point(575, 194);
            btnStringOperations.Name = "btnStringOperations";
            btnStringOperations.Size = new Size(134, 29);
            btnStringOperations.TabIndex = 10;
            btnStringOperations.Text = "StringOperations";
            btnStringOperations.UseVisualStyleBackColor = true;
            btnStringOperations.Click += btnStringOperations_Click;
            // 
            // btnSubstring
            // 
            btnSubstring.Location = new Point(575, 229);
            btnSubstring.Name = "btnSubstring";
            btnSubstring.Size = new Size(94, 29);
            btnSubstring.TabIndex = 11;
            btnSubstring.Text = "Sub";
            btnSubstring.UseVisualStyleBackColor = true;
            btnSubstring.Click += btnSubstring_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(575, 264);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 12;
            // 
            // btnFindIndex
            // 
            btnFindIndex.Location = new Point(575, 299);
            btnFindIndex.Name = "btnFindIndex";
            btnFindIndex.Size = new Size(94, 29);
            btnFindIndex.TabIndex = 13;
            btnFindIndex.Text = "Find";
            btnFindIndex.UseVisualStyleBackColor = true;
            btnFindIndex.Click += btnFindIndex_Click;
            // 
            // btnMethod
            // 
            btnMethod.Location = new Point(12, 502);
            btnMethod.Name = "btnMethod";
            btnMethod.Size = new Size(150, 29);
            btnMethod.TabIndex = 14;
            btnMethod.Text = "Next To Method";
            btnMethod.UseVisualStyleBackColor = true;
            btnMethod.Click += btnMethod_Click;
            // 
            // CodingForm
            // 
            CodingForm.Location = new Point(311, 495);
            CodingForm.Name = "CodingForm";
            CodingForm.Size = new Size(131, 29);
            CodingForm.TabIndex = 15;
            CodingForm.Text = "Coding";
            CodingForm.UseVisualStyleBackColor = true;
            CodingForm.Click += CodingForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 543);
            Controls.Add(CodingForm);
            Controls.Add(btnMethod);
            Controls.Add(btnFindIndex);
            Controls.Add(textBox2);
            Controls.Add(btnSubstring);
            Controls.Add(btnStringOperations);
            Controls.Add(btnDeleteToArray);
            Controls.Add(btnJaggedSize);
            Controls.Add(btnArraySize);
            Controls.Add(btnShowJaggedUsers);
            Controls.Add(btnShowUsers);
            Controls.Add(btnShowJaggedArray);
            Controls.Add(btnSaveToArray);
            Controls.Add(textBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Lab4";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ListBox listBox1;
        private CheckedListBox checkedListBox1;
        private TextBox textBox1;
        private Button btnSaveToArray;
        private Button btnShowJaggedArray;
        private Button btnShowUsers;
        private Button btnShowJaggedUsers;
        private Button btnArraySize;
        private Button btnJaggedSize;
        private Button btnDeleteToArray;
        private Button btnStringOperations;
        private Button btnSubstring;
        private TextBox textBox2;
        private Button btnFindIndex;
        private Button btnMethod;
        private Button CodingForm;
    }
}
