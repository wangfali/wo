namespace WinPlatProject
{
    partial class departmentview
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pronobox = new System.Windows.Forms.TextBox();
            this.pronamebox = new System.Windows.Forms.TextBox();
            this.marjorname = new System.Windows.Forms.TextBox();
            this.profunction = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "部门编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "部门名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "部门专业";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "部门负责人";
           
            // 
            // pronobox
            // 
            this.pronobox.Location = new System.Drawing.Point(197, 49);
            this.pronobox.Name = "pronobox";
            this.pronobox.Size = new System.Drawing.Size(100, 21);
            this.pronobox.TabIndex = 4;
            // 
            // pronamebox
            // 
            this.pronamebox.Location = new System.Drawing.Point(197, 109);
            this.pronamebox.Name = "pronamebox";
            this.pronamebox.Size = new System.Drawing.Size(100, 21);
            this.pronamebox.TabIndex = 5;
            // 
            // marjorname
            // 
            this.marjorname.Location = new System.Drawing.Point(197, 166);
            this.marjorname.Name = "marjorname";
            this.marjorname.Size = new System.Drawing.Size(100, 21);
            this.marjorname.TabIndex = 6;
            // 
            // profunction
            // 
            this.profunction.Location = new System.Drawing.Point(197, 228);
            this.profunction.Name = "profunction";
            this.profunction.Size = new System.Drawing.Size(100, 21);
            this.profunction.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // departmentview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.profunction);
            this.Controls.Add(this.marjorname);
            this.Controls.Add(this.pronamebox);
            this.Controls.Add(this.pronobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "departmentview";
            this.Text = "departmentview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pronobox;
        private System.Windows.Forms.TextBox pronamebox;
        private System.Windows.Forms.TextBox marjorname;
        private System.Windows.Forms.TextBox profunction;
        private System.Windows.Forms.Button button1;
    }
}