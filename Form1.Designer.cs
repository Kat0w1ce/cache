namespace depot
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comfirmBotton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.IDBuffer = new System.Windows.Forms.TextBox();
            this.pwdBuffer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // comfirmBotton
            // 
            this.comfirmBotton.Location = new System.Drawing.Point(256, 344);
            this.comfirmBotton.Name = "comfirmBotton";
            this.comfirmBotton.Size = new System.Drawing.Size(75, 23);
            this.comfirmBotton.TabIndex = 0;
            this.comfirmBotton.Text = "确认";
            this.comfirmBotton.UseVisualStyleBackColor = true;
            this.comfirmBotton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(427, 344);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "退出";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // IDBuffer
            // 
            this.IDBuffer.Location = new System.Drawing.Point(290, 135);
            this.IDBuffer.Name = "IDBuffer";
            this.IDBuffer.Size = new System.Drawing.Size(165, 25);
            this.IDBuffer.TabIndex = 2;
            this.IDBuffer.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // pwdBuffer
            // 
            this.pwdBuffer.Location = new System.Drawing.Point(290, 212);
            this.pwdBuffer.Name = "pwdBuffer";
            this.pwdBuffer.Size = new System.Drawing.Size(165, 25);
            this.pwdBuffer.TabIndex = 3;
            this.pwdBuffer.UseSystemPasswordChar = true;
            this.pwdBuffer.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "password";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(177, 296);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 19);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "采购";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(331, 296);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 19);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "销售";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(498, 296);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 19);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "审核";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwdBuffer);
            this.Controls.Add(this.IDBuffer);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.comfirmBotton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button comfirmBotton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox IDBuffer;
        private System.Windows.Forms.TextBox pwdBuffer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

