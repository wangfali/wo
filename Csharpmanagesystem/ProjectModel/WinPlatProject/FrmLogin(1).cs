 
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
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// 身份验证是否通过，true表示通过，false表示不通过
        /// </summary>
        public Boolean Flag
        {
            get;
            set;
        }
        public ModelProject.Users User
        {
            get;
            set;
        }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           DialogResult dr=MessageBox.Show("您确定退出吗(Y/N)？", "警告", MessageBoxButtons.YesNo);
           if (dr == DialogResult.Yes)
           {
               
               Application.Exit();
               Flag = false;
           }
              
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ModelProject.Users model = new ModelProject.Users();
            model.ID = txtNumber.Text;
            model.Number = txtNumber.Text;
            model.Password = txtPassword.Text;

            BLLProject.Users bll = new BLLProject.Users();
            bll.Model = model;
            switch (bll.checkUser())
            { 
                case 0:
                    MessageBox.Show("您的账号有误，请重新输入！");
                    txtNumber.Focus();
                    txtNumber.SelectAll();
                    break;
                case 1:
                    User = model;
                    Flag = true;
                    Close();
                    break;
                case -2:
                    MessageBox.Show("您的账号被锁定了，请联系管理员！");
                    break;
                default:
                    MessageBox.Show("您的密码有误，请重新输入！");
                    txtPassword.Focus();
                    txtPassword.SelectAll();
                    break;
            }
            //if (bll.validate()!=null)
            //{
            //    Flag = true;
            //    Close();
            //}
            //else
            //    MessageBox.Show("您的账号或密码有误，请重新输入！");
        }
    }
}
