namespace From_Hungary_for_hungry
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
            LoginLabel = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            button1 = new Button();
            textBox2 = new TextBox();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.Anchor = AnchorStyles.Top;
            LoginLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LoginLabel.ForeColor = Color.White;
            LoginLabel.Location = new Point(0, 21);
            LoginLabel.Margin = new Padding(0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(200, 39);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Login";
            LoginLabel.TextAlign = ContentAlignment.MiddleCenter;
            LoginLabel.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.AccessibleDescription = "";
            textBox1.AccessibleName = "";
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(50, 80);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Your mail";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(LoginLabel);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(300, 40);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 250);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.Aqua;
            checkBox1.Location = new Point(40, 206);
            checkBox1.Margin = new Padding(0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 17);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Keep me signed in";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(60, 164);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(80, 20);
            button1.TabIndex = 3;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.Location = new Point(50, 120);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Your password";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(200, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 120);
            panel2.TabIndex = 3;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button3.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(220, 30);
            button3.Name = "button3";
            button3.Size = new Size(197, 60);
            button3.TabIndex = 2;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button2.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(23, 30);
            button2.Name = "button2";
            button2.Size = new Size(197, 60);
            button2.TabIndex = 1;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 0;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(784, 361);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MinimumSize = new Size(800, 400);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label LoginLabel;
        private TextBox textBox1;
        private Panel panel1;
        private TextBox textBox2;
        private Button button1;
        private CheckBox checkBox1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button4;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}