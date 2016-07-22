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
    /// 描述：添加教师
    /// 作者：王法立
    /// 创建日期：2016-6-30 
    /// 版本：2.0.0.0
    /// </summary>
    public partial class addteacher : Form
    {
        public addteacher()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public SqlConnection conn = new SqlConnection("server=SAMSUNG-PC;uid=sa;pwd=111;database=ManageSystem");
        public string i = null;
        /// <summary>
        /// 导入图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
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
        /// 添加教师信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            BLLProject.Teacher bll = new BLLProject.Teacher();
            ModelProject.Teacher teacher = new ModelProject.Teacher();
            if (tnobox.Text == "" && tnamebox.Text == "" && departmentnobox.Text == "" && comboBoxxueli.Text == "" && comboBoxzhicheng.Text == "" && textBoxaddress.Text == "" && txinzi.Text == "" && teteel.Text == "" && comboBoxpolitice.Text == "")
            {
                MessageBox.Show("您的输入不完整！请核对后再输");
            }
            else
            {
                try
                {
                    teacher.Teno = tnobox.Text.ToString();
                    teacher.Tename = tnamebox.Text.ToString();
                    teacher.department1 = new ModelProject.Department();
                    teacher.department1.Depno = departmentnobox.Text.ToString();
                    teacher.Edu = comboBoxxueli.Text.ToString();
                    teacher.Prorank = comboBoxzhicheng.Text.ToString();
                    teacher.Tesal = Convert.ToDecimal(txinzi.Text);
                    teacher.Tel = teteel.Text.ToString();
                    teacher.Teadd = textBoxaddress.Text.ToString();
                    if (radioButtonman.Checked == true)
                        teacher.Sex = ModelProject.Teacher.SEX.男;
                    if (radioButtonfeman.Checked == true)
                        teacher.Sex = ModelProject.Teacher.SEX.女;
                    teacher.Tebirthday = dateTimePickertebirdthday.Value;

                    if (comboBoxpolitice.Text == "群众")
                        teacher.Tepolitice = ModelProject.Teacher.TEPOLITICE.群众;
                    if (comboBoxpolitice.Text == "团员")
                        teacher.Tepolitice = ModelProject.Teacher.TEPOLITICE.团员;
                    if (comboBoxpolitice.Text == "党员")
                        teacher.Tepolitice = ModelProject.Teacher.TEPOLITICE.党员;
                    teacher.Teage = DateTime.Now.Year - teacher.Tebirthday.Year;
                    bll.Model = teacher;
                    if (bll.add() > 0)
                    {
                        MessageBox.Show("添加成功！");
                    }
                    else
                    {
                        MessageBox.Show("添加失败！");
                    }
                    try
                    {
                        conn.Open();
                        FileStream fstream = new FileStream(i, FileMode.Open, FileAccess.Read);//创建文件流
                        BinaryReader BReader = new BinaryReader(fstream);//二进制读取
                        byte[] byteImage = BReader.ReadBytes((int)fstream.Length);//将文件的二进制放入数组中
                        SqlCommand sqlcmd = new SqlCommand("update  Teacher set  Teimage=@photo where Teno='" + teacher.Teno + "'", conn);
                        sqlcmd.Parameters.Add("@photo", SqlDbType.Image).Value = byteImage;//将图片二进制存入数组
                        sqlcmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    finally
                    {
                        conn.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            }
        }
    }
}
