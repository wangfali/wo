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
    /// 描述：添加用户
    /// 作者：王法立
    /// 创建日期：2016-7-16
    /// 版本：2.0.0.0
    /// </summary>
    public partial class adduser : Form
    {
        /// <summary>
        /// 类名：用户
        /// 描述：添加用户
        /// 作者：王法立
        /// 创建日期：2016-6-30 
        /// 版本：2.0.0.0
        /// </summary>
        public adduser()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            BLLProject.User bll = new BLLProject.User();
            ModelProject.User user = new ModelProject.User();
            if (textBox1.Text== "" && textBox2.Text == "")
            {
                MessageBox.Show("请输入用户名及密码");
            }
            else
            {
                try
                {
                    user.Userid = textBox1.Text.ToString();
                    user.Userpwd = textBox2.Text.ToString();
                    bll.Model = user;
                    if (bll.add() > 0)
                    {
                        MessageBox.Show("添加成功！");
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }
    }
}
