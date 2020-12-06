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
            user.set_order_total(int.Parse(total_label.Text));

            Order_Confirm confirm_order_form = new Order_Confirm();
            confirm_order_form.Show();
        }


        private void menuItem1_CheckedChanged(object sender, EventArgs e)
        {
            if (menuItem1.Checked)
            {
                double new_total = double.Parse((total_label.Text));
                new_total += 10;
                total_label.Text = new_total.ToString();
            }
            else
            {
                double new_total = double.Parse((total_label.Text));
                new_total -= 10;
                total_label.Text = new_total.ToString();
            }

            user.add_remove_el_diablo();
        }

        private void menuItem2_CheckedChanged(object sender, EventArgs e)
        {
            if (menuItem2.Checked)
            {
                double new_total = double.Parse((total_label.Text));
                new_total += 10;
                total_label.Text = new_total.ToString();
            }
            else
            {
                double new_total = double.Parse((total_label.Text));
                new_total -= 10;
                total_label.Text = new_total.ToString();
            }

            user.add_remove_pepperoni();
        }

        private void menuItem3_CheckedChanged(object sender, EventArgs e)
        {
            if (menuItem3.Checked)
            {
                double new_total = double.Parse((total_label.Text));
                new_total += 10000;
                total_label.Text = new_total.ToString();
            }
            else
            {
                double new_total = double.Parse((total_label.Text));
                new_total -= 10000;
                total_label.Text = new_total.ToString();
            }

            user.add_remove_gucci();
        }

        private void menuItem4_CheckedChanged(object sender, EventArgs e)
        {
            if (menuItem4.Checked)
            {
                double new_total = double.Parse((total_label.Text));
                new_total += 2;
                total_label.Text = new_total.ToString();
            }
            else
            {
                double new_total = double.Parse((total_label.Text));
                new_total -= 2;
                total_label.Text = new_total.ToString();
            }

            user.add_remove_fish_pizza();
        }

        private void menuItem5_CheckedChanged(object sender, EventArgs e)
        {
            if (menuItem5.Checked)
            {
                double new_total = double.Parse((total_label.Text));
                new_total += 10;
                total_label.Text = new_total.ToString();
            }
            else
            {
                double new_total = double.Parse((total_label.Text));
                new_total -= 10;
                total_label.Text = new_total.ToString();
            }

            user.add_remove_three_meat();
        }
    }
}
