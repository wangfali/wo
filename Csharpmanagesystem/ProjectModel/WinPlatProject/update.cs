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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLLProject.Department bll = new BLLProject.Department();
            ModelProject.Department department = new ModelProject.Department();
            department.Depno = textBox1.Text.ToString();
            
        }
    }
}
