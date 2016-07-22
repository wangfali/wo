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
    /// 描述：添加角色
    /// 作者：王法立
    /// 创建日期：2016-6-30 
    /// 版本：2.0.0.0
    /// </summary>
    public partial class addrole : Form
    {
        public addrole()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            BLLProject.Role bll = new BLLProject.Role();
            ModelProject.Role role = new ModelProject.Role();
            if (roleidbox.Text == "" && roleremark.Text  == "" && rolenamebox.Text == "")
            {
                MessageBox.Show("您的输入不完整！请核对后再输");
            }
            else
            {
                try
                {
                    role.RoleId = roleidbox.Text.ToString();
                    if (rolenamebox.Text.ToString().Equals("教师"))
                    {
                        role.RoleName = ModelProject.ROleName.教师;
                    }
                    if (rolenamebox.Text.ToString().Equals("学生"))
                    {
                        role.RoleName = ModelProject.ROleName.学生;
                    }
                    if (rolenamebox.Text.ToString().Equals("管理员"))
                    {
                        role.RoleName = ModelProject.ROleName.管理员;
                    }
                    role.Remark = roleremark.Text.ToString();
                    bll.Model = role;
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
