using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Ordering_System
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void menuItem1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cancel_order_button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel your order?", "Cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                ActiveForm.Close();
            }
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            Order_Confirm confirm_order_form = new Order_Confirm();
            confirm_order_form.Show();
        }
    }
}
