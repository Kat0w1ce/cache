
using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace depot
{
    public partial class Sale : Form
    {
        private MySqlConnection Conn;
        private Employee employee;
        public static List<string> viewList = new List<string>() { null, "in_order", "out_order" };  
        public Sale(MySqlConnection msc,Employee E )
        {
            this.Conn = msc;
            this.employee = E;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder saleSql = new StringBuilder().AppendFormat("select oid as 单号, gname as 货物名,onumber as 数量, eid as 操作人员,cid as 仓库   from  {0}",viewList[employee.pm]);
            MySqlDataAdapter msda = new MySqlDataAdapter(saleSql.ToString(), Conn);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“db_taskDataSet.in_order”中。您可以根据需要移动或删除它。
            this.in_orderTableAdapter.Fill(this.db_taskDataSet.in_order);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Add add = new Add(Conn, employee);
            add.Show();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete(Conn,employee);
            delete.Show();

        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify(Conn, employee);
            modify.Show();
        }

        private void 缺货表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lack lack = new Lack(Conn, employee);
            lack.Show();
        }
    }
}
