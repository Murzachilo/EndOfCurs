using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompanyOfCarInsurance
{
    public partial class Client : Form

    {



        SqlConnection con = new SqlConnection(@"Data Source=" + System.Environment.MachineName + ";Initial Catalog=CompStrahOfAuto;Integrated Security=True");
        public Client()
        {
            InitializeComponent();
            cname.ReadOnly = true;
            inn.ReadOnly = true;
            bik.ReadOnly = true;
            textBox20.ReadOnly = true;

        }
        bool fizlic = true;

        private void populate()
        {
            con.Open();
            string query = "select * from  КлиентФизЛицо";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            
            con.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (fizlic == true)
            {
                if (fam.Text == "" || name.Text == "" || fname.Text == "" || phone.Text == "" || pasport.Text == "")
                {
                    MessageBox.Show("Какое-то из полей не было заполнено");
                    return;
                }
                try
                {
                con.Open();
                string com = "insert into КлиентФизЛицо (Фамилия, Имя, Отчество, Телефон, [Серия и номер паспорта]) values('" + fam.Text + "', '" + name.Text + "', '" +
                fname.Text + "', '" + phone.Text + "', '" + pasport.Text + "')";
            
                SqlCommand cmd = new SqlCommand(com, con);

                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception io)
                {
                    MessageBox.Show("Упс.... Кажется вы где-то ошиблись");
                    MessageBox.Show(io.Message);
                    con.Close();
                }
                populate();
            }
            else
            {
                if (fam.Text == "" || name.Text == "" || fname.Text == "" || phone.Text == "" || pasport.Text == "" || cname.Text == "" || inn.Text == "" || bik.Text == "" || textBox20.Text == "")
                {
                    MessageBox.Show("Какое-то из полей не было заполнено");
                    return;
                }
                try
                {
                    con.Open();
                    string com = "insert into КлиентЮрЛицо (Фамилия, Имя, Отчество, Телефон, [Серия и номер паспорта], [Наименование компании], ИНН, БИК, [Юридический адрес]) values('" + fam.Text + "', '" + name.Text + "', '" +
                    fname.Text + "', '" + phone.Text + "', '" + pasport.Text + "', '" + cname.Text + "', '" + inn.Text + "', '" + bik.Text + "', '" + textBox20.Text + "')";

                    SqlCommand cmd = new SqlCommand(com, con);

                    MessageBox.Show(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception io)
            {
                MessageBox.Show("Упс.... Кажется вы где-то ошиблись");
                MessageBox.Show(io.Message);
                con.Close();
            }
        }

    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                cname.ReadOnly = false;
                inn.ReadOnly = false;
                bik.ReadOnly = false;
                textBox20.ReadOnly = false;
                fizlic = false;
            }
            else
            {
                cname.ReadOnly = true;
                inn.ReadOnly = true;
                bik.ReadOnly = true;
                textBox20.ReadOnly = true;
                fizlic = true;
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
         

        }
    }
}
