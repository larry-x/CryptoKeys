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
    public partial class Open : Form
    {
        public Open(FileInteraction f)
        {
            fi = f;
            InitializeComponent();
        }

        FileInteraction fi;
        private string passtry;

        private void Form1_Load(object sender, EventArgs e)
        {
            string welcome = "Welcome to CryptoKeyz password tracker application! " +
                    "Please note that by using this software you are agreeing to take " +
                    "full responsibility for any loss of data or damage to self or property. " +
                    "\nFor more information refer to the README. \n\n";
            if (!File.Exists(fi.FPath))
            {
                MessageBox.Show(welcome);
                Initialize ini = new Initialize(fi);
                ini.ShowDialog();
                ini.Dispose();
            }
        }

        private void Unlock()
        {
            string match = fi.Login();

            if(passtry == match)
            {
                Terminal tm = new Terminal(fi);
                Hide();
                tm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Password incorrect");
                passinput.Clear();
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            passtry = passinput.Text;
            Unlock();
        }

        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ButtonClick(sender, e);
            }
        }
    }
}
