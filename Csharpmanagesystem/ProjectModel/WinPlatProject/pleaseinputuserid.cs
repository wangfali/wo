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
    public partial class pleaseinputuserid : Form
    {
        public pleaseinputuserid()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (inputuseridbox.Text == "")
            {
                MessageBox.Show("请输入部门编号");
            }
            else
            {
                try
                {
                    ModelProject.Department department = new ModelProject.Department();
                    BLLProject.Department bll = new BLLProject.Department();
                    string i = inputuseridbox.Text.ToString();
                    bll.Model = department;
                    DataTable bt = bll.find("Depno='" + i + "'");
                    if (bt == null)
                    {
                        MessageBox.Show("您输入的部门编号不存在");
                    }
                    else
                    {
                        this.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }
    }
}
