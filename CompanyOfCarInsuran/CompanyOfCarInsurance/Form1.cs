
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompanyOfCarInsurance
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Застраховать_Click(object sender, EventArgs e)
        {
            Form3 dlg = new Form3();
            dlg.Show(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "compStrahOfAutoDataSet.Договора". При необходимости она может быть перемещена или удалена.
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            dlg.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
