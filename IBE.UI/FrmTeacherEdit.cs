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
    public partial class FrmTeacherEdit : Form
    {
        public FrmTeacherEdit()
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
                    Text = "编辑教师";
                }
                else
                {
                    Text = "新增教师";
                }
            }
        }

        public Teacher Teacher { get; set; }

        public void SetData(Teacher teacher)
        {
            IsEdit = teacher != null;
            Teacher = teacher;
        }
    }
}