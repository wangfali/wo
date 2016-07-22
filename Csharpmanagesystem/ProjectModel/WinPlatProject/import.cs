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
    
    public partial class import : Form
    {
       
        public static string i = null;
        public import()
        {
            InitializeComponent();
        }
        private int oldX = 0;
        private int oldY = 0;
        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void 登录_Click(object sender, EventArgs e)
        {
            BLLProject.User bll = new BLLProject.User();
            ModelProject.User user =new  ModelProject.User();
            bll.Model = user;
             i = useridbox.Text.ToString();
            string pwd = userpwdbox.Text.ToString();
            if (useridbox.Text == "" && userpwdbox.Text == "")
            {
                MessageBox.Show("请输入用户名及密码");
            }
            else
            {
                try
                {
                    switch (i[0])
                    {
                        case 'A':
                            {
                                DataTable dt = bll.find("Userid='" + i + "'");
                                if (dt.Rows.Count == 0 || dt == null)
                                {
                                    MessageBox.Show("你的账号错误");
                                    break;
                                }

                                else if (dt.Rows[0]["Userpwd"].ToString().Equals(pwd))
                                {
                                    BLLProject.Log blls = new BLLProject.Log();
                                    ModelProject.Log log = new ModelProject.Log();
                                    log.Userid = i.ToString();
                                    log.LogName = "用户正常登录";
                                    log.Logta = ModelProject.whether.无;
                                    log.LogRemark = "用户登录的时间为" + DateTime.Now.ToShortDateString();
                                    blls.Model = log;
                                    blls.add();
                                    Studnetform s = new Studnetform();
                                    s.Show();
                                    break;
                                }
                                MessageBox.Show("密码错误！");
                            }

                            break;
                        case 'B':
                            {
                                DataTable dt = bll.find("Userid='" + i + "'");
                                if (dt.Rows.Count == 0 || dt == null)
                                {
                                    MessageBox.Show("你的账号错误");
                                    break;
                                }

                                else if (dt.Rows[0]["Userpwd"].ToString().Equals(pwd))
                                {
                                    BLLProject.Log blls1 = new BLLProject.Log();
                                    ModelProject.Log log = new ModelProject.Log();
                                    log.Userid = i.ToString();
                                    log.LogName = "用户正常登录";
                                    log.Logta = ModelProject.whether.无;
                                    log.LogRemark = "用户登录的时间为" + DateTime.Now.ToShortDateString();
                                    blls1.Model = log;
                                    blls1.add();
                                    teacherfrom teacherfrom = new teacherfrom();
                                    teacherfrom.Show();
                                    break;
                                }
                                MessageBox.Show("密码错误！");
                            }

                            break;
                        case 'C':
                            {
                                try
                                {
                                    BLLProject.Log blls2 = new BLLProject.Log();
                                    ModelProject.Log log = new ModelProject.Log();
                                    log.Userid = i.ToString();
                                    log.LogName = "用户正常登录";
                                    log.Logta = ModelProject.whether.无;
                                    log.LogRemark = "用户登录的时间为" + DateTime.Now.ToShortDateString();
                                    blls2.Model = log;
                                    blls2.add();
                                }
                                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                                DataTable dt = bll.find("Userid='" + i + "'");
                                if (dt.Rows.Count == 0 && dt == null)
                                {
                                    MessageBox.Show("你的账号错误");
                                    break;
                                }

                                else if (dt.Rows[0]["Userpwd"].ToString().Equals(pwd))
                                {
                                    
                                    newmanageform p = new newmanageform();
                                    p.Show();
                                    break;
                                }
                                MessageBox.Show("密码错误！");
                            }

                            break;
                        default: { MessageBox.Show("该用户不存在！"); }
                            break;
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }
        private void 注册_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void import_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oldX = e.X;
                oldY = e.Y;
            }
        }

        private void import_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left = Left + (e.X - oldX);
                Top = Top + (e.Y - oldY);
            }
        }
    }
}