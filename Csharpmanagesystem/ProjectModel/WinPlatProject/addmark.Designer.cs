namespace WinPlatProject
{
    partial class addmark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addmark));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.curnobox = new System.Windows.Forms.TextBox();
            this.marknobox = new System.Windows.Forms.TextBox();
            this.gradebox = new System.Windows.Forms.TextBox();
            this.stnobox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerformark = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(75, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "成绩表编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(80, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "成绩";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(80, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "学生编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(386, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "考试时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(386, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "课程编号";
            // 
            // curnobox
            // 
            this.curnobox.Location = new System.Drawing.Point(465, 49);
            this.curnobox.Name = "curnobox";
            this.curnobox.Size = new System.Drawing.Size(100, 21);
            this.curnobox.TabIndex = 6;
            // 
            // marknobox
            // 
            this.marknobox.Location = new System.Drawing.Point(146, 30);
            this.marknobox.Name = "marknobox";
            this.marknobox.Size = new System.Drawing.Size(100, 21);
            this.marknobox.TabIndex = 7;
            // 
            // gradebox
            // 
            this.gradebox.Location = new System.Drawing.Point(146, 93);
            this.gradebox.Name = "gradebox";
            this.gradebox.Size = new System.Drawing.Size(100, 21);
            this.gradebox.TabIndex = 8;
            // 
            // stnobox
            // 
            this.stnobox.Location = new System.Drawing.Point(146, 150);
            this.stnobox.Name = "stnobox";
            this.stnobox.Size = new System.Drawing.Size(100, 21);
            this.stnobox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "确认上传成绩";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerformark
            // 
            this.dateTimePickerformark.Location = new System.Drawing.Point(445, 153);
            this.dateTimePickerformark.Name = "dateTimePickerformark";
            this.dateTimePickerformark.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerformark.TabIndex = 11;
            // 
            // addmark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(693, 313);
            this.Controls.Add(this.dateTimePickerformark);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stnobox);
            this.Controls.Add(this.gradebox);
            this.Controls.Add(this.marknobox);
            this.Controls.Add(this.curnobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addmark";
            this.Text = "上传成绩";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox curnobox;
        private System.Windows.Forms.TextBox marknobox;
        private System.Windows.Forms.TextBox gradebox;
        private System.Windows.Forms.TextBox stnobox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickerformark;
    }
}