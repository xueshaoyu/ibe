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
            LoadTeacherList();
            LoadStudentList();
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

        private void btnMagAdd_Click(object sender, EventArgs e)
        {
            FrmManagerEdit frm = new FrmManagerEdit();
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
            frm.ShowDialog();
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
    }
}