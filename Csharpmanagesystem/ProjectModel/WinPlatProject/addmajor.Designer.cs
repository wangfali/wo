namespace WinPlatProject
{
    partial class addmajor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addmajor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.专业概述 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pronobox = new System.Windows.Forms.TextBox();
            this.proname = new System.Windows.Forms.TextBox();
            this.prosk = new System.Windows.Forms.TextBox();
            this.depnobox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(101, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "专业编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(101, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "专业名称";
            // 
            // 专业概述
            // 
            this.专业概述.AutoSize = true;
            this.专业概述.BackColor = System.Drawing.Color.Transparent;
            this.专业概述.Location = new System.Drawing.Point(101, 139);
            this.专业概述.Name = "专业概述";
            this.专业概述.Size = new System.Drawing.Size(53, 12);
            this.专业概述.TabIndex = 2;
            this.专业概述.Text = "专业概述";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(101, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "部门编号";
            // 
            // pronobox
            // 
            this.pronobox.Location = new System.Drawing.Point(260, 11);
            this.pronobox.Name = "pronobox";
            this.pronobox.Size = new System.Drawing.Size(100, 21);
            this.pronobox.TabIndex = 4;
            // 
            // proname
            // 
            this.proname.Location = new System.Drawing.Point(260, 72);
            this.proname.Name = "proname";
            this.proname.Size = new System.Drawing.Size(100, 21);
            this.proname.TabIndex = 5;
            // 
            // prosk
            // 
            this.prosk.Location = new System.Drawing.Point(260, 139);
            this.prosk.Name = "prosk";
            this.prosk.Size = new System.Drawing.Size(100, 21);
            this.prosk.TabIndex = 6;
            // 
            // depnobox
            // 
            this.depnobox.Location = new System.Drawing.Point(260, 214);
            this.depnobox.Name = "depnobox";
            this.depnobox.Size = new System.Drawing.Size(100, 21);
            this.depnobox.TabIndex = 7;
            this.depnobox.TextChanged += new System.EventHandler(this.depnobox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addmajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(703, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.depnobox);
            this.Controls.Add(this.prosk);
            this.Controls.Add(this.proname);
            this.Controls.Add(this.pronobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.专业概述);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addmajor";
            this.Text = "添加专业";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label 专业概述;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pronobox;
        private System.Windows.Forms.TextBox proname;
        private System.Windows.Forms.TextBox prosk;
        private System.Windows.Forms.TextBox depnobox;
        private System.Windows.Forms.Button button1;
    }
}