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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            listBox1.Visible = false;
            button1.Click += new EventHandler(Button1__Click);
            //Allie Maus 
            //disabled this so that another match form doesn't show while on match page
            matchButton.Enabled = false;
            //Allie Maus
            //added these 
            homeButton.Click += new EventHandler(HomeButton__Click);
            profileButton.Click += new EventHandler(ProfileButton__Click);
            //Allie Maus
            //made this nonvisible until match button is clicked (hard coded data/values)
            roommateActive.Visible = false;
            roommateAge.Visible = false;
            roommateBed.Visible = false;
            roommateEmail.Visible = false;
            roommateGender.Visible = false;
            roommateGenderPref.Visible = false;
            roommateGuests.Visible = false;
            roommateHobbies1.Visible = false;
            roommateHobbies2.Visible = false;
            roommateMajor.Visible = false;
            roommateName.Visible = false;
            roommatePets.Visible = false;
            roommateStudy.Visible = false;
            roommateWakeUp.Visible = false;
            roommateYear.Visible = false;
            roommatePictureBox.Visible = false;
            compatibilityScore.Visible = false;
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void Button1__Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            //Allie Maus
            //made this visible once match button is clicked
            roommateActive.Visible = true;
            roommateAge.Visible = true;
            roommateBed.Visible = true;
            roommateEmail.Visible = true;
            roommateGender.Visible = true;
            roommateGenderPref.Visible = true;
            roommateGuests.Visible = true;
            roommateHobbies1.Visible = true;
            roommateHobbies2.Visible = true;
            roommateMajor.Visible = true;
            roommateName.Visible = true;
            roommatePets.Visible = true;
            roommateWakeUp.Visible = true;
            roommateYear.Visible = true;
            roommatePictureBox.Visible = true;
            compatibilityScore.Visible = true;
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
        private void ProfileButton__Click(object sender, EventArgs e)
        {
            Form4 oFrm4 = new Form4();
            oFrm4.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
