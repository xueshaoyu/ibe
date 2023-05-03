using IBE.Data.Models;
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
    public partial class FrmTeacherMain : Form
    {
        public FrmTeacherMain()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //发送加密文件
            if (txtFilename.Text == "" || !File.Exists(txtFilename.Text))
            {
                MessageBox.Show("请选择需要传输的文件");
                return;
            }
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("请选择需要传输的学生");
                return;
            }
            var obj = listBox1.SelectedItem as Student;
            var id = obj.Email;
            var messsage = File.ReadAllText(txtFilename.Text);
            var encrypt = EncryptHelper.Encode(messsage, id);
            var encryptMsg = encrypt.V;
            var encryptFilePath = $"files/{Path.GetFileName(txtFilename.Text)}.encrypt";
            if (!Directory.Exists(Path.GetDirectoryName(encryptFilePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(encryptFilePath));
            }
            File.WriteAllText(encryptFilePath, encryptMsg);
            var exchangeFileData = new ExchangeFileData();
            exchangeFileData.DestEmail = id;
            exchangeFileData.KeyX = encrypt.U.X.ToBigInteger().ToString();
            exchangeFileData.KeyY = encrypt.U.Y.ToBigInteger().ToString();
            exchangeFileData.Sender = SessionManager.Teacher.Email;
            exchangeFileData.FileName = Path.GetFileName(txtFilename.Text);
            exchangeFileData.EncryptFilePath = encryptFilePath;
            MyDbContext.Instance.ExchangeFileDatas.Add(exchangeFileData);
            MyDbContext.Instance.SaveChanges();
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

        private void FrmTeacherMain_Load(object sender, EventArgs e)
        {
            //加载学生列表
            LoadStudentData();
            //加载发送给自己的文件
            LoadFileData();
        }
        private void LoadStudentData()
        {
            var list = MyDbContext.Instance.Students.Where(p => true).ToList();
            listBox1.DataSource = list;
        }
        private void LoadFileData()
        {
            var email = SessionManager.Teacher.Email;
            var list = MyDbContext.Instance.ExchangeFileDatas.Where(p => true).ToList();
            listBox2.DataSource = list;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex < 0)
            {
                MessageBox.Show("请选择需要打开的加密文件");
                return;
            }
            var obj = listBox2.SelectedItem as ExchangeFileData;
            if (obj.DestEmail != SessionManager.Teacher.Email)
            {
                MessageBox.Show("该文件不是发给你的，你不能解密。");
                return;
            }
            obj.IsRead = true;
            var message = File.ReadAllText(obj.EncryptFilePath);
            var decryptMsg = EncryptHelper.Decode(obj.KeyX, obj.KeyY, message, SessionManager.Teacher.Email);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, decryptMsg, Encoding.UTF8);
                MyDbContext.Instance.SaveChanges();
                MessageBox.Show($"文件【{saveFileDialog1.FileName}】保存成功");
            }
        }

        private void FrmTeacherMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin.Instance.Show();
            SessionManager.Clear();
        }
    }
}
