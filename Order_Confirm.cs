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
    public partial class Order_Confirm : Form
    {
        public Order_Confirm()
        {
            InitializeComponent();
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
    }
}
