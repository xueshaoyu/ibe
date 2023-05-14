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
    public partial class FrmUserChangePwd : Form
    {
        public FrmUserChangePwd()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var oldPwd = txtOldPwd.Text;
            var newPwd = txtNewPwd.Text;
            var newConfirmPwd = txtNewConfirmPwd.Text; 
            if(string.IsNullOrWhiteSpace(oldPwd)|| string.IsNullOrWhiteSpace(newPwd) || string.IsNullOrWhiteSpace(newConfirmPwd))
            {
                MessageBox.Show("未填写信息");
                return;
            }
            if (newPwd!=newConfirmPwd)
            {
                MessageBox.Show("两次新密码不一致");
                return;
            }
            if (SessionManager.User.Password != oldPwd)
            {
                MessageBox.Show("原密码不正确");
                return;
            }
            SessionManager.User.Password = newPwd;

            MyDbContext.Instance.SaveChanges();
            MessageBox.Show("修改密码成功");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
