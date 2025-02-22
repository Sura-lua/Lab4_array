namespace Lab4_array
{
    partial class Form6
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
            btnCalculateFor = new Button();
            btnCalculateForeach = new Button();
            textBoxNumbers = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnCalculateFor
            // 
            btnCalculateFor.Location = new Point(295, 80);
            btnCalculateFor.Name = "btnCalculateFor";
            btnCalculateFor.Size = new Size(151, 29);
            btnCalculateFor.TabIndex = 0;
            btnCalculateFor.Text = "btnCalculateFor";
            btnCalculateFor.UseVisualStyleBackColor = true;
            btnCalculateFor.Click += btnCalculateFor_Click;
            // 
            // btnCalculateForeach
            // 
            btnCalculateForeach.Location = new Point(295, 115);
            btnCalculateForeach.Name = "btnCalculateForeach";
            btnCalculateForeach.Size = new Size(160, 29);
            btnCalculateForeach.TabIndex = 0;
            btnCalculateForeach.Text = "btnCalculateForeach";
            btnCalculateForeach.UseVisualStyleBackColor = true;
            btnCalculateForeach.Click += btnCalculateForeach_Click;
            // 
            // textBoxNumbers
            // 
            textBoxNumbers.Location = new Point(295, 12);
            textBoxNumbers.Name = "textBoxNumbers";
            textBoxNumbers.Size = new Size(151, 27);
            textBoxNumbers.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 19);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "Numbers";
            // 
            // button1
            // 
            button1.Location = new Point(417, 251);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Next 32";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBoxNumbers);
            Controls.Add(btnCalculateForeach);
            Controls.Add(btnCalculateFor);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculateFor;
        private Button btnCalculateForeach;
        private TextBox textBoxNumbers;
        private Label label1;
        private Button button1;
    }
}