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
    /// 描述：添加专业
    /// 作者：王法立
    /// 创建日期：2016-6-30 
    /// 版本：2.0.0.0
    /// </summary>
    public partial class addmajor : Form
    {
        public addmajor()
        {
            InitializeComponent();
        }

        private void depnobox_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 添加专业
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            BLLProject.Major bll = new BLLProject.Major();
            ModelProject.Major major = new ModelProject.Major();
            if (proname.Text == "" && prosk.Text == "" && proname.Text == "" && depnobox.Text == "")
            {
                MessageBox.Show("您的输入不完整！请核对后再输");
            }
            else
            {
                try
                {
                    major.Prono = pronobox.Text.ToString();
                    major.Proske = prosk.Text.ToString();
                    major.Proname = proname.Text.ToString();
                    major.department1 = new ModelProject.Department();
                    major.department1.Depno = depnobox.Text.ToString();
                    bll.Model = major;
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
