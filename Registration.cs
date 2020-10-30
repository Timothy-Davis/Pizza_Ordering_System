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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void registration_submit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please ensure that the information is entered accurately", "Submission Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
