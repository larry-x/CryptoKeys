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
        }

        FileInteraction fi;
        private string path;

        private void button1_Click(object sender, EventArgs e)
        {
            String password = passwordbox.Text;
            fi.CreateSecret(password);
            Close();
        }
    }
}
