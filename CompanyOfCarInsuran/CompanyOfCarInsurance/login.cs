using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CompanyOfCarInsurance
{
    public partial class login: Form
    {
        SqlConnection conn;
        
        
        public login()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=" + System.Environment.MachineName + ";Initial Catalog=CompStrahOfAuto;Integrated Security=True";
            
        }
        private void logins()
        { 
        
        }
        private void login_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("логин или пароль пуст", textBox1.Text);
                return;
            }
            else
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                DataTable useresTable = new DataTable();
                SqlCommand comm = new SqlCommand("SELECT * FROM Сотрудники WHERE Login = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "' AND IdRole = 0", conn);
                
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                comm.ExecuteNonQuery();
                adapter.Fill(useresTable);
                if (useresTable.Rows.Count > 0)
                {
                    this.Hide();
                    adminMenu dlg = new adminMenu();
                    dlg.Show(this);
                    
                    

                }
                else
                {
                    SqlCommand com = new SqlCommand("SELECT * FROM Сотрудники WHERE Login = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "'", conn);
                    DataTable useresTabl = new DataTable();

                    SqlDataAdapter adapte = new SqlDataAdapter(com);
                    com.ExecuteNonQuery();
                    adapte.Fill(useresTabl);
                    if (useresTabl.Rows.Count > 0)
                    {
                        this.Hide();
                        Menu dlg = new Menu();
                        dlg.Show(this);
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                    
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       
    }
}
