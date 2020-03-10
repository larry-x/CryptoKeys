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
    public partial class Delete : Form
    {
        public Delete(string t, FileInteraction f)
        {
            tag = t;
            fi = f;
            InitializeComponent();
            showtag.Text = $"Are you sure you want to delete the tag and key:\n{tag}?";
        }

        private string tag;
        private FileInteraction fi;

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> copy = fi.CopyPage();
            copy.Remove(copy.Find(x => x.StartsWith(tag + "¦")));
            fi.Recreate(copy);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
