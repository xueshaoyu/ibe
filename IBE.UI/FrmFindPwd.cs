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
    public partial class FrmFindPwd : Form
    {
        public FrmFindPwd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int currentStep = 0;
        private bool allowchangetab = false;

        private void btnPre_Click(object sender, EventArgs e)
        {
            //上一步
            currentStep -= 1;
            if (currentStep < 0)
                currentStep = 0;
            ChangeTab();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //下一步

            currentStep += 1;
            if (currentStep > 3)
                currentStep = 3;
            ChangeTab();
        }

        private void ChangeTab()
        {
            allowchangetab = false;
            switch (currentStep)
            {
                case 1:
                    {
                        var user = MyDbContext.Instance.Users.FirstOrDefault(p => p.LoginAccount == txtUsername.Text);
                        if (user == null)
                        {
                            UIMessageBox.Show("用户名不存在");
                            currentStep--;
                        }
                        else
                        {
                            lblQustion1.Text = user.FirstQuestion;
                            lblQuestion2.Text = user.SecondQuestion;
                            lblQuestion3.Text = user.ThirdQuestion;
                            allowchangetab = true;
                            tabControl1.SelectedIndex = currentStep;
                        }
                    }
                    break;

                case 2:
                    {
                        var user = MyDbContext.Instance.Users.FirstOrDefault(p => p.LoginAccount == txtUsername.Text);
                        if (user == null)
                        {
                            UIMessageBox.Show("用户名不存在");
                            currentStep--;
                        }
                        else
                        {
                            if (user.Email != txtEmail.Text)
                            {
                                UIMessageBox.Show("邮箱与用户名不匹配");
                                currentStep--;
                            }
                            else if (user.FirstAnswer != txtAnswer1.Text || user.SecondAnswer != txtAnswer2.Text || user.ThirdAnswer != txtAnswer2.Text)
                            {
                                UIMessageBox.Show("密保答案有误");
                                currentStep--;
                            }
                            else
                            {
                                allowchangetab = true;
                                tabControl1.SelectedIndex = currentStep;
                            }
                        }
                    }
                    break;

                case 3:
                    {
                        var user = MyDbContext.Instance.Users.FirstOrDefault(p => p.LoginAccount == txtUsername.Text);
                        if (user == null)
                        {
                            UIMessageBox.Show("用户名不存在");
                        }
                        else
                        {
                            if (txtPwd.Text != txtConfirmPwd.Text)
                            {
                                UIMessageBox.Show("两次密码不一致");
                            }
                            else
                            {
                                user.Password = txtPwd.Text;
                                MyDbContext.Instance.SaveChanges();
                                UIMessageBox.Show("找回密码成功");
                                this.Close();
                            }
                        }
                    }
                    break;

                default:
                    break;
            }

            if (currentStep == 0)
            {
                btnPre.Visible = false;
            }
            else
            {
                btnPre.Visible = true;
            }
            if (currentStep == 2)
            {
                btnNext.Text = "完成";
            }
            else
            {
                btnNext.Text = "下一步";
            }
            allowchangetab = false;
        }

        private void FrmFindPwd_Load(object sender, EventArgs e)
        {
            ChangeTab();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !allowchangetab;
        }
    }
}