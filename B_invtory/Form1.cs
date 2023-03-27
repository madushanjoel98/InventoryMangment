using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_invtory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            acess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product_Frm p = new Product_Frm();
            p.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          // label2.Text = Login_info.user_id.ToString();
        }


        public void acess() {
            switch (Login_info.access_id) { 
                case 1:
                    button1.Visible = false;
                    button2.Visible = false;

                    break;
                case 4:
                   button1.Visible = true;
                   button2.Visible = true;
                   break;
            
            }
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            orders_form order_new = new orders_form();
            order_new.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account_mangment acc_m = new Account_mangment();
            acc_m.Show();

        }
    }
}
