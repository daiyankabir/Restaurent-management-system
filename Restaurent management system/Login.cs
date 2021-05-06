using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurent_management_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

        }

        private void btnaccount_Click(object sender, EventArgs e)
        {
            Create_Account ca = new Create_Account();
            ca.Show();
            this.Hide();
        }
    }
}
