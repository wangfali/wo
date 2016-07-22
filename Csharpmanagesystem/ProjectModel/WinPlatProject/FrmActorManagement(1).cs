using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPlatProject.util;

namespace WinPlatProject
{
    public partial class FrmActorManagement : Form
    {
        /// <summary>
        /// 根据condition条件进行角色查找，并显示在界面表格上
        /// </summary>
        /// <param name="condition">查询条件</param>
        public  void Bind(String condition)
        {
            /*查询角色数据*/
            BLLProject.Actor bll = new BLLProject.Actor();
            DataTable dt = bll.find(condition);//执行数据查找

            /*数据显示*/
            if (dt == null || dt.Rows.Count == 0)
            {
                tsslTips.Text = "当前没有符合您要求的数据！";
            }
            else
            {
                dgActor.Rows.Clear();//清空原有数据
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int index=dgActor.Rows.Add();//创建表格行
                    dgActor.Rows[index].Cells["colSerial"].Value = i + 1;
                    dgActor.Rows[index].Cells["colNumber"].Value = dt.Rows[i]["BianHao"].ToString();
                    dgActor.Rows[index].Cells["colName"].Value = dt.Rows[i]["JueSeMingCheng"].ToString();
                }
                tsslTips.Text = "当前共有【"+dt.Rows.Count+"】条数据！";
            }

        }
        public FrmActorManagement()
        {
            InitializeComponent();
        }

        private void tsbFind_Click(object sender, EventArgs e)
        {
            Bind(tstxtCondition.Text);
        }

        private void FrmActorManagement_Load(object sender, EventArgs e)
        {
            Bind("");
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            FrmActor actor = new FrmActor(null);
            actor.parent = this;
            actor.Text = "角色新增";
            actor.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgActor.SelectedRows != null && dgActor.SelectedRows.Count > 0)
            {
                ModelProject.Actor model = new ModelProject.Actor();//创建修改角色对象
                /*从表格中选择选中的角色进行赋值*/
                model.ID = dgActor.SelectedRows[0].Cells["colNumber"].Value.ToString();
                //model.Name = dgActor.SelectedRows[0].Cells["colName"].Value.ToString();

                /*从数据库获取符合ID的角色对象*/
                BLLProject.Actor bll = new BLLProject.Actor();
                bll.Model = model;
                Object obj=bll.getMe(model.ID);
                if (obj == null)
                {
                    MessageBox.Show("抱歉，没有获取到您修改的角色对象，无法修改！");
                    return;
                }
                model = (ModelProject.Actor)obj;
                FrmActor frm = new FrmActor(model);
                frm.parent = this;
                frm.Text = "角色修改";
                frm.ShowDialog();
            }
            else
                MessageBox.Show("请选中需要修改的角色！");
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dgActor.SelectedRows != null && dgActor.SelectedRows.Count > 0)
            {
                ModelProject.Actor model = new ModelProject.Actor();//创建修改角色对象
                /*从表格中选择选中的角色进行赋值*/
                model.ID = dgActor.SelectedRows[0].Cells["colNumber"].Value.ToString();
                model.Name = dgActor.SelectedRows[0].Cells["colName"].Value.ToString();

                if (MessageBox.Show("【" + model.Name + "】删除后，角色数据无法恢复，确定吗(Y/N)?", "警告", MessageBoxButtons.YesNo) == DialogResult.No) return;

                BLLProject.Actor bll = new BLLProject.Actor();
                bll.Model = model;
                if (bll.del() > 0)
                {
                    Bind("");
                    MessageBox.Show("您选择的【"+model.Name+"】角色已经成功删除！");
                }
                else
                    MessageBox.Show("删除失败！");
            }
            else
                MessageBox.Show("请选中需要删除的角色！");
        }

        private void tsbLoadout_Click(object sender, EventArgs e)
        {
            /*查询角色数据*/
            BLLProject.Actor bll = new BLLProject.Actor();
            DataTable dt = bll.find(tstxtCondition.Text);//执行数据查找

            /*数据显示*/
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("没有符合条件的数据！");
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "excel|*.xls|2007-电子表格|*.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                { 
                    util.NPOIHelper.Export(dt, "角色信息", sfd.FileName);
                    Process.Start(sfd.FileName);
                }

            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            
            /*查询角色数据*/
            BLLProject.Actor bll = new BLLProject.Actor();
            DataTable dt = bll.find(tstxtCondition.Text);//执行数据查找

            /*数据显示*/
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("没有符合条件的数据！");
            }
            else
            {
                DataTablePrint print = new DataTablePrint();
                dt.Columns[0].ColumnName = "编号";
                print.PrintPriview(dt, "角色信息");
                
            }
        }
    }
}
