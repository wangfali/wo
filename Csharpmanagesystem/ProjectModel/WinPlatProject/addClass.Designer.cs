namespace WinPlatProject
{
    partial class addClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addClass));
            this.班级编号 = new System.Windows.Forms.Label();
            this.班级名称 = new System.Windows.Forms.Label();
            this.专业编号 = new System.Windows.Forms.Label();
            this.班主任 = new System.Windows.Forms.Label();
            this.clobox = new System.Windows.Forms.TextBox();
            this.clnamebox = new System.Windows.Forms.TextBox();
            this.majorclassbox = new System.Windows.Forms.TextBox();
            this.Cltea = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 班级编号
            // 
            this.班级编号.AutoSize = true;
            this.班级编号.BackColor = System.Drawing.Color.Transparent;
            this.班级编号.Location = new System.Drawing.Point(55, 20);
            this.班级编号.Name = "班级编号";
            this.班级编号.Size = new System.Drawing.Size(53, 12);
            this.班级编号.TabIndex = 1;
            this.班级编号.Text = "班级编号";
            // 
            // 班级名称
            // 
            this.班级名称.AutoSize = true;
            this.班级名称.BackColor = System.Drawing.Color.Transparent;
            this.班级名称.Location = new System.Drawing.Point(55, 50);
            this.班级名称.Name = "班级名称";
            this.班级名称.Size = new System.Drawing.Size(53, 12);
            this.班级名称.TabIndex = 2;
            this.班级名称.Text = "班级名称";
            // 
            // 专业编号
            // 
            this.专业编号.AutoSize = true;
            this.专业编号.BackColor = System.Drawing.Color.Transparent;
            this.专业编号.Location = new System.Drawing.Point(55, 96);
            this.专业编号.Name = "专业编号";
            this.专业编号.Size = new System.Drawing.Size(53, 12);
            this.专业编号.TabIndex = 3;
            this.专业编号.Text = "专业编号";
            // 
            // 班主任
            // 
            this.班主任.AutoSize = true;
            this.班主任.BackColor = System.Drawing.Color.Transparent;
            this.班主任.Location = new System.Drawing.Point(55, 160);
            this.班主任.Name = "班主任";
            this.班主任.Size = new System.Drawing.Size(41, 12);
            this.班主任.TabIndex = 4;
            this.班主任.Text = "班主任";
            // 
            // clobox
            // 
            this.clobox.Location = new System.Drawing.Point(185, 11);
            this.clobox.Name = "clobox";
            this.clobox.Size = new System.Drawing.Size(100, 21);
            this.clobox.TabIndex = 5;
            // 
            // clnamebox
            // 
            this.clnamebox.Location = new System.Drawing.Point(185, 41);
            this.clnamebox.Name = "clnamebox";
            this.clnamebox.Size = new System.Drawing.Size(100, 21);
            this.clnamebox.TabIndex = 6;
            // 
            // majorclassbox
            // 
            this.majorclassbox.Location = new System.Drawing.Point(185, 93);
            this.majorclassbox.Name = "majorclassbox";
            this.majorclassbox.Size = new System.Drawing.Size(100, 21);
            this.majorclassbox.TabIndex = 7;
            // 
            // Cltea
            // 
            this.Cltea.Location = new System.Drawing.Point(185, 168);
            this.Cltea.Name = "Cltea";
            this.Cltea.Size = new System.Drawing.Size(100, 21);
            this.Cltea.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(578, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cltea);
            this.Controls.Add(this.majorclassbox);
            this.Controls.Add(this.clnamebox);
            this.Controls.Add(this.clobox);
            this.Controls.Add(this.班主任);
            this.Controls.Add(this.专业编号);
            this.Controls.Add(this.班级名称);
            this.Controls.Add(this.班级编号);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addClass";
            this.Opacity = 0.8D;
            this.Text = "添加班级";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 班级编号;
        private System.Windows.Forms.Label 班级名称;
        private System.Windows.Forms.Label 专业编号;
        private System.Windows.Forms.Label 班主任;
        private System.Windows.Forms.TextBox clobox;
        private System.Windows.Forms.TextBox clnamebox;
        private System.Windows.Forms.TextBox majorclassbox;
        private System.Windows.Forms.TextBox Cltea;
        private System.Windows.Forms.Button button1;
    }
}