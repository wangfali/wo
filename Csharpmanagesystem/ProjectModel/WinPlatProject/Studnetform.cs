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
    /// 描述：学生用户界面
    /// 作者：王法立
    /// 创建日期：2016-6-30 
    /// 版本：2.0.0.0
    /// </summary>
    public partial class Studnetform : Form
    {
        public Studnetform()
        {
            InitializeComponent();
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
            dataGridView3.DataSource = bll.find("Userid='" + teacherzhanghu + "'");
           // dataGridView3.DataSource = bll.find("");
            foreach (DataGridViewRow dgvarow in dataGridView3.Rows)
            {
                if (dgvarow.Index % 2 == 0)
                {
                    dataGridView3.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    dataGridView3.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }
        /// <summary>
        /// 公共方法用于查询并输出该学生成绩
        /// </summary>
        public void dataviewmark()
        {
            BLLProject.Mark bll = new BLLProject.Mark();
            ModelProject.Mark mark = new ModelProject.Mark();
            bll.Model = mark;
            string studnetcheji = import.i;
            dataGridView1.DataSource = bll.find("Stno='" + studnetcheji + "'");
            bindingSourcechejicount.DataSource = bll.find("Stno='" + studnetcheji + "'");
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
        /// <summary>
        /// 用于修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            BLLProject.User bll = new BLLProject.User();
            ModelProject.User user = new ModelProject.User();
            string teacherzhanghu = import.i;
            string newpwd = textBox1.Text.ToString();
            string newpwdagaint = textBox2.Text.ToString();
            if (newpwd.Equals(newpwdagaint) == false)
            {
                MessageBox.Show("你输入的不正确！");
            }
            if (textBox1.Text == "" && textBox2.Text == "")
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
                    user.Userpwd = textBox2.Text.ToString();
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
        /// 窗体变换时展现视图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_TabIndexChanged(object sender, EventArgs e)
        {
            dataviewmark();
            slectlist();
            studentgerenxinxi();
            datausrlog();
        }
        /// <summary>
        /// 公共方法用于查询并输出学生课表
        /// </summary>
        public void slectlist()
        {
            BLLProject.Student bll = new BLLProject.Student();
            ModelProject.Student student = new ModelProject.Student();
            string geirenlist = import.i;
            bll.Model = student;
            Object obj = bll.getMe(geirenlist);
            student = (ModelProject.Student)obj;
            string i = student.class2.Clno;
            BLLProject.MyClass bll2 = new BLLProject.MyClass();
            ModelProject.MyClass myclass = new ModelProject.MyClass();
            bll2.Model = myclass;
            Object obj2 = bll2.getMe(i);
            myclass = (ModelProject.MyClass)obj2;
            string classname = myclass.Clname;
            BLLProject.List blls = new BLLProject.List();
            ModelProject.List list = new ModelProject.List();
            blls.Model = list;
            dataGridView2.DataSource = blls.find("myclass='" + classname + "'");
            bindingSource1.DataSource = blls.find("myclass='" + classname + "'");
            foreach (DataGridViewRow dgvarow in dataGridView2.Rows)
            {
                if (dgvarow.Index % 2 == 0)
                {
                    dataGridView2.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    dataGridView2.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
            toolStripStatusLabel1.Text = "当前数据共有" + bindingSource1.Count;

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 打开数据库连接
        /// </summary>
         public SqlConnection conn = new SqlConnection("server=SAMSUNG-PC;uid=sa;pwd=111;database=ManageSystem");
        /// <summary>
         /// 公共方法用于查询并输出学生个人信息
        /// </summary>
        public void studentgerenxinxi()
        {
            BLLProject.Student bll = new BLLProject.Student();
            ModelProject.Student student = new ModelProject.Student();
            string t = import.i;
            student.Stno = t;
            bll.Model = student;
            Object obj = bll.getMe(t);
            student = (ModelProject.Student)obj;
            label6.Text = student.Stno.ToString();
            label13.Text = student.Stname.ToString();
            label14.Text = student.Sttel.ToString();
            label15.Text = student.Stage.ToString();
            label16.Text = student.Stpolitice.ToString();
            label17.Text = student.Stadd.ToString();
            label18.Text = student.Sex.ToString();
            label19.Text = student.Stbirthday.ToString();
            label20.Text = student.Enrollt.ToString();
            try
            {
                conn.Open();
                Byte[] info;
                SqlCommand sqlcmd = new SqlCommand("select Stimage from Student where Stno=@name", conn);
                sqlcmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value =student.Stno;
                SqlDataReader sql = sqlcmd.ExecuteReader();
                UTF8Encoding temp = new UTF8Encoding(true);
                if (sql.HasRows)
                {
                    while (sql.Read())
                    {
                        info = (byte[])sql["Stimage"];
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
        /// <summary>
        /// 窗体加载时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Studnetform_Load(object sender, EventArgs e)
        {
            studentgerenxinxi();
            dataviewmark();
            slectlist();
            datausrlog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
