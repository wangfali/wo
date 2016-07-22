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
    public partial class FrmMain : Form
    {
        ModelProject.Users user = null;//当前登录的用户
        frmBack back = new frmBack();

        /// <summary>
        /// 向当前父窗体中增加子窗体,如果子窗体已经存在，则激活
        /// </summary>
        /// <param name="parent">父窗体</param>
        /// <param name="son">子窗体</param>
        private void AddNewChildForm(Form parent, Form son)
        {
            if (parent == null || parent.IsMdiContainer == false || son == null) return; //判断是否符合条件，如果不符合则退出
            foreach (var f in parent.MdiChildren)
            {
                if (f.Text.Trim().Equals(son.Text.Trim()))
                {
                    f.Activate();
                    son.Dispose();//当前子窗体资源释放

                    /*更新操作*/
                    lblOperation.Text = "当前正在操作【" + f.Text + "】";

                    return;
                }
            }
            son.MdiParent = parent;
            son.Show();

            /*更新操作*/
            lblOperation.Text = "当前正在操作【" + son.Text + "】";

        }
        public FrmMain(ModelProject.Users u)
        {
            InitializeComponent();
            user = u;
            /*将用户信息写入状态栏中*/
            lblUsers.Text = "欢迎【"+user.Number+"】使用图书管理系统";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
            back.MdiParent = this;
            back.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {

            back.Width = this.Width;
            back.Height = this.Height - toolStrip1.Height - menuStrip1.Height - statusStrip1.Height;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = "当前时间："+DateTime.Now.ToString();
        }

        private void tsmiUsers_Click(object sender, EventArgs e)
        {
           
            FrmUserManagement frmUsers = new FrmUserManagement();
          
             AddNewChildForm(this, frmUsers);
        }

        private void 角色管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActorManagement frmActor = new FrmActorManagement();
            AddNewChildForm(this, frmActor);  
        }
    }
}
