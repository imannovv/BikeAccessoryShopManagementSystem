namespace bikesystem
{
    partial class Users
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UsersDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.GunaPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EditBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddressTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.PhoneTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.PassWordTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsersManagementHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.LogOutIcon = new System.Windows.Forms.PictureBox();
            this.BillsButton = new System.Windows.Forms.Button();
            this.BillsIcon = new System.Windows.Forms.PictureBox();
            this.Users_UsersButton = new System.Windows.Forms.Button();
            this.User2Icon = new System.Windows.Forms.PictureBox();
            this.AccessoriesButton = new System.Windows.Forms.Button();
            this.AccessoriesIcon = new System.Windows.Forms.PictureBox();
            this.BikeStoreIcon = new System.Windows.Forms.PictureBox();
            this.HeaderText = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.UNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.ItemsManagementIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User2Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoriesIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BikeStoreIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsManagementIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.UsersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UsersDGV.ColumnHeadersHeight = 30;
            this.UsersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.UsersDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UsersDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersDGV.Location = new System.Drawing.Point(624, 126);
            this.UsersDGV.Name = "UsersDGV";
            this.UsersDGV.RowHeadersVisible = false;
            this.UsersDGV.Size = new System.Drawing.Size(863, 683);
            this.UsersDGV.TabIndex = 27;
            this.UsersDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.UsersDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UsersDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UsersDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UsersDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UsersDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UsersDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UsersDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UsersDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsersDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UsersDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.UsersDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.UsersDGV.ThemeStyle.ReadOnly = false;
            this.UsersDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UsersDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsersDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UsersDGV.ThemeStyle.RowsStyle.Height = 22;
            this.UsersDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UsersDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDGV_CellContentClick);
            // 
            // GunaPanel
            // 
            this.GunaPanel.AutoRoundedCorners = true;
            this.GunaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.GunaPanel.BorderRadius = 4;
            this.GunaPanel.BorderThickness = 1;
            this.GunaPanel.Location = new System.Drawing.Point(585, 86);
            this.GunaPanel.Name = "GunaPanel";
            this.GunaPanel.Size = new System.Drawing.Size(11, 732);
            this.GunaPanel.TabIndex = 26;
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
            this.DeleteBtn.Location = new System.Drawing.Point(323, 631);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(150, 45);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Delete User";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
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
            this.EditBtn.Location = new System.Drawing.Point(417, 570);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(150, 45);
            this.EditBtn.TabIndex = 6;
            this.EditBtn.Text = "Edit User";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
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
            this.AddBtn.Location = new System.Drawing.Point(236, 570);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(150, 45);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add User";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddressTb
            // 
            this.AddressTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressTb.DefaultText = "";
            this.AddressTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddressTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddressTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTb.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddressTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTb.Location = new System.Drawing.Point(257, 479);
            this.AddressTb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.PasswordChar = '\0';
            this.AddressTb.PlaceholderText = "Address";
            this.AddressTb.SelectedText = "";
            this.AddressTb.Size = new System.Drawing.Size(283, 40);
            this.AddressTb.TabIndex = 4;
            // 
            // PhoneTb
            // 
            this.PhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTb.DefaultText = "";
            this.PhoneTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneTb.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PhoneTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneTb.Location = new System.Drawing.Point(257, 407);
            this.PhoneTb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.PasswordChar = '\0';
            this.PhoneTb.PlaceholderText = "Phone";
            this.PhoneTb.SelectedText = "";
            this.PhoneTb.Size = new System.Drawing.Size(283, 40);
            this.PhoneTb.TabIndex = 3;
            // 
            // PassWordTb
            // 
            this.PassWordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassWordTb.DefaultText = "";
            this.PassWordTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PassWordTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PassWordTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassWordTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassWordTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassWordTb.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PassWordTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassWordTb.Location = new System.Drawing.Point(257, 338);
            this.PassWordTb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PassWordTb.Name = "PassWordTb";
            this.PassWordTb.PasswordChar = '\0';
            this.PassWordTb.PlaceholderText = "Password";
            this.PassWordTb.SelectedText = "";
            this.PassWordTb.Size = new System.Drawing.Size(283, 40);
            this.PassWordTb.TabIndex = 2;
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
            this.NameTb.Location = new System.Drawing.Point(257, 198);
            this.NameTb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NameTb.Name = "NameTb";
            this.NameTb.PasswordChar = '\0';
            this.NameTb.PlaceholderText = "Name";
            this.NameTb.SelectedText = "";
            this.NameTb.Size = new System.Drawing.Size(283, 40);
            this.NameTb.TabIndex = 0;
            // 
            // UsersManagementHeader
            // 
            this.UsersManagementHeader.AutoSize = true;
            this.UsersManagementHeader.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsersManagementHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.UsersManagementHeader.Location = new System.Drawing.Point(302, 25);
            this.UsersManagementHeader.Name = "UsersManagementHeader";
            this.UsersManagementHeader.Size = new System.Drawing.Size(225, 37);
            this.UsersManagementHeader.TabIndex = 16;
            this.UsersManagementHeader.Text = "Users Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Controls.Add(this.LogOutIcon);
            this.panel1.Controls.Add(this.BillsButton);
            this.panel1.Controls.Add(this.BillsIcon);
            this.panel1.Controls.Add(this.Users_UsersButton);
            this.panel1.Controls.Add(this.User2Icon);
            this.panel1.Controls.Add(this.AccessoriesButton);
            this.panel1.Controls.Add(this.AccessoriesIcon);
            this.panel1.Controls.Add(this.BikeStoreIcon);
            this.panel1.Controls.Add(this.HeaderText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 856);
            this.panel1.TabIndex = 15;
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
            this.LogOutButton.TabIndex = 3;
            this.LogOutButton.Text = "Logout";
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
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
            // Users_UsersButton
            // 
            this.Users_UsersButton.BackColor = System.Drawing.Color.Black;
            this.Users_UsersButton.FlatAppearance.BorderSize = 0;
            this.Users_UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Users_UsersButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Users_UsersButton.ForeColor = System.Drawing.Color.White;
            this.Users_UsersButton.Location = new System.Drawing.Point(81, 359);
            this.Users_UsersButton.Name = "Users_UsersButton";
            this.Users_UsersButton.Size = new System.Drawing.Size(63, 36);
            this.Users_UsersButton.TabIndex = 1;
            this.Users_UsersButton.Text = "Users";
            this.Users_UsersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Users_UsersButton.UseVisualStyleBackColor = false;
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
            this.AccessoriesButton.Click += new System.EventHandler(this.AccessoriesButton_Click);
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
            // UNameTb
            // 
            this.UNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UNameTb.DefaultText = "";
            this.UNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UNameTb.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UNameTb.Location = new System.Drawing.Point(257, 270);
            this.UNameTb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UNameTb.Name = "UNameTb";
            this.UNameTb.PasswordChar = '\0';
            this.UNameTb.PlaceholderText = "Username";
            this.UNameTb.SelectedText = "";
            this.UNameTb.Size = new System.Drawing.Size(283, 40);
            this.UNameTb.TabIndex = 1;
            // 
            // ExitIcon
            // 
            this.ExitIcon.BackColor = System.Drawing.Color.Transparent;
            this.ExitIcon.Image = global::bikesystem.Properties.Resources.icons8_back_64;
            this.ExitIcon.Location = new System.Drawing.Point(1472, 0);
            this.ExitIcon.Name = "ExitIcon";
            this.ExitIcon.Size = new System.Drawing.Size(50, 46);
            this.ExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitIcon.TabIndex = 28;
            this.ExitIcon.TabStop = false;
            this.ExitIcon.Click += new System.EventHandler(this.ExitIcon_Click);
            // 
            // ItemsManagementIcon
            // 
            this.ItemsManagementIcon.BackColor = System.Drawing.Color.Transparent;
            this.ItemsManagementIcon.Image = global::bikesystem.Properties.Resources.icons8_user_menu_male_64;
            this.ItemsManagementIcon.Location = new System.Drawing.Point(246, 16);
            this.ItemsManagementIcon.Name = "ItemsManagementIcon";
            this.ItemsManagementIcon.Size = new System.Drawing.Size(50, 46);
            this.ItemsManagementIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ItemsManagementIcon.TabIndex = 17;
            this.ItemsManagementIcon.TabStop = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1520, 856);
            this.Controls.Add(this.ExitIcon);
            this.Controls.Add(this.UsersDGV);
            this.Controls.Add(this.GunaPanel);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.PassWordTb);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.UsersManagementHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ItemsManagementIcon);
            this.Controls.Add(this.UNameTb);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User2Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoriesIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BikeStoreIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsManagementIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogOutIcon;
        private System.Windows.Forms.PictureBox BillsIcon;
        private System.Windows.Forms.PictureBox User2Icon;
        private System.Windows.Forms.PictureBox BikeStoreIcon;
        private System.Windows.Forms.PictureBox ExitIcon;
        private Guna.UI2.WinForms.Guna2DataGridView UsersDGV;
        private Guna.UI2.WinForms.Guna2Panel GunaPanel;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button EditBtn;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private Guna.UI2.WinForms.Guna2TextBox AddressTb;
        private Guna.UI2.WinForms.Guna2TextBox PhoneTb;
        private Guna.UI2.WinForms.Guna2TextBox PassWordTb;
        private Guna.UI2.WinForms.Guna2TextBox NameTb;
        private System.Windows.Forms.Label UsersManagementHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button BillsButton;
        private System.Windows.Forms.Button Users_UsersButton;
        private System.Windows.Forms.Button AccessoriesButton;
        private System.Windows.Forms.PictureBox AccessoriesIcon;
        private System.Windows.Forms.Label HeaderText;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.PictureBox ItemsManagementIcon;
        private Guna.UI2.WinForms.Guna2TextBox UNameTb;
    }
}