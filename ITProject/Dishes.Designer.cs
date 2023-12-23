namespace ITProject
{
    partial class Dishes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dishes));
            this.list_account = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.bt_delete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.bt_edit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_remove = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btedit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.bt_add = new Guna.UI2.WinForms.Guna2ImageButton();
            this.bt_search = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tb_search = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.list_account)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // list_account
            // 
            this.list_account.AllowUserToAddRows = false;
            this.list_account.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.list_account.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.list_account.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list_account.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.list_account.ColumnHeadersHeight = 40;
            this.list_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list_account.DefaultCellStyle = dataGridViewCellStyle3;
            this.list_account.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.list_account.Location = new System.Drawing.Point(18, 148);
            this.list_account.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.list_account.Name = "list_account";
            this.list_account.ReadOnly = true;
            this.list_account.RowHeadersVisible = false;
            this.list_account.RowHeadersWidth = 51;
            this.list_account.RowTemplate.Height = 24;
            this.list_account.Size = new System.Drawing.Size(894, 390);
            this.list_account.TabIndex = 28;
            this.list_account.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.list_account.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.list_account.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.list_account.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.list_account.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.list_account.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.list_account.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.list_account.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.list_account.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.list_account.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.list_account.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.list_account.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.list_account.ThemeStyle.HeaderStyle.Height = 40;
            this.list_account.ThemeStyle.ReadOnly = true;
            this.list_account.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.list_account.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.list_account.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.list_account.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.list_account.ThemeStyle.RowsStyle.Height = 24;
            this.list_account.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.list_account.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Panel1.Controls.Add(this.bt_delete);
            this.guna2Panel1.Controls.Add(this.bt_edit);
            this.guna2Panel1.Controls.Add(this.guna2ImageButton1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(930, 0);
            this.guna2Panel1.TabIndex = 25;
            // 
            // bt_delete
            // 
            this.bt_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_delete.BackColor = System.Drawing.Color.Transparent;
            this.bt_delete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.bt_delete.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.bt_delete.Image = ((System.Drawing.Image)(resources.GetObject("bt_delete.Image")));
            this.bt_delete.ImageOffset = new System.Drawing.Point(0, 0);
            this.bt_delete.ImageRotate = 0F;
            this.bt_delete.ImageSize = new System.Drawing.Size(55, 55);
            this.bt_delete.Location = new System.Drawing.Point(830, 17);
            this.bt_delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.bt_delete.Size = new System.Drawing.Size(100, 93);
            this.bt_delete.TabIndex = 3;
            this.bt_delete.UseTransparentBackground = true;
            // 
            // bt_edit
            // 
            this.bt_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_edit.BackColor = System.Drawing.Color.Transparent;
            this.bt_edit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.bt_edit.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.bt_edit.Image = ((System.Drawing.Image)(resources.GetObject("bt_edit.Image")));
            this.bt_edit.ImageOffset = new System.Drawing.Point(0, 0);
            this.bt_edit.ImageRotate = 0F;
            this.bt_edit.ImageSize = new System.Drawing.Size(55, 55);
            this.bt_edit.Location = new System.Drawing.Point(723, 17);
            this.bt_edit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.bt_edit.Size = new System.Drawing.Size(100, 93);
            this.bt_edit.TabIndex = 3;
            this.bt_edit.UseTransparentBackground = true;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Location = new System.Drawing.Point(616, 17);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Size = new System.Drawing.Size(100, 93);
            this.guna2ImageButton1.TabIndex = 2;
            this.guna2ImageButton1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(102, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dishes";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::ITProject.Properties.Resources.Group_90;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(18, 19);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(84, 89);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 553);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(930, 17);
            this.guna2Panel2.TabIndex = 26;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.bt_remove);
            this.guna2Panel3.Controls.Add(this.guna2PictureBox3);
            this.guna2Panel3.Controls.Add(this.btedit);
            this.guna2Panel3.Controls.Add(this.bt_add);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(930, 81);
            this.guna2Panel3.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(93, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 28);
            this.label3.TabIndex = 32;
            this.label3.Text = "Dishes";
            // 
            // bt_remove
            // 
            this.bt_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_remove.BackColor = System.Drawing.Color.Transparent;
            this.bt_remove.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.bt_remove.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.bt_remove.Image = ((System.Drawing.Image)(resources.GetObject("bt_remove.Image")));
            this.bt_remove.ImageOffset = new System.Drawing.Point(0, 0);
            this.bt_remove.ImageRotate = 0F;
            this.bt_remove.ImageSize = new System.Drawing.Size(55, 55);
            this.bt_remove.Location = new System.Drawing.Point(841, 12);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.bt_remove.Size = new System.Drawing.Size(89, 65);
            this.bt_remove.TabIndex = 3;
            this.bt_remove.UseTransparentBackground = true;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = global::ITProject.Properties.Resources.Group_90;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(75, 62);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 31;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // btedit
            // 
            this.btedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btedit.BackColor = System.Drawing.Color.Transparent;
            this.btedit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btedit.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.btedit.Image = ((System.Drawing.Image)(resources.GetObject("btedit.Image")));
            this.btedit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btedit.ImageRotate = 0F;
            this.btedit.ImageSize = new System.Drawing.Size(55, 55);
            this.btedit.Location = new System.Drawing.Point(746, 12);
            this.btedit.Name = "btedit";
            this.btedit.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btedit.Size = new System.Drawing.Size(89, 65);
            this.btedit.TabIndex = 3;
            this.btedit.UseTransparentBackground = true;
            this.btedit.Click += new System.EventHandler(this.guna2ImageButton3_Click);
            // 
            // bt_add
            // 
            this.bt_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_add.BackColor = System.Drawing.Color.Transparent;
            this.bt_add.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.bt_add.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.bt_add.Image = ((System.Drawing.Image)(resources.GetObject("bt_add.Image")));
            this.bt_add.ImageOffset = new System.Drawing.Point(0, 0);
            this.bt_add.ImageRotate = 0F;
            this.bt_add.ImageSize = new System.Drawing.Size(55, 55);
            this.bt_add.Location = new System.Drawing.Point(651, 12);
            this.bt_add.Name = "bt_add";
            this.bt_add.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.bt_add.Size = new System.Drawing.Size(89, 65);
            this.bt_add.TabIndex = 2;
            this.bt_add.UseTransparentBackground = true;
            this.bt_add.Click += new System.EventHandler(this.guna2ImageButton4_Click);
            // 
            // bt_search
            // 
            this.bt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_search.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.bt_search.HoverState.ImageSize = new System.Drawing.Size(52, 52);
            this.bt_search.Image = ((System.Drawing.Image)(resources.GetObject("bt_search.Image")));
            this.bt_search.ImageOffset = new System.Drawing.Point(0, 0);
            this.bt_search.ImageRotate = 0F;
            this.bt_search.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_search.Location = new System.Drawing.Point(854, 86);
            this.bt_search.Name = "bt_search";
            this.bt_search.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_search.Size = new System.Drawing.Size(62, 53);
            this.bt_search.TabIndex = 34;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_search.DefaultText = "";
            this.tb_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.Location = new System.Drawing.Point(565, 86);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_search.Name = "tb_search";
            this.tb_search.PasswordChar = '\0';
            this.tb_search.PlaceholderText = "Search Here ...";
            this.tb_search.SelectedText = "";
            this.tb_search.Size = new System.Drawing.Size(282, 53);
            this.tb_search.TabIndex = 33;
            // 
            // Dishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 570);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.list_account);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Dishes";
            this.Text = "Dishes";
            this.Load += new System.EventHandler(this.Dishes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_account)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView list_account;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton bt_delete;
        private Guna.UI2.WinForms.Guna2ImageButton bt_edit;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2ImageButton bt_remove;
        private Guna.UI2.WinForms.Guna2ImageButton btedit;
        private Guna.UI2.WinForms.Guna2ImageButton bt_add;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2ImageButton bt_search;
        private Guna.UI2.WinForms.Guna2TextBox tb_search;
    }
}