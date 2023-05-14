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
    public partial class FrmManagerMain : Form
    {
        public FrmManagerMain()
        {
            InitializeComponent();
        }

        private void FrmManagerMain_Load(object sender, EventArgs e)
        {
            dgv1.AutoGenerateColumns = false;
            dgv2.AutoGenerateColumns = false;
            dgv3.AutoGenerateColumns = false;
            dgv4.AutoGenerateColumns = false;

            LoadManagerList();
            LoadUserList();
            LoadFileList();
            LoadSecretKeyList();
        }

        private void LoadManagerList()
        {
            dgv1.DataSource = MyDbContext.Instance.Managers.Where(p => true).ToList();
        }

        
        private void LoadUserList()
        {
            dgv2.DataSource = MyDbContext.Instance.Users.Where(p => true).ToList();
        }
        private void LoadFileList()
        {
            dgv3.DataSource = MyDbContext.Instance.ExchangeFileDatas.Where(p => true).ToList();
        }
        private void LoadSecretKeyList()
        {
            dgv4.DataSource = MyDbContext.Instance.SecretKeys.Where(p => true).ToList();
        }
        private void btnMagAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmManagerEdit();
            var r = frm.ShowDialog();
            if (r == DialogResult.OK)
            {
                LoadManagerList();
            }
        }

        private void btnMagEdit_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dgv1.CurrentRow.DataBoundItem as Manager;
            FrmManagerEdit frm = new FrmManagerEdit();
            frm.SetData(item);
            var r = frm.ShowDialog();
            if (r == DialogResult.OK)
            {
                LoadManagerList();
            }
        }

        private void btnMagDelete_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dgv1.CurrentRow.DataBoundItem as Manager;
            if (!item.AllowDelete)
            {
                MessageBox.Show("不能删除内置账户");
                return;
            }
            if (MessageBox.Show("删除后，数据将不可恢复，请谨慎操作。\n是否继续删除？", "警告", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            MyDbContext.Instance.Managers.Remove(item);

            MyDbContext.Instance.SaveChanges();
            LoadManagerList();
        } 


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {

                case 0:
                    LoadManagerList();
                    break; 
                case 1:
                    LoadUserList();
                    break;
                default:
                    break;
            }
        }

        private void FrmManagerMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin.Instance.Show();
            SessionManager.Clear();
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {

            var frm = new FrmUserEdit();
            var r = frm.ShowDialog();
            if (r == DialogResult.OK)
            {
                LoadUserList();
            }
        }

        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dgv2.CurrentRow.DataBoundItem as User;
            var frm = new FrmUserEdit();
            frm.SetData(item);
            var r = frm.ShowDialog();
            if (r == DialogResult.OK)
            {
                LoadUserList();
            }
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            if (MessageBox.Show("删除后，数据将不可恢复，请谨慎操作。\n是否继续删除？", "警告", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var item = dgv2.CurrentRow.DataBoundItem as User;

            MyDbContext.Instance.Users.Remove(item);

            MyDbContext.Instance.SaveChanges();
            LoadUserList();
        }

        private void btnUserEnable_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dgv2.CurrentRow.DataBoundItem as User;
            item.Enable = true;
            MyDbContext.Instance.SaveChanges();
            LoadUserList();
        }

        private void btnUserDisable_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dgv2.CurrentRow.DataBoundItem as User;
            item.Enable = false;
            MyDbContext.Instance.SaveChanges();
            LoadUserList();

        }

        private void btnFileDelete_Click(object sender, EventArgs e)
        {
            if (dgv3.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            if (MessageBox.Show("删除后，数据将不可恢复，请谨慎操作。\n是否继续删除？", "警告", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var item = dgv3.CurrentRow.DataBoundItem as ExchangeFileData;

            MyDbContext.Instance.ExchangeFileDatas.Remove(item);

            MyDbContext.Instance.SaveChanges();
            LoadFileList();
        }

        private void btnKey_Click(object sender, EventArgs e)
        {

            if (dgv4.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            if (MessageBox.Show("删除后，加密文件将永久无法解密，请谨慎操作。\n是否继续删除？", "警告", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var item = dgv4.CurrentRow.DataBoundItem as SecretKey;

            MyDbContext.Instance.SecretKeys.Remove(item);

            MyDbContext.Instance.SaveChanges();
            LoadSecretKeyList();
        }

        private void btnMagEnable_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dgv1.CurrentRow.DataBoundItem as Manager;
            item.Enable = true;
            MyDbContext.Instance.SaveChanges();
            LoadManagerList();
        }

        private void btnMagDisable_Click(object sender, EventArgs e)
        {

            if (dgv1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dgv1.CurrentRow.DataBoundItem as Manager;
            if(item.Id==SessionManager.Manager.Id)
            {
                MessageBox.Show("不能禁用自己");
                return;
            }
            item.Enable = false;
            MyDbContext.Instance.SaveChanges();
            LoadManagerList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //禁用秘钥

            if (dgv4.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            if (MessageBox.Show("禁用后，网盘用户将无法下载解密文件。\n是否继续禁用？", "警告", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var item = dgv4.CurrentRow.DataBoundItem as SecretKey;

            item.Enable = false;

            MyDbContext.Instance.SaveChanges();
            LoadSecretKeyList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //启用秘钥

            if (dgv4.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            } 
            var item = dgv4.CurrentRow.DataBoundItem as SecretKey;

            item.Enable = true;

            MyDbContext.Instance.SaveChanges();
            LoadSecretKeyList();
        }
    }
}