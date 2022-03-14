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
    public partial class Writtens : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=" + System.Environment.MachineName + ";Initial Catalog=CompStrahOfAuto;Integrated Security=True");
        public Writtens()
        {
            InitializeComponent();
        }
        private void fillVu()
        {
            con.Open();
            string query = "select Код, Серия + ' ' + Номер as Номер from [Водительское удостверение]";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Код", typeof(string));
            dt.Columns.Add("Номер", typeof(string));

            dt.Load(rdr);
            vuId.ValueMember = "Код";
            vuId.DisplayMember = "Номер";
            vuId.DataSource = dt;

            con.Close();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string com = "insert into [Лица, допущенных к управлению автотранспортом]" +
                    " (Фамилия, Имя, Отчество, Телефон, [Серия и номер паспорта], ВУ)" +
                    " values('" + family.Text + "', '" + name.Text + "', '" +
                    sname.Text + "', '" + number.Text + "', '" + pasport.Text +
                    "', '" + vuId.SelectedValue.ToString() + "')";

                SqlCommand cmd = new SqlCommand(com, con);

                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception io) {
                MessageBox.Show(io.Message);
            }
            
        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string com = "insert into [Водительское удостверение] (Серия, Номер, [Дата Рождения], [Дата начала стажа]) values('" + vuser.Text + "', '" + vunum.Text + "', '" +
                    dateTimePicker1.Value.Date.ToString() + "', '" + dateTimePicker2.Value.Date.ToString() + "')";

                SqlCommand cmd = new SqlCommand(com, con);

                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
                con.Close();
                fillVu();
                
            }
            catch (Exception wisp) {
                MessageBox.Show(wisp.Message);
            }
        }

        private void Writtens_Load(object sender, EventArgs e)
        {
            fillVu();

        }

        private void vuId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
