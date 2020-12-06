using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pizza_Ordering_System
{
    public partial class Registration : Form
    {
        public MySqlConnection connect_to_database()
        {
            string connStr = "server=157.89.28.130;user=ChangK;database=csc440;port=3306;password=Wallace#409;";

            MySqlConnection conn = new MySqlConnection(connStr);

            return conn;
        }

        public Registration()
        {
            InitializeComponent();
        }

        private void registration_submit_button_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text != verifyPasswordBox.Text)
            {
                MessageBox.Show("The passwords you entered do not match.", "Submission Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string password = passwordBox.Text;
            string address = addressBox.Text + ", " + cityBox.Text + ", " + stateBox.Text + " " + zipBox;
            string phoneNumber = phoneNumberBox.Text;
            string email = emailBox.Text;
            string username = usernameTextBox.Text;
            string cc_num = creditCardNumBox.Text;
            string cc_exp = creditCardExpBox.Text;
            string cc_cvc = CreditCardCVCbox.Text;

            MySqlConnection conn = connect_to_database();

            try
            {
                conn.Open();
                string sql = "INSERT INTO davis_pizza_user (userName, password, address, phone, userEmail, ) " +
                    "VALUES (@username, @password, @address, @phone, @email, @cc_num, @cc_exp, @cc_cvc)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phoneNumber);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@cc_num", cc_num);
                cmd.Parameters.AddWithValue("@cc_exp", cc_exp);
                cmd.Parameters.AddWithValue("@cc_cvc", cc_cvc);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please ensure that the information is entered accurately", "Submission Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Form.ActiveForm.Close();
            return;
        }


    }
}
