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
    public partial class manageForm : Form
    {
        public manageForm()
        {
            InitializeComponent();
        }
       
        private void tabPage2_Click(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLLProject.User bll = new BLLProject.User();
            ModelProject.User user = new ModelProject.User();
      
            string i = newuserbox.Text.ToString();
            string pwd = newpwdbox.Text.ToString();
            if (newpwdbox.Text == "" && newpwdbox.Text == "")
            {
                MessageBox.Show("请输入用户名及密码");
            }
            DataTable dt = bll.find("Userid='" + i + "'");
            if (dt.Rows.Count == 0 || dt == null)
            {
                MessageBox.Show("你的账号错误");
                
            }
            else
            {
                try
                {
                    Object obj = bll.getMe(i);
                    user = (ModelProject.User)obj;
                    user.Userid = i;
                    user.Userpwd = newpwdbox.Text.ToString();
                    bll.Model = user;
                    if (bll.edit() > 0)
                    {
                        MessageBox.Show("修改成功！");
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
           
        }

        private void okadd_Click(object sender, EventArgs e)
        {
            BLLProject.User bll = new BLLProject.User();
            ModelProject.User user = new ModelProject.User();
            if (addusernamebox.Text=="" && adduserpwd.Text=="")
            {
                MessageBox.Show("请输入用户名及密码");
            }
            else
            {
                try
                {
                    user.Userid = addusernamebox.Text.ToString();
                    user.Userpwd = adduserpwd.Text.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            BLLProject.User bll = new BLLProject.User();
            ModelProject.User user = new ModelProject.User();
            string i = selectusername.Text.ToString();
            if (selectusername.Text=="")
            {
                MessageBox.Show("请输入用户名");
            }
            else
            {
                Object obj = bll.getMe(i);
                user = (ModelProject.User)obj;
                selectuserpwd.Text = user.Userpwd.ToString();
            }
        }

        private void 添加部门ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 添加部门ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            departmentview p = new departmentview();
            p.Show();
        }

        private void 查询部门ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pleaseinputuserid p = new pleaseinputuserid();
            p.Show();
            
        }

        private void 删除部门ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletedepartment d = new deletedepartment();
            d.Show();
        }

        private void 修改部门ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 添加班级_PaddingChanged(object sender, EventArgs e)
        {

        }

        private void 添加教师用户_PaddingChanged(object sender, EventArgs e)
        {
            BLLProject.Department bll=new BLLProject.Department();
            ModelProject.Department department=new ModelProject.Department();
            bll.Model = department;
            dataGridView1.DataSource = bll.find("");
        }

        private void 添加教师用户_SelectedIndexChanged(object sender, EventArgs e)
        {

            BLLProject.Department bll = new BLLProject.Department();
            ModelProject.Department department = new ModelProject.Department();
            bll.Model = department;
            dataGridView1.DataSource = bll.find("");
        }
    }
}
