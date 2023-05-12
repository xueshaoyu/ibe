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

            LoadManagerList();
        }

        private void LoadManagerList()
        {
            dgv1.DataSource = MyDbContext.Instance.Managers.Where(p => true).ToList();
        }

        private void LoadTeacherList()
        {
            dgv2.DataSource = MyDbContext.Instance.Teachers.Where(p => true).ToList();
        }

        private void LoadStudentList()
        {
            dgv3.DataSource = MyDbContext.Instance.Students.Where(p => true).ToList();
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
            MyDbContext.Instance.Managers.Remove(item);

            MyDbContext.Instance.SaveChanges();
            LoadManagerList();
        }

        private void btnTeacherAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmTeacherEdit();
            var r = frm.ShowDialog();
            if (r == DialogResult.OK)
            {
                LoadTeacherList();
            }
        }

        private void btnTeacherEdit_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dgv2.CurrentRow.DataBoundItem as Teacher;
            var frm = new FrmTeacherEdit();
            frm.SetData(item);
            var r = frm.ShowDialog();
            if (r == DialogResult.OK)
            {
                LoadTeacherList();
            }
        }

        private void btnTeacherDelete_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dgv2.CurrentRow.DataBoundItem as Teacher;

            MyDbContext.Instance.Teachers.Remove(item);
            MyDbContext.Instance.SaveChanges();
            LoadTeacherList();
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmUserEdit();
            var r = frm.ShowDialog();
            if (r == DialogResult.OK)
            {
                LoadStudentList();
            }
        }

        private void btnStudentEdit_Click(object sender, EventArgs e)
        {
            if (dgv3.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dgv3.CurrentRow.DataBoundItem as Student;
            var frm = new FrmUserEdit();
            frm.SetData(item);
            var r = frm.ShowDialog();
            if (r == DialogResult.OK)
            {
                LoadStudentList();
            }
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            if (dgv3.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dgv3.CurrentRow.DataBoundItem as Student;

            MyDbContext.Instance.Students.Remove(item);

            MyDbContext.Instance.SaveChanges();
            LoadStudentList();
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {

                case 0:
                    LoadManagerList();
                    break;
                case 1:
                    LoadTeacherList();
                    break;
                case 2:
                    LoadStudentList();
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
    }
}