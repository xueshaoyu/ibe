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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("请填写登录信息");
                return;
            }
            MyDbContext context = MyDbContext.Instance;
            if (comboBox1.Text == "系统管理员")
            {
                var manager = context.Managers.FirstOrDefault(p => p.LoginAccount == textBox1.Text && p.Password == textBox2.Text);
                if (manager == null)
                {
                    MessageBox.Show("登录失败");
                    return;
                }
                FrmManagerMain frm = new FrmManagerMain();
                frm.Show();
                Hide();
            }
            else if (comboBox1.Text == "教师")
            {
                var teacher = context.Teachers.FirstOrDefault(p => p.LoginAccount == textBox1.Text && p.Password == textBox2.Text);
                if (teacher == null)
                {
                    MessageBox.Show("登录失败");
                    return;
                }
                FrmTeacherMain frm = new FrmTeacherMain();
                frm.Show();
                Hide();
            }
            else if (comboBox1.Text == "学生")
            {
                var student = context.Students.FirstOrDefault(p => p.LoginAccount == textBox1.Text && p.Password == textBox2.Text);
                if (student == null)
                {
                    MessageBox.Show("登录失败");
                    return;
                }
                FrmStudentMain frm = new FrmStudentMain();
                frm.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}