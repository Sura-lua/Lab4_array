namespace Lab4_array
{
    partial class Form7
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
            btnSortAscending = new Button();
            btnSortDescending = new Button();
            textBoxNumbers = new TextBox();
            textBoxOutput = new Label();
            SuspendLayout();
            // 
            // btnSortAscending
            // 
            btnSortAscending.Location = new Point(308, 97);
            btnSortAscending.Name = "btnSortAscending";
            btnSortAscending.Size = new Size(175, 29);
            btnSortAscending.TabIndex = 0;
            btnSortAscending.Text = "btnSortAscending";
            btnSortAscending.UseVisualStyleBackColor = true;
            btnSortAscending.Click += btnSortAscending_Click;
            // 
            // btnSortDescending
            // 
            btnSortDescending.Location = new Point(308, 132);
            btnSortDescending.Name = "btnSortDescending";
            btnSortDescending.Size = new Size(175, 29);
            btnSortDescending.TabIndex = 0;
            btnSortDescending.Text = "btnSortDescending";
            btnSortDescending.UseVisualStyleBackColor = true;
            btnSortDescending.Click += btnSortDescending_Click;
            // 
            // textBoxNumbers
            // 
            textBoxNumbers.Location = new Point(308, 40);
            textBoxNumbers.Name = "textBoxNumbers";
            textBoxNumbers.Size = new Size(175, 27);
            textBoxNumbers.TabIndex = 1;
            // 
            // textBoxOutput
            // 
            textBoxOutput.AutoSize = true;
            textBoxOutput.Location = new Point(373, 243);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(50, 20);
            textBoxOutput.TabIndex = 2;
            textBoxOutput.Text = "label1";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxOutput);
            Controls.Add(textBoxNumbers);
            Controls.Add(btnSortDescending);
            Controls.Add(btnSortAscending);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSortAscending;
        private Button btnSortDescending;
        private TextBox textBoxNumbers;
        private Label textBoxOutput;
    }
}