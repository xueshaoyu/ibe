﻿using IBE.Data.Models;
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
    public partial class FrmManagerEdit : Form
    {
        public FrmManagerEdit()
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
                    Text = "编辑管理员";
                }
                else
                {
                    Text = "新增管理员";
                }
            }
        }

        public Manager Manager { get; set; }

        public void SetData(Manager manager)
        {
            IsEdit = manager != null;
            Manager = manager;
        }
    }
}