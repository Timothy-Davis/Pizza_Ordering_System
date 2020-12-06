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
        ArrayList OrderIds = new ArrayList();
        String ItemIds = "";
        ArrayList ItemIDNums = new ArrayList();
        ArrayList ItemIDStr = new ArrayList();
        int[] ItemIDNum;
        public OrderHistory()
        {
            InitializeComponent();
            getItemIds();
            getItemValues();


        }
        public OrderHistory(int userNum)
        {
            InitializeComponent();
            userID = userNum;
            getItemIds();
            getItemValues();
            
        }

        public void getItemIds()
        {
            MySqlConnection conn = connect_to_database();

            try
            {
                conn.Open();
                string sql = "SELECT ItemID, orderID FROM davis_order WHERE userID = @userID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userID", userID);


                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    ItemIDStr.Add(myReader["ItemID"].ToString());
                    OrderIds.Add(Int32.Parse(myReader["OrderID"].ToString()));


                }
                else
                {
                    listBox1.Items.Add("No orders for this user were found.");

                }

                myReader.Close();
                


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "***");
                return;
            }



        }

        public void getItemValues()
        {
            ArrayList MenuItemIDS = new ArrayList(); 
            ArrayList ItemNames = new ArrayList();
            //ArrayList ItemDescriptions = new ArrayList();

            MySqlConnection conn = connect_to_database();

            try
            {
                conn.Open();
                string sql = "SELECT * FROM davis_menu_item";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userID", userID);


                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    MenuItemIDS.Add(myReader["itemID"].ToString());
                    ItemNames.Add( myReader["ItemName"].ToString());
                    //ItemDescriptions.Add(myReader["description"].ToString());
                }
                else
                {
                    listBox1.Items.Add("No Items were found for this order.");
                }

                myReader.Close();

                
                for (int i = 0; i < OrderIds.Count; i++)
                {
                    listBox1.Items.Add("Order " + i + 1);
                    

                    for (int j = 0; j < ItemIDStr.Count; j++)
                    {
                        String thing = (string)ItemIDStr[j];
                        String[] StringThing = thing.Split(',');
                        ItemIDNum= new int[StringThing.Length];
                        for (int k = 0; k < StringThing.Length; k++)
                        {
                            ItemIDNum[k] = Int32.Parse(StringThing[k]);
                        }
                    }
                    for (int j = 0; j < ItemIDNum.Length; j++)
                    {
                        for (int k = 0; k < MenuItemIDS.Count; k++)
                        {
                            if (ItemIDNum[j] == Int32.Parse(MenuItemIDS[k].ToString())){
                                listBox1.Items.Add(ItemNames[k]);
                            }
                        }
                        
                    }

                   
                    
                }
                   
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "***");
                return;
            }
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

