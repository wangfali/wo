namespace WinPlatProject
{
    partial class addrole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addrole));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roleidbox = new System.Windows.Forms.TextBox();
            this.rolenamebox = new System.Windows.Forms.TextBox();
            this.roleremark = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(74, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "角色编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(74, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "角色名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(74, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "角色描述";
            // 
            // roleidbox
            // 
            this.roleidbox.Location = new System.Drawing.Point(162, 50);
            this.roleidbox.Name = "roleidbox";
            this.roleidbox.Size = new System.Drawing.Size(100, 21);
            this.roleidbox.TabIndex = 3;
            // 
            // rolenamebox
            // 
            this.rolenamebox.Location = new System.Drawing.Point(162, 112);
            this.rolenamebox.Name = "rolenamebox";
            this.rolenamebox.Size = new System.Drawing.Size(100, 21);
            this.rolenamebox.TabIndex = 4;
            // 
            // roleremark
            // 
            this.roleremark.Location = new System.Drawing.Point(162, 172);
            this.roleremark.Name = "roleremark";
            this.roleremark.Size = new System.Drawing.Size(100, 21);
            this.roleremark.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addrole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(540, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roleremark);
            this.Controls.Add(this.rolenamebox);
            this.Controls.Add(this.roleidbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addrole";
            this.Opacity = 0.8D;
            this.Text = "添加角色";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roleidbox;
        private System.Windows.Forms.TextBox rolenamebox;
        private System.Windows.Forms.TextBox roleremark;
        private System.Windows.Forms.Button button1;
    }
}