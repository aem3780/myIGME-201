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
    public partial class TigerMatch : Form
    {
        public TigerMatch()
        {
            InitializeComponent();
            okButton.Click += new EventHandler(OkButton__Click);

            //Allie Maus
            //Renamed these so that they were easier to identify and set enabled to false so that 
            //users don't have access without loging in 
            homeButton.Enabled = false;
            profileButton.Enabled = false;
            matchButton.Enabled = false;



        }

        private void OkButton__Click(object sender, EventArgs e)
        {
            //allie maus
            //when ok button is clicked it checks to make sure an rit email was entered and that the password isnt empty
            //before allowing the user to log in
            string user = licText.Text;
            string password = passwordText.Text;
            string substring = "@rit.edu";

            if(user.Contains(substring)== true)
            {
                if(password != "")
                {
                    Form4 oFrm4 = new Form4();
                    oFrm4.Show();
                }
            }


            
        }
    }
}
