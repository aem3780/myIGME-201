using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace interfaceFromHell
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            yesButton.Click += new EventHandler(YesButton__Click);
            noButton.Click += new EventHandler(NoButton__Click);
            Thread t = new Thread(Print);


            threadLabel.Text = "Are you ready?";


            t.Start();



        }

        public void Print()
        {
            for (int i = 0; i < 31; i++)
            {
                countdownLabel.Text = ($"{i}");
                Thread.Sleep(200);
            }
        }

        public void YesButton__Click(object sender, EventArgs e)
        {
            threadLabel.Text = "COOL! You can close this countdown then :)";
        }
        public void NoButton__Click(object sender, EventArgs e)
        {
            threadLabel.Text = "That's okay take your time!";
        }
    }
}

