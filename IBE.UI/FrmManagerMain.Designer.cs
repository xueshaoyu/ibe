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
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentLoginAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMagDelete = new System.Windows.Forms.Button();
            this.btnMagEdit = new System.Windows.Forms.Button();
            this.btnMagAdd = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.ManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerLoginAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerAllowDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTeacherDelete = new System.Windows.Forms.Button();
            this.btnTeacherEdit = new System.Windows.Forms.Button();
            this.btnTeacherAdd = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherLoginAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.btnStudentEdit = new System.Windows.Forms.Button();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "Name";
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // StudentLoginAccount
            // 
            this.StudentLoginAccount.DataPropertyName = "LoginAccount";
            this.StudentLoginAccount.HeaderText = "登录名";
            this.StudentLoginAccount.Name = "StudentLoginAccount";
            this.StudentLoginAccount.ReadOnly = true;
            // 
            // StudentPassword
            // 
            this.StudentPassword.DataPropertyName = "Password";
            this.StudentPassword.HeaderText = "密码";
            this.StudentPassword.Name = "StudentPassword";
            this.StudentPassword.ReadOnly = true;
            // 
            // StudentEmail
            // 
            this.StudentEmail.DataPropertyName = "Email";
            this.StudentEmail.HeaderText = "邮箱";
            this.StudentEmail.Name = "StudentEmail";
            this.StudentEmail.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
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
            this.ManagerPassword,
            this.ManagerAllowDelete});
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
            // ManagerPassword
            // 
            this.ManagerPassword.DataPropertyName = "Password";
            this.ManagerPassword.HeaderText = "密码";
            this.ManagerPassword.Name = "ManagerPassword";
            this.ManagerPassword.ReadOnly = true;
            // 
            // ManagerAllowDelete
            // 
            this.ManagerAllowDelete.DataPropertyName = "AllowDelete";
            this.ManagerAllowDelete.HeaderText = "是否可删除";
            this.ManagerAllowDelete.Name = "ManagerAllowDelete";
            this.ManagerAllowDelete.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTeacherDelete);
            this.tabPage2.Controls.Add(this.btnTeacherEdit);
            this.tabPage2.Controls.Add(this.btnTeacherAdd);
            this.tabPage2.Controls.Add(this.dgv2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "教师管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTeacherDelete
            // 
            this.btnTeacherDelete.Location = new System.Drawing.Point(197, 6);
            this.btnTeacherDelete.Name = "btnTeacherDelete";
            this.btnTeacherDelete.Size = new System.Drawing.Size(75, 23);
            this.btnTeacherDelete.TabIndex = 7;
            this.btnTeacherDelete.Text = "删除";
            this.btnTeacherDelete.UseVisualStyleBackColor = true;
            this.btnTeacherDelete.Click += new System.EventHandler(this.btnTeacherDelete_Click);
            // 
            // btnTeacherEdit
            // 
            this.btnTeacherEdit.Location = new System.Drawing.Point(103, 6);
            this.btnTeacherEdit.Name = "btnTeacherEdit";
            this.btnTeacherEdit.Size = new System.Drawing.Size(75, 23);
            this.btnTeacherEdit.TabIndex = 6;
            this.btnTeacherEdit.Text = "编辑";
            this.btnTeacherEdit.UseVisualStyleBackColor = true;
            this.btnTeacherEdit.Click += new System.EventHandler(this.btnTeacherEdit_Click);
            // 
            // btnTeacherAdd
            // 
            this.btnTeacherAdd.Location = new System.Drawing.Point(8, 6);
            this.btnTeacherAdd.Name = "btnTeacherAdd";
            this.btnTeacherAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTeacherAdd.TabIndex = 5;
            this.btnTeacherAdd.Text = "新增";
            this.btnTeacherAdd.UseVisualStyleBackColor = true;
            this.btnTeacherAdd.Click += new System.EventHandler(this.btnTeacherAdd_Click);
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherName,
            this.TeacherLoginAccount,
            this.TeacherPassword,
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
            // TeacherName
            // 
            this.TeacherName.DataPropertyName = "Name";
            this.TeacherName.HeaderText = "姓名";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            // 
            // TeacherLoginAccount
            // 
            this.TeacherLoginAccount.DataPropertyName = "LoginAccount";
            this.TeacherLoginAccount.HeaderText = "登录名";
            this.TeacherLoginAccount.Name = "TeacherLoginAccount";
            this.TeacherLoginAccount.ReadOnly = true;
            // 
            // TeacherPassword
            // 
            this.TeacherPassword.DataPropertyName = "Password";
            this.TeacherPassword.HeaderText = "密码";
            this.TeacherPassword.Name = "TeacherPassword";
            this.TeacherPassword.ReadOnly = true;
            // 
            // TeacherEmail
            // 
            this.TeacherEmail.DataPropertyName = "Email";
            this.TeacherEmail.HeaderText = "邮箱";
            this.TeacherEmail.Name = "TeacherEmail";
            this.TeacherEmail.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnStudentDelete);
            this.tabPage3.Controls.Add(this.btnStudentEdit);
            this.tabPage3.Controls.Add(this.btnStudentAdd);
            this.tabPage3.Controls.Add(this.dgv3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "学生管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Location = new System.Drawing.Point(197, 6);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(75, 23);
            this.btnStudentDelete.TabIndex = 7;
            this.btnStudentDelete.Text = "删除";
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            this.btnStudentDelete.Click += new System.EventHandler(this.btnStudentDelete_Click);
            // 
            // btnStudentEdit
            // 
            this.btnStudentEdit.Location = new System.Drawing.Point(103, 6);
            this.btnStudentEdit.Name = "btnStudentEdit";
            this.btnStudentEdit.Size = new System.Drawing.Size(75, 23);
            this.btnStudentEdit.TabIndex = 6;
            this.btnStudentEdit.Text = "编辑";
            this.btnStudentEdit.UseVisualStyleBackColor = true;
            this.btnStudentEdit.Click += new System.EventHandler(this.btnStudentEdit_Click);
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Location = new System.Drawing.Point(8, 6);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(75, 23);
            this.btnStudentAdd.TabIndex = 5;
            this.btnStudentAdd.Text = "新增";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // dgv3
            // 
            this.dgv3.AllowUserToAddRows = false;
            this.dgv3.AllowUserToDeleteRows = false;
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.StudentLoginAccount,
            this.StudentPassword,
            this.StudentEmail});
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnMagAdd;
        private System.Windows.Forms.Button btnMagDelete;
        private System.Windows.Forms.Button btnMagEdit;
        private System.Windows.Forms.Button btnTeacherDelete;
        private System.Windows.Forms.Button btnTeacherEdit;
        private System.Windows.Forms.Button btnTeacherAdd;
        private System.Windows.Forms.Button btnStudentDelete;
        private System.Windows.Forms.Button btnStudentEdit;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentLoginAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerLoginAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerPassword;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ManagerAllowDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherLoginAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherEmail;		

    }
}