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
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
        }

        private void sign_in_submit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Credentials do not match what's in the system.", "Login Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
