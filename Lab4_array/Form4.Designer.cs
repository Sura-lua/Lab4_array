namespace Lab4_array
{
    partial class Form4
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
            textBoxWidth = new TextBox();
            textBoxHeight = new TextBox();
            textBoxRadius = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(247, 37);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(181, 27);
            textBoxWidth.TabIndex = 0;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(247, 92);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(181, 27);
            textBoxHeight.TabIndex = 0;
            // 
            // textBoxRadius
            // 
            textBoxRadius.Location = new Point(247, 206);
            textBoxRadius.Name = "textBoxRadius";
            textBoxRadius.Size = new Size(181, 27);
            textBoxRadius.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(459, 35);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 44);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 99);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Height";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 213);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Radius";
            // 
            // button2
            // 
            button2.Location = new Point(459, 204);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(694, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Next 31";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxRadius);
            Controls.Add(textBoxHeight);
            Controls.Add(textBoxWidth);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxWidth;
        private TextBox textBoxHeight;
        private TextBox textBoxRadius;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
    }
}