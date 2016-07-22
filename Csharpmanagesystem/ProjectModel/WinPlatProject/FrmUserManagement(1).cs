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
    public partial class FrmUserManagement : Form
    {
        
        private void Bind(String condition)
        {
            BLLProject.Users user = new BLLProject.Users();
            DataTable dtResult=user.find(condition);

            for (int i = 0; i < dtResult.Rows.Count; i++)
            {
                int index = dgUsers.Rows.Add();
                dgUsers.Rows[index].Cells["colSerial"].Value = i+1;
                dgUsers.Rows[index].Cells["colAccount"].Value = dtResult.Rows[i]["ZhangHao"];
                dgUsers.Rows[index].Cells["colNickName"].Value = dtResult.Rows[i]["NiCheng"];
                dgUsers.Rows[index].Cells["colStatus"].Value = dtResult.Rows[i]["ZhuangTai"];
                dgUsers.Rows[index].Cells["colActors"].Value = dtResult.Rows[i]["jueSe"]; 

            }

             
            tsslTips.Text = "当前共有【" + (dtResult == null ? 0 : dtResult.Rows.Count) + "】条数据！";
            
        }
        public FrmUserManagement()
        {
            InitializeComponent();
        }

        private void FrmUserManagement_Load(object sender, EventArgs e)
        {
            Bind("1=1");
        }

        private void tsbFind_Click(object sender, EventArgs e)
        {

        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            FrmUsers frm = new FrmUsers();
            frm.ShowDialog();
        }
    }
}
