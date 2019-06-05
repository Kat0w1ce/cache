using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace depot
{
    public partial class Form2 : Form
    {
        MySqlConnection Conn;
        Employee employee;
        public Form2(MySqlConnection conn,Employee E)
        {
            Conn = conn;
            employee = E;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder saleSql = new StringBuilder().AppendFormat("select oid as 单号, gname as 货物名,onumber as 数量, eid as 操作人员,cid as 仓库   from  orderlist" );
            MySqlDataAdapter msda = new MySqlDataAdapter(saleSql.ToString(), Conn);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 审核ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Censer censer = new Censer(Conn, employee);
            censer.Show();
        }

        private void 缺货清单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lack lack = new Lack(Conn, employee);
            lack.Show();
        }
    }
}
