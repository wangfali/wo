namespace WinPlatProject
{
    partial class FrmAdd
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
            this.txtOne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txt_JF_Result = new System.Windows.Forms.TextBox();
            this.btnJianFa = new System.Windows.Forms.Button();
            this.txt_JF_Two = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_JF_One = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(30, 58);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(57, 21);
            this.txtOne.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(152, 58);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(56, 21);
            this.txtTwo.TabIndex = 2;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(214, 58);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 3;
            this.btnCompute.Text = "=";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(295, 58);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(56, 21);
            this.txtResult.TabIndex = 4;
            // 
            // txt_JF_Result
            // 
            this.txt_JF_Result.Location = new System.Drawing.Point(295, 103);
            this.txt_JF_Result.Name = "txt_JF_Result";
            this.txt_JF_Result.Size = new System.Drawing.Size(56, 21);
            this.txt_JF_Result.TabIndex = 9;
            // 
            // btnJianFa
            // 
            this.btnJianFa.Location = new System.Drawing.Point(214, 103);
            this.btnJianFa.Name = "btnJianFa";
            this.btnJianFa.Size = new System.Drawing.Size(75, 23);
            this.btnJianFa.TabIndex = 8;
            this.btnJianFa.Text = "=";
            this.btnJianFa.UseVisualStyleBackColor = true;
            this.btnJianFa.Click += new System.EventHandler(this.btnJianFa_Click);
            // 
            // txt_JF_Two
            // 
            this.txt_JF_Two.Location = new System.Drawing.Point(152, 103);
            this.txt_JF_Two.Name = "txt_JF_Two";
            this.txt_JF_Two.Size = new System.Drawing.Size(56, 21);
            this.txt_JF_Two.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "-";
            // 
            // txt_JF_One
            // 
            this.txt_JF_One.Location = new System.Drawing.Point(30, 103);
            this.txt_JF_One.Name = "txt_JF_One";
            this.txt_JF_One.Size = new System.Drawing.Size(57, 21);
            this.txt_JF_One.TabIndex = 5;
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 239);
            this.Controls.Add(this.txt_JF_Result);
            this.Controls.Add(this.btnJianFa);
            this.Controls.Add(this.txt_JF_Two);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_JF_One);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOne);
            this.Name = "FrmAdd";
            this.Text = "FrmAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txt_JF_Result;
        private System.Windows.Forms.Button btnJianFa;
        private System.Windows.Forms.TextBox txt_JF_Two;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_JF_One;
    }
}