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
    /// <summary>
    /// 类名：用户
    /// 描述：添加部门
    /// 作者：王法立
    /// 创建日期：2016-6-30 
    /// 版本：2.0.0.0
    /// </summary>
    public partial class departmentview : Form
    {
        public departmentview()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            BLLProject.Department bll = new BLLProject.Department();
            ModelProject.Department department = new ModelProject.Department();
            if (pronobox.Text == "" && pronamebox.Text == "" && profunction.Text == "" && marjorname.Text == "")
            {
                MessageBox.Show("您的输入不完整！请核对后再输");
            }
            else
            {
                try
                {
                    department.Depno = pronobox.Text.ToString();
                    department.Depname = pronamebox.Text.ToString();
                    department.Depfunctian = profunction.Text.ToString();
                    department.Depma = marjorname.Text.ToString();
                    bll.Model = department;
                    if (bll.add() > 0)
                    {
                        MessageBox.Show("添加成功！");
                    }
                    else
                    {
                        MessageBox.Show("添加失败！");
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }
    }
}
