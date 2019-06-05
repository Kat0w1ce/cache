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
    public partial class Lack : Form
    {
        private Employee employee;
        private MySqlConnection Conn;
        public Lack(MySqlConnection connection,Employee E)
        {
            employee = E;
            Conn = connection;
            InitializeComponent();
            if (E.pm != 3) button4.Enabled = false;
            else button4.Enabled = true;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            { 
                StringBuilder saleSql = new StringBuilder().AppendFormat("select lid as 单号, gid as 货品  ,cid as 仓库, lnum as 出库量, dum as 库存,delta as 差额   from  newview");
                MySqlDataAdapter msda = new MySqlDataAdapter(saleSql.ToString(), Conn);
                DataTable dt = new DataTable();
                msda.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch(NullReferenceException E)
            {
                MessageBox.Show(E.Message);
                this.Close();
            }
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                 
                StringBuilder saleSql = new StringBuilder().AppendFormat("select lid as 单号, gid as 货品  ,cid as 仓库, lnum as 出库量, dum as 库存,delta as 差额   from  newview where delta>=0 ");
                MySqlDataAdapter msda = new MySqlDataAdapter(saleSql.ToString(), Conn);
                DataTable dt = new DataTable();
                msda.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (NullReferenceException E)
            {
                MessageBox.Show(E.Message);
                this.Close();
            }

        }
        
        private void Button4_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
    