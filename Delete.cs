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
    public partial class Delete : Form
    {
        private MySqlConnection Conn;
        private Employee employee;
        public Delete(MySqlConnection conn,Employee E)
        {

            InitializeComponent();
            this.Conn = conn;
            employee = E;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int cnt=-1;
                StringBuilder query = new StringBuilder().AppendFormat("select count(*) as cnt from {1} where oid = {0}", textBox1.Text,Sale.viewList[employee.id]);
                MySqlCommand cmd = new MySqlCommand(query.ToString(), Conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) if (reader.HasRows) cnt = reader.GetInt32(0);
                if (cnt <= 0)
                {
                    reader.Close();
                    throw new Exception();
                }
                else
                {
                    reader.Close();
                    query.Clear();
                    query.AppendFormat("delete from ord where oid={0}", textBox1.Text);
                    cmd.CommandText = query.ToString();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("删除成功");
                    
                }
            }
            catch
            {
                
                MessageBox.Show("非法操作");
                this.Close();
            }
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
