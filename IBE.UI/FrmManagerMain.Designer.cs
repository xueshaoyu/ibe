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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnTeacherDelete = new System.Windows.Forms.Button();
            this.btnTeacherEdit = new System.Windows.Forms.Button();
            this.btnTeacherAdd = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.btnStudentEdit = new System.Windows.Forms.Button();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
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
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnMagDelete);
            this.tabPage1.Controls.Add(this.btnMagEdit);
            this.tabPage1.Controls.Add(this.btnMagAdd);
            this.tabPage1.Controls.Add(this.dataGridView1);
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
            this.btnMagDelete.Location = new System.Drawing.Point(197, 8);
            this.btnMagDelete.Name = "btnMagDelete";
            this.btnMagDelete.Size = new System.Drawing.Size(75, 23);
            this.btnMagDelete.TabIndex = 3;
            this.btnMagDelete.Text = "删除";
            this.btnMagDelete.UseVisualStyleBackColor = true;
            this.btnMagDelete.Click += new System.EventHandler(this.btnMagDelete_Click);
            // 
            // btnMagEdit
            // 
            this.btnMagEdit.Location = new System.Drawing.Point(103, 8);
            this.btnMagEdit.Name = "btnMagEdit";
            this.btnMagEdit.Size = new System.Drawing.Size(75, 23);
            this.btnMagEdit.TabIndex = 2;
            this.btnMagEdit.Text = "编辑";
            this.btnMagEdit.UseVisualStyleBackColor = true;
            this.btnMagEdit.Click += new System.EventHandler(this.btnMagEdit_Click);
            // 
            // btnMagAdd
            // 
            this.btnMagAdd.Location = new System.Drawing.Point(8, 8);
            this.btnMagAdd.Name = "btnMagAdd";
            this.btnMagAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMagAdd.TabIndex = 1;
            this.btnMagAdd.Text = "新增";
            this.btnMagAdd.UseVisualStyleBackColor = true;
            this.btnMagAdd.Click += new System.EventHandler(this.btnMagAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 37);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(786, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTeacherDelete);
            this.tabPage2.Controls.Add(this.btnTeacherEdit);
            this.tabPage2.Controls.Add(this.btnTeacherAdd);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "教师管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnStudentDelete);
            this.tabPage3.Controls.Add(this.btnStudentEdit);
            this.tabPage3.Controls.Add(this.btnStudentAdd);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "学生管理";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 37);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(786, 384);
            this.dataGridView2.TabIndex = 4;
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
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView3.Location = new System.Drawing.Point(3, 37);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(786, 384);
            this.dataGridView3.TabIndex = 4;
            // 
            // FrmManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmManagerMain";
            this.Text = "管理员主界面";
            this.Load += new System.EventHandler(this.FrmManagerMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMagAdd;
        private System.Windows.Forms.Button btnMagDelete;
        private System.Windows.Forms.Button btnMagEdit;
        private System.Windows.Forms.Button btnTeacherDelete;
        private System.Windows.Forms.Button btnTeacherEdit;
        private System.Windows.Forms.Button btnTeacherAdd;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnStudentDelete;
        private System.Windows.Forms.Button btnStudentEdit;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}