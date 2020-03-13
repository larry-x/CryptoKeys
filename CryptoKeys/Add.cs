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
            newtag.Select();
        }

        private FileInteraction fi;
        private string[] tags;

        private void Special_char(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '¦')
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Return)
            {
                save_Click(sender, e);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            newtag.Text = newtag.Text.Replace("¦", string.Empty);
            newpass.Text = newpass.Text.Replace("¦", string.Empty);

            if (tags.Contains(newtag.Text))
            {
                MessageBox.Show("This tag already exists. Give it a different name.");
            }
            else if(string.IsNullOrEmpty(newtag.Text))
            {
                MessageBox.Show("Please do not leave tag blank.");
            }
            else
            {
                string entry = newtag.Text + "¦" + newpass.Text;
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
