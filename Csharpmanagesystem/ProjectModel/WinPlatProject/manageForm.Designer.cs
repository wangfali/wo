namespace WinPlatProject
{
    partial class manageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabPage 添加班级;
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.添加教师用户 = new System.Windows.Forms.TabControl();
            this.userinformation = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.okadd = new System.Windows.Forms.Button();
            this.adduserpwd = new System.Windows.Forms.TextBox();
            this.addusernamebox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newuserbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newpwdbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.添加教师 = new System.Windows.Forms.TabPage();
            this.查询用户 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.selectuserpwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectusername = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加学生 = new System.Windows.Forms.TabPage();
            this.添加部门 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.pronamebox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.prnobox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.添加部门ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询部门ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改部门ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除部门ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加教师室 = new System.Windows.Forms.TabPage();
            this.添加专业 = new System.Windows.Forms.TabPage();
            this.添加课程 = new System.Windows.Forms.TabPage();
            this.添加课程表 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            添加班级 = new System.Windows.Forms.TabPage();
            this.添加教师用户.SuspendLayout();
            this.userinformation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.查询用户.SuspendLayout();
            this.添加部门.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 添加班级
            // 
            添加班级.Location = new System.Drawing.Point(4, 22);
            添加班级.Name = "添加班级";
            添加班级.Size = new System.Drawing.Size(818, 390);
            添加班级.TabIndex = 7;
            添加班级.Text = "添加班级";
            添加班级.UseVisualStyleBackColor = true;
            添加班级.PaddingChanged += new System.EventHandler(this.添加班级_PaddingChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // 添加教师用户
            // 
            this.添加教师用户.Controls.Add(this.userinformation);
            this.添加教师用户.Controls.Add(this.添加教师);
            this.添加教师用户.Controls.Add(this.查询用户);
            this.添加教师用户.Controls.Add(this.添加学生);
            this.添加教师用户.Controls.Add(this.添加部门);
            this.添加教师用户.Controls.Add(this.添加教师室);
            this.添加教师用户.Controls.Add(this.添加专业);
            this.添加教师用户.Controls.Add(添加班级);
            this.添加教师用户.Controls.Add(this.添加课程);
            this.添加教师用户.Controls.Add(this.添加课程表);
            this.添加教师用户.Location = new System.Drawing.Point(-7, 2);
            this.添加教师用户.Name = "添加教师用户";
            this.添加教师用户.SelectedIndex = 0;
            this.添加教师用户.Size = new System.Drawing.Size(826, 416);
            this.添加教师用户.TabIndex = 0;
            this.添加教师用户.SelectedIndexChanged += new System.EventHandler(this.添加教师用户_SelectedIndexChanged);
            this.添加教师用户.DockChanged += new System.EventHandler(this.tabPage2_Click);
            this.添加教师用户.TabIndexChanged += new System.EventHandler(this.tabPage2_Click);
            this.添加教师用户.PaddingChanged += new System.EventHandler(this.添加教师用户_PaddingChanged);
            // 
            // userinformation
            // 
            this.userinformation.Controls.Add(this.groupBox2);
            this.userinformation.Controls.Add(this.groupBox1);
            this.userinformation.Location = new System.Drawing.Point(4, 22);
            this.userinformation.Name = "userinformation";
            this.userinformation.Padding = new System.Windows.Forms.Padding(3);
            this.userinformation.Size = new System.Drawing.Size(818, 390);
            this.userinformation.TabIndex = 0;
            this.userinformation.Text = "修改信息";
            this.userinformation.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.okadd);
            this.groupBox2.Controls.Add(this.adduserpwd);
            this.groupBox2.Controls.Add(this.addusernamebox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(315, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 251);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "用户编码以A开头为学生\r\n用户账号以B开头为教师\r\n用户账号以C开头为管理员\r\n";
            // 
            // okadd
            // 
            this.okadd.Location = new System.Drawing.Point(76, 213);
            this.okadd.Name = "okadd";
            this.okadd.Size = new System.Drawing.Size(75, 23);
            this.okadd.TabIndex = 10;
            this.okadd.Text = "添加";
            this.okadd.UseVisualStyleBackColor = true;
            this.okadd.Click += new System.EventHandler(this.okadd_Click);
            // 
            // adduserpwd
            // 
            this.adduserpwd.Location = new System.Drawing.Point(150, 97);
            this.adduserpwd.Name = "adduserpwd";
            this.adduserpwd.Size = new System.Drawing.Size(100, 21);
            this.adduserpwd.TabIndex = 9;
            // 
            // addusernamebox
            // 
            this.addusernamebox.Location = new System.Drawing.Point(150, 40);
            this.addusernamebox.Name = "addusernamebox";
            this.addusernamebox.Size = new System.Drawing.Size(100, 21);
            this.addusernamebox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "请输入密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "请输入用户账号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newuserbox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.newpwdbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 277);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // newuserbox
            // 
            this.newuserbox.Location = new System.Drawing.Point(149, 37);
            this.newuserbox.Name = "newuserbox";
            this.newuserbox.Size = new System.Drawing.Size(100, 21);
            this.newuserbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入新的密码";
            // 
            // newpwdbox
            // 
            this.newpwdbox.Location = new System.Drawing.Point(149, 94);
            this.newpwdbox.Name = "newpwdbox";
            this.newpwdbox.Size = new System.Drawing.Size(100, 21);
            this.newpwdbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入账号";
            // 
            // 添加教师
            // 
            this.添加教师.Location = new System.Drawing.Point(4, 22);
            this.添加教师.Name = "添加教师";
            this.添加教师.Padding = new System.Windows.Forms.Padding(3);
            this.添加教师.Size = new System.Drawing.Size(818, 390);
            this.添加教师.TabIndex = 1;
            this.添加教师.Text = "添加教师";
            this.添加教师.UseVisualStyleBackColor = true;
            this.添加教师.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // 查询用户
            // 
            this.查询用户.Controls.Add(this.button2);
            this.查询用户.Controls.Add(this.label7);
            this.查询用户.Controls.Add(this.selectuserpwd);
            this.查询用户.Controls.Add(this.label6);
            this.查询用户.Controls.Add(this.selectusername);
            this.查询用户.Controls.Add(this.menuStrip1);
            this.查询用户.Location = new System.Drawing.Point(4, 22);
            this.查询用户.Name = "查询用户";
            this.查询用户.Padding = new System.Windows.Forms.Padding(3);
            this.查询用户.Size = new System.Drawing.Size(818, 390);
            this.查询用户.TabIndex = 2;
            this.查询用户.Text = "查询用户";
            this.查询用户.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "密码为";
            // 
            // selectuserpwd
            // 
            this.selectuserpwd.Location = new System.Drawing.Point(97, 129);
            this.selectuserpwd.Name = "selectuserpwd";
            this.selectuserpwd.Size = new System.Drawing.Size(100, 21);
            this.selectuserpwd.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "输入用户账号";
            // 
            // selectusername
            // 
            this.selectusername.Location = new System.Drawing.Point(97, 49);
            this.selectusername.Name = "selectusername";
            this.selectusername.Size = new System.Drawing.Size(100, 21);
            this.selectusername.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加学生
            // 
            this.添加学生.Location = new System.Drawing.Point(4, 22);
            this.添加学生.Name = "添加学生";
            this.添加学生.Size = new System.Drawing.Size(818, 390);
            this.添加学生.TabIndex = 3;
            this.添加学生.Text = "添加学生";
            this.添加学生.UseVisualStyleBackColor = true;
            // 
            // 添加部门
            // 
            this.添加部门.Controls.Add(this.dataGridView1);
            this.添加部门.Controls.Add(this.label10);
            this.添加部门.Controls.Add(this.pronamebox);
            this.添加部门.Controls.Add(this.label9);
            this.添加部门.Controls.Add(this.prnobox);
            this.添加部门.Controls.Add(this.label8);
            this.添加部门.Controls.Add(this.menuStrip2);
            this.添加部门.Location = new System.Drawing.Point(4, 22);
            this.添加部门.Name = "添加部门";
            this.添加部门.Size = new System.Drawing.Size(818, 390);
            this.添加部门.TabIndex = 4;
            this.添加部门.Text = "添加部门";
            this.添加部门.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 12);
            this.label10.TabIndex = 4;
            // 
            // pronamebox
            // 
            this.pronamebox.Location = new System.Drawing.Point(113, 116);
            this.pronamebox.Name = "pronamebox";
            this.pronamebox.Size = new System.Drawing.Size(100, 21);
            this.pronamebox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "部门名称";
            // 
            // prnobox
            // 
            this.prnobox.Location = new System.Drawing.Point(113, 65);
            this.prnobox.Name = "prnobox";
            this.prnobox.Size = new System.Drawing.Size(100, 21);
            this.prnobox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "部门编号";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加部门ToolStripMenuItem,
            this.查询部门ToolStripMenuItem,
            this.修改部门ToolStripMenuItem,
            this.删除部门ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(818, 25);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 添加部门ToolStripMenuItem
            // 
            this.添加部门ToolStripMenuItem.Name = "添加部门ToolStripMenuItem";
            this.添加部门ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.添加部门ToolStripMenuItem.Text = "添加部门";
            this.添加部门ToolStripMenuItem.Click += new System.EventHandler(this.添加部门ToolStripMenuItem_Click_1);
            // 
            // 查询部门ToolStripMenuItem
            // 
            this.查询部门ToolStripMenuItem.Name = "查询部门ToolStripMenuItem";
            this.查询部门ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.查询部门ToolStripMenuItem.Text = "查询部门";
            this.查询部门ToolStripMenuItem.Click += new System.EventHandler(this.查询部门ToolStripMenuItem_Click);
            // 
            // 修改部门ToolStripMenuItem
            // 
            this.修改部门ToolStripMenuItem.Name = "修改部门ToolStripMenuItem";
            this.修改部门ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.修改部门ToolStripMenuItem.Text = "修改部门";
            this.修改部门ToolStripMenuItem.Click += new System.EventHandler(this.修改部门ToolStripMenuItem_Click);
            // 
            // 删除部门ToolStripMenuItem
            // 
            this.删除部门ToolStripMenuItem.Name = "删除部门ToolStripMenuItem";
            this.删除部门ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.删除部门ToolStripMenuItem.Text = "删除部门";
            this.删除部门ToolStripMenuItem.Click += new System.EventHandler(this.删除部门ToolStripMenuItem_Click);
            // 
            // 添加教师室
            // 
            this.添加教师室.Location = new System.Drawing.Point(4, 22);
            this.添加教师室.Name = "添加教师室";
            this.添加教师室.Size = new System.Drawing.Size(818, 390);
            this.添加教师室.TabIndex = 5;
            this.添加教师室.Text = "添加教室";
            this.添加教师室.UseVisualStyleBackColor = true;
            // 
            // 添加专业
            // 
            this.添加专业.Location = new System.Drawing.Point(4, 22);
            this.添加专业.Name = "添加专业";
            this.添加专业.Size = new System.Drawing.Size(818, 390);
            this.添加专业.TabIndex = 6;
            this.添加专业.Text = "添加专业";
            this.添加专业.UseVisualStyleBackColor = true;
            // 
            // 添加课程
            // 
            this.添加课程.CausesValidation = false;
            this.添加课程.Location = new System.Drawing.Point(4, 22);
            this.添加课程.Name = "添加课程";
            this.添加课程.Size = new System.Drawing.Size(818, 390);
            this.添加课程.TabIndex = 8;
            this.添加课程.Text = "添加课程";
            this.添加课程.UseVisualStyleBackColor = true;
            // 
            // 添加课程表
            // 
            this.添加课程表.Location = new System.Drawing.Point(4, 22);
            this.添加课程表.Name = "添加课程表";
            this.添加课程表.Size = new System.Drawing.Size(818, 390);
            this.添加课程表.TabIndex = 9;
            this.添加课程表.Text = "添加课程表";
            this.添加课程表.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(774, 359);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // manageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 430);
            this.Controls.Add(this.添加教师用户);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "manageForm";
            this.Text = "manageForm";
            this.添加教师用户.ResumeLayout(false);
            this.userinformation.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.查询用户.ResumeLayout(false);
            this.查询用户.PerformLayout();
            this.添加部门.ResumeLayout(false);
            this.添加部门.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TabControl 添加教师用户;
        private System.Windows.Forms.TabPage userinformation;
        private System.Windows.Forms.TabPage 添加教师;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox newuserbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newpwdbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage 查询用户;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button okadd;
        private System.Windows.Forms.TextBox adduserpwd;
        private System.Windows.Forms.TextBox addusernamebox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox selectuserpwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox selectusername;
        private System.Windows.Forms.TabPage 添加学生;
        private System.Windows.Forms.TabPage 添加部门;
        private System.Windows.Forms.TabPage 添加教师室;
        private System.Windows.Forms.TabPage 添加专业;
        private System.Windows.Forms.TabPage 添加课程;
        private System.Windows.Forms.TabPage 添加课程表;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pronamebox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox prnobox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 添加部门ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询部门ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改部门ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除部门ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}