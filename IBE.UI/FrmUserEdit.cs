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
                    Text = "编辑用户";
                }
                else
                {
                    Text = "新增用户";
                }
            }
        }

        public User User { get; set; } = new User();

        public void SetData(User user)
        {
            IsEdit = user != null;
            User = user;
            if (User != null)
            {
                txtUserName.ReadOnly = false;
                txtEmail.ReadOnly = false;
            }
            txtUserName.Text = user.LoginAccount;
            txtTrueName.Text = user.Name;
            txtPwd.Text = user.Password;
            txtEmail.Text = user.Email;
            txtAnwser1.Text = user.FirstAnswer;
            txtAnwser2.Text = user.SecondAnswer;
            txtAnwser3.Text = user.ThirdAnswer;
            cbbQ1.Text = user.FirstQuestion;
            cbbQ2.Text = user.SecondQuestion;
            cbbQ3.Text = user.ThirdQuestion;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //注册
            var userName = txtUserName.Text;
            var trueName = txtTrueName.Text;
            var pwd = txtPwd.Text;
            var email = txtEmail.Text;
            var anwser1 = txtAnwser1.Text;
            var anwser2 = txtAnwser2.Text;
            var anwser3 = txtAnwser3.Text;
            var q1 = cbbQ1.Text;
            var q2 = cbbQ2.Text;
            var q3 = cbbQ3.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(trueName) || string.IsNullOrWhiteSpace(pwd) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(anwser1) ||
                string.IsNullOrWhiteSpace(anwser2) || string.IsNullOrWhiteSpace(anwser3) || string.IsNullOrWhiteSpace(q1) ||
                string.IsNullOrWhiteSpace(q2) || string.IsNullOrWhiteSpace(q3))
            {
                UIMessageBox.Show("注册信息不完整");
                return;
            }

            if (!IsEdit && MyDbContext.Instance.Users.FirstOrDefault(p => p.Email == email || p.LoginAccount == userName) != null)
            {
                UIMessageBox.Show("用户已存在或者邮箱已被注册");
                return;
            }

            User.LoginAccount = userName;
            User.Name = trueName;
            User.Email = email;
            User.FirstQuestion = q1;
            User.SecondQuestion = q2;
            User.ThirdQuestion = q3;
            User.FirstAnswer = anwser1;
            User.SecondAnswer = anwser2;
            User.ThirdAnswer = anwser3;
            User.Password = pwd;
            if (IsEdit)
            {
                MyDbContext.Instance.Users.Attach(User);
            }
            else
            {
                MyDbContext.Instance.Users.Add(User);
            }
            MyDbContext.Instance.SaveChanges();
            UIMessageBox.Show("注册成功");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadQuestion(UIComboBox combobox, int defaultSelected)
        {
            combobox.DropDownStyle = UIDropDownStyle.DropDownList;
            combobox.Items.Add("1.你的生日是？");
            combobox.Items.Add("2.你的出生地是？");
            combobox.Items.Add("3.你的小学老师是？");
            combobox.Items.Add("4.你第一次哭的原因是？");
            combobox.Items.Add("5.你最喜欢的动物是？");
            combobox.Items.Add("6.你最喜欢的人是？");
            combobox.SelectedIndex = defaultSelected;
        }

        private void FrmUserEdit_Load(object sender, EventArgs e)
        {
            LoadQuestion(cbbQ1, 0);
            LoadQuestion(cbbQ2, 1);
            LoadQuestion(cbbQ3, 2);
        }
    }
}