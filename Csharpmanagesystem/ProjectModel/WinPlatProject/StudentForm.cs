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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            ModelProject.Student student = new ModelProject.Student();
            BLLProject.Student bll = new BLLProject.Student();
            bll.Model = student;
            try
            {
                student.Stno = stnobox.Text.ToString();
                student.Stname = stnamebox.Text.ToString();
                //student.class2 = new ModelProject.Class();
               // student.class2.Clname = classnamebox.Text.ToString();
                student.clname = classnamebox.Text.ToString();
                student.Stbirthday = Convert.ToDateTime(dateTimePickerst.Text);
                if (radioButtonman.Checked == true)
                {
                    student.Sex = ModelProject.Student.SEX.男;
                }
                if (radioButtonfeman.Checked == true)
                {
                    student.Sex = ModelProject.Student.SEX.女;
                }
                student.Enrollt = Convert.ToDateTime(dateTimePickerenrolltst.Text);
                student.Sttel = telst.Text.ToString();
                if (bll.add() > 0)
                {
                    MessageBox.Show("添加成功");

                }
                else
                    MessageBox.Show("抱歉，班级信息新增失败！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
