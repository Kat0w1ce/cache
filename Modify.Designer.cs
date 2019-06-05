namespace depot
{
    partial class Modify
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
            this.OID = new System.Windows.Forms.TextBox();
            this.NUM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OID
            // 
            this.OID.Location = new System.Drawing.Point(216, 22);
            this.OID.Name = "OID";
            this.OID.Size = new System.Drawing.Size(100, 25);
            this.OID.TabIndex = 0;
            // 
            // NUM
            // 
            this.NUM.Location = new System.Drawing.Point(216, 71);
            this.NUM.Name = "NUM";
            this.NUM.Size = new System.Drawing.Size(100, 25);
            this.NUM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "单号";
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(118, 74);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(37, 15);
            this.numLabel.TabIndex = 3;
            this.numLabel.Text = "数量";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 149);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUM);
            this.Controls.Add(this.OID);
            this.Name = "Modify";
            this.Text = "Modify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OID;
        private System.Windows.Forms.TextBox NUM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}