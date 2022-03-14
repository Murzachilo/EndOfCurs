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
    public partial class adminMenu : Form
    {
        public adminMenu()
        {
            InitializeComponent();
        }

        private void NewCadr_Click(object sender, EventArgs e)
        {
            Strahzxc dlg = new Strahzxc();
            dlg.Show(this);
        }

        private void adminMenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void First_Click(object sender, EventArgs e)
        {
            
            Dogovor dlg = new Dogovor();
            dlg.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            contracts dlg = new contracts();
            dlg.Show(this);
        }
    }
}
