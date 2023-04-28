﻿namespace IBE.UI
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMagAdd = new System.Windows.Forms.Button();
            this.btnMagEdit = new System.Windows.Forms.Button();
            this.btnMagDelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // tabPage2
            // 
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "学生管理";
            this.tabPage3.UseVisualStyleBackColor = true;
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
    }
}