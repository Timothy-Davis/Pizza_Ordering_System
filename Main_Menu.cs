using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pizza_Ordering_System
{
    public partial class Main_Menu : Form
    {

        public MySqlConnection connect_to_database()
        {
            string connStr = "server=157.89.28.130;user=ChangK;database=csc440;port=3306;password=Wallace#409;";

            MySqlConnection conn = new MySqlConnection(connStr);

            return conn;
        }

        public Main_Menu()
        {
            InitializeComponent();
            signinLabel.Text = user.get_signed_in().ToString();
        }



        private void create_order_button_Click(object sender, EventArgs e)
        {
            Order order_form = new Order();
            order_form.Show();
        }

        

        private void view_orders_bttn_Click(object sender, EventArgs e)
        {
            Form orderHistory = new OrderHistory();
            orderHistory.Show();
        }

        private void logout_bttn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes){
                user.sign_out();
                Form login = new Sign_In();
                login.Show();
                this.Close();
            }
        }
    }
}
