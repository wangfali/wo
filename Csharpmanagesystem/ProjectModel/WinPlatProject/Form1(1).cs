using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPlatProject
{
    public partial class FrmActor : Form
    {
        private ModelProject.Actor editActor = null;//修改的角色
        /// <summary>
        /// 设置或获取当前窗体的父级属性
        /// </summary>
        public FrmActorManagement parent
        { get; set; }
        /// <summary>
        /// 新增角色
        /// </summary>
        private void add()
        {
            ModelProject.Actor model = new ModelProject.Actor();
            model.ID = txtID.Text;
            model.Name = txtName.Text;

            if (txtID.Text.Trim() == "" || txtName.Text.Trim() == "")
            {
                MessageBox.Show("角色的编号和名称都不能为空！");
                txtID.Focus();
                return;
            }

            if (MessageBox.Show("数据保存后不能撤销，确定吗？(Y/N)", "警告", MessageBoxButtons.YesNo) == DialogResult.No) return;

            String strTemp = model.ToXML();

            BLLProject.Actor bll = new BLLProject.Actor();//创建业务层角色对象
            bll.Model = model;//持久层获得操作数据对象model
            int result = bll.add();
            if (result > 0)
            {
                if (parent != null)
                {
                    parent.Bind(txtName.Text);
                }
                MessageBox.Show("角色新增成功！");
                Close();
            }
            else
                MessageBox.Show("角色新增失败！" + result.ToString());
        }
        private void edit()
        {
            editActor.Name = txtName.Text;

            BLLProject.Actor bll = new BLLProject.Actor();
            bll.Model = editActor;
            if (bll.edit() > 0)
            {
                parent.Bind(txtName.Text);
                Close();
            }
            else
            MessageBox.Show("角色修改失败！");
        }
        public FrmActor(ModelProject.Actor a)
        {
            InitializeComponent();

            editActor = a;//获得修改的对象

            if (editActor != null)
            {
                txtID.Text = editActor.ID;
                txtName.Text = editActor.Name;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editActor == null)
                add();
            else
                edit();
        }
    }
}
