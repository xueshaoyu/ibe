using IBE.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBE.UI
{
    public partial class FrmUserEdit : Form
    {
        public FrmUserEdit()
        {
            InitializeComponent();
        }

        private bool isEdit;

        /// <summary>
        /// 是否是编辑
        /// </summary>
        public bool IsEdit
        {
            get => isEdit; set
            {
                isEdit = value;
                if (isEdit)
                {
                    Text = "编辑学生";
                }
                else
                {
                    Text = "新增学生";
                }
            }
        }

        public User User { get; set; } = new User();

        public void SetData(User student)
        {
            IsEdit = student != null;
            User = student;
            txtAccount.Text = student.LoginAccount;
            txtName.Text = student.Name;
            txtPassword.Text = student.Password;
            txtEmail.Text = student.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtAccount.Text == "")
            {
                MessageBox.Show("用户名密码不能为空");
                return;
            }
            User.Password = txtPassword.Text;
            User.Name = txtName.Text;
            User.LoginAccount = txtAccount.Text;
            User.Email = txtEmail.Text;
            if (isEdit)
            {
                MyDbContext.Instance.Users.Attach(User);
            }
            else
            {
                MyDbContext.Instance.Users.Add(User);
            }
            MyDbContext.Instance.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //取消
            DialogResult = DialogResult.Cancel;
        }
    }
}