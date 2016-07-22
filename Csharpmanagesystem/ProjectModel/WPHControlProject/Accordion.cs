using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPH.Controls
{
    public partial class Accordion : UserControl
    {
        private int oldHeight = 0;
        #region 属性
        /// <summary>
        /// 设置或获取标题
        /// </summary>
        public String Title {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        /// <summary>
        /// 设置或获取图标
        /// </summary>
        public Image Image
        {
            get { return lblTitle.Image; }
            set { lblTitle.Image = value; }
        }

        public Panel WorkArea
        {
            get { return panel1; } 
        }
        #endregion
        #region 方法
        /// <summary>
        /// 获取当前容器控件的高度
        /// </summary>
        /// <returns></returns>
        private int getHeight()
        {
            int h = 0;
            for (int i = 0; i < Controls.Count; i++)
                h += Controls[i].Height;
            return h;
        }
        public Accordion()
        {
            InitializeComponent();
            
        } 
         
        #endregion

        private void Accordion_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            if (lblTitle.Height >= this.Height) //展开处理
            {
                Height = getHeight();
            }
            else
                Height = lblTitle.Height; //收起
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
