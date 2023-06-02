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
    public partial class FrmLogin : Form
    {
        public static FrmLogin Instance { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
            Instance = this;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                UIMessageBox.Show("请填写登录信息");
                return;
            }
            MyDbContext context = MyDbContext.Instance;
            if (comboBox1.Text == "系统管理员")
            {
                var manager = context.Managers.FirstOrDefault(p => p.LoginAccount == textBox1.Text && p.Password == textBox2.Text);
                if (manager == null)
                {
                    UIMessageBox.Show("登录失败");
                    return;
                }
                if (!manager.Enable)
                {
                    UIMessageBox.Show("管理员被禁用");
                    return;
                }
                SessionManager.Manager = manager;
                FrmManagerMain frm = new FrmManagerMain();
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                frm.Show();
                Hide();
            }
            else if (comboBox1.Text == "网盘用户")
            {
                var user = context.Users.FirstOrDefault(p => p.LoginAccount == textBox1.Text && p.Password == textBox2.Text);
                if (user == null)
                {
                    UIMessageBox.Show("登录失败");
                    return;
                }
                if (user.Enable == false)
                {
                    UIMessageBox.Show("用户被禁用");
                    return;
                }
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                SessionManager.User = user;
                FrmUserMain frm = new FrmUserMain();
                frm.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmFindPwd frmFindPwd = new FrmFindPwd();
            frmFindPwd.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //用户登录才显示找回密码和注册用户
            if (comboBox1.Text == "网盘用户")
            {
                linkLabel1.Visible = true;
                linkLabel2.Visible = true;
            }
            else
            {
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
            }
        }
    }
}