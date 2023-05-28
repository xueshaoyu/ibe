using IBE.Data.Models;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBE.UI
{
    public partial class FrmUserMain : Form
    {
        public FrmUserMain()
        {
            InitializeComponent();
        }

        private void FrmStudentMain_Load(object sender, EventArgs e)
        {
            ////加载用户列表
            LoadUserData();
            ////加载发送给自己的文件
            LoadFileData();
        }

        private void LoadUserData()
        {
            var list = MyDbContext.Instance.Users.Where(p => p.Id != SessionManager.User.Id).ToList();
            listBox1.DataSource = list;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //发送加密文件
            if (aesKey == "")
            {
                MessageBox.Show("轻轨先生成秘钥");
                return;
            }
            if (txtFilename.Text == "" || !File.Exists(txtFilename.Text))
            {
                MessageBox.Show("请选择需要传输的文件");
                return;
            }
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("请选择需要传输的教师");
                return;
            }
            var obj = listBox1.SelectedItem as User;
            var id = obj.Email;
            var filePath = txtFilename.Text;
            var encryptFilePath = $"files/{Path.GetFileName(txtFilename.Text)}.encrypt";
            // var desKey = EncryptHelper.GetDesKeyByEmail(id);
            // DesHelper.EncryptFile(filePath, encryptFilePath, desKey);
            if (!Directory.Exists("files"))
            {
                Directory.CreateDirectory("files");
            }
            var filecontent = File.ReadAllText(filePath);
            var aesContent = AESHelper.AESEncrypt(filecontent, aesKey);
            File.WriteAllText(encryptFilePath, aesContent);
            var exchangeFileData = new ExchangeFileData();
            exchangeFileData.DestEmail = id;
            exchangeFileData.Sender = SessionManager.User.Email;
            exchangeFileData.FileName = Path.GetFileName(txtFilename.Text);
            exchangeFileData.EncryptFilePath = encryptFilePath;
            exchangeFileData.AesSourceKey = aesKey;
            exchangeFileData.AesEncryptKey = EncryptHelper.EncryptAesKeyByEmail(id, aesKey);
            MyDbContext.Instance.ExchangeFileDatas.Add(exchangeFileData);
            MyDbContext.Instance.SaveChanges();
            aesKey = "";
            lblAesKey.Text = "";
            MessageBox.Show("发送加密文件成功");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // 选择文件

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilename.Text = openFileDialog1.FileName;
            }
        }

        private void LoadFileData()
        {
            var email = SessionManager.User.Email;
            if (!checkBox1.Checked)
            {
                var list = MyDbContext.Instance.ExchangeFileDatas.Where(p => true).ToList();
                list.ForEach(p =>
                {
                    if (p.DestEmail == email)
                    {
                        p.IsSendMe = true;
                    }
                });
                BindingSource bs = new BindingSource();
                bs.DataSource = list;
                listBox2.DataSource = bs;
            }
            else
            {
                var list = MyDbContext.Instance.ExchangeFileDatas.Where(p => p.DestEmail == email).ToList();
                list.ForEach(p =>
                {
                    if (p.DestEmail == email)
                    {
                        p.IsSendMe = true;
                    }
                });
                BindingSource bs = new BindingSource();
                bs.DataSource = list;
                listBox2.DataSource = bs;
            }
        }

        private void FrmStudentMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin.Instance.Show();
            SessionManager.Clear();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserChangePwd frmUserChangePwd = new FrmUserChangePwd();
            frmUserChangePwd.ShowDialog();
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin.Instance.Show();
            SessionManager.Clear();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //解密文件

            if (listBox2.SelectedIndex < 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = listBox2.SelectedItem as ExchangeFileData;
            var sec = MyDbContext.Instance.SecretKeys.FirstOrDefault(p => p.Email == SessionManager.User.Email);
            if (sec == null)
            {
                MessageBox.Show("无法下载文件。因为无法解密。");
                return;
            }
            if (!sec.Enable)
            {
                MessageBox.Show("无法下载文件。因为秘钥被禁用，请联系管理员。");
                return;
            }
            var aesKey = EncryptHelper.DecryptAesKeyByEmail(SessionManager.User.Email, item.AesEncryptKey);

            //  var desKey = EncryptHelper.GetDesKeyByEmail(SessionManager.User.Email);
            var fileName = item.FileName;
            saveFileDialog1.FileName = fileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var encryptFileContent = File.ReadAllText(item.EncryptFilePath);
                var decryptContent = AESHelper.AESDecrypt(encryptFileContent, aesKey);
                File.WriteAllText(saveFileDialog1.FileName, decryptContent);
                //  DesHelper.DecryptFile(item.EncryptFilePath, saveFileDialog1.FileName, desKey);
                MessageBox.Show("接收文件成功");
                item.IsDowload = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoadFileData();
        }

        private string aesKey;

        private void btnCreateKey_Click(object sender, EventArgs e)
        {
            //生成秘钥
            aesKey = RandomHelper.GenerateRandomNumber(10);
            lblAesKey.Text = aesKey;
            MessageBox.Show(aesKey, "信息提示");
        }
    }
}