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
    public partial class car : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = " + System.Environment.MachineName + "; Initial Catalog = CompStrahOfAuto; Integrated Security = True");
        public car()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tx1.Text == "" || tx2.Text == "" || tx3.Text == "" || tx4.Text == "" || tx5.Text == "" || tx6.Text == "" || tx7.Text == "")
            {
                MessageBox.Show("Какое-то из полей не было заполнено");
                return;
            }
            try
            {
                con.Open();
                string com = "insert into [Транспортное средство] ([Номер VIN]," +
                    " [Год выпуска], [Объём двигателя], [Гос номер], Марка, Модель, Пробег) " +
                    "values('" + tx1.Text + "', '" + tx2.Text + "', '" + tx3.Text +
                    "', '" + tx4.Text + "', '" + tx5.Text +
                    "', '" + tx6.Text + "', '" + tx7.Text + "')"; 

                SqlCommand cmd = new SqlCommand(com, con);

                MessageBox.Show("Транспортное средство успешно добавлено");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception io)
            {
                MessageBox.Show(io.Message);
            }
        }

        private void car_Load(object sender, EventArgs e)
        {

        }
    }
}
