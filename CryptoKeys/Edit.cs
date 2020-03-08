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
    public partial class Edit : Form
    {
        public Edit(string t, string p, FileInteraction f)
        {
            tag = t;
            pass = p;
            fi = f;
            InitializeComponent();
            showtag.Text = $"Change key stored at {tag}:";
        }

        private string tag;
        private string pass;
        private FileInteraction fi;

        private void button2_Click(object sender, EventArgs e)
        {
            string entry = tag + "|" + Remove_char(showpass.Text);
            Repopulate(entry);
            Close();
        }

        private void Special_char(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '|' || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private string Remove_char(string s)
        {
            s = s.Replace("|", string.Empty);
            s = s.Replace(" ", string.Empty);
            return s;
        }

        private void Repopulate(string newentry)
        {
            List<string> copy = fi.CopyPage();
            int i = copy.FindIndex(x => x.StartsWith(tag + "|"));
            copy[i] = newentry;
            fi.Recreate(copy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
