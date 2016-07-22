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
    public partial class addlist : Form
    {
        public addlist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLLProject.List bll = new BLLProject.List();
            ModelProject.List list = new ModelProject.List();
            if (crnobox.Text == "" && curnobox.Text == "" && listnobox.Text == "" && myclassbox.Text == "" && datebox.Text == "" && jieshubox.Text == "" && termbox.Text == "")
            {
                MessageBox.Show("您的输入不完整！请核对后再输");
            }
            else
            {
                try
                {
                    list.Listno = listnobox.Text.ToString();
                    list.Myclass = myclassbox.Text.ToString();
                    list.Jieshu = Convert.ToInt32(jieshubox.Text);
                    list.classroom1 = new ModelProject.Classroom();
                    list.classroom1.Crno = crnobox.Text.ToString();
                    list.course1 = new ModelProject.Course();
                    list.course1.curno = curnobox.Text.ToString();
                    list.Term = termbox.Text.ToString();
                    list.date = Convert.ToDateTime(datebox.Text);
                    bll.Model = list;
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
