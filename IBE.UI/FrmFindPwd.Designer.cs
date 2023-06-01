
namespace IBE.UI
{
    partial class FrmFindPwd
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
            this.txtEmail = new Sunny.UI.UITextBox();
            this.label10 = new Sunny.UI.UILabel();
            this.txtUsername = new Sunny.UI.UITextBox();
            this.label1 = new Sunny.UI.UILabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new Sunny.UI.UILabel();
            this.label8 = new Sunny.UI.UILabel();
            this.txtAnswer3 = new Sunny.UI.UITextBox();
            this.lblQuestion3 = new Sunny.UI.UILabel();
            this.label4 = new Sunny.UI.UILabel();
            this.label5 = new Sunny.UI.UILabel();
            this.txtAnswer2 = new Sunny.UI.UITextBox();
            this.lblQuestion2 = new Sunny.UI.UILabel();
            this.label2 = new Sunny.UI.UILabel();
            this.label3 = new Sunny.UI.UILabel();
            this.txtAnswer1 = new Sunny.UI.UITextBox();
            this.lblQustion1 = new Sunny.UI.UILabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtConfirmPwd = new Sunny.UI.UITextBox();
            this.label9 = new Sunny.UI.UILabel();
            this.txtPwd = new Sunny.UI.UITextBox();
            this.label6 = new Sunny.UI.UILabel();
            this.btnNext = new Sunny.UI.UIButton();
            this.btnPre = new Sunny.UI.UIButton();
            this.btnCancel = new Sunny.UI.UIButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.MainPage = "";
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(469, 233);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtUsername);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(469, 193);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "请输入要找回密码的用户账号";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmail.Location = new System.Drawing.Point(149, 96);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(5);
            this.txtEmail.ShowText = false;
            this.txtEmail.Size = new System.Drawing.Size(271, 29);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.Watermark = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(5, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "请输入邮箱：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUsername.Location = new System.Drawing.Point(149, 45);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(5);
            this.txtUsername.ShowText = false;
            this.txtUsername.Size = new System.Drawing.Size(271, 29);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUsername.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(5, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入用户账号：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtAnswer3);
            this.tabPage2.Controls.Add(this.lblQuestion3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtAnswer2);
            this.tabPage2.Controls.Add(this.lblQuestion2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtAnswer1);
            this.tabPage2.Controls.Add(this.lblQustion1);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(469, 193);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "回答密保问题";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "密保问题3：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(3, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "答案：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnswer3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAnswer3.Location = new System.Drawing.Point(75, 157);
            this.txtAnswer3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnswer3.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.Padding = new System.Windows.Forms.Padding(5);
            this.txtAnswer3.ShowText = false;
            this.txtAnswer3.Size = new System.Drawing.Size(345, 29);
            this.txtAnswer3.TabIndex = 9;
            this.txtAnswer3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAnswer3.Watermark = "";
            // 
            // lblQuestion3
            // 
            this.lblQuestion3.AutoSize = true;
            this.lblQuestion3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQuestion3.Location = new System.Drawing.Point(108, 131);
            this.lblQuestion3.Name = "lblQuestion3";
            this.lblQuestion3.Size = new System.Drawing.Size(55, 21);
            this.lblQuestion3.TabIndex = 8;
            this.lblQuestion3.Text = "label2";
            this.lblQuestion3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(5, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "密保问题2：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(5, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "答案：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnswer2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAnswer2.Location = new System.Drawing.Point(77, 95);
            this.txtAnswer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnswer2.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Padding = new System.Windows.Forms.Padding(5);
            this.txtAnswer2.ShowText = false;
            this.txtAnswer2.Size = new System.Drawing.Size(345, 29);
            this.txtAnswer2.TabIndex = 5;
            this.txtAnswer2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAnswer2.Watermark = "";
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.AutoSize = true;
            this.lblQuestion2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQuestion2.Location = new System.Drawing.Point(110, 69);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(55, 21);
            this.lblQuestion2.TabIndex = 4;
            this.lblQuestion2.Text = "label2";
            this.lblQuestion2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "密保问题1：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "答案：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnswer1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAnswer1.Location = new System.Drawing.Point(75, 34);
            this.txtAnswer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnswer1.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Padding = new System.Windows.Forms.Padding(5);
            this.txtAnswer1.ShowText = false;
            this.txtAnswer1.Size = new System.Drawing.Size(345, 29);
            this.txtAnswer1.TabIndex = 1;
            this.txtAnswer1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAnswer1.Watermark = "";
            // 
            // lblQustion1
            // 
            this.lblQustion1.AutoSize = true;
            this.lblQustion1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQustion1.Location = new System.Drawing.Point(108, 8);
            this.lblQustion1.Name = "lblQustion1";
            this.lblQustion1.Size = new System.Drawing.Size(55, 21);
            this.lblQustion1.TabIndex = 0;
            this.lblQustion1.Text = "label2";
            this.lblQustion1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtConfirmPwd);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtPwd);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(0, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(469, 193);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "输入新的密码";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtConfirmPwd.Location = new System.Drawing.Point(117, 102);
            this.txtConfirmPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmPwd.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.Padding = new System.Windows.Forms.Padding(5);
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.ShowText = false;
            this.txtConfirmPwd.Size = new System.Drawing.Size(288, 29);
            this.txtConfirmPwd.TabIndex = 3;
            this.txtConfirmPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtConfirmPwd.Watermark = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(17, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "确认新密码：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPwd
            // 
            this.txtPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.Location = new System.Drawing.Point(117, 42);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Padding = new System.Windows.Forms.Padding(5);
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.ShowText = false;
            this.txtPwd.Size = new System.Drawing.Size(288, 29);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPwd.Watermark = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(41, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "新密码：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(266, 239);
            this.btnNext.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "下一步";
            this.btnNext.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPre.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPre.Location = new System.Drawing.Point(185, 239);
            this.btnPre.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 2;
            this.btnPre.Text = "上一步";
            this.btnPre.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPre.Visible = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(347, 239);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmFindPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 274);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmFindPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "找回密码";
            this.Load += new System.EventHandler(this.FrmFindPwd_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Sunny.UI.UITextBox txtUsername;
        private Sunny.UI.UILabel label1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UIButton btnNext;
        private Sunny.UI.UIButton btnPre;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UILabel label7;
        private Sunny.UI.UILabel label8;
        private Sunny.UI.UITextBox txtAnswer3;
        private Sunny.UI.UILabel lblQuestion3;
        private Sunny.UI.UILabel label4;
        private Sunny.UI.UILabel label5;
        private Sunny.UI.UITextBox txtAnswer2;
        private Sunny.UI.UILabel lblQuestion2;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UILabel label3;
        private Sunny.UI.UITextBox txtAnswer1;
        private Sunny.UI.UILabel lblQustion1;
        private System.Windows.Forms.TabPage tabPage3;
        private Sunny.UI.UITextBox txtConfirmPwd;
        private Sunny.UI.UILabel label9;
        private Sunny.UI.UITextBox txtPwd;
        private Sunny.UI.UILabel label6;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UILabel label10;
    }
}