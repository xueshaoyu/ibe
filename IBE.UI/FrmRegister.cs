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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //注册
            var userName = txtUserName.Text;
            var trueName = txtTrueName.Text;
            var pwd = txtPwd.Text;
            var confirmPwd = txtConfirmPwd.Text;
            var email = txtEmail.Text;
            var anwser1 = txtAnwser1.Text;
            var anwser2 = txtAnwser2.Text;
            var anwser3 = txtAnwser3.Text;
            var q1 = cbbQ1.Text;
            var q2 = cbbQ2.Text;
            var q3 = cbbQ3.Text; 

            if(string .IsNullOrWhiteSpace(userName)|| string.IsNullOrWhiteSpace(trueName) || string.IsNullOrWhiteSpace(pwd)||
                string.IsNullOrWhiteSpace(confirmPwd) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(anwser1) ||
                string.IsNullOrWhiteSpace(anwser2) || string.IsNullOrWhiteSpace(anwser3) || string.IsNullOrWhiteSpace(q1)||
                string.IsNullOrWhiteSpace(q2) || string.IsNullOrWhiteSpace(q3))
            {
                MessageBox.Show("注册信息不完整");
                return;
            }
            if(pwd!=confirmPwd)
            {
                MessageBox.Show("两次密码不一致");
                return;
            }
            if (MyDbContext.Instance.Users.FirstOrDefault(p => p.Email == email || p.LoginAccount == userName) != null)
            {
                MessageBox.Show("用户已存在或者邮箱已被注册");
                return;
            }
            var user = new User()
            {
                LoginAccount = userName,
                Name = trueName,
                Email = email,
                FirstQuestion = q1,
                SecondQuestion = q2,
                ThirdQuestion = q3,
                FirstAnswer = anwser1,
                SecondAnswer = anwser2,
                ThirdAnswer = anwser3,
                Password = pwd
            };
            MyDbContext.Instance.Users.Add(user);
            MyDbContext.Instance.SaveChanges();
            MessageBox.Show("注册成功");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void LoadQuestion(ComboBox combobox,int defaultSelected)
        {
            combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox.Items.Add("1.你的生日是？");
            combobox.Items.Add("2.你的出生地是？");
            combobox.Items.Add("3.你的小学老师是？");
            combobox.Items.Add("4.你第一次哭的原因是？");
            combobox.Items.Add("5.你最喜欢的动物是？");
            combobox.Items.Add("6.你最喜欢的人是？");
            combobox.SelectedIndex = defaultSelected;
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            LoadQuestion(cbbQ1, 0);
            LoadQuestion(cbbQ2, 1);
            LoadQuestion(cbbQ3, 2);
        }
    }
}
