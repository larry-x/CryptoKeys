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
    public partial class Retrieve : Form
    {
        public Retrieve(string t, string p)
        {
            tag = t;
            pass = p;
            InitializeComponent();
            showtag.Text = $"Value stored at {tag}:";
            showpass.Text = pass;
        }

        private string tag;
        private string pass;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
