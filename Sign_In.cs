using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Pizza_Ordering_System
{
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
        }

        public MySqlConnection connect_to_database()
        {
            string connStr = "server=157.89.28.130;user=ChangK;database=csc440;port=3306;password=Wallace#409;";

            MySqlConnection conn = new MySqlConnection(connStr);

            return conn;
        }

        private void sign_in_submit_button_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;

            MySqlConnection conn = connect_to_database();

            try
            {
                conn.Open();
                string sql = "SELECT * FROM davis_pizza_user WHERE userName=@username AND password=@password";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    user.set_signed_in(myReader["userName"].ToString());
                    user.set_user_id(int.Parse(myReader["customerID"].ToString()));
                } 
                else
                {
                    MessageBox.Show("Login Credentials do not match what's in the system.", "Login Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }

                myReader.Close();
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

    public static class user
    {
        public static bool is_signed_in = false;
        public static string signed_in = "";
        public static int user_id = 0;

        public static bool El_Diablo = false;
        public static bool Pepperoni = false;
        public static bool Gucci = false;
        public static bool Fish_Pizza = false;
        public static bool Three_Meat = false;

        public static int order_total = 0;

        public static void set_signed_in(string username)
        {
            is_signed_in = true;
            signed_in = username;
        }

        public static void sign_out()
        {
            is_signed_in = false;
            signed_in = null;
        }

        public static string get_signed_in()
        {
            return signed_in;
        }

        public static void add_remove_el_diablo()
        {
            if(El_Diablo)
            {
                El_Diablo = false;
            }
            else
            {
                El_Diablo = true;
            }
        }

        public static void add_remove_pepperoni()
        {
            if (Pepperoni)
            {
                Pepperoni = false;
            }
            else
            {
                Pepperoni = true;
            }
        }

        public static void add_remove_gucci()
        {
            if (Gucci)
            {
                Gucci = false;
            }
            else
            {
                Gucci = true;
            }
        }

        public static void add_remove_fish_pizza()
        {
            if (Fish_Pizza)
            {
                Fish_Pizza = false;
            }
            else
            {
                Fish_Pizza = true;
            }
        }

        public static void add_remove_three_meat()
        {
            if (Three_Meat)
            {
                Three_Meat = false;
            }
            else
            {
                Three_Meat = true;
            }
        }

        public static void set_order_total(int total)
        {
            order_total = total;
        }

        public static void set_user_id(int id)
        {
            user_id = id;
        }
    }
}
