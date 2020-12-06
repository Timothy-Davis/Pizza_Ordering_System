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
    public partial class Finalize_Order : Form
    {
        public MySqlConnection connect_to_database()
        {
            string connStr = "server=157.89.28.130;user=ChangK;database=csc440;port=3306;password=Wallace#409;";

            MySqlConnection conn = new MySqlConnection(connStr);

            return conn;
        }

        public Finalize_Order()
        {
            InitializeComponent();

            // Add order info to the text box
            if (user.El_Diablo)
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
                order_info.Text += "Three Meat Pizza \n";
            }

            // Grab the subtotal from the user class
            subtotal_label.Text = "Subtotal: $" + user.order_total.ToString();

            total_label.Text = "Grand Total: $" + (user.order_total*1.06).ToString();
        }

        private void place_order_button_Click(object sender, EventArgs e)
        {
            string itemID = "";
            if(user.El_Diablo)
            {
                itemID += "1,";
            }    

            if(user.Pepperoni)
            {
                itemID += "2,";
            }

            if(user.Gucci)
            {
                itemID += "3,";
            }

            if(user.Fish_Pizza)
            {
                itemID += "4,";
            }

            if(user.Three_Meat)
            {
                itemID += "5,";
            }

            itemID = itemID.Substring(0, itemID.Length - 1);

            MySqlConnection conn = connect_to_database();

            try
            {
                conn.Open();
                string sql = "INSERT INTO davis_order (userID, itemID) VALUES (@userID, @itemID)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userID", user.user_id);
                cmd.Parameters.AddWithValue("@itemID", itemID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            MessageBox.Show("Thank for for your order!", "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
