using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace interfaceFromHell
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            congratsButton.Click += new EventHandler(CongratsButton__Click);

        }  
        public void CongratsButton__Click(object sender, EventArgs e)

        {
            string name = nameTextBox.Text;
            name = name.ToUpper();
            name = name.Replace('A', 'B').Replace('E', 'C').Replace('I', 'D');
            congratsLabel.Visible = true;
            congratsLabel.Text = "Congrats " + name + "!!";
        }
    }
}
