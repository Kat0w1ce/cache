using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace depot
{
    partial class Add : Form
    {
        private MySqlConnection Conn;
        private Employee employee;

        
        public Add(MySqlConnection Conn,Employee employee)
        {
            InitializeComponent();
            this.Conn = Conn;
            this.employee = employee;
       
        }

        #region 程序集特性访问器

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextClicked(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string sql = "select gid as 货号,gname as 货物名 from good";
            MySqlDataAdapter msda = new MySqlDataAdapter(sql, Conn);
            msda.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void TextBox2_TextClicked(object sender, EventArgs e)
        {

            try
            {
                DataTable dataTable = new DataTable();
                string sql = "select vid as 编号,vname as 客户 from vend";
                MySqlDataAdapter msda = new MySqlDataAdapter(sql, Conn);
                msda.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch
            {
                return;
            }
        }
        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                int gid = int.Parse(gidBox.Text);
                int vid = int.Parse(vendBuffer.Text);
                int num = int.Parse(numberBuffer.Text);
                int eid = employee.id;
                int pm  = employee.pm;
                int cid = int.Parse(cachebox.Text);
                StringBuilder sqlbuilder = new StringBuilder().AppendFormat("insert into ord(gid,eid,vid,onum,kind,cid) values({0},{1},{2},{3},{4},{5})", gid.ToString(), eid.ToString(), vid.ToString(),  num.ToString(), pm.ToString(),cid.ToString());
                MySqlCommand mySql = new MySqlCommand(sqlbuilder.ToString(), Conn);
                mySql.ExecuteNonQuery();
                MessageBox.Show("添加成功");
                this.Close();
            }
                catch
            {
                MessageBox.Show("非法数据");
                Application.Exit();
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void cache_TextClick(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                string sql = "select cid as 编号,clc as 地址 from cache";
                MySqlDataAdapter msda = new MySqlDataAdapter(sql, Conn);
                msda.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch
            {
                return;
            }
        }
    }
}
