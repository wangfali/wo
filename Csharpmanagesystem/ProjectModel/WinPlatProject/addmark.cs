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
    /// 描述：添加成绩
    /// 作者：王法立
    /// 创建日期：2016-7-15 
    /// 版本：2.0.0.0
    /// </summary>
    public partial class addmark : Form
    {
        public addmark()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// 添加成绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            BLLProject.Mark bll = new BLLProject.Mark();
            ModelProject.Mark mark = new ModelProject.Mark();
            if (marknobox.Text == "" && curnobox.Text == "" && gradebox.Text == "" && stnobox.Text == "")
            {
                MessageBox.Show("您的输入不完整！请核对后再输");
            }
            else
            {
                try
                {
                    mark.Markno = marknobox.Text.ToString();
                    mark.Grade = Convert.ToInt32(gradebox.Text);
                    mark.course1 = new ModelProject.Course();
                    mark.class2 = new ModelProject.MyClass();
                    mark.course1.curno = curnobox.Text.ToString();
                    mark.student1 = new ModelProject.Student();
                    mark.student1.Stno = stnobox.Text.ToString();
                    mark.time = dateTimePickerformark.Value;
                    bll.Model = mark;
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
