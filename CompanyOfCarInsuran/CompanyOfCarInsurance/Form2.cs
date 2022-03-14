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
    public partial class Form2 : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=DESKTOP-GF9UMVM;Initial Catalog=CompStrahOfAuto;Integrated Security=True";
        string sql = "SELECT * FROM Договора";

        public Form2()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                // делаем недоступным столбец id для изменения
                dataGridView1.Columns["Id"].ReadOnly = true;

            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            ds.Tables[0].Rows.Add(row);
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = new SqlCommand("sp_CreateUser", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@number", SqlDbType.Int, 0, "№ договора"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@dates", SqlDbType.Date, 0, "Дата заключения"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@sum", SqlDbType.Money, 0, "Страховая сумма"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@agent", SqlDbType.Int, 0, "Страховой агент"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@car", SqlDbType.Int, 0, "Транспортное средство"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@client", SqlDbType.Int, 0, "Клиент"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@datef", SqlDbType.Date, 0, "ДатаОкончания"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@writen", SqlDbType.Int, 0, "Вписанные"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@client2", SqlDbType.Int, 0, "КлиентЮрЛицо"));

                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Код договора");
                parameter.Direction = ParameterDirection.Output;

                adapter.Update(ds);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

