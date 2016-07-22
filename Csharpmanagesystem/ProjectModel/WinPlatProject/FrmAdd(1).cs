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
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {

            Computer com = new Computer(Convert.ToInt32(txtOne.Text),Convert.ToInt32(txtTwo.Text));//创建对象，并赋值
            txtResult.Text = com.add().ToString();
        }

        private void btnJianFa_Click(object sender, EventArgs e)
        {
            int one = Int32.Parse(txt_JF_One.Text);//获取定义运算数
            int two = Int32.Parse(txt_JF_Two.Text);
            txt_JF_Result.Text= Computer.JianFa(one,two).ToString();
        }
    }
}
