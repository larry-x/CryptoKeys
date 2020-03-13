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
    public partial class Generate : Form
    {
        public Generate(FileInteraction f, string[] t)
        {
            fi = f;
            tags = t;
            InitializeComponent();
            seedbox.Select();
        }

        private FileInteraction fi;
        private string[] tags;

        private void gseed_Click(object sender, EventArgs e)
        {
            hashbox.Text = fi.SeedKeys(seedbox.Text);
            tagbox.Enabled = true;
        }

        private void gsave_Click(object sender, EventArgs e)
        {
            tagbox.Text = tagbox.Text.Replace("¦", string.Empty);
            hashbox.Text = hashbox.Text.Replace("¦", string.Empty);

            if (string.IsNullOrEmpty(hashbox.Text))
            {
                MessageBox.Show("First generate a password from seed.");
            }
            else if(string.IsNullOrEmpty(tagbox.Text))
            {
                MessageBox.Show("Give a tag for this password.");
            }
            else if (tags.Contains(tagbox.Text))
            {
                MessageBox.Show("This tag already exists. Name it something different.");
            }
            else
            {
                string entry = tagbox.Text + "¦" + hashbox.Text;
                fi.Entry(entry);
                Close();
            }
        }

        private void gok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
