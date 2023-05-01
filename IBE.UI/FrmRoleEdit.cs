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
    public partial class FrmRoleEdit : Form
    {
        public FrmRoleEdit()
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
                    Text = "编辑角色";
                }
                else
                {
                    Text = "新增角色";
                }
            }
        }
        public Role Role { get; set; }

        public void SetData(Role role)
        {
            IsEdit = role != null;
            Role = role;
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRoleName.Text == "" )
            {
                MessageBox.Show("角色名称不能为空");
                return;
            }
            Role.Remark = txtRemark.Text;
            Role.Name = txtRoleName.Text;
            if (isEdit)
            { 
                MyDbContext.Instance.Roles.Attach(Role);
            }
            else
            {
                MyDbContext.Instance.Roles.Add(Role);
            }
            MyDbContext.Instance.SaveChanges();
          DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //取消
            DialogResult = DialogResult.Cancel;
        }
    }
}
