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
    public partial class adddepartment : Form
    {
        public adddepartment()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            BLLProject.Department bll = new BLLProject.Department();
            ModelProject.Department dep = new ModelProject.Department();

            if (pronobox.Text == "" && pronamebox.Text == "" && profuzheren.Text == "" && progongnengbox.Text == "" && prozhinengbox.Text == "" && prokaoqinbox.Text == "")
            {
                MessageBox.Show("您的输入不完整！请核对后再输");
            }
            else
            {
                try
                {
                    dep.Depno = pronobox.Text.ToString();
                    dep.Depname = pronamebox.Text.ToString();
                    dep.Depma = profuzheren.Text.ToString();
                    dep.Depfunctian = progongnengbox.Text.ToString();
                    dep.Depjob = prozhinengbox.Text.ToString();
                    dep.Depchecking = prokaoqinbox.Text.ToString();
                    bll.Model = dep;
                    if (bll.add() > 0)
                    {
                        MessageBox.Show("添加成功！");
                    }
                    else
                    {
                        MessageBox.Show("添加失败！");
                    }
                    pronobox.Clear();
                    pronamebox.Clear();
                    profuzheren.Clear();
                    progongnengbox.Clear();
                    prozhinengbox.Clear();
                    prokaoqinbox.Clear();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }

        private void adddepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
