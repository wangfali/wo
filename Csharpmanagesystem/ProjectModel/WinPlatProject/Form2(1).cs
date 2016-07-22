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
    public partial class Form2 : Form
    {
        private int oldX = 0;//移动前X轴坐标
        private int oldY = 0;//移动前Y轴坐标
        Shape p = new Shape();
        public Form2()
        {
            InitializeComponent();
            p.AreaEvent += new AreaHandle(Compute);
            p.AreaEvent += new AreaHandle(Compute1);
        }

        private double Compute(Object obj)
        {
            return 100;
        }
        private double Compute1(Object obj)
        {
            return 10;
        }

        private int flag = 0;
        private void Mouse_Click(object sender, MouseEventArgs e)
        {
 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TransparencyKey = this.BackColor;

        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdd frmTemp = new FrmAdd();
            frmTemp.MdiParent = this;
            frmTemp.Show();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("是否真的退出(Y/N)?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Close();
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = e.X;
            oldY = e.Y;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left =Left+(e.X - oldX);
                Top =Top+(e.Y - oldY);
            }
        }
    }
}
