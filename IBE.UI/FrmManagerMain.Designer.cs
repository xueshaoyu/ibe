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
            this.tabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMagDisable = new Sunny.UI.UIButton();
            this.btnMagEnable = new Sunny.UI.UIButton();
            this.btnMagDelete = new Sunny.UI.UIButton();
            this.btnMagEdit = new Sunny.UI.UIButton();
            this.btnMagAdd = new Sunny.UI.UIButton();
            this.dgv1 = new Sunny.UI.UIDataGridView();
            this.ManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerLoginAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerAllowDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUserDisable = new Sunny.UI.UIButton();
            this.btnUserEnable = new Sunny.UI.UIButton();
            this.btnUserDelete = new Sunny.UI.UIButton();
            this.btnUserEdit = new Sunny.UI.UIButton();
            this.btnUserAdd = new Sunny.UI.UIButton();
            this.dgv2 = new Sunny.UI.UIDataGridView();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TeacherLoginAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnFileDelete = new Sunny.UI.UIButton();
            this.dgv3 = new Sunny.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new Sunny.UI.UIButton();
            this.button1 = new Sunny.UI.UIButton();
            this.btnKey = new Sunny.UI.UIButton();
            this.dgv4 = new Sunny.UI.UIDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentLoginAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.MainPage = "";
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 450);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1024, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "管理员管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnMagDisable
            // 
            this.btnMagDisable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMagDisable.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMagDisable.Location = new System.Drawing.Point(390, 8);
            this.btnMagDisable.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMagDisable.Name = "btnMagDisable";
            this.btnMagDisable.Size = new System.Drawing.Size(75, 23);
            this.btnMagDisable.TabIndex = 11;
            this.btnMagDisable.Text = "禁用";
            this.btnMagDisable.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMagDisable.Click += new System.EventHandler(this.btnMagDisable_Click);
            // 
            // btnMagEnable
            // 
            this.btnMagEnable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMagEnable.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMagEnable.Location = new System.Drawing.Point(295, 8);
            this.btnMagEnable.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMagEnable.Name = "btnMagEnable";
            this.btnMagEnable.Size = new System.Drawing.Size(75, 23);
            this.btnMagEnable.TabIndex = 10;
            this.btnMagEnable.Text = "启用";
            this.btnMagEnable.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMagEnable.Click += new System.EventHandler(this.btnMagEnable_Click);
            // 
            // btnMagDelete
            // 
            this.btnMagDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMagDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMagDelete.Location = new System.Drawing.Point(197, 6);
            this.btnMagDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMagDelete.Name = "btnMagDelete";
            this.btnMagDelete.Size = new System.Drawing.Size(75, 23);
            this.btnMagDelete.TabIndex = 3;
            this.btnMagDelete.Text = "删除";
            this.btnMagDelete.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMagDelete.Click += new System.EventHandler(this.btnMagDelete_Click);
            // 
            // btnMagEdit
            // 
            this.btnMagEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMagEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMagEdit.Location = new System.Drawing.Point(103, 6);
            this.btnMagEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMagEdit.Name = "btnMagEdit";
            this.btnMagEdit.Size = new System.Drawing.Size(75, 23);
            this.btnMagEdit.TabIndex = 2;
            this.btnMagEdit.Text = "编辑";
            this.btnMagEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMagEdit.Click += new System.EventHandler(this.btnMagEdit_Click);
            // 
            // btnMagAdd
            // 
            this.btnMagAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMagAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMagAdd.Location = new System.Drawing.Point(8, 6);
            this.btnMagAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMagAdd.Name = "btnMagAdd";
            this.btnMagAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMagAdd.TabIndex = 1;
            this.btnMagAdd.Text = "新增";
            this.btnMagAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMagAdd.Click += new System.EventHandler(this.btnMagAdd_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms. DataGridViewColumn[] {
            this.ManagerName,
            this.ManagerLoginAccount,
            this.ManagerAllowDelete,
            this.Column7});
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv1.Location = new System.Drawing.Point(0, 37);
            this.dgv1.MultiSelect = false;
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(1024, 373);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUserDisable);
            this.tabPage2.Controls.Add(this.btnUserEnable);
            this.tabPage2.Controls.Add(this.btnUserDelete);
            this.tabPage2.Controls.Add(this.btnUserEdit);
            this.tabPage2.Controls.Add(this.btnUserAdd);
            this.tabPage2.Controls.Add(this.dgv2);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1024, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "用户管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUserDisable
            // 
            this.btnUserDisable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserDisable.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserDisable.Location = new System.Drawing.Point(386, 6);
            this.btnUserDisable.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUserDisable.Name = "btnUserDisable";
            this.btnUserDisable.Size = new System.Drawing.Size(75, 23);
            this.btnUserDisable.TabIndex = 9;
            this.btnUserDisable.Text = "禁用";
            this.btnUserDisable.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserDisable.Click += new System.EventHandler(this.btnUserDisable_Click);
            // 
            // btnUserEnable
            // 
            this.btnUserEnable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserEnable.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserEnable.Location = new System.Drawing.Point(291, 6);
            this.btnUserEnable.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUserEnable.Name = "btnUserEnable";
            this.btnUserEnable.Size = new System.Drawing.Size(75, 23);
            this.btnUserEnable.TabIndex = 8;
            this.btnUserEnable.Text = "启用";
            this.btnUserEnable.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserEnable.Click += new System.EventHandler(this.btnUserEnable_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserDelete.Location = new System.Drawing.Point(197, 6);
            this.btnUserDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(75, 23);
            this.btnUserDelete.TabIndex = 7;
            this.btnUserDelete.Text = "删除";
            this.btnUserDelete.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserEdit.Location = new System.Drawing.Point(103, 6);
            this.btnUserEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(75, 23);
            this.btnUserEdit.TabIndex = 6;
            this.btnUserEdit.Text = "编辑";
            this.btnUserEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserEdit.Click += new System.EventHandler(this.btnUserEdit_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserAdd.Location = new System.Drawing.Point(8, 6);
            this.btnUserAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(75, 23);
            this.btnUserAdd.TabIndex = 5;
            this.btnUserAdd.Text = "新增";
            this.btnUserAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.dgv2.Location = new System.Drawing.Point(0, 35);
            this.dgv2.MultiSelect = false;
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 23;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(1024, 375);
            this.dgv2.TabIndex = 4;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnFileDelete);
            this.tabPage3.Controls.Add(this.dgv3);
            this.tabPage3.Location = new System.Drawing.Point(0, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1024, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "文件管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnFileDelete
            // 
            this.btnFileDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFileDelete.Location = new System.Drawing.Point(8, 8);
            this.btnFileDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFileDelete.Name = "btnFileDelete";
            this.btnFileDelete.Size = new System.Drawing.Size(75, 23);
            this.btnFileDelete.TabIndex = 7;
            this.btnFileDelete.Text = "删除";
            this.btnFileDelete.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFileDelete.Click += new System.EventHandler(this.btnFileDelete_Click);
            // 
            // dgv3
            // 
            this.dgv3.AllowUserToAddRows = false;
            this.dgv3.AllowUserToDeleteRows = false;
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column10,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv3.Location = new System.Drawing.Point(0, 37);
            this.dgv3.MultiSelect = false;
            this.dgv3.Name = "dgv3";
            this.dgv3.ReadOnly = true;
            this.dgv3.RowHeadersWidth = 51;
            this.dgv3.RowTemplate.Height = 23;
            this.dgv3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv3.Size = new System.Drawing.Size(1024, 373);
            this.dgv3.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FileName";
            this.Column1.HeaderText = "文件名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "AesSourceKey";
            this.Column9.HeaderText = "文件加密密钥明文";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 200;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "AesEncryptKey";
            this.Column10.HeaderText = "文件加密密钥密文";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 200;
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.btnKey);
            this.tabPage4.Controls.Add(this.dgv4);
            this.tabPage4.Location = new System.Drawing.Point(0, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1024, 410);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "密钥管理";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(170, 6);
            this.button2.MinimumSize = new System.Drawing.Size(1, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "启用";
            this.button2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(89, 6);
            this.button1.MinimumSize = new System.Drawing.Size(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "禁用";
            this.button1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKey
            // 
            this.btnKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKey.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnKey.Location = new System.Drawing.Point(8, 6);
            this.btnKey.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnKey.Name = "btnKey";
            this.btnKey.Size = new System.Drawing.Size(75, 23);
            this.btnKey.TabIndex = 9;
            this.btnKey.Text = "删除";
            this.btnKey.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnKey.Click += new System.EventHandler(this.btnKey_Click);
            // 
            // dgv4
            // 
            this.dgv4.AllowUserToAddRows = false;
            this.dgv4.AllowUserToDeleteRows = false;
            this.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column6});
            this.dgv4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv4.Location = new System.Drawing.Point(0, 35);
            this.dgv4.MultiSelect = false;
            this.dgv4.Name = "dgv4";
            this.dgv4.ReadOnly = true;
            this.dgv4.RowHeadersWidth = 51;
            this.dgv4.RowTemplate.Height = 23;
            this.dgv4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv4.Size = new System.Drawing.Size(1024, 375);
            this.dgv4.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn1.HeaderText = "邮箱";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "IBEMainKey";
            this.Column6.HeaderText = "IBE主密钥";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
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
            // FrmManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 450);
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

        private Sunny.UI.UITabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UIButton btnMagAdd;
        private Sunny.UI.UIButton btnMagDelete;
        private Sunny.UI.UIButton btnMagEdit;
        private Sunny.UI.UIButton btnUserDelete;
        private Sunny.UI.UIButton btnUserEdit;
        private Sunny.UI.UIButton btnUserAdd;
        private Sunny.UI.UIDataGridView dgv1;
        private Sunny.UI.UIDataGridView dgv2;
        private System.Windows.Forms.TabPage tabPage3;
        private Sunny.UI.UIButton btnFileDelete;
        private Sunny.UI.UIDataGridView dgv3;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentLoginAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.TabPage tabPage4;
        private Sunny.UI.UIButton btnUserDisable;
        private Sunny.UI.UIButton btnUserEnable;
        private Sunny.UI.UIButton btnKey;
        private Sunny.UI.UIDataGridView dgv4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerLoginAccount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ManagerAllowDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private Sunny.UI.UIButton btnMagDisable;
        private Sunny.UI.UIButton btnMagEnable;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherLoginAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherEmail;
        private Sunny.UI.UIButton button2;
        private Sunny.UI.UIButton button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}