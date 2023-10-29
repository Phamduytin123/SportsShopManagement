namespace DoAn
{
    partial class NhanVien
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
            this.txtRoleNv = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtMaNv = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbRoleNv = new System.Windows.Forms.Label();
            this.lbMaNv = new System.Windows.Forms.Label();
            this.lbThongTinNv = new System.Windows.Forms.Label();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNhanVien = new System.Windows.Forms.Label();
            this.bttCancel_Add = new System.Windows.Forms.Button();
            this.bttUpdate_Add = new System.Windows.Forms.Button();
            this.bttDelete_Add = new System.Windows.Forms.Button();
            this.bttDelete_Update = new System.Windows.Forms.Button();
            this.bttCancel_Update = new System.Windows.Forms.Button();
            this.bttSave_Add = new System.Windows.Forms.Button();
            this.bttSave_Update = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttAdd
            // 
            this.bttAdd.BackColor = System.Drawing.SystemColors.Desktop;
            this.bttAdd.FlatAppearance.BorderSize = 0;
            this.bttAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdd.Location = new System.Drawing.Point(439, 253);
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
            this.bttAdd_Update.Location = new System.Drawing.Point(439, 253);
            this.bttAdd_Update.Name = "bttAdd_Update";
            this.bttAdd_Update.Size = new System.Drawing.Size(72, 30);
            this.bttAdd_Update.TabIndex = 81;
            this.bttAdd_Update.Text = "Add";
            this.bttAdd_Update.UseVisualStyleBackColor = false;
            // 
            // txtRoleNv
            // 
            this.txtRoleNv.Location = new System.Drawing.Point(193, 157);
            this.txtRoleNv.Name = "txtRoleNv";
            this.txtRoleNv.ReadOnly = true;
            this.txtRoleNv.Size = new System.Drawing.Size(144, 22);
            this.txtRoleNv.TabIndex = 75;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(193, 95);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(144, 22);
            this.txtUsername.TabIndex = 74;
            // 
            // txtMaNv
            // 
            this.txtMaNv.Location = new System.Drawing.Point(548, 157);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.ReadOnly = true;
            this.txtMaNv.Size = new System.Drawing.Size(144, 22);
            this.txtMaNv.TabIndex = 72;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbUsername.Location = new System.Drawing.Point(46, 102);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(97, 17);
            this.lbUsername.TabIndex = 70;
            this.lbUsername.Text = "USER NAME:";
            // 
            // lbRoleNv
            // 
            this.lbRoleNv.AutoSize = true;
            this.lbRoleNv.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoleNv.Location = new System.Drawing.Point(46, 162);
            this.lbRoleNv.Name = "lbRoleNv";
            this.lbRoleNv.Size = new System.Drawing.Size(50, 17);
            this.lbRoleNv.TabIndex = 69;
            this.lbRoleNv.Text = "ROLE:";
            // 
            // lbMaNv
            // 
            this.lbMaNv.AutoSize = true;
            this.lbMaNv.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNv.Location = new System.Drawing.Point(419, 162);
            this.lbMaNv.Name = "lbMaNv";
            this.lbMaNv.Size = new System.Drawing.Size(69, 17);
            this.lbMaNv.TabIndex = 66;
            this.lbMaNv.Text = "USER ID:";
            // 
            // lbThongTinNv
            // 
            this.lbThongTinNv.AutoSize = true;
            this.lbThongTinNv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinNv.Location = new System.Drawing.Point(17, 61);
            this.lbThongTinNv.Name = "lbThongTinNv";
            this.lbThongTinNv.Size = new System.Drawing.Size(142, 19);
            this.lbThongTinNv.TabIndex = 65;
            this.lbThongTinNv.Text = "THÔNG TIN USER";
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bttDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.bttDelete.FlatAppearance.BorderSize = 0;
            this.bttDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDelete.Location = new System.Drawing.Point(651, 253);
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
            this.bttUpdate.Location = new System.Drawing.Point(548, 253);
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
            this.Username,
            this.Password,
            this.Role});
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
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.FillWeight = 170F;
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.FillWeight = 150F;
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.FillWeight = 80F;
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 19);
            this.label1.TabIndex = 58;
            this.label1.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // lbNhanVien
            // 
            this.lbNhanVien.AutoSize = true;
            this.lbNhanVien.BackColor = System.Drawing.Color.MistyRose;
            this.lbNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNhanVien.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanVien.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbNhanVien.Location = new System.Drawing.Point(15, 17);
            this.lbNhanVien.Name = "lbNhanVien";
            this.lbNhanVien.Size = new System.Drawing.Size(91, 34);
            this.lbNhanVien.TabIndex = 57;
            this.lbNhanVien.Text = "USER";
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
            this.bttUpdate_Add.Location = new System.Drawing.Point(548, 253);
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
            this.bttDelete_Add.Location = new System.Drawing.Point(651, 253);
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
            this.bttDelete_Update.Location = new System.Drawing.Point(650, 253);
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
            this.bttSave_Add.Location = new System.Drawing.Point(439, 253);
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
            this.bttSave_Update.Location = new System.Drawing.Point(548, 253);
            this.bttSave_Update.Name = "bttSave_Update";
            this.bttSave_Update.Size = new System.Drawing.Size(72, 30);
            this.bttSave_Update.TabIndex = 82;
            this.bttSave_Update.Text = "Save";
            this.bttSave_Update.UseVisualStyleBackColor = false;
            this.bttSave_Update.Click += new System.EventHandler(this.bttSave_Update_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(419, 100);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(92, 17);
            this.lbPassword.TabIndex = 84;
            this.lbPassword.Text = "PASSWORD:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(548, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(144, 22);
            this.txtPassword.TabIndex = 85;
            // 
            // NhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.bttAdd_Update);
            this.Controls.Add(this.txtRoleNv);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtMaNv);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbRoleNv);
            this.Controls.Add(this.lbMaNv);
            this.Controls.Add(this.lbThongTinNv);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttUpdate);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNhanVien);
            this.Controls.Add(this.bttCancel_Add);
            this.Controls.Add(this.bttUpdate_Add);
            this.Controls.Add(this.bttDelete_Add);
            this.Controls.Add(this.bttDelete_Update);
            this.Controls.Add(this.bttCancel_Update);
            this.Controls.Add(this.bttSave_Add);
            this.Controls.Add(this.bttSave_Update);
            this.Name = "NhanVien";
            this.Size = new System.Drawing.Size(760, 587);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttAdd_Update;
        private System.Windows.Forms.TextBox txtRoleNv;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtMaNv;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbRoleNv;
        private System.Windows.Forms.Label lbMaNv;
        private System.Windows.Forms.Label lbThongTinNv;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNhanVien;
        private System.Windows.Forms.Button bttCancel_Add;
        private System.Windows.Forms.Button bttUpdate_Add;
        private System.Windows.Forms.Button bttDelete_Add;
        private System.Windows.Forms.Button bttDelete_Update;
        private System.Windows.Forms.Button bttCancel_Update;
        private System.Windows.Forms.Button bttSave_Add;
        private System.Windows.Forms.Button bttSave_Update;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}
