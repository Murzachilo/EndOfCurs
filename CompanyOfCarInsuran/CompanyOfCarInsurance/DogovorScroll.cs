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
    public partial class contracts : Form
    { 

        public contracts()
        {
            InitializeComponent();

        }
        

        SqlConnection con = new SqlConnection(@"Data Source = " + System.Environment.MachineName + "; Initial Catalog = CompStrahOfAuto; Integrated Security = True");
        private void populate()
        {
            con.Open();
            string query = "select [№ договора], [Дата заключения], ДатаОкончания , [Страховая сумма], Сотрудники.Фамилия + ' ' + Сотрудники.Имя as Агент, " + 
            "[Транспортное средство].[Гос номер] + ' ' + [Транспортное средство].Марка + ' ' + [Транспортное средство].Модель as ТС, " +
            "[Лица, допущенных к управлению автотранспортом].Фамилия + ' ' + [Лица, допущенных к управлению автотранспортом].Имя as Водитель, " +
            "КлиентФизЛицо.Фамилия + ' ' + КлиентФизЛицо.Имя as Клиент from Договора " +
            "INNER JOIN Сотрудники ON Договора.[Страховой агент] = Сотрудники.Код " +
            "INNER JOIN [Транспортное средство] ON Договора.ТранспортноеCредство = [Транспортное средство].Код " +
            "INNER JOIN [Лица, допущенных к управлению автотранспортом] ON Договора.Вписанные = [Лица, допущенных к управлению автотранспортом].Код " +
            "INNER JOIN КлиентФизЛицо ON Договора.Клиент = КлиентФизЛицо.Код";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ContractsDGV.DataSource = ds.Tables[0];
            ContractsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();

        }
        private void AddB_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ContractsDGV.SelectedRows)
            {
                ContractsDGV.Rows.Remove(row);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ContractsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu dlg = new Menu();
            dlg.Show(this);
        }
    }
}

