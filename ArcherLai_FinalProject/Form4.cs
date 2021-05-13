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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            submitButton.Click += new EventHandler(SubmitButton__Click);
            homeButton.Click += new EventHandler(HomeButton__Click);
            matchButton.Click += new EventHandler(MatchButton__Click);
            //Allie Maus
            //disabled profile button so that another profile form isn't displayed while on the profile page
            profileButton.Enabled = false;

        }

        private void SubmitButton__Click(object sender, EventArgs e)
        {

            Form2 oFrm2 = new Form2();
            oFrm2.Show();
        }
        //Allie Maus
        //Added these
        private void HomeButton__Click(object sender, EventArgs e)
        {
            Form2 oFrm2 = new Form2();
            oFrm2.Show();
        }
        //Allie Maus
        //Added these
        private void MatchButton__Click(object sender, EventArgs e)
        {
            Form3 oFrm3 = new Form3();
            oFrm3.Show();
        }
    }
}
