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
            //if (listBox1.SelectedIndex < 0)
            //{
            //    MessageBox.Show("请选择需要传输的学生");
            //    return;
            //}

            var messsage = File.ReadAllText(txtFilename.Text);
            var msg = EncryptHelper.Encode(messsage, "75668578@qq.com");
            var msg2 = EncryptHelper.Decode(msg, "75668578@qq.com");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // 选择文件

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilename.Text = openFileDialog1.FileName;

            }
        }
    }
}
