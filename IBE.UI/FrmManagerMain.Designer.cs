namespace IBE.UI
{
     partial class FrmManagerMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMagDelete = new System.Windows.Forms.Button();
            this.btnMagEdit = new System.Windows.Forms.Button();
            this.btnMagAdd = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserEdit = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnFileDelete = new System.Windows.Forms.Button();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.StudentEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentLoginAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUserEnable = new System.Windows.Forms.Button();
            this.btnUserDisable = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKey = new System.Windows.Forms.Button();
            this.dgv4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerLoginAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerAllowDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TeacherLoginAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMagDisable = new System.Windows.Forms.Button();
            this.btnMagEnable = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnMagDisable);
            this.tabPage1.Controls.Add(this.btnMagEnable);
            this.tabPage1.Controls.Add(this.btnMagDelete);
            this.tabPage1.Controls.Add(this.btnMagEdit);
            this.tabPage1.Controls.Add(this.btnMagAdd);
            this.tabPage1.Controls.Add(this.dgv1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "管理员管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnMagDelete
            // 
            this.btnMagDelete.Location = new System.Drawing.Point(197, 6);
            this.btnMagDelete.Name = "btnMagDelete";
            this.btnMagDelete.Size = new System.Drawing.Size(75, 23);
            this.btnMagDelete.TabIndex = 3;
            this.btnMagDelete.Text = "删除";
            this.btnMagDelete.UseVisualStyleBackColor = true;
            this.btnMagDelete.Click += new System.EventHandler(this.btnMagDelete_Click);
            // 
            // btnMagEdit
            // 
            this.btnMagEdit.Location = new System.Drawing.Point(103, 6);
            this.btnMagEdit.Name = "btnMagEdit";
            this.btnMagEdit.Size = new System.Drawing.Size(75, 23);
            this.btnMagEdit.TabIndex = 2;
            this.btnMagEdit.Text = "编辑";
            this.btnMagEdit.UseVisualStyleBackColor = true;
            this.btnMagEdit.Click += new System.EventHandler(this.btnMagEdit_Click);
            // 
            // btnMagAdd
            // 
            this.btnMagAdd.Location = new System.Drawing.Point(8, 6);
            this.btnMagAdd.Name = "btnMagAdd";
            this.btnMagAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMagAdd.TabIndex = 1;
            this.btnMagAdd.Text = "新增";
            this.btnMagAdd.UseVisualStyleBackColor = true;
            this.btnMagAdd.Click += new System.EventHandler(this.btnMagAdd_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ManagerName,
            this.ManagerLoginAccount,
            this.ManagerAllowDelete,
            this.Column7});
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv1.Location = new System.Drawing.Point(3, 37);
            this.dgv1.MultiSelect = false;
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(786, 384);
            this.dgv1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUserDisable);
            this.tabPage2.Controls.Add(this.btnUserEnable);
            this.tabPage2.Controls.Add(this.btnUserDelete);
            this.tabPage2.Controls.Add(this.btnUserEdit);
            this.tabPage2.Controls.Add(this.btnUserAdd);
            this.tabPage2.Controls.Add(this.dgv2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "用户管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Location = new System.Drawing.Point(197, 6);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(75, 23);
            this.btnUserDelete.TabIndex = 7;
            this.btnUserDelete.Text = "删除";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.Location = new System.Drawing.Point(103, 6);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(75, 23);
            this.btnUserEdit.TabIndex = 6;
            this.btnUserEdit.Text = "编辑";
            this.btnUserEdit.UseVisualStyleBackColor = true;
            this.btnUserEdit.Click += new System.EventHandler(this.btnUserEdit_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Location = new System.Drawing.Point(8, 6);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(75, 23);
            this.btnUserAdd.TabIndex = 5;
            this.btnUserAdd.Text = "新增";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherName,
            this.Column8,
            this.TeacherLoginAccount,
            this.TeacherEmail});
            this.dgv2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv2.Location = new System.Drawing.Point(3, 37);
            this.dgv2.MultiSelect = false;
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 23;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(786, 384);
            this.dgv2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnFileDelete);
            this.tabPage3.Controls.Add(this.dgv3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "文件管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnFileDelete
            // 
            this.btnFileDelete.Location = new System.Drawing.Point(8, 8);
            this.btnFileDelete.Name = "btnFileDelete";
            this.btnFileDelete.Size = new System.Drawing.Size(75, 23);
            this.btnFileDelete.TabIndex = 7;
            this.btnFileDelete.Text = "删除";
            this.btnFileDelete.UseVisualStyleBackColor = true;
            this.btnFileDelete.Click += new System.EventHandler(this.btnFileDelete_Click);
            // 
            // dgv3
            // 
            this.dgv3.AllowUserToAddRows = false;
            this.dgv3.AllowUserToDeleteRows = false;
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv3.Location = new System.Drawing.Point(3, 37);
            this.dgv3.MultiSelect = false;
            this.dgv3.Name = "dgv3";
            this.dgv3.ReadOnly = true;
            this.dgv3.RowHeadersWidth = 51;
            this.dgv3.RowTemplate.Height = 23;
            this.dgv3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv3.Size = new System.Drawing.Size(786, 384);
            this.dgv3.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnKey);
            this.tabPage4.Controls.Add(this.dgv4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "秘钥管理";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // StudentEmail
            // 
            this.StudentEmail.DataPropertyName = "Email";
            this.StudentEmail.HeaderText = "邮箱";
            this.StudentEmail.Name = "StudentEmail";
            this.StudentEmail.ReadOnly = true;
            // 
            // StudentPassword
            // 
            this.StudentPassword.DataPropertyName = "Password";
            this.StudentPassword.HeaderText = "密码";
            this.StudentPassword.Name = "StudentPassword";
            this.StudentPassword.ReadOnly = true;
            // 
            // StudentLoginAccount
            // 
            this.StudentLoginAccount.DataPropertyName = "LoginAccount";
            this.StudentLoginAccount.HeaderText = "登录名";
            this.StudentLoginAccount.Name = "StudentLoginAccount";
            this.StudentLoginAccount.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "Name";
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // btnUserEnable
            // 
            this.btnUserEnable.Location = new System.Drawing.Point(291, 6);
            this.btnUserEnable.Name = "btnUserEnable";
            this.btnUserEnable.Size = new System.Drawing.Size(75, 23);
            this.btnUserEnable.TabIndex = 8;
            this.btnUserEnable.Text = "启用";
            this.btnUserEnable.UseVisualStyleBackColor = true;
            this.btnUserEnable.Click += new System.EventHandler(this.btnUserEnable_Click);
            // 
            // btnUserDisable
            // 
            this.btnUserDisable.Location = new System.Drawing.Point(386, 6);
            this.btnUserDisable.Name = "btnUserDisable";
            this.btnUserDisable.Size = new System.Drawing.Size(75, 23);
            this.btnUserDisable.TabIndex = 9;
            this.btnUserDisable.Text = "禁用";
            this.btnUserDisable.UseVisualStyleBackColor = true;
            this.btnUserDisable.Click += new System.EventHandler(this.btnUserDisable_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FileName";
            this.Column1.HeaderText = "文件名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "EncryptFilePath";
            this.Column2.HeaderText = "文件路径";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Sender";
            this.Column3.HeaderText = "发送人";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DestEmail";
            this.Column4.HeaderText = "接收人";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Time";
            this.Column5.HeaderText = "时间";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnKey
            // 
            this.btnKey.Location = new System.Drawing.Point(8, 6);
            this.btnKey.Name = "btnKey";
            this.btnKey.Size = new System.Drawing.Size(75, 23);
            this.btnKey.TabIndex = 9;
            this.btnKey.Text = "删除";
            this.btnKey.UseVisualStyleBackColor = true;
            this.btnKey.Click += new System.EventHandler(this.btnKey_Click);
            // 
            // dgv4
            // 
            this.dgv4.AllowUserToAddRows = false;
            this.dgv4.AllowUserToDeleteRows = false;
            this.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column6});
            this.dgv4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv4.Location = new System.Drawing.Point(3, 37);
            this.dgv4.MultiSelect = false;
            this.dgv4.Name = "dgv4";
            this.dgv4.ReadOnly = true;
            this.dgv4.RowHeadersWidth = 51;
            this.dgv4.RowTemplate.Height = 23;
            this.dgv4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv4.Size = new System.Drawing.Size(786, 384);
            this.dgv4.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn1.HeaderText = "邮箱";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FileKey";
            this.dataGridViewTextBoxColumn2.HeaderText = "加密秘钥";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "IBEMainKey";
            this.Column6.HeaderText = "IBE主秘钥";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // ManagerName
            // 
            this.ManagerName.DataPropertyName = "Name";
            this.ManagerName.HeaderText = "姓名";
            this.ManagerName.Name = "ManagerName";
            this.ManagerName.ReadOnly = true;
            // 
            // ManagerLoginAccount
            // 
            this.ManagerLoginAccount.DataPropertyName = "LoginAccount";
            this.ManagerLoginAccount.HeaderText = "登录名";
            this.ManagerLoginAccount.Name = "ManagerLoginAccount";
            this.ManagerLoginAccount.ReadOnly = true;
            // 
            // ManagerAllowDelete
            // 
            this.ManagerAllowDelete.DataPropertyName = "AllowDelete";
            this.ManagerAllowDelete.HeaderText = "是否可删除";
            this.ManagerAllowDelete.Name = "ManagerAllowDelete";
            this.ManagerAllowDelete.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Enable";
            this.Column7.HeaderText = "启用";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // TeacherName
            // 
            this.TeacherName.DataPropertyName = "Name";
            this.TeacherName.HeaderText = "姓名";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Enable";
            this.Column8.HeaderText = "启用";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // TeacherLoginAccount
            // 
            this.TeacherLoginAccount.DataPropertyName = "LoginAccount";
            this.TeacherLoginAccount.HeaderText = "登录名";
            this.TeacherLoginAccount.Name = "TeacherLoginAccount";
            this.TeacherLoginAccount.ReadOnly = true;
            // 
            // TeacherEmail
            // 
            this.TeacherEmail.DataPropertyName = "Email";
            this.TeacherEmail.HeaderText = "邮箱";
            this.TeacherEmail.Name = "TeacherEmail";
            this.TeacherEmail.ReadOnly = true;
            // 
            // btnMagDisable
            // 
            this.btnMagDisable.Location = new System.Drawing.Point(390, 8);
            this.btnMagDisable.Name = "btnMagDisable";
            this.btnMagDisable.Size = new System.Drawing.Size(75, 23);
            this.btnMagDisable.TabIndex = 11;
            this.btnMagDisable.Text = "禁用";
            this.btnMagDisable.UseVisualStyleBackColor = true;
            this.btnMagDisable.Click += new System.EventHandler(this.btnMagDisable_Click);
            // 
            // btnMagEnable
            // 
            this.btnMagEnable.Location = new System.Drawing.Point(295, 8);
            this.btnMagEnable.Name = "btnMagEnable";
            this.btnMagEnable.Size = new System.Drawing.Size(75, 23);
            this.btnMagEnable.TabIndex = 10;
            this.btnMagEnable.Text = "启用";
            this.btnMagEnable.UseVisualStyleBackColor = true;
            this.btnMagEnable.Click += new System.EventHandler(this.btnMagEnable_Click);
            // 
            // FrmManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmManagerMain";
            this.Text = "管理员主界面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmManagerMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmManagerMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnMagAdd;
        private System.Windows.Forms.Button btnMagDelete;
        private System.Windows.Forms.Button btnMagEdit;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserEdit;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnFileDelete;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentLoginAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnUserDisable;
        private System.Windows.Forms.Button btnUserEnable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnKey;
        private System.Windows.Forms.DataGridView dgv4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerLoginAccount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ManagerAllowDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.Button btnMagDisable;
        private System.Windows.Forms.Button btnMagEnable;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherLoginAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherEmail;
    }
}