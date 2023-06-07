namespace From_Hungary_for_hungry
{
    partial class CustomerForm
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
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            CartPanel = new Panel();
            MenuPanel = new Panel();
            button1 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            CartPanel.SuspendLayout();
            MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveBorder;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "5.0 - Pizza 4 Sale", "5.0 - Grapes Lounge Pub", "5.0 - Coffemania", "5.0 - The Brunch", "5.0 - Homely Café", "5.0 - The Eat Spot", "5.0 - The Hash House", "5.0 - The Pit Spot", "5.0 - The Snack Bar", "5.0 - The Pub", "5.0 - The Deli", "5.0 - The British Tea House", "5.0 - The Beerhouse", "5.0 - Cocktail", "5.0 - The Tied House", "5.0 - Brasserie", "5.0 - Café Spot", "5.0 - The Outlet Hub", "5.0 - The Former", "5.0 - The Juke", "5.0 - Entertainment Spot", "5.0 - The Food Resort", "5.0 - The Pub Hub", "5.0 - Sustainable", "5.0 - The Minor", "5.0 - Eatable", "5.0 - The Long Dinner", "5.0 - The Star Hub", "5.0 - The Deli Food", "5.0 - Flourish", "5.0 - Egg and Bowl", "5.0 - The Rice Bowl", "5.0 - The Dune", "5.0 - Casual Restaurant", "5.0 - The Shabby Space", "5.0 - The Incorporative", "5.0 - The Natural Resort", "5.0 - Eatery Spot", "5.0 - The Coffee Spot", "5.0 - The Ample Service", "5.0 - Busy Dine", "5.0 - The Tasty Spot", "5.0 - Fancy Co.", "5.0 - The Meals", "5.0 - The Dawn", "5.0 - Thyme for Lunch", "5.0 - Wok This Way", "5.0 - Lettuce Eat", "5.0 - Pho Real", "5.0 - Pita Pan", "5.0 - Lord of the Fries", "5.0 - Grillenium Falcon", "5.0 - Tequila Mockingbird" });
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(276, 424);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Image1;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // CartPanel
            // 
            CartPanel.BackColor = SystemColors.ActiveCaption;
            CartPanel.Controls.Add(button2);
            CartPanel.Controls.Add(pictureBox1);
            CartPanel.Location = new Point(622, 12);
            CartPanel.Name = "CartPanel";
            CartPanel.Size = new Size(166, 424);
            CartPanel.TabIndex = 2;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = SystemColors.ActiveCaption;
            MenuPanel.Controls.Add(button1);
            MenuPanel.Controls.Add(label1);
            MenuPanel.Controls.Add(pictureBox2);
            MenuPanel.Location = new Point(294, 12);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(325, 424);
            MenuPanel.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(143, 398);
            button1.Name = "button1";
            button1.Size = new Size(40, 23);
            button1.TabIndex = 4;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 18);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Image2;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 42);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(51, 398);
            button2.Name = "button2";
            button2.Size = new Size(67, 23);
            button2.TabIndex = 5;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(CartPanel);
            Controls.Add(MenuPanel);
            Name = "CustomerForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            CartPanel.ResumeLayout(false);
            MenuPanel.ResumeLayout(false);
            MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Panel CartPanel;
        private Panel MenuPanel;
        private PictureBox pictureBox2;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}