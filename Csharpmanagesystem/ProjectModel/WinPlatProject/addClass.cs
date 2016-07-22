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
    public partial class addClass : Form
    {
        public addClass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           BLLProject.MyClass bll=new BLLProject.MyClass();
            ModelProject.MyClass myclass =new ModelProject.MyClass();
            if (clobox.Text == "" && clnamebox.Text == "" && majorclassbox.Text == "" && Cltea.Text == "")
            {
                MessageBox.Show("您的输入不完整！请核对后再输");
            }
            else
            {
                try
                {
                    myclass.Clno = clobox.Text.ToString();
                    myclass.Clname = clnamebox.Text.ToString();
                    myclass.Cltea = Cltea.Text.ToString();
                    myclass.major1=new ModelProject.Major();
                    myclass.major1.Prono = majorclassbox.Text.ToString();
                    bll.Model = myclass;
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
