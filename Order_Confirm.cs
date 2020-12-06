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
    public partial class Order_Confirm : Form
    {
        public MySqlConnection connect_to_database()
        {
            string connStr = "server=157.89.28.130;user=ChangK;database=csc440;port=3306;password=Wallace#409;";

            MySqlConnection conn = new MySqlConnection(connStr);

            return conn;
        }

        public Order_Confirm()
        {
            InitializeComponent();

            // Add order info to the text box
            if(user.El_Diablo)
            {
                order_info.Text += "El Diablo Pizza \n";
            }

            if (user.Pepperoni)
            {
                order_info.Text += "Pepperoni Pizza \n";
            }

            if (user.Gucci)
            {
                order_info.Text += "Gucci Pizza \n";
            }

            if (user.Fish_Pizza)
            {
                order_info.Text += "Salty Fish Pizza \n";
            }

            if (user.Three_Meat)
            {
                order_info.Text += "Three Mean Pizza \n";
            }

            // Grab the subtotal from the user class
            subtotal_label.Text = "Subtotal: $" + user.order_total.ToString();

            // If the user is logged in, autofill the information we can
            if(user.is_signed_in)
            {

            }
        }

        private void log_in_button_Click(object sender, EventArgs e)
        {
            Mid_Order_Sign_in mid_order_sign_in = new Mid_Order_Sign_in();
            mid_order_sign_in.Show();
        }

        private void checkout_button_Click(object sender, EventArgs e)
        {
            Finalize_Order finalize_order_form = new Finalize_Order();
            finalize_order_form.Show();
        }

        private void go_back_button_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
