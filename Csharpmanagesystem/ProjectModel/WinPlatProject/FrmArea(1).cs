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
    public partial class FrmArea : Form
    {
        public FrmArea()
        {
            InitializeComponent();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            ModelProject.Triangle tri = new ModelProject.Triangle();
            tri.Bottom=Convert.ToDouble(txt_tri_bottom.Text);
            tri.Height = Convert.ToDouble(txt_tri_height.Text);
            txt_tri_area.Text=tri.area().ToString();
        }

        private void btn_circle_area_Click(object sender, EventArgs e)
        {
            ModelProject.Circle c = new ModelProject.Circle();
            c.R = Convert.ToDouble(txt_circle_r.Text);
            txt_circle_area.Text = c.area().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelProject.JuXing d = new ModelProject.JuXing();
            d.Chang = Convert.ToDouble(text_JuXing_chang.Text);
            d.Kuan = Convert.ToDouble(text_JuXing_kuan.Text);
            text_JuXing_area.Text = d.area().ToString();
        }
    }
}
