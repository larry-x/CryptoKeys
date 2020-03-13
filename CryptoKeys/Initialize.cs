using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CryptoKeys
{
    public partial class Initialize : Form
    {
        public Initialize(FileInteraction f)
        {
            fi = f;
            path = Path.Combine(Environment.CurrentDirectory, "secret.txt");
            InitializeComponent();
            passwordbox.Select();
        }

        FileInteraction fi;
        private string path;

        private void button1_Click(object sender, EventArgs e)
        {
            passwordbox.Text = Remove_Chars(passwordbox.Text);

            if(string.IsNullOrEmpty(passwordbox.Text))
            {
                MessageBox.Show("The password box is blank.");
            }
            else
            {
                fi.CreateSecret(passwordbox.Text);
                Close();
            }
        }

        private string Remove_Chars(string sample)
        {
            sample = sample.Replace(" ", string.Empty);
            sample = sample.Replace("¦", string.Empty);
            return sample;
        }

        private void Special_chars(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '¦' || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
