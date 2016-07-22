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
    public partial class deletedepartment : Form
    {
        public deletedepartment()
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
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入部门编号");
            }
            else
            {
                try
                {
                    ModelProject.Department department = new ModelProject.Department();
                    BLLProject.Department bll = new BLLProject.Department();
                    string i = textBox1.Text.ToString();
                    department.Depno = textBox1.Text.ToString();
                    bll.Model = department;
                    DataTable bt = bll.find("Depno='" + i + "'");
                    if (bt == null)
                    {
                        MessageBox.Show("您输入的部门编号不存在");
                    }
                    else
                    {
                        if (bll.del() > 0)
                        {
                            MessageBox.Show("删除成功!");
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }
        /// <summary>
        /// 关闭对话窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
