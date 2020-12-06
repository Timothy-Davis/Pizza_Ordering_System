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
    public partial class Finalize_Order : Form
    {
        public Finalize_Order()
        {
            InitializeComponent();
        }

        private void place_order_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank for for your order!", "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
