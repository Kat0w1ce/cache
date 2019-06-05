namespace depot
{
    partial class Sale
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
            this.components = new System.ComponentModel.Container();
            this.QueryButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缺货表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_taskDataSet = new depot.db_taskDataSet();
            this.inorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.in_orderTableAdapter = new depot.db_taskDataSetTableAdapters.in_orderTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_taskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inorderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // QueryButton
            // 
            this.QueryButton.Location = new System.Drawing.Point(513, 377);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(75, 23);
            this.QueryButton.TabIndex = 1;
            this.QueryButton.Text = "查询";
            this.QueryButton.UseVisualStyleBackColor = true;
            this.QueryButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(656, 377);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "退出";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.缺货表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.添加ToolStripMenuItem.Text = "添加";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.添加ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 缺货表ToolStripMenuItem
            // 
            this.缺货表ToolStripMenuItem.Name = "缺货表ToolStripMenuItem";
            this.缺货表ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.缺货表ToolStripMenuItem.Text = "缺货表";
            this.缺货表ToolStripMenuItem.Click += new System.EventHandler(this.缺货表ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(592, 287);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // db_taskDataSet
            // 
            this.db_taskDataSet.DataSetName = "db_taskDataSet";
            this.db_taskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inorderBindingSource
            // 
            this.inorderBindingSource.DataMember = "in_order";
            this.inorderBindingSource.DataSource = this.db_taskDataSet;
            // 
            // in_orderTableAdapter
            // 
            this.in_orderTableAdapter.ClearBeforeFill = true;
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.QueryButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sale";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_taskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inorderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QueryButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缺货表ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_taskDataSet db_taskDataSet;
        private System.Windows.Forms.BindingSource inorderBindingSource;
        private db_taskDataSetTableAdapters.in_orderTableAdapter in_orderTableAdapter;
    }
}