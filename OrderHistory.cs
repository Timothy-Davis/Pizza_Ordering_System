using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;
namespace Pizza_Ordering_System
{
    public partial class OrderHistory : Form
    {
        public int userID = -1;
        ArrayList ItemIDS = new ArrayList();
        public OrderHistory()
        {
            InitializeComponent();
        }
        public OrderHistory(int userNum)
        {
            InitializeComponent();
            userID = userNum;
        }
        public MySqlConnection connect_to_database()
        {
            string connStr = "server=157.89.28.130;user=ChangK;database=csc440;port=3306;password=Wallace#409;";

            MySqlConnection conn = new MySqlConnection(connStr);

            return conn;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            MySqlConnection conn = connect_to_database();

            try
            {
                conn.Open();
                string sql = "SELECT * FROM davis_order WHERE userID = @userID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userID", userID);


                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    ItemIDS.Add(myReader["ItemID"]);
                }
                else
                {
                    listBox1.Text = "No orders for this user were found.";
                    return;
                }

                myReader.Close();
                for (int i = 0; i < ItemIDS.Count; i++)
                {
                    Console.WriteLine(ItemIDS[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "***");
                return;
            }

            Main_Menu main_menu_form = new Main_Menu();
            ActiveForm.Hide();
            main_menu_form.Show();

            return;
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            Registration register_form = new Registration();
            register_form.Show();
        }

        private void skip_button_Click(object sender, EventArgs e)
        {
            Main_Menu main_menu_form = new Main_Menu();
            ActiveForm.Hide();
            main_menu_form.Show();
        }
    }
}
}
