namespace WinPlatProject
{
    partial class import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(import));
            this.登录 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.useridbox = new System.Windows.Forms.TextBox();
            this.userpwdbox = new System.Windows.Forms.TextBox();
            this.用户密码 = new System.Windows.Forms.Label();
            this.用户账号 = new System.Windows.Forms.Label();
            this.注册 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 登录
            // 
            this.登录.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.登录.Location = new System.Drawing.Point(127, 295);
            this.登录.Name = "登录";
            this.登录.Size = new System.Drawing.Size(75, 23);
            this.登录.TabIndex = 0;
            this.登录.Text = "登录";
            this.登录.UseVisualStyleBackColor = true;
            this.登录.Click += new System.EventHandler(this.登录_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.useridbox);
            this.groupBox1.Controls.Add(this.userpwdbox);
            this.groupBox1.Controls.Add(this.用户密码);
            this.groupBox1.Controls.Add(this.用户账号);
            this.groupBox1.Location = new System.Drawing.Point(115, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "欢迎";
            // 
            // useridbox
            // 
            this.useridbox.Location = new System.Drawing.Point(209, 46);
            this.useridbox.Name = "useridbox";
            this.useridbox.Size = new System.Drawing.Size(100, 21);
            this.useridbox.TabIndex = 3;
            // 
            // userpwdbox
            // 
            this.userpwdbox.Location = new System.Drawing.Point(209, 131);
            this.userpwdbox.Name = "userpwdbox";
            this.userpwdbox.PasswordChar = '*';
            this.userpwdbox.Size = new System.Drawing.Size(100, 21);
            this.userpwdbox.TabIndex = 4;
            // 
            // 用户密码
            // 
            this.用户密码.AutoSize = true;
            this.用户密码.ForeColor = System.Drawing.Color.Red;
            this.用户密码.Location = new System.Drawing.Point(64, 140);
            this.用户密码.Name = "用户密码";
            this.用户密码.Size = new System.Drawing.Size(53, 12);
            this.用户密码.TabIndex = 4;
            this.用户密码.Text = "用户密码";
            // 
            // 用户账号
            // 
            this.用户账号.AutoSize = true;
            this.用户账号.Location = new System.Drawing.Point(64, 49);
            this.用户账号.Name = "用户账号";
            this.用户账号.Size = new System.Drawing.Size(53, 12);
            this.用户账号.TabIndex = 3;
            this.用户账号.Text = "用户账号";
            // 
            // 注册
            // 
            this.注册.Location = new System.Drawing.Point(560, 295);
            this.注册.Name = "注册";
            this.注册.Size = new System.Drawing.Size(75, 23);
            this.注册.TabIndex = 2;
            this.注册.Text = "退出";
            this.注册.UseVisualStyleBackColor = true;
            this.注册.Click += new System.EventHandler(this.注册_Click);
            // 
            // import
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 348);
            this.Controls.Add(this.注册);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.登录);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "import";
            this.Text = "欢迎进入教务管理系统";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.import_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.import_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 登录;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label 用户密码;
        private System.Windows.Forms.Label 用户账号;
        private System.Windows.Forms.Button 注册;
        private System.Windows.Forms.TextBox useridbox;
        private System.Windows.Forms.TextBox userpwdbox;

    }
}