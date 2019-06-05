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
    public partial class Form1 : Form
    {
        private MySqlConnection Conn;
        private int Kind;
        private Employee employee;
    
        public Form1()
        {
            Kind = 0;
            employee = null;
            InitializeComponent();
            string connStr = "server=localhost;User Id=root;password=12345;Database=db_task";
            Conn = new MySqlConnection(connStr);
            if (!Opendatabase())
            {
                MessageBox.Show("connect to database failed");
                Application.Exit();
            }
        }
        private bool Opendatabase()
        {
            try
            {
                Conn.Open();
            }
            catch
            {
                
                return false;
            }
            return true;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(IDBuffer.Text);
                string password = pwdBuffer.Text;
                if (radioButton1.Checked) Kind = 1;
                else if (radioButton2.Checked) Kind = 2;
                else if (radioButton3.Checked) Kind = 3;

                if (!ComfirmLoginInfo(id, password, Kind))
                {
                    MessageBox.Show("Password not correct");
                    Application.Exit();
                }
                else
                {

                    SetEmployee(new Employee(id, password, Kind));
                    switch (Kind)
                    {
                        
                        case (1):
                        case (2):
                            Sale saleWindow = new Sale(Conn,employee);
                            saleWindow.Show();
                            //Form f = new Form();
                            //f.Show();
                            break;
                        case (3):
                            Form2 conser = new Form2(Conn, employee);
                            conser.Show();
                            break;
                        default:
                            throw new Exception();

                    }

                }

            }
            catch
            {
                MessageBox.Show("Error");
                Application.Exit();
            }
          
        }
     
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Conn.Close();
            Application.Exit();
        }
        private void SetEmployee(Employee E)
        {
            this.employee = E;
        }
        private bool ComfirmLoginInfo(int ID, string Password,int pm)
        {
            StringBuilder sql = new StringBuilder().AppendFormat("select pwd,pm from employee where pwd = '{0}'", Password);

            string query = sql.ToString();
            Console.WriteLine(query);
            try
            {
                MySqlCommand sqlCommand = new MySqlCommand(query, Conn);
                MySqlDataReader sqlDR = sqlCommand.ExecuteReader();
                // string s1 = sqlDR.GetString(0);
                if (!sqlDR.HasRows && !Password.Equals(sqlDR.GetString(0)))
                {
                    sqlDR.Close();
                    return false;
                }
                sqlDR.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
