namespace depot
{
    partial class Add
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
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
            this.addButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.gidBox = new System.Windows.Forms.TextBox();
            this.vendBuffer = new System.Windows.Forms.TextBox();
            this.numberBuffer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cachebox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(341, 256);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "添加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(461, 256);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "退出";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // gidBox
            // 
            this.gidBox.Location = new System.Drawing.Point(391, 63);
            this.gidBox.Name = "gidBox";
            this.gidBox.Size = new System.Drawing.Size(145, 25);
            this.gidBox.TabIndex = 2;
            this.gidBox.Click += new System.EventHandler(this.TextBox1_TextClicked);
            // 
            // vendBuffer
            // 
            this.vendBuffer.Location = new System.Drawing.Point(391, 108);
            this.vendBuffer.Name = "vendBuffer";
            this.vendBuffer.Size = new System.Drawing.Size(145, 25);
            this.vendBuffer.TabIndex = 3;
            this.vendBuffer.Click += new System.EventHandler(this.TextBox2_TextClicked);
            // 
            // numberBuffer
            // 
            this.numberBuffer.Location = new System.Drawing.Point(391, 160);
            this.numberBuffer.Name = "numberBuffer";
            this.numberBuffer.Size = new System.Drawing.Size(145, 25);
            this.numberBuffer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "货号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "客户";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "数量";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(293, 286);
            this.dataGridView1.TabIndex = 8;
            // 
            // cachebox
            // 
            this.cachebox.Location = new System.Drawing.Point(391, 207);
            this.cachebox.Name = "cachebox";
            this.cachebox.Size = new System.Drawing.Size(145, 25);
            this.cachebox.TabIndex = 9;
            this.cachebox.Click += new System.EventHandler(this.cache_TextClick);
            this.cachebox.TextChanged += new System.EventHandler(this.cache_TextClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "仓库";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 327);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cachebox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberBuffer);
            this.Controls.Add(this.vendBuffer);
            this.Controls.Add(this.gidBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add";
            this.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox gidBox;
        private System.Windows.Forms.TextBox vendBuffer;
        private System.Windows.Forms.TextBox numberBuffer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox cachebox;
        private System.Windows.Forms.Label label4;
    }
}
