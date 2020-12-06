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
            getOrderIDS();
            listBox1.Items.Add("Chicken Shit");

        }
        public OrderHistory(int userNum)
        {
            InitializeComponent();
            userID = userNum;
            getOrderIDS();
            listBox1.Items.Add("Chicken Shit");
        }

        public void getOrderIDS()
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
                    listBox1.Items.Add("No orders for this user were found.");
                    
                }
                for (int i = 0; i < ItemIDS.Count; i++)
                {
                    listBox1.Items.Add(ItemIDS[i]);
                }
                myReader.Close();
                
                Console.WriteLine("Yeet");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "***");
                return;
            }

            for (int i = 0; i < ItemIDS.Count; i++)
            {
                //listBox1.Text = ItemIDS[i].ToString();
            }
            

            return;
        }

        public MySqlConnection connect_to_database()
        {
            string connStr = "server=157.89.28.130;user=ChangK;database=csc440;port=3306;password=Wallace#409;";

            MySqlConnection conn = new MySqlConnection(connStr);

            return conn;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            
        }

        
        
    }
}

