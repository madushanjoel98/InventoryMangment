using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_invtory.database;

namespace B_invtory
{
    public partial class Account_mangment : Form
    {
        Accounts_DB ac_db = new Accounts_DB();
        public Account_mangment()
        {
            InitializeComponent();
        }

        private void Account_mangment_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy/MM";
            dateTimePicker2.CustomFormat = "yyyy";
           // dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.ShowUpDown = true;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int month = (int) dateTimePicker1.Value.Month;
            int year = (int)dateTimePicker1.Value.Year;

            double income = ac_db.monthly_income(month,year);
            tt_o.Text = ac_db.order_count(month, year).ToString();
            sold_it.Text = ac_db.sold_item(month, year).ToString();
            income_lbl.Text = income.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
