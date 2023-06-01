using IBE.Data.Models;
using Sunny.UI;
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
    public partial class FrmManagerEdit : Form
    {
        public FrmManagerEdit()
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
                    Text = "编辑管理员";
                }
                else
                {
                    Text = "新增管理员";
                }
            }
        }

        public Manager Manager { get; set; } = new Manager();

        public void SetData(Manager manager)
        {
            IsEdit = manager != null;
            Manager = manager;
            txtAccount.Text = manager.LoginAccount;
            txtName.Text = manager.Name;
            txtPassword.Text = manager.Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtAccount.Text == "")
            {
                UIMessageBox.Show("用户名密码不能为空");
                return;
            }
            Manager.Password = txtPassword.Text;
            Manager.Name = txtName.Text;
            Manager.LoginAccount = txtAccount.Text;
            if (isEdit)
            {
                MyDbContext.Instance.Managers.Attach(Manager);
            }
            else
            {
                MyDbContext.Instance.Managers.Add(Manager);
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