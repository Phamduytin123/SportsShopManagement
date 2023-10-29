namespace DoAn
{
    partial class HoaDon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttAdd_Update = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtGiaSp = new System.Windows.Forms.TextBox();
            this.txtMaHoadon = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.lbTenSp = new System.Windows.Forms.Label();
            this.lbMaHoaDon = new System.Windows.Forms.Label();
            this.lbThongTinSp = new System.Windows.Forms.Label();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHoaDon = new System.Windows.Forms.Label();
            this.bttCancel_Add = new System.Windows.Forms.Button();
            this.bttUpdate_Add = new System.Windows.Forms.Button();
            this.bttDelete_Add = new System.Windows.Forms.Button();
            this.bttDelete_Update = new System.Windows.Forms.Button();
            this.bttCancel_Update = new System.Windows.Forms.Button();
            this.bttSave_Add = new System.Windows.Forms.Button();
            this.bttSave_Update = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cbBoxProduct = new System.Windows.Forms.ComboBox();
            this.cbBoxUsername = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttAdd
            // 
            this.bttAdd.BackColor = System.Drawing.SystemColors.Desktop;
            this.bttAdd.FlatAppearance.BorderSize = 0;
            this.bttAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdd.Location = new System.Drawing.Point(443, 253);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(72, 30);
            this.bttAdd.TabIndex = 62;
            this.bttAdd.Text = "Add";
            this.bttAdd.UseVisualStyleBackColor = false;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttAdd_Update
            // 
            this.bttAdd_Update.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttAdd_Update.FlatAppearance.BorderSize = 0;
            this.bttAdd_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdd_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd_Update.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bttAdd_Update.Location = new System.Drawing.Point(443, 253);
            this.bttAdd_Update.Name = "bttAdd_Update";
            this.bttAdd_Update.Size = new System.Drawing.Size(72, 30);
            this.bttAdd_Update.TabIndex = 81;
            this.bttAdd_Update.Text = "Add";
            this.bttAdd_Update.UseVisualStyleBackColor = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(535, 134);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(144, 22);
            this.txtQuantity.TabIndex = 75;
            // 
            // txtGiaSp
            // 
            this.txtGiaSp.Location = new System.Drawing.Point(197, 171);
            this.txtGiaSp.Name = "txtGiaSp";
            this.txtGiaSp.ReadOnly = true;
            this.txtGiaSp.Size = new System.Drawing.Size(144, 22);
            this.txtGiaSp.TabIndex = 73;
            // 
            // txtMaHoadon
            // 
            this.txtMaHoadon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHoadon.Location = new System.Drawing.Point(197, 96);
            this.txtMaHoadon.Name = "txtMaHoadon";
            this.txtMaHoadon.ReadOnly = true;
            this.txtMaHoadon.Size = new System.Drawing.Size(144, 22);
            this.txtMaHoadon.TabIndex = 71;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(403, 139);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(88, 17);
            this.lbQuantity.TabIndex = 70;
            this.lbQuantity.Text = "QUANTITY:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(403, 101);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(97, 17);
            this.lbUsername.TabIndex = 69;
            this.lbUsername.Text = "USER NAME:";
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(53, 176);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(48, 17);
            this.lbCost.TabIndex = 68;
            this.lbCost.Text = "COST:";
            // 
            // lbTenSp
            // 
            this.lbTenSp.AutoSize = true;
            this.lbTenSp.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSp.Location = new System.Drawing.Point(53, 137);
            this.lbTenSp.Name = "lbTenSp";
            this.lbTenSp.Size = new System.Drawing.Size(130, 17);
            this.lbTenSp.TabIndex = 67;
            this.lbTenSp.Text = "PRODUCT NAME:";
            // 
            // lbMaHoaDon
            // 
            this.lbMaHoaDon.AutoSize = true;
            this.lbMaHoaDon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHoaDon.Location = new System.Drawing.Point(53, 101);
            this.lbMaHoaDon.Name = "lbMaHoaDon";
            this.lbMaHoaDon.Size = new System.Drawing.Size(82, 17);
            this.lbMaHoaDon.TabIndex = 66;
            this.lbMaHoaDon.Text = "ORDER ID:";
            // 
            // lbThongTinSp
            // 
            this.lbThongTinSp.AutoSize = true;
            this.lbThongTinSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinSp.Location = new System.Drawing.Point(17, 61);
            this.lbThongTinSp.Name = "lbThongTinSp";
            this.lbThongTinSp.Size = new System.Drawing.Size(185, 20);
            this.lbThongTinSp.TabIndex = 65;
            this.lbThongTinSp.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bttDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.bttDelete.FlatAppearance.BorderSize = 0;
            this.bttDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDelete.Location = new System.Drawing.Point(655, 253);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(72, 30);
            this.bttDelete.TabIndex = 64;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = false;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttUpdate
            // 
            this.bttUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.bttUpdate.FlatAppearance.BorderSize = 0;
            this.bttUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttUpdate.Location = new System.Drawing.Point(552, 253);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(72, 30);
            this.bttUpdate.TabIndex = 63;
            this.bttUpdate.Text = "Update";
            this.bttUpdate.UseVisualStyleBackColor = false;
            this.bttUpdate.Click += new System.EventHandler(this.bttUpdate_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttCancel.FlatAppearance.BorderSize = 0;
            this.bttCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bttCancel.Location = new System.Drawing.Point(330, 253);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(72, 30);
            this.bttCancel.TabIndex = 61;
            this.bttCancel.Text = "Cancel";
            this.bttCancel.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.NameCl,
            this.ProductName,
            this.Cost,
            this.Quantity,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(23, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 225);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.FillWeight = 70F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // NameCl
            // 
            this.NameCl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameCl.FillWeight = 170F;
            this.NameCl.HeaderText = "User Name";
            this.NameCl.MinimumWidth = 6;
            this.NameCl.Name = "NameCl";
            this.NameCl.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cost.FillWeight = 120F;
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.FillWeight = 80F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // lbHoaDon
            // 
            this.lbHoaDon.AutoSize = true;
            this.lbHoaDon.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoaDon.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbHoaDon.Location = new System.Drawing.Point(15, 17);
            this.lbHoaDon.Name = "lbHoaDon";
            this.lbHoaDon.Size = new System.Drawing.Size(153, 34);
            this.lbHoaDon.TabIndex = 57;
            this.lbHoaDon.Text = "HÓA ĐƠN";
            // 
            // bttCancel_Add
            // 
            this.bttCancel_Add.BackColor = System.Drawing.SystemColors.Highlight;
            this.bttCancel_Add.FlatAppearance.BorderSize = 0;
            this.bttCancel_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancel_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttCancel_Add.Location = new System.Drawing.Point(330, 253);
            this.bttCancel_Add.Name = "bttCancel_Add";
            this.bttCancel_Add.Size = new System.Drawing.Size(72, 30);
            this.bttCancel_Add.TabIndex = 76;
            this.bttCancel_Add.Text = "Cancel";
            this.bttCancel_Add.UseVisualStyleBackColor = false;
            this.bttCancel_Add.Click += new System.EventHandler(this.bttCancel_Add_Click);
            // 
            // bttUpdate_Add
            // 
            this.bttUpdate_Add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttUpdate_Add.FlatAppearance.BorderSize = 0;
            this.bttUpdate_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttUpdate_Add.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bttUpdate_Add.Location = new System.Drawing.Point(552, 253);
            this.bttUpdate_Add.Name = "bttUpdate_Add";
            this.bttUpdate_Add.Size = new System.Drawing.Size(72, 30);
            this.bttUpdate_Add.TabIndex = 78;
            this.bttUpdate_Add.Text = "Update";
            this.bttUpdate_Add.UseVisualStyleBackColor = false;
            // 
            // bttDelete_Add
            // 
            this.bttDelete_Add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttDelete_Add.FlatAppearance.BorderSize = 0;
            this.bttDelete_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDelete_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDelete_Add.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bttDelete_Add.Location = new System.Drawing.Point(655, 253);
            this.bttDelete_Add.Name = "bttDelete_Add";
            this.bttDelete_Add.Size = new System.Drawing.Size(72, 30);
            this.bttDelete_Add.TabIndex = 79;
            this.bttDelete_Add.Text = "Delete";
            this.bttDelete_Add.UseVisualStyleBackColor = false;
            // 
            // bttDelete_Update
            // 
            this.bttDelete_Update.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttDelete_Update.FlatAppearance.BorderSize = 0;
            this.bttDelete_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDelete_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDelete_Update.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bttDelete_Update.Location = new System.Drawing.Point(655, 253);
            this.bttDelete_Update.Name = "bttDelete_Update";
            this.bttDelete_Update.Size = new System.Drawing.Size(72, 30);
            this.bttDelete_Update.TabIndex = 83;
            this.bttDelete_Update.Text = "Delete";
            this.bttDelete_Update.UseVisualStyleBackColor = false;
            // 
            // bttCancel_Update
            // 
            this.bttCancel_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttCancel_Update.FlatAppearance.BorderSize = 0;
            this.bttCancel_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancel_Update.Location = new System.Drawing.Point(330, 253);
            this.bttCancel_Update.Name = "bttCancel_Update";
            this.bttCancel_Update.Size = new System.Drawing.Size(72, 30);
            this.bttCancel_Update.TabIndex = 80;
            this.bttCancel_Update.Text = "Cancel";
            this.bttCancel_Update.UseVisualStyleBackColor = false;
            this.bttCancel_Update.Click += new System.EventHandler(this.bttCancel_Update_Click);
            // 
            // bttSave_Add
            // 
            this.bttSave_Add.BackColor = System.Drawing.SystemColors.Desktop;
            this.bttSave_Add.FlatAppearance.BorderSize = 0;
            this.bttSave_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSave_Add.Location = new System.Drawing.Point(443, 253);
            this.bttSave_Add.Name = "bttSave_Add";
            this.bttSave_Add.Size = new System.Drawing.Size(72, 30);
            this.bttSave_Add.TabIndex = 77;
            this.bttSave_Add.Text = "Save";
            this.bttSave_Add.UseVisualStyleBackColor = false;
            this.bttSave_Add.Click += new System.EventHandler(this.bttSave_Add_Click);
            // 
            // bttSave_Update
            // 
            this.bttSave_Update.BackColor = System.Drawing.SystemColors.Highlight;
            this.bttSave_Update.FlatAppearance.BorderSize = 0;
            this.bttSave_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSave_Update.Location = new System.Drawing.Point(552, 253);
            this.bttSave_Update.Name = "bttSave_Update";
            this.bttSave_Update.Size = new System.Drawing.Size(72, 30);
            this.bttSave_Update.TabIndex = 82;
            this.bttSave_Update.Text = "Save";
            this.bttSave_Update.UseVisualStyleBackColor = false;
            this.bttSave_Update.Click += new System.EventHandler(this.bttSave_Update_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(403, 176);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(49, 17);
            this.lbDate.TabIndex = 84;
            this.lbDate.Text = "DATE:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(535, 173);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(144, 22);
            this.txtDate.TabIndex = 85;
            // 
            // cbBoxProduct
            // 
            this.cbBoxProduct.FormattingEnabled = true;
            this.cbBoxProduct.Location = new System.Drawing.Point(197, 132);
            this.cbBoxProduct.Name = "cbBoxProduct";
            this.cbBoxProduct.Size = new System.Drawing.Size(144, 24);
            this.cbBoxProduct.TabIndex = 87;
            this.cbBoxProduct.SelectedIndexChanged += new System.EventHandler(this.cbBoxProduct_SelectedIndexChanged);
            // 
            // cbBoxUsername
            // 
            this.cbBoxUsername.FormattingEnabled = true;
            this.cbBoxUsername.Location = new System.Drawing.Point(535, 94);
            this.cbBoxUsername.Name = "cbBoxUsername";
            this.cbBoxUsername.Size = new System.Drawing.Size(144, 24);
            this.cbBoxUsername.TabIndex = 88;
            // 
            // HoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.cbBoxUsername);
            this.Controls.Add(this.cbBoxProduct);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.bttAdd_Update);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtGiaSp);
            this.Controls.Add(this.txtMaHoadon);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.lbTenSp);
            this.Controls.Add(this.lbMaHoaDon);
            this.Controls.Add(this.lbThongTinSp);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttUpdate);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHoaDon);
            this.Controls.Add(this.bttCancel_Add);
            this.Controls.Add(this.bttUpdate_Add);
            this.Controls.Add(this.bttDelete_Add);
            this.Controls.Add(this.bttDelete_Update);
            this.Controls.Add(this.bttCancel_Update);
            this.Controls.Add(this.bttSave_Add);
            this.Controls.Add(this.bttSave_Update);
            this.Name = "HoaDon";
            this.Size = new System.Drawing.Size(760, 569);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttAdd_Update;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtGiaSp;
        private System.Windows.Forms.TextBox txtMaHoadon;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label lbTenSp;
        private System.Windows.Forms.Label lbMaHoaDon;
        private System.Windows.Forms.Label lbThongTinSp;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHoaDon;
        private System.Windows.Forms.Button bttCancel_Add;
        private System.Windows.Forms.Button bttUpdate_Add;
        private System.Windows.Forms.Button bttDelete_Add;
        private System.Windows.Forms.Button bttDelete_Update;
        private System.Windows.Forms.Button bttCancel_Update;
        private System.Windows.Forms.Button bttSave_Add;
        private System.Windows.Forms.Button bttSave_Update;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ComboBox cbBoxProduct;
        private System.Windows.Forms.ComboBox cbBoxUsername;
    }
}
