namespace Lab4_array
{
    partial class Form5
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
            button1 = new Button();
            textBoxSymbol = new TextBox();
            textBoxSize = new TextBox();
            comboBoxPattern = new TextBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(43, 111);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxSymbol
            // 
            textBoxSymbol.Location = new Point(12, 12);
            textBoxSymbol.Name = "textBoxSymbol";
            textBoxSymbol.Size = new Size(125, 27);
            textBoxSymbol.TabIndex = 1;
            // 
            // textBoxSize
            // 
            textBoxSize.Location = new Point(12, 45);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(125, 27);
            textBoxSize.TabIndex = 1;
            // 
            // comboBoxPattern
            // 
            comboBoxPattern.Location = new Point(12, 78);
            comboBoxPattern.Name = "comboBoxPattern";
            comboBoxPattern.Size = new Size(125, 27);
            comboBoxPattern.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(484, 32);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // button2
            // 
            button2.Location = new Point(694, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Next 32";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(comboBoxPattern);
            Controls.Add(textBoxSize);
            Controls.Add(textBoxSymbol);
            Controls.Add(button1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxSymbol;
        private TextBox textBoxSize;
        private TextBox comboBoxPattern;
        private Label label1;
        private Button button2;
    }
}