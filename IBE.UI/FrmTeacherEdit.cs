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
    public partial class FrmTeacherEdit : Form
    {
        public FrmTeacherEdit()
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
                    Text = "编辑教师";
                }
                else
                {
                    Text = "新增教师";
                }
            }
        }

        public Teacher Teacher { get; set; }

        public void SetData(Teacher teacher)
        {
            IsEdit = teacher != null;
            Teacher = teacher;
            txtAccount.Text = teacher.LoginAccount;
            txtName.Text = teacher.Name;
            txtPassword.Text = teacher.Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtAccount.Text == "")
            {
                MessageBox.Show("用户名密码不能为空");
                return;
            }
            Teacher.Password = txtPassword.Text;
            Teacher.Name = txtName.Text;
            Teacher.LoginAccount = txtAccount.Text;
            if (isEdit)
            {
                MyDbContext.Instance.Teachers.Attach(Teacher);
            }
            else
            {
                MyDbContext.Instance.Teachers.Add(Teacher);
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