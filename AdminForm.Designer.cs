namespace From_Hungary_for_hungry
{
    partial class AdminForm
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
            restaurantsDt = new DataGridView();
            menuPnl = new Panel();
            logoutBtn = new Button();
            allAccountsBtn = new Button();
            allRestaurantsBtn = new Button();
            mainPnl = new Panel();
            label1 = new Label();
            allAccountsPnl = new Panel();
            accountsDt = new DataGridView();
            label2 = new Label();
            deleteAccountBtn = new Button();
            allRestaurantsPnl = new Panel();
            rmvMembershipBtn = new Button();
            membershipBtn = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)restaurantsDt).BeginInit();
            menuPnl.SuspendLayout();
            mainPnl.SuspendLayout();
            allAccountsPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accountsDt).BeginInit();
            allRestaurantsPnl.SuspendLayout();
            SuspendLayout();
            // 
            // restaurantsDt
            // 
            restaurantsDt.AllowUserToAddRows = false;
            restaurantsDt.AllowUserToDeleteRows = false;
            restaurantsDt.AllowUserToOrderColumns = true;
            restaurantsDt.AllowUserToResizeColumns = false;
            restaurantsDt.AllowUserToResizeRows = false;
            restaurantsDt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            restaurantsDt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            restaurantsDt.BorderStyle = BorderStyle.None;
            restaurantsDt.CellBorderStyle = DataGridViewCellBorderStyle.None;
            restaurantsDt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            restaurantsDt.EditMode = DataGridViewEditMode.EditOnEnter;
            restaurantsDt.Location = new Point(68, 115);
            restaurantsDt.Name = "restaurantsDt";
            restaurantsDt.ReadOnly = true;
            restaurantsDt.RowHeadersVisible = false;
            restaurantsDt.RowHeadersWidth = 51;
            restaurantsDt.RowTemplate.Height = 29;
            restaurantsDt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            restaurantsDt.ShowCellErrors = false;
            restaurantsDt.ShowCellToolTips = false;
            restaurantsDt.ShowEditingIcon = false;
            restaurantsDt.ShowRowErrors = false;
            restaurantsDt.Size = new Size(820, 382);
            restaurantsDt.TabIndex = 2;
            // 
            // menuPnl
            // 
            menuPnl.BackColor = SystemColors.ControlDark;
            menuPnl.Controls.Add(logoutBtn);
            menuPnl.Controls.Add(allAccountsBtn);
            menuPnl.Controls.Add(allRestaurantsBtn);
            menuPnl.Dock = DockStyle.Left;
            menuPnl.Location = new Point(0, 0);
            menuPnl.Name = "menuPnl";
            menuPnl.Size = new Size(324, 673);
            menuPnl.TabIndex = 0;
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new Point(12, 343);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(297, 69);
            logoutBtn.TabIndex = 2;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // allAccountsBtn
            // 
            allAccountsBtn.Location = new Point(12, 268);
            allAccountsBtn.Name = "allAccountsBtn";
            allAccountsBtn.Size = new Size(297, 69);
            allAccountsBtn.TabIndex = 1;
            allAccountsBtn.Text = "View All Accounts";
            allAccountsBtn.UseVisualStyleBackColor = true;
            allAccountsBtn.Click += allAccountsBtn_Click;
            // 
            // allRestaurantsBtn
            // 
            allRestaurantsBtn.Location = new Point(12, 193);
            allRestaurantsBtn.Name = "allRestaurantsBtn";
            allRestaurantsBtn.Size = new Size(297, 69);
            allRestaurantsBtn.TabIndex = 0;
            allRestaurantsBtn.Text = "View All Restaurants";
            allRestaurantsBtn.UseVisualStyleBackColor = true;
            allRestaurantsBtn.Click += allRestaurantsBtn_Click;
            // 
            // mainPnl
            // 
            mainPnl.Controls.Add(label1);
            mainPnl.Dock = DockStyle.Right;
            mainPnl.Location = new Point(330, 0);
            mainPnl.Name = "mainPnl";
            mainPnl.Size = new Size(932, 673);
            mainPnl.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 63);
            label1.Name = "label1";
            label1.Size = new Size(284, 31);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Admin Panel";
            // 
            // allAccountsPnl
            // 
            allAccountsPnl.Controls.Add(accountsDt);
            allAccountsPnl.Controls.Add(label2);
            allAccountsPnl.Controls.Add(deleteAccountBtn);
            allAccountsPnl.Location = new Point(330, 0);
            allAccountsPnl.Name = "allAccountsPnl";
            allAccountsPnl.Size = new Size(932, 673);
            allAccountsPnl.TabIndex = 1;
            // 
            // accountsDt
            // 
            accountsDt.AllowUserToAddRows = false;
            accountsDt.AllowUserToDeleteRows = false;
            accountsDt.AllowUserToOrderColumns = true;
            accountsDt.AllowUserToResizeColumns = false;
            accountsDt.AllowUserToResizeRows = false;
            accountsDt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            accountsDt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            accountsDt.BorderStyle = BorderStyle.None;
            accountsDt.CellBorderStyle = DataGridViewCellBorderStyle.None;
            accountsDt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountsDt.Location = new Point(68, 126);
            accountsDt.Name = "accountsDt";
            accountsDt.ReadOnly = true;
            accountsDt.RowHeadersVisible = false;
            accountsDt.RowHeadersWidth = 51;
            accountsDt.RowTemplate.Height = 29;
            accountsDt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            accountsDt.Size = new Size(820, 371);
            accountsDt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(68, 72);
            label2.Name = "label2";
            label2.Size = new Size(149, 31);
            label2.TabIndex = 1;
            label2.Text = "All Accounts";
            // 
            // deleteAccountBtn
            // 
            deleteAccountBtn.Location = new Point(68, 523);
            deleteAccountBtn.Name = "deleteAccountBtn";
            deleteAccountBtn.Size = new Size(175, 29);
            deleteAccountBtn.TabIndex = 0;
            deleteAccountBtn.Text = "Delete Account";
            deleteAccountBtn.UseVisualStyleBackColor = true;
            deleteAccountBtn.Click += deleteAccountBtn_Click;
            // 
            // allRestaurantsPnl
            // 
            allRestaurantsPnl.Controls.Add(rmvMembershipBtn);
            allRestaurantsPnl.Controls.Add(restaurantsDt);
            allRestaurantsPnl.Controls.Add(membershipBtn);
            allRestaurantsPnl.Controls.Add(label3);
            allRestaurantsPnl.Location = new Point(330, 0);
            allRestaurantsPnl.Name = "allRestaurantsPnl";
            allRestaurantsPnl.Size = new Size(932, 673);
            allRestaurantsPnl.TabIndex = 3;
            // 
            // rmvMembershipBtn
            // 
            rmvMembershipBtn.Location = new Point(249, 523);
            rmvMembershipBtn.Name = "rmvMembershipBtn";
            rmvMembershipBtn.Size = new Size(175, 29);
            rmvMembershipBtn.TabIndex = 3;
            rmvMembershipBtn.Text = "Remove Membership";
            rmvMembershipBtn.UseVisualStyleBackColor = true;
            rmvMembershipBtn.Click += rmvMembershipBtn_Click;
            // 
            // membershipBtn
            // 
            membershipBtn.Location = new Point(68, 523);
            membershipBtn.Name = "membershipBtn";
            membershipBtn.Size = new Size(175, 29);
            membershipBtn.TabIndex = 1;
            membershipBtn.Text = "Give Membership";
            membershipBtn.UseVisualStyleBackColor = true;
            membershipBtn.Click += membershipBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(68, 63);
            label3.Name = "label3";
            label3.Size = new Size(175, 31);
            label3.TabIndex = 0;
            label3.Text = "All Restaurants";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(menuPnl);
            Controls.Add(allRestaurantsPnl);
            Controls.Add(allAccountsPnl);
            Controls.Add(mainPnl);
            MaximizeBox = false;
            Name = "AdminForm";
            Text = "Admin Panel";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)restaurantsDt).EndInit();
            menuPnl.ResumeLayout(false);
            mainPnl.ResumeLayout(false);
            mainPnl.PerformLayout();
            allAccountsPnl.ResumeLayout(false);
            allAccountsPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)accountsDt).EndInit();
            allRestaurantsPnl.ResumeLayout(false);
            allRestaurantsPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuPnl;
        private Panel mainPnl;
        private Button logoutBtn;
        private Button allAccountsBtn;
        private Button allRestaurantsBtn;
        private Label label1;
        private Panel allAccountsPnl;
        private Label label2;
        private Button deleteAccountBtn;
        private Panel allRestaurantsPnl;
        private Label label3;
        private Button membershipBtn;
        private DataGridView accountsDt;
        private DataGridView restaurantsDt;
        private Button rmvMembershipBtn;
    }
}