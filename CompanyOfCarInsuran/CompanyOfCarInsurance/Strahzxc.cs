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
    public partial class Strahzxc : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=" + System.Environment.MachineName + ";Initial Catalog=CompStrahOfAuto;Integrated Security=True");
        public Strahzxc()
        {
            InitializeComponent();
        }

        private void Strahzxc_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string com = "insert into Сотрудники (Фамилия," +
                    " Имя, Отчество, Пол, Телефон, Login, Password, IdRole) " +
                    "values('" + name.Text + "', '" + fam.Text + "', '" + sname.Text +
                    "', '" + gender.Text + "', '" + phone.Text +
                    "', '" + log.Text + "', '" + pas.Text + "', '1')";

                SqlCommand cmd = new SqlCommand(com, con);

                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception io)
            {
                MessageBox.Show(io.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите создать нового админа.", "Выход", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                try
                {
                    con.Open();
                    string com = "insert into Сотрудники (Фамилия," +
                        " Имя, Отчество, Пол, Телефон, Login, Password, IdRole) " +
                        "values('" + name.Text + "', '" + fam.Text + "', '" + sname.Text +
                        "', '" + gender.Text + "', '" + phone.Text +
                        "', '" + log.Text + "', '" + pas.Text + "', '0')";

                    SqlCommand cmd = new SqlCommand(com, con);

                    MessageBox.Show(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception io)
                {
                    MessageBox.Show(io.Message);
                }
            } 
        }
    }
}
