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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            tx7.ReadOnly = true;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GF9UMVM;Initial Catalog=CompStrahOfAuto;Integrated Security=True");
        bool fizlic = true;
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client dlg = new Client();
            dlg.Show(this);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            car dlg = new car();
            dlg.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Writtens dlg = new Writtens();
            dlg.Show(this);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fizlic == true)
            {
                try
                {
                    con.Open();
                    string com = "insert into Договора ([№ договора], [Дата заключения]," +
                        " [Страховая сумма], [Страховой агент], [Транспортное средство]," +
                        " Клиент, ДатаОкончания, Вписанные) values('" + tx1.Text +
                        "', '" + date1.Value.Date.ToString() + "', '" + tx2.Text + "', '" + tx3.Text +
                        "', '" + tx4.Text + "', '" + tx5.Text + "', '" + date2.Value.Date.ToString() +
                        "', '" + tx6.Text + "')";

                    SqlCommand cmd = new SqlCommand(com, con);

                    MessageBox.Show(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Договор успешно создан");
                }
                catch (Exception io)
                {
                    MessageBox.Show("Упс.... Кажется вы где-то ошиблись");
                    MessageBox.Show(io.Message);
                    con.Close();
                }
            }
            else {
                try
                {
                    con.Open();
                    string com = "insert into Договора ([№ договора], [Дата заключения]," +
                        " [Страховая сумма], [Страховой агент], [Транспортное средство]," +
                        " ДатаОкончания, Вписанные, КлиентЮрЛицо) values('" + tx1.Text +
                        "', '" + date1.Value.Date.ToString() + "', '" + tx2.Text + "', '" + tx3.Text +
                        "', '" + tx4.Text + "', '" + date2.Value.Date.ToString() +
                        "', '" + tx6.Text + "', '" + tx7.Text + "')";

                    SqlCommand cmd = new SqlCommand(com, con);

                    MessageBox.Show(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Договор успешно создан");
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
                tx5.ReadOnly = true;
                tx7.ReadOnly = false;
                fizlic = false;
            }
            else
            {
                tx5.ReadOnly = false;
                tx7.ReadOnly = true;
                fizlic = false;
            }
        }
    }
}
