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
    public partial class FrmStudentEdit : Form
    {
        public FrmStudentEdit()
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
                    Text = "编辑学生";
                }
                else
                {
                    Text = "新增学生";
                }
            }
        }

        public Student Student { get; set; }

        public void SetData(Student student)
        {
            IsEdit = student != null;
            Student = student;
        }
    }
}