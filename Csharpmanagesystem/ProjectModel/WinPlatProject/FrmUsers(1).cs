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
    public partial class FrmUsers : Form
    {
        private void BindActor()
        {
            /*查找数据*/
            BLLProject.Actor bll = new BLLProject.Actor();
            DataTable dt=bll.find("");
            /*绑定数据*/
            cmbActors.DataSource = dt;
            cmbActors.DisplayMember = "JueSeMingCheng";
            cmbActors.ValueMember = "BianHao";
        }
        public FrmUsers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelProject.Users u = new ModelProject.Users();
            u.ID = txtNumber.Text;
            u.Number = txtNumber.Text;
            u.Name = txtName.Text;
            u.Password = txtNumber.Text;
            if (rbNormal.Checked == true)
                u.Status = "正常";
            else
                u.Status = "锁定";
            u.Actors = new List<ModelProject.Actor>();

            ModelProject.Actor actor1 = new ModelProject.Actor();
            actor1.ID = cmbActors.SelectedValue.ToString();
            actor1.Name = cmbActors.SelectedText;



            u.Actors.Add(actor1);

             

            String strTemp = u.ToXML();
            BLLProject.Users bll = new BLLProject.Users();//创建业务层角色对象
            bll.Model = u;//持久层获得操作数据对象model
            int result = bll.add();
            if (result > 0)
                MessageBox.Show("用户新增成功！");
            else
                MessageBox.Show("用户新增失败！" + result.ToString());
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            BindActor();
        }
    }
}
