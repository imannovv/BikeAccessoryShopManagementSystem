namespace bikesystem
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.LogOutIcon = new System.Windows.Forms.PictureBox();
            this.BillsButton = new System.Windows.Forms.Button();
            this.BillsIcon = new System.Windows.Forms.PictureBox();
            this.User2Button = new System.Windows.Forms.Button();
            this.User2Icon = new System.Windows.Forms.PictureBox();
            this.User1Button = new System.Windows.Forms.Button();
            this.User1Icon = new System.Windows.Forms.PictureBox();
            this.AccessoriesButton = new System.Windows.Forms.Button();
            this.AccessoriesIcon = new System.Windows.Forms.PictureBox();
            this.BikeStoreIcon = new System.Windows.Forms.PictureBox();
            this.HeaderText = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.ItemsManagementHeader = new System.Windows.Forms.Label();
            this.ItemNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ItemCategoryBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ItemPriceBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.QuantityBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ItemDetailsBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddItemButton = new Guna.UI2.WinForms.Guna2Button();
            this.EditItemButton = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteItemButton = new Guna.UI2.WinForms.Guna2Button();
            this.GunaPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BackIcon = new System.Windows.Forms.PictureBox();
            this.ItemsManagementIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User2Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User1Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoriesIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BikeStoreIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsManagementIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Controls.Add(this.LogOutIcon);
            this.panel1.Controls.Add(this.BillsButton);
            this.panel1.Controls.Add(this.BillsIcon);
            this.panel1.Controls.Add(this.User2Button);
            this.panel1.Controls.Add(this.User2Icon);
            this.panel1.Controls.Add(this.User1Button);
            this.panel1.Controls.Add(this.User1Icon);
            this.panel1.Controls.Add(this.AccessoriesButton);
            this.panel1.Controls.Add(this.AccessoriesIcon);
            this.panel1.Controls.Add(this.BikeStoreIcon);
            this.panel1.Controls.Add(this.HeaderText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 888);
            this.panel1.TabIndex = 0;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.Location = new System.Drawing.Point(81, 823);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(82, 36);
            this.LogOutButton.TabIndex = 11;
            this.LogOutButton.Text = "Logout";
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutButton.UseVisualStyleBackColor = false;
            // 
            // LogOutIcon
            // 
            this.LogOutIcon.BackColor = System.Drawing.Color.Transparent;
            this.LogOutIcon.Image = global::bikesystem.Properties.Resources.icons8_logout_60;
            this.LogOutIcon.Location = new System.Drawing.Point(30, 813);
            this.LogOutIcon.Name = "LogOutIcon";
            this.LogOutIcon.Size = new System.Drawing.Size(50, 46);
            this.LogOutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogOutIcon.TabIndex = 10;
            this.LogOutIcon.TabStop = false;
            // 
            // BillsButton
            // 
            this.BillsButton.BackColor = System.Drawing.Color.Transparent;
            this.BillsButton.FlatAppearance.BorderSize = 0;
            this.BillsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillsButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BillsButton.ForeColor = System.Drawing.Color.White;
            this.BillsButton.Location = new System.Drawing.Point(81, 536);
            this.BillsButton.Name = "BillsButton";
            this.BillsButton.Size = new System.Drawing.Size(63, 36);
            this.BillsButton.TabIndex = 9;
            this.BillsButton.Text = "Bills";
            this.BillsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BillsButton.UseVisualStyleBackColor = false;
            // 
            // BillsIcon
            // 
            this.BillsIcon.BackColor = System.Drawing.Color.Transparent;
            this.BillsIcon.Image = global::bikesystem.Properties.Resources.icons8_estimate_60;
            this.BillsIcon.Location = new System.Drawing.Point(30, 526);
            this.BillsIcon.Name = "BillsIcon";
            this.BillsIcon.Size = new System.Drawing.Size(50, 46);
            this.BillsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BillsIcon.TabIndex = 8;
            this.BillsIcon.TabStop = false;
            // 
            // User2Button
            // 
            this.User2Button.BackColor = System.Drawing.Color.Transparent;
            this.User2Button.FlatAppearance.BorderSize = 0;
            this.User2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User2Button.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.User2Button.ForeColor = System.Drawing.Color.White;
            this.User2Button.Location = new System.Drawing.Point(81, 446);
            this.User2Button.Name = "User2Button";
            this.User2Button.Size = new System.Drawing.Size(63, 36);
            this.User2Button.TabIndex = 7;
            this.User2Button.Text = "User2";
            this.User2Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.User2Button.UseVisualStyleBackColor = false;
            // 
            // User2Icon
            // 
            this.User2Icon.BackColor = System.Drawing.Color.Transparent;
            this.User2Icon.Image = global::bikesystem.Properties.Resources.icons8_user_menu_male_64;
            this.User2Icon.Location = new System.Drawing.Point(30, 436);
            this.User2Icon.Name = "User2Icon";
            this.User2Icon.Size = new System.Drawing.Size(50, 46);
            this.User2Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.User2Icon.TabIndex = 6;
            this.User2Icon.TabStop = false;
            // 
            // User1Button
            // 
            this.User1Button.BackColor = System.Drawing.Color.Transparent;
            this.User1Button.FlatAppearance.BorderSize = 0;
            this.User1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User1Button.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.User1Button.ForeColor = System.Drawing.Color.White;
            this.User1Button.Location = new System.Drawing.Point(81, 359);
            this.User1Button.Name = "User1Button";
            this.User1Button.Size = new System.Drawing.Size(63, 36);
            this.User1Button.TabIndex = 5;
            this.User1Button.Text = "User1";
            this.User1Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.User1Button.UseVisualStyleBackColor = false;
            this.User1Button.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // User1Icon
            // 
            this.User1Icon.BackColor = System.Drawing.Color.Transparent;
            this.User1Icon.Image = global::bikesystem.Properties.Resources.icons8_quad_bike_60;
            this.User1Icon.Location = new System.Drawing.Point(30, 349);
            this.User1Icon.Name = "User1Icon";
            this.User1Icon.Size = new System.Drawing.Size(50, 46);
            this.User1Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.User1Icon.TabIndex = 4;
            this.User1Icon.TabStop = false;
            // 
            // AccessoriesButton
            // 
            this.AccessoriesButton.BackColor = System.Drawing.Color.Transparent;
            this.AccessoriesButton.FlatAppearance.BorderSize = 0;
            this.AccessoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccessoriesButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AccessoriesButton.ForeColor = System.Drawing.Color.White;
            this.AccessoriesButton.Location = new System.Drawing.Point(81, 270);
            this.AccessoriesButton.Name = "AccessoriesButton";
            this.AccessoriesButton.Size = new System.Drawing.Size(119, 36);
            this.AccessoriesButton.TabIndex = 3;
            this.AccessoriesButton.Text = "Accessories";
            this.AccessoriesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccessoriesButton.UseVisualStyleBackColor = false;
            this.AccessoriesButton.Click += new System.EventHandler(this.button1_Click_1);
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
            this.AccessoriesIcon.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.BikeStoreIcon.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.HeaderText.Click += new System.EventHandler(this.label1_Click);
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
            this.ItemsManagementHeader.Click += new System.EventHandler(this.ItemsManagementHeader_Click);
            // 
            // ItemNameBox
            // 
            this.ItemNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ItemNameBox.DefaultText = "";
            this.ItemNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ItemNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ItemNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ItemNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ItemNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemNameBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ItemNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemNameBox.Location = new System.Drawing.Point(327, 198);
            this.ItemNameBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ItemNameBox.Name = "ItemNameBox";
            this.ItemNameBox.PasswordChar = '\0';
            this.ItemNameBox.PlaceholderText = "Item Name";
            this.ItemNameBox.SelectedText = "";
            this.ItemNameBox.Size = new System.Drawing.Size(283, 40);
            this.ItemNameBox.TabIndex = 3;
            this.ItemNameBox.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // ItemCategoryBox
            // 
            this.ItemCategoryBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ItemCategoryBox.DefaultText = "";
            this.ItemCategoryBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ItemCategoryBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ItemCategoryBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ItemCategoryBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ItemCategoryBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemCategoryBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ItemCategoryBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemCategoryBox.Location = new System.Drawing.Point(327, 338);
            this.ItemCategoryBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ItemCategoryBox.Name = "ItemCategoryBox";
            this.ItemCategoryBox.PasswordChar = '\0';
            this.ItemCategoryBox.PlaceholderText = "Item Category";
            this.ItemCategoryBox.SelectedText = "";
            this.ItemCategoryBox.Size = new System.Drawing.Size(283, 40);
            this.ItemCategoryBox.TabIndex = 4;
            // 
            // ItemPriceBox
            // 
            this.ItemPriceBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ItemPriceBox.DefaultText = "";
            this.ItemPriceBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ItemPriceBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ItemPriceBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ItemPriceBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ItemPriceBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemPriceBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ItemPriceBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemPriceBox.Location = new System.Drawing.Point(327, 270);
            this.ItemPriceBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ItemPriceBox.Name = "ItemPriceBox";
            this.ItemPriceBox.PasswordChar = '\0';
            this.ItemPriceBox.PlaceholderText = "Item Price";
            this.ItemPriceBox.SelectedText = "";
            this.ItemPriceBox.Size = new System.Drawing.Size(283, 40);
            this.ItemPriceBox.TabIndex = 5;
            // 
            // QuantityBox
            // 
            this.QuantityBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityBox.DefaultText = "";
            this.QuantityBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuantityBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuantityBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.QuantityBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityBox.Location = new System.Drawing.Point(327, 479);
            this.QuantityBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.PasswordChar = '\0';
            this.QuantityBox.PlaceholderText = "Quantity";
            this.QuantityBox.SelectedText = "";
            this.QuantityBox.Size = new System.Drawing.Size(283, 40);
            this.QuantityBox.TabIndex = 8;
            // 
            // ItemDetailsBox
            // 
            this.ItemDetailsBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ItemDetailsBox.DefaultText = "";
            this.ItemDetailsBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ItemDetailsBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ItemDetailsBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ItemDetailsBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ItemDetailsBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemDetailsBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ItemDetailsBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemDetailsBox.Location = new System.Drawing.Point(327, 407);
            this.ItemDetailsBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ItemDetailsBox.Name = "ItemDetailsBox";
            this.ItemDetailsBox.PasswordChar = '\0';
            this.ItemDetailsBox.PlaceholderText = "Item Details";
            this.ItemDetailsBox.SelectedText = "";
            this.ItemDetailsBox.Size = new System.Drawing.Size(283, 40);
            this.ItemDetailsBox.TabIndex = 6;
            // 
            // AddItemButton
            // 
            this.AddItemButton.BorderRadius = 12;
            this.AddItemButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddItemButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddItemButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddItemButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddItemButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.AddItemButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddItemButton.ForeColor = System.Drawing.Color.Black;
            this.AddItemButton.Location = new System.Drawing.Point(268, 597);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(180, 45);
            this.AddItemButton.TabIndex = 9;
            this.AddItemButton.Text = "Add Item";
            // 
            // EditItemButton
            // 
            this.EditItemButton.BorderRadius = 12;
            this.EditItemButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditItemButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditItemButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditItemButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditItemButton.FillColor = System.Drawing.Color.Black;
            this.EditItemButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditItemButton.ForeColor = System.Drawing.Color.White;
            this.EditItemButton.Location = new System.Drawing.Point(494, 597);
            this.EditItemButton.Name = "EditItemButton";
            this.EditItemButton.Size = new System.Drawing.Size(180, 45);
            this.EditItemButton.TabIndex = 10;
            this.EditItemButton.Text = "Edit Item";
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.BorderRadius = 12;
            this.DeleteItemButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteItemButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteItemButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteItemButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteItemButton.FillColor = System.Drawing.Color.Crimson;
            this.DeleteItemButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteItemButton.ForeColor = System.Drawing.Color.White;
            this.DeleteItemButton.Location = new System.Drawing.Point(371, 664);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(180, 45);
            this.DeleteItemButton.TabIndex = 11;
            this.DeleteItemButton.Text = "Delete Item";
            // 
            // GunaPanel
            // 
            this.GunaPanel.AutoRoundedCorners = true;
            this.GunaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.GunaPanel.BorderRadius = 4;
            this.GunaPanel.BorderThickness = 1;
            this.GunaPanel.Location = new System.Drawing.Point(731, 103);
            this.GunaPanel.Name = "GunaPanel";
            this.GunaPanel.Size = new System.Drawing.Size(11, 732);
            this.GunaPanel.TabIndex = 12;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle30;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(764, 169);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(707, 640);
            this.guna2DataGridView1.TabIndex = 13;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // BackIcon
            // 
            this.BackIcon.BackColor = System.Drawing.Color.Transparent;
            this.BackIcon.Image = global::bikesystem.Properties.Resources.icons8_back_64;
            this.BackIcon.Location = new System.Drawing.Point(1434, 0);
            this.BackIcon.Name = "BackIcon";
            this.BackIcon.Size = new System.Drawing.Size(50, 46);
            this.BackIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackIcon.TabIndex = 14;
            this.BackIcon.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1483, 888);
            this.Controls.Add(this.BackIcon);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.GunaPanel);
            this.Controls.Add(this.DeleteItemButton);
            this.Controls.Add(this.EditItemButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.ItemDetailsBox);
            this.Controls.Add(this.ItemPriceBox);
            this.Controls.Add(this.ItemCategoryBox);
            this.Controls.Add(this.ItemNameBox);
            this.Controls.Add(this.ItemsManagementIcon);
            this.Controls.Add(this.ItemsManagementHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User2Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User1Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoriesIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BikeStoreIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsManagementIcon)).EndInit();
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
        private System.Windows.Forms.PictureBox User1Icon;
        private System.Windows.Forms.Button User1Button;
        private System.Windows.Forms.PictureBox User2Icon;
        private System.Windows.Forms.PictureBox BillsIcon;
        private System.Windows.Forms.Button User2Button;
        private System.Windows.Forms.Button BillsButton;
        private System.Windows.Forms.PictureBox LogOutIcon;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label ItemsManagementHeader;
        private System.Windows.Forms.PictureBox ItemsManagementIcon;
        private Guna.UI2.WinForms.Guna2TextBox ItemNameBox;
        private Guna.UI2.WinForms.Guna2TextBox ItemCategoryBox;
        private Guna.UI2.WinForms.Guna2TextBox ItemPriceBox;
        private Guna.UI2.WinForms.Guna2TextBox QuantityBox;
        private Guna.UI2.WinForms.Guna2TextBox ItemDetailsBox;
        private Guna.UI2.WinForms.Guna2Button AddItemButton;
        private Guna.UI2.WinForms.Guna2Button EditItemButton;
        private Guna.UI2.WinForms.Guna2Button DeleteItemButton;
        private Guna.UI2.WinForms.Guna2Panel GunaPanel;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.PictureBox BackIcon;
    }
}

