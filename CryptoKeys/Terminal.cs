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
    public partial class Terminal : Form
    {
        public Terminal(FileInteraction f)
        {
            fi = f;
            InitializeComponent();
            Refresh_Screen();
        }

        private FileInteraction fi;
        public Dictionary<string,string> Items { get; private set; }
        private string[] tags;
        private BindingSource bs = new BindingSource();

        private void Refresh_Screen()
        {
            Items = fi.GetItems();
            tags = Items.Keys.ToArray();
            allitems.Items.Clear();
            allitems.Items.AddRange(tags);
            Disable_buttons();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Add a = new Add(fi, tags);
            a.ShowDialog();
            a.Dispose();
            Refresh_Screen();
        }

        private void generate_Click(object sender, EventArgs e)
        {

        }

        private void readme_Click(object sender, EventArgs e)
        {
            Read read = new Read();
            read.ShowDialog();
            read.Dispose();
        }

        private void retrieve_Click(object sender, EventArgs e)
        {
            if(allitems.SelectedItem == null)
            {
                MessageBox.Show("You haven't selected anything");
            }
            else
            {
                string tag = allitems.SelectedItem.ToString();
                Retrieve r = new Retrieve(tag, Items[tag]);
                r.ShowDialog();
                r.Dispose();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (allitems.SelectedItem == null)
            {
                MessageBox.Show("You haven't selected anything");
            }
            else
            {
                string tag = allitems.SelectedItem.ToString();
                Edit ed = new Edit(tag, Items[tag], fi);
                ed.ShowDialog();
                ed.Dispose();
                Refresh_Screen();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (allitems.SelectedItem == null)
            {
                MessageBox.Show("You haven't selected anything");
            }
            else
            {
                Delete d = new Delete(allitems.SelectedItem.ToString(), fi);
                d.ShowDialog();
                d.Dispose();
                Refresh_Screen();
            }
        }

        private void Disable_buttons()
        {
            retrieve.Enabled = false;
            edit.Enabled = false;
            delete.Enabled = false;
        }

        private void Enable_buttons(object sender, EventArgs e)
        {
            retrieve.Enabled = true;
            edit.Enabled = true;
            delete.Enabled = true;
        }

        private void leave_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }

}
