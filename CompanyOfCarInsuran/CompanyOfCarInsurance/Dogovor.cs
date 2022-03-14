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
    public partial class Dogovor : Form
    {

        public Dogovor()
        {
            InitializeComponent();
            
            clientComvo.Enabled = false;
            clientBoxer.Enabled = true;
            fizlic = true;
        }
        SqlConnection con = new SqlConnection(@"Data Source=" + System.Environment.MachineName + ";Initial Catalog=CompStrahOfAuto;Integrated Security=True");
        bool fizlic = true;

        private void sotrudnikCombo() {
            con.Open();
            string query = "select Код, Фамилия + ' ' + Имя + ' ' + Отчество as ФИО from Сотрудники";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Код", typeof(string));
            dt.Columns.Add("ФИО", typeof(string));
            
            dt.Load(rdr);
            agentvox.ValueMember = "Код"; 
            agentvox.DisplayMember = "ФИО";
            agentvox.DataSource = dt;
            con.Close();

        
        }

        private void carCombo()
        {
            con.Open();
            string query = "select Код, [Гос номер] + ' ' + Марка + ' ' + Модель as info from  [Транспортное средство]";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Код", typeof(string));
            dt.Columns.Add("info", typeof(string));

            dt.Load(rdr);
            carbox.ValueMember = "Код";
            carbox.DisplayMember = "info";
            carbox.DataSource = dt;
            con.Close();


        }
        private void clientCombo()
        {
            con.Open();
            string query = "select Код, Фамилия + ' ' + Имя + ' ' + Отчество as ФИО from КлиентФизЛицо";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Код", typeof(string));
            dt.Columns.Add("ФИО", typeof(string));

            dt.Load(rdr);
            clientBoxer.ValueMember = "Код";
            clientBoxer.DisplayMember = "ФИО";
            clientBoxer.DataSource = dt;
            con.Close();
        }
        private void driversCombo()
        {
            con.Open();
            string query = "select Код, Фамилия + ' ' + Имя + ' ' + Отчество as ФИО from [Лица, допущенных к управлению автотранспортом]";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Код", typeof(string));
            dt.Columns.Add("ФИО", typeof(string));

            dt.Load(rdr);
            driversR.ValueMember = "Код";
            driversR.DisplayMember = "ФИО";
            driversR.DataSource = dt;
            con.Close();
        }
        private void client2Combo()
        {
            con.Open();
            string query = "select Код, Фамилия + ' ' + Имя + ' ' + Отчество + ' ' + [Наименование компании] as ФИО from КлиентЮрЛицо";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Код", typeof(string));
            dt.Columns.Add("ФИО", typeof(string));

            dt.Load(rdr);
            clientComvo.ValueMember = "Код";
            clientComvo.DisplayMember = "ФИО";
            clientComvo.DataSource = dt;
            con.Close();
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

            sotrudnikCombo();
            carCombo();
            clientCombo();
            driversCombo();
            client2Combo();
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
                        "', '" + date1.Value.Date.ToString() + "', '" + tx2.Text + "', '" + agentvox.SelectedValue.ToString() +
                        "', '" + carbox.SelectedValue.ToString() + "', '" + clientBoxer.SelectedValue.ToString() + "', '"
                        + date2.Value.Date.ToString() + "', '" + driversR.SelectedValue.ToString() + "')";

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
                        "', '" + date1.Value.Date.ToString() + "', '" + tx2.Text + "', '" + agentvox.SelectedValue.ToString() +
                        "', '" + carbox.SelectedValue.ToString() +  "', '"
                        + date2.Value.Date.ToString() + "', '" + driversR.SelectedValue.ToString() + "', '" + clientComvo.SelectedValue.ToString() + "')";


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
                clientComvo.Enabled = true;
                clientBoxer.Enabled = false;
                fizlic = false;
            }
            else
            {
                clientComvo.Enabled = false;
                clientBoxer.Enabled = true;
                fizlic = true;
            }
        }

        

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        

        

        

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu dlg = new Menu();
            dlg.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sotrudnikCombo();
            carCombo();
            clientCombo();
            driversCombo();
            client2Combo();
        }
    }
}
