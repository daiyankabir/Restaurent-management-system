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
    public partial class Create_Account : Form
    {
        public Create_Account()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                char ch = ' ';
                if (textusername.Text != "")
                {
                    ch = textusername.Text[0];
                }
                if ((textusername.Text == "") || (textpassword.Text == "") ||  (textfirstname.Text == "") || (textaddress.Text == "") || (combotype.SelectedIndex == -1) || (textemail.Text == ""))
                {
                    MessageBox.Show("Fields all are Mandatory");
                }

                else if (!((textemail.Text.Contains("@")) && (textemail.Text.Contains("."))))
                {
                    MessageBox.Show("Invalid E-mail ID");
                }
                else if ((textemail.Text.IndexOf("@")) > (textemail.Text.LastIndexOf(".")))
                {
                    MessageBox.Show("Invalid E-mail ID");
                }
                else if (textusername.Text.Contains(" "))
                {
                    MessageBox.Show("Username Cannot Contain Space");
                }
                else if (!(((Convert.ToInt16(ch) >= 65) && (Convert.ToInt16(ch) <= 90)) || ((Convert.ToInt16(ch) >= 97) && (Convert.ToInt16(ch) <= 122))))
                {
                    MessageBox.Show("Username Must starts with an Alphabet");
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
