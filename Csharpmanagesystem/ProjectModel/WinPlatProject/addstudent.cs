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
    /// 描述：添加学生
    /// 作者：王法立
    /// 创建日期：2016-6-30 
    /// 版本：2.0.0.0
    /// </summary>
    public partial class addstudent : Form
    {
        public addstudent()
        {
            InitializeComponent();
        }
        
       /* public bool AddInfo( string strImage)//图片添加函数
        {
            try
            {
                conn.Open();
                FileStream fstream = new FileStream(strImage, FileMode.Open, FileAccess.Read);//创建文件流
                BinaryReader BReader = new BinaryReader(fstream);//二进制读取
                byte[] byteImage = BReader.ReadBytes((int)fstream.Length);//将文件的二进制放入数组中
                SqlCommand sqlcmd = new SqlCommand("update  Student set  Stimage=@photo where Stno='"+ +"'", conn);
                sqlcmd.Parameters.Add("@photo", SqlDbType.Image).Value = byteImage;//将图片二进制存入数组
                sqlcmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally
            {
                conn.Close();
            }
           
            return false;
        }*/
        /*public string daorutupian()
        {
            OpenFileDialog openpic = new OpenFileDialog();
            openpic.Filter = "bmp 文件(*.bmp)|*.bmp|jpg 文件(*.jpg)|*jpg|ico 文件(*.ico)|*.ico";
            openpic.Title = "导入图像";
            if (openpic.ShowDialog() == DialogResult.OK)
            {
                return openpic.FileName;
            }
            return null;
        }*/
        public string i=null;
       /// <summary>
       /// 导入图片
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void  button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openpic = new OpenFileDialog();
            openpic.Filter = "bmp 文件(*.bmp)|*.bmp|jpg 文件(*.jpg)|*jpg|ico 文件(*.ico)|*.ico";
            openpic.Title = "导入图像";
            if (openpic.ShowDialog() == DialogResult.OK)
            {
                i = openpic.FileName;
                Bitmap tmp = new Bitmap(openpic.FileName);
                this.pictureBox1.Image = tmp;
            }
        }
        /// <summary>
        /// 数据库连接
        /// </summary>
        public SqlConnection conn = new SqlConnection("server=SAMSUNG-PC;uid=sa;pwd=111;database=ManageSystem");
        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            BLLProject.Student bll = new BLLProject.Student();
            ModelProject.Student student = new ModelProject.Student();
            student.Stno = stnobox.Text.ToString();
            student.Stname = stname.Text.ToString();
            student.class2=new ModelProject.MyClass();
            student.class2.Clno = stclass.Text.ToString();
            student.Stbirthday = stbirdthday.Value;
            student.Stage = student.Stbirthday.Year - DateTime.Now.Year;
            if(radioButtonman.Checked==true)
            {
                student.Sex = ModelProject.Student.SEX.男;
            }
            if(radioButtonfeman.Checked==true)
            {
                student.Sex = ModelProject.Student.SEX.女;
            }
            student.Enrollt = enroll.Value;
            if(stpoletice.Text.ToString().Equals("群众"))
            {

                student.Stpolitice = ModelProject.Student.STPOLITICE.群众;
            }
            if (stpoletice.Text.ToString().Equals("团员"))
            {

                student.Stpolitice = ModelProject.Student.STPOLITICE.团员;
            }
            if (stpoletice.Text.ToString().Equals("党员"))
            {

                student.Stpolitice = ModelProject.Student.STPOLITICE.党员;
            }
            student.Sttel = stellbox.Text.ToString();
            student.StQQ = stidcardbox.Text.ToString();
            bll.Model = student;
            if (bll.add() > 0)
            {
                MessageBox.Show("数据添加成功！");
            }
            else
            {
                MessageBox.Show("数据添加失败！");
            }
                try
                {
                    conn.Open();
                    FileStream fstream = new FileStream(i, FileMode.Open, FileAccess.Read);//创建文件流
                    BinaryReader BReader = new BinaryReader(fstream);//二进制读取
                    byte[] byteImage = BReader.ReadBytes((int)fstream.Length);//将文件的二进制放入数组中
                    SqlCommand sqlcmd = new SqlCommand("update  Student set  Stimage=@photo where Stno='" +student.Stno +"'", conn);
                    sqlcmd.Parameters.Add("@photo", SqlDbType.Image).Value = byteImage;//将图片二进制存入数组
                    sqlcmd.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                finally
                {
                    conn.Close();
                }
        }
    }
}
