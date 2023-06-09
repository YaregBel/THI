namespace Lab_5_for_THP
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 11);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(96, 36);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 51);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(96, 39);
            button2.TabIndex = 1;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(12, 94);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(96, 37);
            button3.TabIndex = 2;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 150);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 3;
            label1.Text = "Общий вес";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(114, 150);
            label2.Name = "label2";
            label2.Size = new Size(19, 21);
            label2.TabIndex = 5;
            label2.Text = "0";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(114, 11);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(166, 124);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 182);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        public ListBox listBox1;
        public Label label2;
    }
}