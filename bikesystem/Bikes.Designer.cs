namespace bikesystem
{
    partial class Bikes
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.LogOutIcon = new System.Windows.Forms.PictureBox();
            this.BillsButton = new System.Windows.Forms.Button();
            this.BillsIcon = new System.Windows.Forms.PictureBox();
            this.UsersButton = new System.Windows.Forms.Button();
            this.User2Icon = new System.Windows.Forms.PictureBox();
            this.AccessoriesButton = new System.Windows.Forms.Button();
            this.AccessoriesIcon = new System.Windows.Forms.PictureBox();
            this.BikeStoreIcon = new System.Windows.Forms.PictureBox();
            this.HeaderText = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.ItemsManagementHeader = new System.Windows.Forms.Label();
            this.NameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.CategoryTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.PriceTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.QtyTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.DetailsTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EditBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.GunaPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.ItemsManagementIcon = new System.Windows.Forms.PictureBox();
            this.ItemsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User2Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoriesIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BikeStoreIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsManagementIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Controls.Add(this.LogOutIcon);
            this.panel1.Controls.Add(this.BillsButton);
            this.panel1.Controls.Add(this.BillsIcon);
            this.panel1.Controls.Add(this.UsersButton);
            this.panel1.Controls.Add(this.User2Icon);
            this.panel1.Controls.Add(this.AccessoriesButton);
            this.panel1.Controls.Add(this.AccessoriesIcon);
            this.panel1.Controls.Add(this.BikeStoreIcon);
            this.panel1.Controls.Add(this.HeaderText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 856);
            this.panel1.TabIndex = 8;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Black;
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.Location = new System.Drawing.Point(81, 796);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(82, 36);
            this.LogOutButton.TabIndex = 1;
            this.LogOutButton.Text = "Logout";
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.ExitIcon_Click);
            // 
            // LogOutIcon
            // 
            this.LogOutIcon.BackColor = System.Drawing.Color.Transparent;
            this.LogOutIcon.Image = global::bikesystem.Properties.Resources.icons8_logout_60;
            this.LogOutIcon.Location = new System.Drawing.Point(30, 789);
            this.LogOutIcon.Name = "LogOutIcon";
            this.LogOutIcon.Size = new System.Drawing.Size(50, 46);
            this.LogOutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogOutIcon.TabIndex = 10;
            this.LogOutIcon.TabStop = false;
            // 
            // BillsButton
            // 
            this.BillsButton.BackColor = System.Drawing.Color.Black;
            this.BillsButton.FlatAppearance.BorderSize = 0;
            this.BillsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillsButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BillsButton.ForeColor = System.Drawing.Color.White;
            this.BillsButton.Location = new System.Drawing.Point(81, 449);
            this.BillsButton.Name = "BillsButton";
            this.BillsButton.Size = new System.Drawing.Size(63, 36);
            this.BillsButton.TabIndex = 2;
            this.BillsButton.Text = "Bills";
            this.BillsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BillsButton.UseVisualStyleBackColor = false;
            this.BillsButton.Click += new System.EventHandler(this.BillsButton_Click);
            // 
            // BillsIcon
            // 
            this.BillsIcon.BackColor = System.Drawing.Color.Transparent;
            this.BillsIcon.Image = global::bikesystem.Properties.Resources.icons8_estimate_60;
            this.BillsIcon.Location = new System.Drawing.Point(30, 439);
            this.BillsIcon.Name = "BillsIcon";
            this.BillsIcon.Size = new System.Drawing.Size(50, 46);
            this.BillsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BillsIcon.TabIndex = 8;
            this.BillsIcon.TabStop = false;
            // 
            // UsersButton
            // 
            this.UsersButton.BackColor = System.Drawing.Color.Black;
            this.UsersButton.FlatAppearance.BorderSize = 0;
            this.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsersButton.ForeColor = System.Drawing.Color.White;
            this.UsersButton.Location = new System.Drawing.Point(81, 359);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(63, 36);
            this.UsersButton.TabIndex = 1;
            this.UsersButton.Text = "Users";
            this.UsersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsersButton.UseVisualStyleBackColor = false;
            // 
            // User2Icon
            // 
            this.User2Icon.BackColor = System.Drawing.Color.Transparent;
            this.User2Icon.Image = global::bikesystem.Properties.Resources.icons8_user_menu_male_64;
            this.User2Icon.Location = new System.Drawing.Point(30, 349);
            this.User2Icon.Name = "User2Icon";
            this.User2Icon.Size = new System.Drawing.Size(50, 46);
            this.User2Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.User2Icon.TabIndex = 6;
            this.User2Icon.TabStop = false;
            // 
            // AccessoriesButton
            // 
            this.AccessoriesButton.BackColor = System.Drawing.Color.Black;
            this.AccessoriesButton.FlatAppearance.BorderSize = 0;
            this.AccessoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccessoriesButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AccessoriesButton.ForeColor = System.Drawing.Color.White;
            this.AccessoriesButton.Location = new System.Drawing.Point(81, 270);
            this.AccessoriesButton.Name = "AccessoriesButton";
            this.AccessoriesButton.Size = new System.Drawing.Size(119, 36);
            this.AccessoriesButton.TabIndex = 0;
            this.AccessoriesButton.Text = "Accessories";
            this.AccessoriesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccessoriesButton.UseVisualStyleBackColor = false;
            // 
            // AccessoriesIcon
            // 
            this.AccessoriesIcon.BackColor = System.Drawing.Color.Transparent;
            this.AccessoriesIcon.Image = global::bikesystem.Properties.Resources.icons8_quad_bike_60;
            this.AccessoriesIcon.Location = new System.Drawing.Point(30, 260);
            this.AccessoriesIcon.Name = "AccessoriesIcon";
            this.AccessoriesIcon.Size = new System.Drawing.Size(50, 46);
            this.AccessoriesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AccessoriesIcon.TabIndex = 2;
            this.AccessoriesIcon.TabStop = false;
            // 
            // BikeStoreIcon
            // 
            this.BikeStoreIcon.BackColor = System.Drawing.Color.Transparent;
            this.BikeStoreIcon.Image = global::bikesystem.Properties.Resources.icons8_quad_bike_60;
            this.BikeStoreIcon.Location = new System.Drawing.Point(81, 47);
            this.BikeStoreIcon.Name = "BikeStoreIcon";
            this.BikeStoreIcon.Size = new System.Drawing.Size(50, 46);
            this.BikeStoreIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BikeStoreIcon.TabIndex = 1;
            this.BikeStoreIcon.TabStop = false;
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HeaderText.ForeColor = System.Drawing.Color.White;
            this.HeaderText.Location = new System.Drawing.Point(44, 16);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HeaderText.Size = new System.Drawing.Size(119, 30);
            this.HeaderText.TabIndex = 1;
            this.HeaderText.Text = "BikeStore";
            // 
            // ItemsManagementHeader
            // 
            this.ItemsManagementHeader.AutoSize = true;
            this.ItemsManagementHeader.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ItemsManagementHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.ItemsManagementHeader.Location = new System.Drawing.Point(303, 25);
            this.ItemsManagementHeader.Name = "ItemsManagementHeader";
            this.ItemsManagementHeader.Size = new System.Drawing.Size(227, 37);
            this.ItemsManagementHeader.TabIndex = 1;
            this.ItemsManagementHeader.Text = "Items Management";
            // 
            // NameTb
            // 
            this.NameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTb.DefaultText = "";
            this.NameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTb.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTb.Location = new System.Drawing.Point(258, 198);
            this.NameTb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NameTb.Name = "NameTb";
            this.NameTb.PasswordChar = '\0';
            this.NameTb.PlaceholderText = "Item Name";
            this.NameTb.SelectedText = "";
            this.NameTb.Size = new System.Drawing.Size(283, 40);
            this.NameTb.TabIndex = 0;
            // 
            // CategoryTb
            // 
            this.CategoryTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryTb.DefaultText = "";
            this.CategoryTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CategoryTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CategoryTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CategoryTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CategoryTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryTb.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CategoryTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryTb.Location = new System.Drawing.Point(258, 338);
            this.CategoryTb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CategoryTb.Name = "CategoryTb";
            this.CategoryTb.PasswordChar = '\0';
            this.CategoryTb.PlaceholderText = "Item Category";
            this.CategoryTb.SelectedText = "";
            this.CategoryTb.Size = new System.Drawing.Size(283, 40);
            this.CategoryTb.TabIndex = 2;
            // 
            // PriceTb
            // 
            this.PriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTb.DefaultText = "";
            this.PriceTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PriceTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PriceTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTb.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PriceTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTb.Location = new System.Drawing.Point(258, 270);
            this.PriceTb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.PasswordChar = '\0';
            this.PriceTb.PlaceholderText = "Item Price";
            this.PriceTb.SelectedText = "";
            this.PriceTb.Size = new System.Drawing.Size(283, 40);
            this.PriceTb.TabIndex = 1;
            // 
            // QtyTb
            // 
            this.QtyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QtyTb.DefaultText = "";
            this.QtyTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QtyTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QtyTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QtyTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QtyTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QtyTb.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.QtyTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QtyTb.Location = new System.Drawing.Point(258, 479);
            this.QtyTb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.PasswordChar = '\0';
            this.QtyTb.PlaceholderText = "Quantity";
            this.QtyTb.SelectedText = "";
            this.QtyTb.Size = new System.Drawing.Size(283, 40);
            this.QtyTb.TabIndex = 4;
            // 
            // DetailsTb
            // 
            this.DetailsTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DetailsTb.DefaultText = "";
            this.DetailsTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DetailsTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DetailsTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DetailsTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DetailsTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DetailsTb.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DetailsTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DetailsTb.Location = new System.Drawing.Point(258, 407);
            this.DetailsTb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DetailsTb.Name = "DetailsTb";
            this.DetailsTb.PasswordChar = '\0';
            this.DetailsTb.PlaceholderText = "Item Details";
            this.DetailsTb.SelectedText = "";
            this.DetailsTb.Size = new System.Drawing.Size(283, 40);
            this.DetailsTb.TabIndex = 3;
            // 
            // AddBtn
            // 
            this.AddBtn.BorderRadius = 12;
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.AddBtn.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddBtn.ForeColor = System.Drawing.Color.Black;
            this.AddBtn.Location = new System.Drawing.Point(237, 570);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(150, 45);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add Item";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BorderRadius = 12;
            this.EditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditBtn.FillColor = System.Drawing.Color.Black;
            this.EditBtn.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(418, 570);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(150, 45);
            this.EditBtn.TabIndex = 6;
            this.EditBtn.Text = "Edit Item";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BorderRadius = 12;
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.FillColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(324, 631);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(150, 45);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Delete Item";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // GunaPanel
            // 
            this.GunaPanel.AutoRoundedCorners = true;
            this.GunaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.GunaPanel.BorderRadius = 4;
            this.GunaPanel.BorderThickness = 1;
            this.GunaPanel.Location = new System.Drawing.Point(586, 86);
            this.GunaPanel.Name = "GunaPanel";
            this.GunaPanel.Size = new System.Drawing.Size(11, 732);
            this.GunaPanel.TabIndex = 12;
            // 
            // ExitIcon
            // 
            this.ExitIcon.BackColor = System.Drawing.Color.Transparent;
            this.ExitIcon.Image = global::bikesystem.Properties.Resources.icons8_back_64;
            this.ExitIcon.Location = new System.Drawing.Point(1471, 0);
            this.ExitIcon.Name = "ExitIcon";
            this.ExitIcon.Size = new System.Drawing.Size(50, 46);
            this.ExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitIcon.TabIndex = 14;
            this.ExitIcon.TabStop = false;
            this.ExitIcon.Click += new System.EventHandler(this.ExitIcon_Click);
            // 
            // ItemsManagementIcon
            // 
            this.ItemsManagementIcon.BackColor = System.Drawing.Color.Transparent;
            this.ItemsManagementIcon.Image = global::bikesystem.Properties.Resources.icons8_scooter_60;
            this.ItemsManagementIcon.Location = new System.Drawing.Point(247, 16);
            this.ItemsManagementIcon.Name = "ItemsManagementIcon";
            this.ItemsManagementIcon.Size = new System.Drawing.Size(50, 46);
            this.ItemsManagementIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ItemsManagementIcon.TabIndex = 2;
            this.ItemsManagementIcon.TabStop = false;
            // 
            // ItemsDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ItemsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ItemsDGV.ColumnHeadersHeight = 30;
            this.ItemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ItemsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsDGV.Location = new System.Drawing.Point(625, 126);
            this.ItemsDGV.Name = "ItemsDGV";
            this.ItemsDGV.RowHeadersVisible = false;
            this.ItemsDGV.Size = new System.Drawing.Size(863, 683);
            this.ItemsDGV.TabIndex = 28;
            this.ItemsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ItemsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ItemsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ItemsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ItemsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ItemsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ItemsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ItemsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ItemsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ItemsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ItemsDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.ItemsDGV.ThemeStyle.ReadOnly = false;
            this.ItemsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ItemsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemsDGV.ThemeStyle.RowsStyle.Height = 22;
            this.ItemsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDGV_CellContentClick_1);
            // 
            // Bikes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1520, 856);
            this.Controls.Add(this.ItemsDGV);
            this.Controls.Add(this.ExitIcon);
            this.Controls.Add(this.GunaPanel);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.DetailsTb);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.CategoryTb);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.ItemsManagementIcon);
            this.Controls.Add(this.ItemsManagementHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bikes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User2Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoriesIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BikeStoreIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsManagementIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HeaderText;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.PictureBox BikeStoreIcon;
        private System.Windows.Forms.PictureBox AccessoriesIcon;
        private System.Windows.Forms.Button AccessoriesButton;
        private System.Windows.Forms.PictureBox User2Icon;
        private System.Windows.Forms.PictureBox BillsIcon;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button BillsButton;
        private System.Windows.Forms.PictureBox LogOutIcon;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label ItemsManagementHeader;
        private System.Windows.Forms.PictureBox ItemsManagementIcon;
        private Guna.UI2.WinForms.Guna2TextBox NameTb;
        private Guna.UI2.WinForms.Guna2TextBox CategoryTb;
        private Guna.UI2.WinForms.Guna2TextBox PriceTb;
        private Guna.UI2.WinForms.Guna2TextBox QtyTb;
        private Guna.UI2.WinForms.Guna2TextBox DetailsTb;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private Guna.UI2.WinForms.Guna2Button EditBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Panel GunaPanel;
        private System.Windows.Forms.PictureBox ExitIcon;
        private Guna.UI2.WinForms.Guna2DataGridView ItemsDGV;
    }
}

