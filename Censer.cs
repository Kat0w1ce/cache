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
    
    public partial class Censer : Form
    {
        private int[] rs;
        MySqlConnection Conn;
        Employee employee;
        public Censer(MySqlConnection conn, Employee E)
        {
            Conn = conn;
            employee = E;
            InitializeComponent();
            rs = new int[4];
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void InsertDepot(int oid)
        {
            try
            {
                StringBuilder query;
                if (!IsExist())
                    query = new StringBuilder().AppendFormat("insert into depot (gid,cid,NUM) values({0},{1},{2})", rs[0], rs[1], rs[2]);
                else query =new StringBuilder().AppendFormat("update depot SET NUM=NUM+{0} where gid={1} and cid={2}",rs[2],rs[0],rs[1]);
                MySqlCommand cmd = new MySqlCommand(query.ToString(), Conn);
                cmd.ExecuteNonQuery();
                query.Clear();
                query.AppendFormat("delete from ord where oid={0}",oid);
                cmd.CommandText = query.ToString();
                cmd.ExecuteNonQuery();
                MessageBox.Show("审核成功");
                this.Close();
            }
            catch
            {
                MessageBox.Show("purchase error");
                this.Close();
            }
        }
        private bool IsExist()
        {
            bool rst=false;
            try
            {   
                StringBuilder query = new StringBuilder().AppendFormat("select count(*) from depot where gid={0} and cid ={1}", rs[0], rs[1]);
                MySqlCommand cmd = new MySqlCommand(query.ToString(), Conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) if (reader.HasRows) rst = reader.GetInt32(0) == 1;
                reader.Close();
            }
            catch
            {
                MessageBox.Show("check error");
            }
            return rst;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            
            //{gid,cid,onum,kind}
            try
            {
                int cnt = -1;
                StringBuilder query = new StringBuilder().AppendFormat("select count(*) as cnt from orderlist where oid = {0}", textBox1.Text);
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
                    query.AppendFormat("select gid,cid,onum,kind from ord where oid = {0}", textBox1.Text);
                    cmd.CommandText = query.ToString();
                    reader = cmd.ExecuteReader();
                    while(reader.Read()&&reader.HasRows)
                    {
                        for (int i = 0; i < rs.Length; i++)
                               rs[i] = reader.GetInt32(i);
                    }
                    // MessageBox.Show(new StringBuilder().AppendFormat("{0},{1},{2},{3}",rs[1],rs[2],rs[3],rs[4]).ToString());
                    
                    reader.Close();
                    query.Clear();
                    if(rs[3]==1)
                    {
                        InsertDepot(int.Parse(textBox1.Text));
                    }else{
                        OutDepot(int.Parse(textBox1.Text));
                    }
                }
            }
            catch
            {
 
                MessageBox.Show("非法操作");
                this.Close();
            }
        }

        private void OutDepot(int oid)
        {
            int num;
            try
            {
                StringBuilder query=new StringBuilder();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conn;
                if (!IsExist())
                {
                    query.AppendFormat("insert into lack(gid,cid,lnum) values({0},{1},{2})", rs[0], rs[1], rs[2]);
                    cmd.CommandText = query.ToString();
                    MessageBox.Show("缺货");
                }
                else
                {
                    Console.WriteLine(rs[0]);
                    int delta = CompareToDepot();
                    if (delta >= 0){
                        query.AppendFormat("update depot Set NUM={0} where gid={1} and cid={2}",delta,rs[0], rs[1]);
                        MessageBox.Show("出库成功");
                    }else{
                        delta = -delta;
                        query.AppendFormat("insert into lack(gid,cid,lnum) values({0},{1},{2})", rs[0], rs[1], rs[2]);
                        MessageBox.Show("缺货");
                    }
                }
                cmd.CommandText = query.ToString();
                cmd.ExecuteNonQuery();
                query.Clear();
                query.AppendFormat("delete from ord where oid={0}", oid);
                cmd.CommandText = query.ToString();
                cmd.ExecuteNonQuery();
                this.Close();
            }
            catch
            {
                MessageBox.Show("出库错误");
                this.Close();
            }
           
        }

        private int CompareToDepot()
        {
            MySqlDataReader reader=null;
            int rst=0;
            try
            {
                int cnt=0;
                StringBuilder query = new StringBuilder().AppendFormat("select NUM from depot where gid={0} and cid={1}", rs[0], rs[1]);
                MySqlCommand cmd = new MySqlCommand(query.ToString(), Conn);
                reader = cmd.ExecuteReader();
                while (reader.Read()) { if (reader.HasRows) cnt = reader.GetInt32(0); }
                rst = cnt - rs[2];
                
            }
            catch
            {
                reader.Close();
                MessageBox.Show("compareError");
                this.Close();
            }
            reader.Close();
            return rst;
        }
    }
}
