using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoKeys
{
    public partial class Add : Form
    {
        public Add(FileInteraction f, string[] t)
        {
            fi = f;
            tags = t;
            InitializeComponent();
        }

        private FileInteraction fi;
        private string[] tags;

        private void Special_char(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '¦')
            {
                e.Handled = true;
            }
        }

        private string Remove_char(string s)
        {
            s = s.Replace("¦", string.Empty);
            return s;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if(tags.Contains(newtag.Text))
            {
                MessageBox.Show("You cannot have two identical tags.");
            }
            else if(string.IsNullOrEmpty(newtag.Text))
            {
                MessageBox.Show("Please do not leave tag blank.");
            }
            else
            {
                string entry = Remove_char(newtag.Text) + "¦" + Remove_char(newpass.Text);
                fi.Entry(entry);
                Close();
            }
            
        }

        private void canceladd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
