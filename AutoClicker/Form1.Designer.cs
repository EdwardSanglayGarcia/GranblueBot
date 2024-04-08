namespace AutoClicker
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
            lblMousePosition = new Label();
            btnClicker = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblMousePosition
            // 
            lblMousePosition.AutoSize = true;
            lblMousePosition.Location = new Point(12, 9);
            lblMousePosition.Name = "lblMousePosition";
            lblMousePosition.Size = new Size(38, 15);
            lblMousePosition.TabIndex = 0;
            lblMousePosition.Text = "label1";
            // 
            // btnClicker
            // 
            btnClicker.Location = new Point(12, 46);
            btnClicker.Name = "btnClicker";
            btnClicker.Size = new Size(75, 23);
            btnClicker.TabIndex = 1;
            btnClicker.Text = "button1";
            btnClicker.UseVisualStyleBackColor = true;
            btnClicker.Click += btnClicker_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 75);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 193);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btnClicker);
            Controls.Add(lblMousePosition);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMousePosition;
        private Button btnClicker;
        private TextBox textBox1;
    }
}
