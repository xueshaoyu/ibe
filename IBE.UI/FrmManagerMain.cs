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
            LoadManagerList(); 
        }

        private void LoadManagerList()
        {
            dataGridView1.DataSource = MyDbContext.Instance.Managers.Where(p => true).ToList();
        }

        private void LoadTeacherList()
        {
            dataGridView1.DataSource = MyDbContext.Instance.Teachers.Where(p => true).ToList();
        }

        private void LoadStudentList()
        {
            dataGridView1.DataSource = MyDbContext.Instance.Students.Where(p => true).ToList();
        }
        private void LoadRoleList()
        {
            dataGridView4.DataSource = MyDbContext.Instance.Roles.Where(p => true).ToList();
        }
        private void btnMagAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmManagerEdit();
            frm.ShowDialog();
        }

        private void btnMagEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dataGridView1.CurrentRow.DataBoundItem as Manager;
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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dataGridView1.CurrentRow.DataBoundItem as Manager;

            MyDbContext.Instance.Managers.Remove(item);

            LoadManagerList();
        }

        private void btnTeacherAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmTeacherEdit();
            frm.ShowDialog();
        }

        private void btnTeacherEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dataGridView2.CurrentRow.DataBoundItem as Teacher;
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
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dataGridView2.CurrentRow.DataBoundItem as Teacher;

            MyDbContext.Instance.Teachers.Remove(item);

            LoadTeacherList();
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmStudentEdit();
            frm.ShowDialog();
        }

        private void btnStudentEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dataGridView3.CurrentRow.DataBoundItem as Student;
            var frm = new FrmStudentEdit();
            frm.SetData(item);
            var r = frm.ShowDialog();
            if (r == DialogResult.OK)
            {
                LoadStudentList();
            }
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dataGridView3.CurrentRow.DataBoundItem as Student;

            MyDbContext.Instance.Students.Remove(item);

            LoadStudentList();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            var frm = new FrmRoleEdit();
            frm.ShowDialog();
        }

        private void btnEditRole_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dataGridView4.CurrentRow.DataBoundItem as Role;
            var frm = new FrmRoleEdit();
            frm.SetData(item);
            var r = frm.ShowDialog();
            if (r == DialogResult.OK)
            {
                LoadRoleList();
            }
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择行");
                return;
            }
            var item = dataGridView3.CurrentRow.DataBoundItem as Role;

            MyDbContext.Instance.Roles.Remove(item);

            LoadRoleList();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {

                case 0:
                    LoadManagerList();
                    break;
                case 1:
                    LoadRoleList();
                    break;
                case 2:
                    LoadTeacherList();
                    break;
                case 3:
                    LoadStudentList();
                    break;
                default:
                    break;
            }
        }
    }
}