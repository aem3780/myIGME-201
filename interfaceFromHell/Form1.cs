using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceFromHell
{
    public partial class AnimalForm : Form
    {
        public int score = 0;
        public AnimalForm()
        {
            InitializeComponent();

            exitButton.Click += new EventHandler(ExitButton__Click);
            guessButton.Click += new EventHandler(GuessButton__Click);
            pigRadioButton.CheckedChanged += new EventHandler(PigRadioButton__CheckedChanged);
            zebraRadioButton.CheckedChanged += new EventHandler(ZebraRadioButton__CheckedChanged);
            dogRadioButton.CheckedChanged += new EventHandler(DogRadioButton__CheckedChanged);
            colorChangeCheckBox.CheckedChanged += new EventHandler(ColorChangeCheckBox__CheckedChanged);

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;


        }

        public void ColorChangeCheckBox__CheckedChanged(object sender, EventArgs e) {
            
            if(colorChangeCheckBox.Checked == true)
            {
                label1.BackColor = Color.Red;
                label2.BackColor = Color.Orange;
                label3.BackColor = Color.Yellow;
                label4.BackColor = Color.Green;
                label5.BackColor = Color.Blue;
                label6.BackColor = Color.Purple;
                label7.BackColor = Color.Pink;
            }
            else
            {
                label1.BackColor = Color.Orange;
                label2.BackColor = Color.Transparent;
                label3.BackColor = Color.Green;
                label4.BackColor = Color.Pink;
                label5.BackColor = Color.Transparent;
                label6.BackColor = Color.Transparent;
                label7.BackColor = Color.Transparent;
            }

        }
        public void GuessButton__Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            if (zebraRadioButton.Checked == false)
            {
                label1.Text = "WRONG ANSWER";
                label2.Text = "WRONG ANSWER";
                label3.Text = "WRONG ANSWER";
                label4.Text = "WRONG ANSWER";
                label5.Text = "WRONG ANSWER";
                label6.Text = "WRONG ANSWER";
                label7.Text = "WRONG ANSWER";
            }

            else if (zebraRadioButton.Checked == true)
            {

                label1.Text = "HMMM... MAYBE";
                label2.Text = "HMMM... MAYBE";
                label3.Text = "HMMM... MAYBE";
                label4.Text = "HMMM... MAYBE";
                label5.Text = "HMMM... MAYBE";
                label6.Text = "HMMM... MAYBE";
                label7.Text = "HMMM... MAYBE";
            }

            if(score >= 5)
            {
                form2.Show();
            }
                


        }
        public void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void PigRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            score++;
            label1.Visible = false;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = false;
            label6.Visible = true;
            label7.Visible = false;


            label1.Text = "BARK";
            label2.Text = "BARK";
            label3.Text = "BARK";
            label4.Text = "BARK";
            label5.Text = "BARK";
            label6.Text = "BARK";
            label7.Text = "BARK";

            if (colorChangeCheckBox.Checked == true)
            {
                this.animalPictureBox.ImageLocation = "https://static.dw.com/image/47863948_303.jpg";
            }
            else
            {
                this.animalPictureBox.ImageLocation = "https://cdn-a.william-reed.com/var/wrbm_gb_food_pharma/storage/images/publications/feed/feednavigator.com/news/r-d/how-can-the-prenatal-phase-influence-the-lifelong-performance-of-a-pig/8769254-1-eng-GB/How-can-the-prenatal-phase-influence-the-lifelong-performance-of-a-pig_wrbm_large.jpg";
            }
                

        }
        public void ZebraRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            score++;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            label1.Text = "MOO";
            label2.Text = "MOO";
            label3.Text = "MOO";
            label4.Text = "MOO";
            label5.Text = "MOO";
            label6.Text = "MOO";
            label7.Text = "MOO";

            Form3 form3 = new Form3();
            form3.Show();

            this.animalPictureBox.ImageLocation = "https://s3.amazonaws.com/hudsonalpha/wp-content/uploads/2020/03/31082714/Common_zebra_1-800x600.jpg";
            
        }
        public void DogRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            score++;
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = true;
            label6.Visible = false;
            label7.Visible = true;

            label1.Text = "MEOW";
            label2.Text = "MEOW";
            label3.Text = "MEOW";
            label4.Text = "MEOW";
            label5.Text = "MEOW";
            label6.Text = "MEOW";
            label7.Text = "MEOW";

            this.animalPictureBox.ImageLocation = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/golden-retriever-royalty-free-image-506756303-1560962726.jpg?crop=0.672xw:1.00xh;0.166xw,0&resize=640:*";
           
        }
    }
}
