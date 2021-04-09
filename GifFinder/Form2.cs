using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GifFinder
{
    public partial class SearchForm : Form
    {

        public string response;
        public string searchTerm;
        public int maxItems;

        public SearchForm()
        {
            InitializeComponent();

            this.maxItemstextBox.KeyPress += new KeyPressEventHandler(MaxItemstextBox__KeyPress);
            this.okButton.Click += new EventHandler(OkButton__Click);
            this.cancelButton.Click += new EventHandler(CancelButton__Click);
        }

        private void MaxItemstextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if(Char.IsDigit(e.KeyChar)|| e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        private void OkButton__Click(object sender, EventArgs e)
        {
            this.response = "OK";

            this.searchTerm = searchItemTextBox.Text;
            maxItems = Convert.ToInt32(maxItemstextBox.Text);
            this.Hide();
        }

        private void CancelButton__Click(object sender, EventArgs e)
        {
            this.response = "Cancel";
            this.Hide();
        }

    }
}
