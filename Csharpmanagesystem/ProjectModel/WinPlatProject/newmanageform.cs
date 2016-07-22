using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace WinPlatProject
{
    /// <summary>
    /// 类名：用户
    /// 描述：描述了用户界面的功能代码
    /// 作者：王法立
    /// 创建日期：2016-7-17 
    /// 版本：2.0.0.0
    /// </summary>
    public partial class newmanageform : Form
    {
        public newmanageform()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 创建查看教师表的方法
        /// </summary>
        public void datateacher()
        {
            BLLProject.Teacher bll = new BLLProject.Teacher();
            ModelProject.Teacher teacher = new ModelProject.Teacher();
            bll.Model = teacher;
            dataGridViewteacher.DataSource = bll.find("");
            // bindingSource3.DataSource = bll.find("");
            foreach (DataGridViewRow dgvarow in dataGridViewteacher.Rows)
            {
                if (dgvarow.Index % 2 == 0)
                {
                    dataGridViewteacher.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    dataGridViewteacher.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }
        /// <summary>
        /// 引用用户账号
        /// </summary>
        string zhanghu = import.i;
        /// <summary>
        /// 创建查看部门表的的方法
        /// </summary>
        public  void dataview()
        {
            BLLProject.Department bll = new BLLProject.Department();
            ModelProject.Department department = new ModelProject.Department();
            bll.Model = department;
            selectdepartment.DataSource = bll.find("");
            // bindingSource3.DataSource = bll.find("");
            foreach (DataGridViewRow dgvarow in selectdepartment.Rows)
            {
                if (dgvarow.Index % 2 == 0)
                {
                    selectdepartment.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    selectdepartment.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
           // toolStripStatusLabel2.Text = "记录总条数为" + bindingSource1.Count;
        }
        /// <summary>
        ///  创建查看用户表的的方法
        /// </summary>
        public void  datausers()
        {
            BLLProject.User bll=new BLLProject.User();
            ModelProject.User users=new ModelProject.User();
            bll.Model = users;
            dataGridViewuser.DataSource = bll.find("");
          //  bindingSource2.DataSource = bll.find("");
            foreach (DataGridViewRow dgvarow in dataGridViewuser.Rows)
            {
                if (dgvarow.Index % 2 == 0)
                {
                    dataGridViewuser.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    dataGridViewuser.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }
        /// <summary>
        ///  创建查看班级表的的方法
        /// </summary>
        /// </summary>
        public void dataview2()
        {
            BLLProject.MyClass bll = new BLLProject.MyClass();
            ModelProject.MyClass clas = new ModelProject.MyClass();
            bll.Model = clas;
            selectbanjibox.DataSource = bll.find("");
          //  bindingSource2.DataSource = bll.find("");
            foreach (DataGridViewRow dgvarow in selectbanjibox.Rows)
            {
                if (dgvarow.Index % 2 == 0)
                {
                    selectbanjibox.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    selectbanjibox.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
           // zhuangtai.Text = "当前数据总共有：" + bindingSource1.Count;
        }
        /// <summary>
        /// 创建查看专业表的方法
        /// </summary>
        public void dataviewmajor()
        {
            BLLProject.Major bll= new BLLProject.Major();
            ModelProject.Major major = new ModelProject.Major();
            bll.Model = major;
            dataGridViewmajor.DataSource = bll.find("");
           // bindingSource2.DataSource = bll.find("");
            foreach (DataGridViewRow dgvarow in dataGridViewmajor.Rows)
            {
                if (dgvarow.Index % 2 == 0)
                {
                    dataGridViewmajor.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    dataGridViewmajor.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
            //statusStrip6.Text = "当前数据总共有：" + bindingSource2.Count;
        }
        /// <summary>
        /// 创建查看成绩表的方法
        /// </summary>
        public void datamarkview()
        {
            BLLProject.Mark bll = new BLLProject.Mark();
            ModelProject.Mark mark = new ModelProject.Mark();
            bll.Model = mark;
            dataGridViewmark.DataSource = bll.find("");
           // bindingSource4.DataSource = bll.find("");
            foreach (DataGridViewRow dgvarow in dataGridViewmark.Rows)
            {
                if (dgvarow.Index % 2 == 0)
                {
                    dataGridViewmark.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    dataGridViewmark.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }

        }
        /// <summary>
        /// 创建查看班级表的方法
        /// </summary>
        public void dataclassview()
        {
            BLLProject.MyClass bll = new BLLProject.MyClass();
            ModelProject.MyClass myclass = new ModelProject.MyClass();
            bll.Model = myclass;
            selectbanjibox.DataSource = bll.find("");
           // bindingSourcebanji.DataSource = bll.find("");
            foreach (DataGridViewRow dgvarow in selectbanjibox.Rows)
            {
                if (dgvarow.Index % 2 == 0)
                {
                    selectbanjibox.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    selectbanjibox.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }

        }
        /// <summary>
        /// 创建查看用户日志的方法
        /// </summary>
        public void datausrlog()
        {
            BLLProject.Log bll = new BLLProject.Log();
            ModelProject.Log logs = new ModelProject.Log();
            bll.Model = logs;
            selectlog.DataSource = bll.find("");
           bindinglog.DataSource = bll.find("");
            foreach (DataGridViewRow dgvarow in selectlog.Rows)
            {
                if (dgvarow.Index % 2 == 0)
                {
                    selectlog.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    selectlog.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
            userlog.Text = "当前数据总共有：" + bindinglog.Count;
        }
        /// <summary>
        /// 创建查看学生表的方法
        /// </summary>
        public void datastudent()
        {
            BLLProject.Student bll = new BLLProject.Student();
            ModelProject.Student student = new ModelProject.Student();
            bll.Model = student;
            selectstudent.DataSource = bll.find("");
           // bindingSource3.DataSource = bll.find("");
            foreach (DataGridViewRow dgvarow in selectstudent.Rows)
            {
                if (dgvarow.Index % 2 == 0)
                {
                    selectstudent.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    selectstudent.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }
        /// <summary>
        /// 创建查看课程表的方法
        /// </summary>
        public void datalist()
        {
            BLLProject.List bll = new BLLProject.List();
            ModelProject.List list = new ModelProject.List();
            bll.Model = list;
            selectlist.DataSource = bll.find("");
          //  bindinglist.DataSource = bll.find("");
            foreach (DataGridViewRow dgvarow in selectlist.Rows)
            {
                if (dgvarow.Index % 2 == 0)
                {
                    selectlist.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    selectlist.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
           
        }
        /// <summary>
        /// 创建查看角色表的方法
        /// </summary>
        public void datarole()
        {
            BLLProject.Role bll = new BLLProject.Role();
            ModelProject.Role role = new ModelProject.Role();
            bll.Model = role;
            dataGridViewrole.DataSource = bll.find("");
           // bindingSourcerole.DataSource = bll.find("");
            foreach (DataGridViewRow dgvarow in dataGridViewrole.Rows)
            {
                if (dgvarow.Index % 2 == 0)
                {
                    dataGridViewrole.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    dataGridViewrole.Rows[dgvarow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }

            statusStrip7.Text = "当前数据共有" + bindingSourcerole.Count;
        }
        /// <summary>
        /// 当界面发生转换时所触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            dataview();
            dataview2();
            dataviewmajor();
            dataclassview();
            datastudent();
            datausrlog();
            datalist();
            datarole();
            datamarkview();
            datausers();
            datateacher();
        }
        /// <summary>
        /// 当界面转换顺序的发生转换时所触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataview();
            dataview2();
            dataviewmajor();
            dataclassview();
            datastudent();
            datausrlog();
            datalist();
            datarole();
            datamarkview();
            datausers();
            datateacher();
        }
        /// <summary>
        /// 当界面触发的时候触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_PaddingChanged(object sender, EventArgs e)
        {
            dataview();
            dataview2();
            dataviewmajor();
            dataclassview();
            datastudent();
            datausrlog();
            datalist();
            datarole();
            datamarkview();
            datausers();
            datateacher();
        }
        /// <summary>
        /// 通过部门编号查找部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       private void toolStripButton1_Click(object sender, EventArgs e)
        {
            BLLProject.Department bll = new BLLProject.Department();
            ModelProject.Department department = new ModelProject.Department();
            string i = selectbox.Text.ToString();
            bll.Model = department;
            try
            {
                if (bll.find("Depno='" + i + "'") == null)
                {
                    MessageBox.Show("你查找的部门不存在！");
                }
                else
                {
                    selectdepartment.DataSource = bll.find("Depno='" + i + "'");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        /// <summary>
        /// 创建公共的变量用于记录指针在表格上的操作
        /// </summary>
        public int rowindex = -1;
        /// <summary>
        /// 当指针在表格上双击时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            newrowindex = e.RowIndex;//记录当前单元格地址
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// 查找学生表的方法 
        /// </summary>
        public void bindData()
        {
            BLLProject.Student bll = new BLLProject.Student();
            selectdepartment.DataSource = bll.find("");
            
        }
        /// <summary>
        /// 更新部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                BLLProject.Department bll = new BLLProject.Department();
                ModelProject.Department department = new ModelProject.Department();
                department.Depno = selectdepartment.Rows[newrowindex].Cells[0].Value.ToString();
                department.Depname = selectdepartment.Rows[newrowindex].Cells[1].Value.ToString();
                department.Depma = selectdepartment.Rows[newrowindex].Cells[2].Value.ToString();
                department.Depfunctian = selectdepartment.Rows[newrowindex].Cells[3].Value.ToString();
                department.Depjob = selectdepartment.Rows[newrowindex].Cells[4].Value.ToString();
                department.Depchecking = selectdepartment.Rows[newrowindex].Cells[5].Value.ToString();
                bll.Model = department;
                if (bll.edit() > 0)
                {
                    MessageBox.Show("更新成功！");
                    dataview2();
                }
                else
                {
                    MessageBox.Show("更新失败！");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            dataview();
        }
        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sanchu_Click(object sender, EventArgs e)
        {
            BLLProject.Department bll = new BLLProject.Department();
            ModelProject.Department department = new ModelProject.Department();
            department.Depno = selectdepartment.Rows[newdeletedepartment].Cells[0].Value.ToString();
            bll.Model = department;
            if (bll.del() > 0)
            {
                MessageBox.Show("删除成功！");
                dataview2();
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
            dataview();
        }
        /// <summary>
        ///  定义一个变量用于记录单击单元格的位置
        /// </summary>
        public int clunm1 = -1;
        /// <summary>
        /// 单击单元格所触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clunm1 = e.RowIndex;
        }
        /// <summary>
        /// 界面转换时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            adddepartment d = new adddepartment();
            d.Show();
            dataview();

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// 查找通过主码查找专业
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            BLLProject.Major bll =new  BLLProject.Major();
            ModelProject.Major major =new  ModelProject.Major();
            string i = selectbox3.Text.ToString();
            bll.Model = major;
            try
            {
                if (bll.find("Prono='" + i + "'") == null)
                {
                    MessageBox.Show("你查找的专业不存在！");
                }
                else
                {
                   dataGridViewmajor.DataSource = bll.find("Prono='" + i + "'");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// 界面转换时所触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_Click(object sender, EventArgs e)
        {
           
           
        }
        /// <summary>
        /// 创建一个变量用于双击单元格时记录单元格信息
        /// </summary>
        public int majorRowindex = 0;
        /// <summary>
        /// 双击专业单元格时记录下单元格的位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewmajor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            majorRowindex = e.RowIndex;
        }
        private void 更新_Click(object sender, EventArgs e)
        {
            try
            {
               /* BLLProject.Major bll = new BLLProject.Major();
                ModelProject.Major major = new ModelProject.Major();
                major.Prono = dataGridViewmajor.Rows[majorRowindex].Cells[0].Value.ToString();
                major.Proname = dataGridViewmajor.Rows[majorRowindex].Cells[1].Value.ToString();
                major.Proske = dataGridViewmajor.Rows[majorRowindex].Cells[2].Value.ToString();
                major.department1 = new ModelProject.Department();
                major.department1.Depno = dataGridViewmajor.Rows[majorRowindex].Cells[3].Value.ToString();
                bll.Model = major;
                if (bll.edit() > 0)
                {
                    MessageBox.Show("！");
                    bindData();
                }
                else
                {
                    MessageBox.Show("");
                }*/
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// 通过主码删除专业信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除_Click(object sender, EventArgs e)
        {
            try
            {
                BLLProject.Major bll = new BLLProject.Major();
                ModelProject.Major major = new ModelProject.Major();
                major.Prono = dataGridViewmajor.Rows[colummajor].Cells[0].Value.ToString();
                bll.Model = major;
                if (bll.del() > 0)
                {
                    MessageBox.Show("删除成功！");

                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            datamarkview();
        }
        /// <summary>
        /// 定义变量用于记录单击专业单元格时记录下的信息
        /// </summary>
        public int colummajor = 0;
        /// <summary>
        /// 单击专业单元格时所触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewmajor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            colummajor = e.RowIndex;
        }
        /// <summary>
        /// 新增专业信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 新增_Click(object sender, EventArgs e)
        {
            addmajor a = new addmajor();
            a.Show();
            datamarkview();
        }
        /// <summary>
        /// 通过主码查找班级的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 查找班级1_Click(object sender, EventArgs e)
        {
            BLLProject.MyClass bll = new BLLProject.MyClass();
            ModelProject.MyClass mylass = new ModelProject.MyClass();
            string i = selectclass.Text.ToString();
            bll.Model = mylass;
            try
            {
                if (bll.find("Clno='" + i + "'") == null)
                {
                    MessageBox.Show("你查找的专业不存在！");
                }
                else
                {
                    dataGridViewmajor.DataSource = bll.find("Clno='" + i + "'");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// 更新班级的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 更新班级_Click(object sender, EventArgs e)
        {
            try
            {
                BLLProject.MyClass bll = new BLLProject.MyClass();
                ModelProject.MyClass myclass = new ModelProject.MyClass();
                myclass.Clno = selectbanjibox.Rows[banjicolum].Cells[0].Value.ToString();
                myclass.Clname = selectbanjibox.Rows[banjicolum].Cells[1].Value.ToString();
                myclass.Cltea = selectbanjibox.Rows[banjicolum].Cells[3].Value.ToString();
                myclass.major1 = new ModelProject.Major();
                myclass.major1.Prono = selectbanjibox.Rows[banjicolum].Cells[2].Value.ToString();
                bll.Model = myclass;
                if (bll.edit() > 0)
                {
                    MessageBox.Show("更新成功！");
                    bindData();
                }
                else
                {
                    MessageBox.Show("更新失败！");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            dataview2();
        }
        /// <summary>
        /// 定义变量用于记录单元格的位置
        /// </summary>
        public int banjicolum = -1;
        /// <summary>
        /// 当班级单元格双击时记录下单元位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectbanjibox_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             banjicolum = e.RowIndex;
        }
        /// <summary>
        /// 删除班级信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除班级_Click(object sender, EventArgs e)
        {
            try
            {
                BLLProject.MyClass bll = new BLLProject.MyClass();
                ModelProject.MyClass myclass = new ModelProject.MyClass();
                myclass.Clno = selectbanjibox.Rows[sanchubanjihao].Cells[0].Value.ToString();
                bll.Model = myclass;
                if (bll.del() > 0)
                {
                    MessageBox.Show("删除成功！");

                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            dataview2();
        }
        public int sanchubanjihao = -1;
        private void selectbanjibox_Click(object sender, EventArgs e)
        {
          
        }

        private void selectbanjibox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sanchubanjihao = e.RowIndex;
        }
        /// <summary>
        /// 增加班级信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 增加班级_Click(object sender, EventArgs e)
        {
            addClass a = new addClass();
            a.Show();
            dataview2();
        }
        /// <summary>
        /// 添加学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 添加学生_Click(object sender, EventArgs e)
        {
            addstudent a = new addstudent();
            a.Show();
        }
        /// <summary>
        /// 建立数据库连接
        /// </summary>
        public SqlConnection conn = new SqlConnection("server=SAMSUNG-PC;uid=sa;pwd=111;database=ManageSystem");
        /// <summary>
        /// 查找学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 查找学生_Click(object sender, EventArgs e)
        {
            BLLProject.Student bll = new BLLProject.Student();
            ModelProject.Student studnet = new ModelProject.Student();
            studnet.Stno = selectstudentbox.Text.ToString();
            string i = selectstudentbox.Text.ToString();
            bll.Model = studnet;
            try
            {
                if (bll.find("Stno='" + i + "'") == null)
                {
                    MessageBox.Show("你查找的学生不存在！");
                }
                else
                {
                    selectstudent.DataSource = bll.find("Stno='" + i + "'");
                    try
                    {
                        conn.Open();
                        Byte[] info;
                        SqlCommand sqlcmd = new SqlCommand("select Stimage from Student where Stno=@name", conn);
                        sqlcmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = studnet.Stno;
                        SqlDataReader sql = sqlcmd.ExecuteReader();
                        UTF8Encoding temp = new UTF8Encoding(true);
                        if (sql.HasRows)
                        {
                            while (sql.Read())
                            {
                                info = (byte[])sql["Stimage"];
                                MemoryStream ms = new MemoryStream(info);
                                Bitmap bmp = new Bitmap(Bitmap.FromStream(ms));
                                this.pictureBox2.Image = bmp;
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

            catch (Exception ex) { MessageBox.Show(ex.ToString()); }



        }
        /// <summary>
        /// 更新学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void 更新学生_Click(object sender, EventArgs e)
        {
            try
            {
                BLLProject.Student bll = new BLLProject.Student();
                ModelProject.Student student = new ModelProject.Student();
                student.Stno = selectstudent.Rows[studnetindex].Cells[0].Value.ToString();
                student.class2 = new ModelProject.MyClass();
                student.class2.Clno = selectstudent.Rows[studnetindex].Cells[1].Value.ToString();
                student.Stname = selectstudent.Rows[studnetindex].Cells[2].Value.ToString();
                student.Stmname = selectstudent.Rows[studnetindex].Cells[3].Value.ToString();
                student.Stmname = selectstudent.Rows[studnetindex].Cells[4].Value.ToString();
                student.Stfname = selectstudent.Rows[studnetindex].Cells[5].Value.ToString();
                student.Sttel = selectstudent.Rows[studnetindex].Cells[6].Value.ToString();
                student.Stadd = selectstudent.Rows[studnetindex].Cells[7].Value.ToString();
                student.StEmail = selectstudent.Rows[studnetindex].Cells[13].Value.ToString();
                student.StQQ = selectstudent.Rows[studnetindex].Cells[14].Value.ToString();
                student.StHobby = selectstudent.Rows[studnetindex].Cells[15].Value.ToString();
                student.Stoldadd = selectstudent.Rows[studnetindex].Cells[16].Value.ToString();
                student.Steconomy = selectstudent.Rows[studnetindex].Cells[18].Value.ToString();
                student.Stposition = selectstudent.Rows[studnetindex].Cells[17].Value.ToString();
                bll.Model = student;
                if (bll.edit() > 0)
                {
                    MessageBox.Show("更新成功！");
                    bindData();
                }
                else
                {
                    MessageBox.Show("更新失败！");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            datastudent();
        }
        /// <summary>
        /// 变量用于记录更新学生数据的表
        /// </summary>
        public int studnetindex=-1;
        /// <summary>
        /// 双击学生数据集表时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectstudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            studnetindex = e.RowIndex;
        }
        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除学生_Click(object sender, EventArgs e)
        {
            try
            {
                BLLProject.Student bll = new BLLProject.Student();
                ModelProject.Student student = new ModelProject.Student();
                student.Stno = student.Stno = selectstudent.Rows[deletestudnet].Cells[0].Value.ToString();
                bll.Model = student;
                if (bll.del() > 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            datastudent();
        }
        /// <summary>
        /// 变量用于记录删除的表格
        /// </summary>
        public int deletestudnet = -1;
        /// <summary>
        /// 单击表时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectstudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deletestudnet = e.RowIndex;
        }
        /// <summary>
        /// 查找用户日志信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            BLLProject.Log bll = new BLLProject.Log();
            ModelProject.Log log = new ModelProject.Log();
            string i = textBoxforlog.Text.ToString();
            bll.Model = log;
            try
            {
                if (bll.find("Userid='" + i + "'") == null)
                {
                    MessageBox.Show("你查找的信息不存在！");
                }
                else
                {
                    dataGridViewmajor.DataSource = bll.find("Userid='" + i + "'");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// 清空用户日志信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 清空记录_Click(object sender, EventArgs e)
        {
            BLLProject.Log bll = new BLLProject.Log();
            ModelProject.Log log = new ModelProject.Log();
            try
            {
                conn.Open(); 
                SqlCommand sqlcmd = new SqlCommand("delete from logs", conn);
                if (sqlcmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("清除数据成功！");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally
            {
                conn.Close();
            }
            datausrlog();
        }
        /// <summary>
        /// 更新课表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            try
            {
                BLLProject.List bll = new BLLProject.List();
                ModelProject.List list = new ModelProject.List();
                list.course1 = new ModelProject.Course();
                list.course1.curno = selectlist.Rows[listupate].Cells[0].Value.ToString();
                list.classroom1 = new ModelProject.Classroom();
                list.classroom1.Crno = selectlist.Rows[listupate].Cells[1].Value.ToString();
                list.Listno = selectlist.Rows[listupate].Cells[2].Value.ToString();
                list.Term = selectlist.Rows[listupate].Cells[3].Value.ToString();
                list.Jieshu = Convert.ToInt32(selectlist.Rows[listupate].Cells[4].Value);
                list.date = Convert.ToDateTime(selectlist.Rows[listupate].Cells[5].Value);
                list.Myclass = selectlist.Rows[listupate].Cells[6].Value.ToString();
                bll.Model = list;
                if (bll.edit() > 0)
                {
                    MessageBox.Show("更新成功！");
                }
                else
                {
                    MessageBox.Show("更新失败！");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            datalist();

        }
        /// <summary>
        /// 查找课程表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 查找课程_Click(object sender, EventArgs e)
        {
            BLLProject.List bll = new BLLProject.List();
            ModelProject.List list = new ModelProject.List();
            string i = selectlistbox.Text.ToString();
            bll.Model = list;
            try
            {
                if (bll.find("Listno='" + i + "'") == null)
                {
                    MessageBox.Show("你查找的课程安排不存在不存在！");
                }
                else
                {
                    selectlist .DataSource = bll.find("Listno='" + i + "'");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// 变量用于更新课程表
        /// </summary>
        public int listupate = -1;
        /// <summary>
        /// 双击课程表时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            listupate = e.RowIndex;
        }
        /// <summary>
        /// 删除课程表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除课程_Click(object sender, EventArgs e)
        {
            try
            {
                BLLProject.List bll = new BLLProject.List();
                ModelProject.List list = new ModelProject.List();
                list.Listno = selectlist.Rows[deletelist].Cells[2].Value.ToString();
                bll.Model = list;
                if (bll.del() > 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            datalist();
        }
        /// <summary>
        /// 变量用于记录删除课程的单元格
        /// </summary>
        public int deletelist=-1;
        /// <summary>
        /// 单击课程时记录触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deletelist = e.RowIndex;
        }
        /// <summary>
        /// 单击课程触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 添加课程_Click(object sender, EventArgs e)
        {
            addlist l = new addlist();
            l.Show();
            datalist();
        }
        /// <summary>
        /// 查找角色信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 查找角色_Click(object sender, EventArgs e)
        {

            BLLProject.Role bll = new BLLProject.Role();
            ModelProject.Role role = new ModelProject.Role();
            string roleid =rolechazhaobox.Text.ToString();
            bll.Model = role;
            try
            {
                if (bll.find("RoleId='" + roleid + "'") == null)
                {
                    MessageBox.Show("你查找的信息不存在！");
                }
                else
                {
                    dataGridViewrole.DataSource = bll.find("RoleId='" + roleid + "'");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// 更新角色信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 更新角色_Click(object sender, EventArgs e)
        {
            try
            {
                BLLProject.Role bll = new BLLProject.Role();
                ModelProject.Role role = new ModelProject.Role();
                role.RoleId = dataGridViewrole.Rows[updaterole].Cells[1].Value.ToString();
                if (dataGridViewrole.Rows[updaterole].Cells[0].Value.ToString().Equals("教师"))
                {
                    role.RoleName = ModelProject.ROleName.教师;
                }
                if (dataGridViewrole.Rows[updaterole].Cells[0].Value.ToString().Equals("管理员"))
                {
                    role.RoleName = ModelProject.ROleName.管理员;
                }
                if (dataGridViewrole.Rows[updaterole].Cells[0].Value.ToString().Equals("学生"))
                {
                    role.RoleName = ModelProject.ROleName.学生;
                }
                role.Remark = dataGridViewrole.Rows[updaterole].Cells[2].Value.ToString();
                bll.Model = role;
                if (bll.edit() > 0)
                {
                    MessageBox.Show("更新成功！");
                    bindData();
                }
                else
                {
                    MessageBox.Show("更新失败！");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            datarole();

        }
        /// <summary>
        ///变量记录删除角色
        /// </summary>
        public int deleterole = -1;
        /// <summary>
        /// 单击角色表触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewrole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleterole = e.RowIndex;
        }
        /// <summary>
        /// 变量用于更新角色
        /// </summary>
        public int updaterole = -1;
        /// <summary>
        /// 双击角色表记录信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewrole_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updaterole = e.RowIndex;
        }
        /// <summary>
        /// 删除角色信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除角色_Click(object sender, EventArgs e)
        {
            try
            {
                BLLProject.Role bll = new BLLProject.Role();
                ModelProject.Role role = new ModelProject.Role();
                role.RoleId = dataGridViewrole.Rows[deleterole].Cells[1].Value.ToString();
                bll.Model = role;
                if (bll.del() > 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            datarole();
        }
        /// <summary>
        /// 新增角色信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 新增角色_Click(object sender, EventArgs e)
        {
            addrole r = new addrole();
            r.Show();
        }
        /// <summary>
        /// 角色管理进入学生界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 进入学生界面_Click(object sender, EventArgs e)
        {
            BLLProject.Role bll = new BLLProject.Role();
            ModelProject.Role role = new ModelProject.Role();
            string roleid = rolechazhaobox.Text.ToString();
            bll.Model = role;
            try
            {
                Object obj = bll.getMe(zhanghu);
                role = (ModelProject.Role)obj;
                if (role.RoleId == null)
                {
                    进入学生界面.Enabled = false;
                    MessageBox.Show("您没有该权限！");
                }
                else if (role.RoleId.Equals(zhanghu) || role.RoleName == ModelProject.ROleName.学生)
                {
                    进入学生界面.Enabled = true;
                    Studnetform s = new Studnetform();
                    s.Show();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// 角色管理进入教师界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 进入教室界面_Click(object sender, EventArgs e)
        {
            BLLProject.Role bll = new BLLProject.Role();
            ModelProject.Role role = new ModelProject.Role();
            bll.Model = role;
            try
            {
                Object obj= bll.getMe(zhanghu);
                role = (ModelProject.Role)obj;
                if (role.RoleId== null)
                {
                    进入教室界面.Enabled = false;
                    MessageBox.Show("您没有该权限！");
                }
                else if(role.RoleId.Equals(zhanghu)||role.RoleName==ModelProject.ROleName.教师)
                {
                    进入学生界面.Enabled = true;
                    teacherfrom f = new teacherfrom();
                    f.Show();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// 查找教师信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton8_Click_1(object sender, EventArgs e)
        {
            BLLProject.Teacher bll = new BLLProject.Teacher();
            ModelProject.Teacher teacher = new ModelProject.Teacher();
            teacher.Teno = toolStripTextBox1.Text.ToString();
            string i = toolStripTextBox1.Text.ToString();
            bll.Model = teacher;
                if (bll.find("Teno='" + i + "'") == null)
                {
                    MessageBox.Show("你查找的教师不存在！");
                }
                else
                {
                    dataGridViewteacher.DataSource = bll.find("Teno='" + i + "'");
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
                                this.pictureBox3.Image = bmp;
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
        /// <summary>
        /// 更新教师信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton9_Click_1(object sender, EventArgs e)
        {
            try
            {
                BLLProject.Teacher bll = new BLLProject.Teacher();
                ModelProject.Teacher teacher = new ModelProject.Teacher();
                teacher.Teno = dataGridViewteacher.Rows[deleteteacher].Cells[0].Value.ToString();
                teacher.department1 = new ModelProject.Department();
                teacher.department1.Depno = dataGridViewteacher.Rows[deleteteacher].Cells[1].Value.ToString();
                teacher.Tename = dataGridViewteacher.Rows[deleteteacher].Cells[2].Value.ToString();
                teacher.Edu = dataGridViewteacher.Rows[tednetindex].Cells[3].Value.ToString();
                teacher.Prorank = dataGridViewteacher.Rows[tednetindex].Cells[4].Value.ToString();
                teacher.Tesal = Convert.ToDecimal(dataGridViewteacher.Rows[tednetindex].Cells[5].Value);
                teacher.Tel = dataGridViewteacher.Rows[tednetindex].Cells[6].Value.ToString();
                teacher.Teadd = dataGridViewteacher.Rows[tednetindex].Cells[7].Value.ToString();
                teacher.Tebirthday = Convert.ToDateTime(dataGridViewteacher.Rows[tednetindex].Cells[9].Value);
                teacher.TQQ = dataGridViewteacher.Rows[tednetindex].Cells[12].Value.ToString();
                teacher.TEoldadd = dataGridViewteacher.Rows[tednetindex].Cells[13].Value.ToString();
                teacher.TeEmail = dataGridViewteacher.Rows[tednetindex].Cells[15].Value.ToString();
                teacher.DtLengthOfService = Convert.ToInt32(dataGridViewteacher.Rows[tednetindex].Cells[16].Value);
                bll.Model = teacher;
                if (bll.edit() > 0)
                {
                    MessageBox.Show("更新成功！");

                }
                else
                {
                    MessageBox.Show("更新失败！");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            datateacher();
        }
        /// <summary>
        /// 变量用于更新教师
        /// </summary>
        public int tednetindex = -1;
        /// <summary>
        /// 双击教师表时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tednetindex = e.RowIndex;
        }
        /// <summary>
        /// 变量用于删除教师
        /// </summary>
        public int deleteteacher = -1;
        /// <summary>
        /// 删除教师
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            BLLProject.Teacher bll = new BLLProject.Teacher();
            ModelProject.Teacher teacher = new ModelProject.Teacher();
            teacher.Teno = dataGridViewteacher.Rows[deleteteacher].Cells[0].Value.ToString();
            bll.Model = teacher;
            if (bll.del() > 0)
            {
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
            datateacher();
        }
        /// <summary>
        /// 单击教师表格时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteteacher = e.RowIndex;
        }
        /// <summary>
        /// 新增教师
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            addteacher a = new addteacher();
            a.Show();
            datateacher();
            
        }
        /// <summary>
        /// 修改管理员密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            BLLProject.User bll = new BLLProject.User();
            ModelProject.User user = new ModelProject.User();
            string teacherzhanghu = import.i;
            string newpwd = newuserpwd.Text.ToString();
            string newpwdagaint = againtuserpwd.Text.ToString();
            if (newpwd.Equals(newpwdagaint) == false)
            {
                MessageBox.Show("你输入的不正确！");
            }
            if (newuserpwd.Text == "" && againtuserpwd.Text == "")
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
                    user.Userpwd = againtuserpwd.Text.ToString();
                    bll.Model = user;
                    if (bll.edit() > 0)
                    {
                        MessageBox.Show("修改成功！");
                        datausers(); 
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
        /// 更新专业
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 更新_Click_1(object sender, EventArgs e)
        {
            try
            {
                 BLLProject.Major bll = new BLLProject.Major();
                 ModelProject.Major major = new ModelProject.Major();
                 major.Prono = dataGridViewmajor.Rows[majorRowindex].Cells[0].Value.ToString();
                 major.Proname = dataGridViewmajor.Rows[majorRowindex].Cells[1].Value.ToString();
                 major.Proske = dataGridViewmajor.Rows[majorRowindex].Cells[2].Value.ToString();
                 major.department1 = new ModelProject.Department();
                 major.department1.Depno = dataGridViewmajor.Rows[majorRowindex].Cells[3].Value.ToString();
                 bll.Model = major;
                 if (bll.edit() > 0)
                 {
                     MessageBox.Show("更新成功！");
                     bindData();
                 }
                 else
                 {
                     MessageBox.Show("更新失败！");
                 }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// 查找成绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            BLLProject.Mark bll = new BLLProject.Mark();
            ModelProject.Mark mark = new ModelProject.Mark();
            mark.Markno = toolStripLabel1.Text.ToString();
            string i = toolStripLabel1.Text.ToString();
            bll.Model = mark;
            try
            {
                if (bll.find("Markno='" + i + "'") == null)
                {
                    MessageBox.Show("你查找的成绩表不存在！");
                }
                else
                {
                    dataGridViewmark.DataSource = bll.find("Markno='" + i + "'");
                }
            }

            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// 变量用于更新成绩表
        /// </summary>
        public int updatemark = -1;
        /// <summary>
        /// 双击成绩表时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewmark_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updatemark = e.RowIndex;
        }
        /// <summary>
        /// 更新成绩表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            try
            {
                BLLProject.Mark bll = new BLLProject.Mark();
                ModelProject.Mark mark = new ModelProject.Mark();
                mark.Grade = Convert.ToInt32(dataGridViewmark.Rows[deletemark].Cells[0].Value);
                mark.Markno = dataGridViewmark.Rows[deletemark].Cells[1].Value.ToString();
                mark.student1 = new ModelProject.Student();
                mark.student1.Stno = dataGridViewmark.Rows[deletemark].Cells[2].Value.ToString();
                mark.course1 = new ModelProject.Course();
                mark.course1.curno = dataGridViewmark.Rows[deletemark].Cells[3].Value.ToString();
                mark.time = Convert.ToDateTime(dataGridViewmark.Rows[deletemark].Cells[4].Value);
                bll.Model = mark;
                if (bll.edit() > 0)
                {
                    MessageBox.Show("更新成功！");

                }
                else
                {
                    MessageBox.Show("更新失败！");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            datamarkview();
        }
        /// <summary>
        /// 窗体加载时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newmanageform_Load(object sender, EventArgs e)
         {
             /*dataview();
             dataview2();
             dataviewmajor();
             dataclassview();
             datastudent();
             datausrlog();
             datalist();
             datarole();
             datamarkview();*/
        }

        private void selectdepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public int newrowindex = -1;
        private void selectdepartment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            newrowindex = e.RowIndex;
        }
        /// <summary>
        /// 变量用于删除部门
        /// </summary>
        public int newdeletedepartment = -1;
        /// <summary>
        /// 单击部门表示触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectdepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            newdeletedepartment = e.RowIndex;
        }
        /// <summary>
        /// 变量用于更新成绩
        /// </summary>
        public int updatemarks = -1;
        /// <summary>
        /// 双击成绩表时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewmark_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updatemarks = e.RowIndex;
        }

        private void dataGridViewmark_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// 变量用于删除成绩
        /// </summary>
        public int deletemark = -1;
        /// <summary>
        /// 单击成绩表时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewmark_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deletemark = e.RowIndex;
        }

        private void dataGridViewuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       /// <summary>
       /// 查找用户
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void 查找用户_Click(object sender, EventArgs e)
        {
            BLLProject.User bll = new BLLProject.User();
            ModelProject.User users = new ModelProject.User();
            string i =toolStripComboBox1.Text.ToString();
            bll.Model = users;
            try
            {
                if (bll.find("Userid='" + i + "'") == null)
                {
                    MessageBox.Show("你查找的用户不存在不存在！");
                }
                else
                {
                    dataGridViewuser.DataSource = bll.find("Userid='" + i + "'");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 更新用户_Click(object sender, EventArgs e)
        {
            try
            {
                BLLProject.User bll = new BLLProject.User();
                ModelProject.User users = new ModelProject.User();
                users.Userid = dataGridViewuser.Rows[majorRowindex].Cells[0].Value.ToString();
                users.Userpwd = dataGridViewuser.Rows[majorRowindex].Cells[1].Value.ToString();
                bll.Model = users;
                if (bll.edit() > 0)
                {
                    MessageBox.Show("更新成功！");
                     datausers();
                }
                else
                {
                    MessageBox.Show("更新失败！");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
          
        }
        /// <summary>
        /// 变量用于更新用户
        /// </summary>
        public int updateuser = -1;
        /// <summary>
        /// 双击用户表时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewuser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateuser = e.RowIndex;
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除用户_Click(object sender, EventArgs e)
        {
            try
            {
                BLLProject.User bll = new BLLProject.User();
                ModelProject.User users = new ModelProject.User();
                users.Userid = dataGridViewuser.Rows[deleteuser].Cells[0].Value.ToString();
                bll.Model = users;
                if (bll.del() > 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            datausers();
        }
        /// <summary>
        /// 变量用于删除用户
        /// </summary>
        public int deleteuser = -1;
        /// <summary>
        /// 单击用户表时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewuser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteuser = e.RowIndex;
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 添加用户_Click(object sender, EventArgs e)
        {
            adduser a = new adduser();
            a.Show();
            datausers();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*label4.Left -= 2;
            if(label4.Right<0)
            {
                label4.Left = this.Width;
            }*/
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        }

    }

