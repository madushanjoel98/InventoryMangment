using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_invtory.databse;

namespace B_invtory
{
    public partial class Login : Form
    {

       Products_DB logDb = new Products_DB();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//login
            if (login_vali() == true)
            {

                bool login = logDb.admin_login(l_email.Text.ToString(), passwor_login.Text.ToString());
                if (login == true)
                {
                   // Login_info.email = l_email.Text;
                    clear_inputs(1);
                    Form1 form_run = new Form1();
                    form_run.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("Unable to login ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // clear_inputs(1);
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Sign up
            if (signup_vali())
            {
                bool insert = logDb.insert_admin(reg_email.Text, reg_emp.Text, reg_pass.Text);
                if (insert == true)
                {
                    MessageBox.Show("Registered", "Success");
                    l_email.Text = reg_email.Text;
                    clear_inputs(2);
                   

                }
                else {
 MessageBox.Show("Unable to Register. Please check the values", "Error:Unable to Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private  bool login_vali() {
            bool res = true;
            if (l_email.Text.Length ==0|| passwor_login.Text.Length == 0 ) {
                MessageBox.Show("Unable to login check the values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            return res;
        }

        private bool signup_vali()
        {
            bool res = true;
            if (reg_email.Text.Length == 0 || reg_pass.Text.Length==0 || reg_emp.Text.Length==0)
            {
                MessageBox.Show("Unable to Register. Please check the values", "Error:Unable to Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }else
                if (reg_pass.Text.Length < 8)
                {
                    MessageBox.Show("Password is very short", "Error:Unable to Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    res = false;
                }else
            if ( reg_pass.Text!=conf_pass.Text)
            {
                MessageBox.Show("Confrim Password is wrong", "Error:Unable to Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            
            return res;
        }

        private void clear_inputs(int function_id) {
            if (function_id == 1) {
                //function_id stand for login
                l_email.Text = "";
                passwor_login.Text = "";

            }
            else
                if (function_id == 2)
                {
                    //function_id stand for Register/signup
                    reg_email.Text = "";
                    reg_emp.Text = "";
                    reg_pass.Text = "";
                    conf_pass.Text = "";

                }
                else {
                    Console.WriteLine("invalid clear function");
                }
        
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    
    }
}
