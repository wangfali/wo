using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WinPlatProject
{
    /// <summary>
    /// 类名：用户
    /// 描述：教师用户界面
    /// 作者：王法立
    /// 创建日期：2016-6-30 
    /// 版本：2.0.0.0
    /// </summary>
    public partial class teacherfrom : Form
    {
        public teacherfrom()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 公共方法用于查询并输出该用户日志
        /// </summary>
        public void datausrlog()
        {
            BLLProject.Log bll = new BLLProject.Log();
            ModelProject.Log logs = new ModelProject.Log();
            string teacherzhanghu = import.i;
            logs.Userid = teacherzhanghu;
            bll.Model = logs;
            dataGridView1.DataSource = bll.find("Userid='" + teacherzhanghu + "'");
            // dataGridView3.DataSource = bll.find("");
            foreach (DataGridViewRow dgvarow in dataGridView1.Rows)
            {
                if (dgvarow.Index % 2 == 0)
                {
                    dataGridView1.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    dataGridView1.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }
        public void teaacherview()
        {

        }
        /// <summary>
        /// 修改教师密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 修改教师密码_Click(object sender, EventArgs e)
        {

            BLLProject.User bll = new BLLProject.User();
            ModelProject.User user = new ModelProject.User();
            string teacherzhanghu = import.i;
            string newpwd = newpwdbox.Text.ToString();
            string newpwdagaint = newpwdagaintbox.Text.ToString();
            if (newpwd.Equals(newpwdagaint) == true)
            {
                MessageBox.Show("你输入的不正确！");
            }
            if (newpwdbox.Text == "" && newpwdagaintbox.Text == "")
            {
                MessageBox.Show("请输入密码");
            }
            else
            {
                try
                {
                    Object obj = bll.getMe(teacherzhanghu);
                    user = (ModelProject.User)obj;
                    user.Userid = teacherzhanghu;
                    user.Userpwd = newpwdagaintbox.Text.ToString();
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
        /// <summary>
        /// 公共方法用于查询并输出该课表
        /// </summary>
        public void dataviewlist()
        {
            BLLProject.List bll = new BLLProject.List();
            ModelProject.List list = new ModelProject.List();
            bll.Model = list;
            dataGridViewtecherlist.DataSource = bll.find("");
            bindingteacher.DataSource = bll.find("");
            foreach (DataGridViewRow dgvarow in dataGridViewtecherlist.Rows)
            {
                if (dgvarow.Index % 2 == 0)
                {
                    dataGridViewtecherlist.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    dataGridViewtecherlist.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
            teacherlistcount.Text = "当前数据共有" + bindingteacher.Count;
        }
        /*public void dataviewteacher()
        {
            BLLProject.Teacher bll = new BLLProject.Teacher();
            ModelProject.Teacher teacher = new ModelProject.Teacher();
            bll.Model = teacher;
            selectxinxi.DataSource = bll.find("");
            bindingSourcegerenxinxi.DataSource = bll.find("");
            foreach (DataGridViewRow dgvarow in selectxinxi.Rows)
            {
                if (dgvarow.Index % 2 == 0)
                {
                    selectxinxi.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    selectxinxi.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }

        }*/
        /// <summary>
        /// 公共方法用于查询并输出该学生成绩
        /// </summary>
        public void datamarkview()
        {
            BLLProject.Mark bll = new BLLProject.Mark();
            ModelProject.Mark mark = new ModelProject.Mark();
            bll.Model = mark;
            markview.DataSource = bll.find("");
            bindingSourcemark.DataSource = bll.find("");
            foreach (DataGridViewRow dgvarow in markview.Rows)
            {
                if (dgvarow.Index % 2 == 0)
                {
                    markview.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    markview.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
            statusStrip2.Text = "当前数据共有" + bindingSourcemark.Count;
        }
        /// <summary>
        /// 窗体变化时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // dataviewteacher();
            dataviewlist();
            datamarkview();
            datausrlog();
            //studentgerenxinxi();
        }
        /// <summary>
        /// 窗体变化时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
             // dataviewteacher();
            dataviewlist();
            datamarkview();
           datausrlog();
            //studentgerenxinxi();
        }
        /// <summary>
        /// 查找课程表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 查找课表_Click(object sender, EventArgs e)
        {
            BLLProject.List bll = new BLLProject.List();
            ModelProject.List list = new ModelProject.List();
            string i = listnobox.Text.ToString();
            bll.Model = list;
            try
            {
                if (bll.find("Listno='" + i + "'") == null)
                {
                    MessageBox.Show("你查找的课程安排不存在不存在！");
                }
                else
                {
                    dataGridViewtecherlist.DataSource = bll.find("Listno='" + i + "'");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// 查找学生成绩表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            BLLProject.Mark bll = new BLLProject.Mark();
            ModelProject.Mark mark = new ModelProject.Mark();
            string i = chazhaochengji.Text.ToString();
            bll.Model = mark;
            try
            {
                if (bll.find("Markno='" + i + "'") == null)
                {
                    MessageBox.Show("你查找的成绩表不存在！");
                }
                else
                {
                    dataGridViewtecherlist.DataSource = bll.find("Markno='" + i + "'");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// 上传学生成绩信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 上传成绩对于教师_Click(object sender, EventArgs e)
        {
            addmark a = new addmark();
            a.Show();
        }
        /// <summary>
        /// 公共方法用于查询并输出教师个人信息
        /// </summary>
        public SqlConnection conn = new SqlConnection("server=SAMSUNG-PC;uid=sa;pwd=111;database=ManageSystem");
        public void studentgerenxinxi()
        {

            BLLProject.Teacher bll = new BLLProject.Teacher();
            ModelProject.Teacher teacher = new ModelProject.Teacher();
            string t = import.i;
            teacher.Teno = t;
            bll.Model = teacher;
            Object obj = bll.getMe(t);
            teacher = (ModelProject.Teacher)obj;
            label15.Text = teacher.Tename.ToString();
            label18.Text = teacher.Tepolitice.ToString();
            label5.Text = teacher.Tel.ToString();
            label4.Text = teacher.Teadd.ToString();
            label17.Text = teacher.Tebirthday.ToShortDateString();
            label3.Text = teacher.Prorank.ToString();
            label16.Text = teacher.Edu.ToString();
            
            try
            {
                conn.Open();
                Byte[] info;
                SqlCommand sqlcmd = new SqlCommand("select Teimage from Teacher where Teno=@name", conn);
                sqlcmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = teacher.Teno;
                SqlDataReader sql = sqlcmd.ExecuteReader();
                UTF8Encoding temp = new UTF8Encoding(true);
                if (sql.HasRows)
                {
                    while (sql.Read())
                    {
                        info = (byte[])sql["Teimage"];
                        MemoryStream ms = new MemoryStream(info);
                        Bitmap bmp = new Bitmap(Bitmap.FromStream(ms));
                        this.pictureBox1.Image = bmp;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally
            {
                conn.Close();
            }

        }
    }
}