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
    public partial class Modify : Form
    {

        MySqlConnection Conn;
        Employee employee;
        public Modify(MySqlConnection conn,Employee E)
        {
            
            InitializeComponent();
            Conn = conn;
            employee = E;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int num;
            int cnt = -1;
            try
            {
                num = int.Parse(NUM.Text);
                if (num <= 0) throw new Exception();
                StringBuilder query = new StringBuilder().AppendFormat("select count(*) as cnt from {1} where oid = {0}",OID.Text, Sale.viewList[employee.id]);
                MySqlCommand cmd = new MySqlCommand(query.ToString(), Conn);
                MySqlDataReader reader = cmd.ExecuteReader();
               
                while (reader.Read()) if(reader.HasRows)cnt=reader.GetInt32(0);
                if (cnt<=0)
                {
                    reader.Close();
                    throw new Exception();
                }
                else
                {
                    reader.Close();
                    query.Clear();
                    query.AppendFormat("UPDATE  db_task.ord SET onum={0} where oid={1}", NUM.Text,OID.Text);
                    cmd.CommandText = query.ToString();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改成功");

                }
            }
            catch
            {
                MessageBox.Show("非法操作");
                this.Close();
            }
            
        }
    }
}
