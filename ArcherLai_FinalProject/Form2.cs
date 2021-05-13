using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcherLai_FinalProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            homeOkButton.Visible = false;
            single.CheckedChanged += new EventHandler(Single__CheckedChanged);
            standard.CheckedChanged += new EventHandler(Standard__CheckedChanged);
            triple.CheckedChanged += new EventHandler(Triple__CheckedChanged);
            radioButton1.CheckedChanged += new EventHandler(RadioButton1__CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(RadioButton2__CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(RadioButton3__CheckedChanged);
            homeOkButton.Click += new EventHandler(HomeOkButton__Click);
            //Allie Maus
            //disabled home so that another home form doesn't pop up while on the home page
            homeButton.Enabled = false;
            //Allie Maus
            //Added these
            matchButton.Click += new EventHandler(MatchButton__Click);
            profileButton.Click += new EventHandler(ProfileButton__Click);
        }

        private void RadioButton1__CheckedChanged(object sender, EventArgs e)
        {
            greenWood.Text = "Greenwood Cove";
            theHill.Text = "The hill";
            theLodge.Text = "The lodge";
        }

        private void RadioButton2__CheckedChanged(object sender, EventArgs e)
        {
            greenWood.Text = "House 1";
            theHill.Text = "House 3";
            theLodge.Text = "House 2";
        }

        private void RadioButton3__CheckedChanged(object sender, EventArgs e)
        {
            greenWood.Text = "Sol Heumann Hall";
            theHill.Text = "Helen Fish Hall";
            theLodge.Text = "Mark Ellingson Hall";
        }

        private void HomeOkButton__Click(object sender, EventArgs e)
        {
            Form3 oFrm3 = new Form3();
            oFrm3.Show();

        }

        private void Single__CheckedChanged(object sender, EventArgs e)
        {
            homeOkButton.Visible = true;
        }

        private void Standard__CheckedChanged(object sender, EventArgs e)
        {
            homeOkButton.Visible = true;
        }

        private void Triple__CheckedChanged(object sender, EventArgs e)
        {
            homeOkButton.Visible = true;
        }

        //Allie Maus
        //Added these
        private void MatchButton__Click(object sender, EventArgs e)
        {
            Form3 oFrm3 = new Form3();
            oFrm3.Show();
        }

        //Allie Maus
        //Added these
        private void ProfileButton__Click(object sender, EventArgs e)
        {
            Form4 oFrm4 = new Form4();
            oFrm4.Show();
        }



    }
}
