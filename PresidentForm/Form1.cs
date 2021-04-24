using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresidentForm
{
    public partial class Form1 : Form
    {
        public int score = 0;

        public Form1()
        {
            InitializeComponent();

            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 11001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser1__DocumentCompleted);

            this.harrisonTextBox.KeyPress += new KeyPressEventHandler(HarrisonTextBox__KeyPress);
            this.rooseveltTextBox.KeyPress += new KeyPressEventHandler(RooseveltTextBox__KeyPress);
            this.clintonTextBox.KeyPress += new KeyPressEventHandler(ClintonTextBox__KeyPress);
            this.buchananTextBox.KeyPress += new KeyPressEventHandler(BuchananTextBox__KeyPress);
            this.pierceTextBox.KeyPress += new KeyPressEventHandler(PierceTextBox__KeyPress);
            this.bushTextBox.KeyPress += new KeyPressEventHandler(BushTextBox__KeyPress);
            this.obamaTextBox.KeyPress += new KeyPressEventHandler(ObamaTextBox__KeyPress);
            this.kennedyTextBox.KeyPress += new KeyPressEventHandler(KennedyTextBox__KeyPress);
            this.mckinleyTextBox.KeyPress += new KeyPressEventHandler(MckinleyTextBox__KeyPress);
            this.reaganTextBox.KeyPress += new KeyPressEventHandler(ReaganTextBox__KeyPress);
            this.eisenhowerTextBox.KeyPress += new KeyPressEventHandler(EisenhowerTextBox__KeyPress);
            this.vanburenTextBox.KeyPress += new KeyPressEventHandler(VanburenTextBox__KeyPress);
            this.washingtonTextBox.KeyPress += new KeyPressEventHandler(WashingtonTextBox__KeyPress);
            this.adamsTextBox.KeyPress += new KeyPressEventHandler(AdamsTextBox__KeyPress);
            this.theodoreTextBox.KeyPress += new KeyPressEventHandler(TheodoreTextBox__KeyPress);
            this.jeffersonTextBox.KeyPress += new KeyPressEventHandler(JeffersonTextBox__KeyPress);

            this.harrisonTextBox.TextChanged += new EventHandler(HarrisonTextBox__TextChanged);
            this.rooseveltTextBox.TextChanged += new EventHandler(RooseveltTextBox__TextChanged);
            this.clintonTextBox.TextChanged += new EventHandler(ClintonTextBox__TextChanged);
            this.buchananTextBox.TextChanged += new EventHandler(BuchananTextBox__TextChanged);
            this.pierceTextBox.TextChanged += new EventHandler(PierceTextBox__TextChanged);
            this.bushTextBox.TextChanged += new EventHandler(BushTextBox__TextChanged);
            this.obamaTextBox.TextChanged += new EventHandler(ObamaTextBox__TextChanged);
            this.kennedyTextBox.TextChanged += new EventHandler(KennedyTextBox__TextChanged);
            this.mckinleyTextBox.TextChanged += new EventHandler(MckinleyTextBox__TextChanged);
            this.reaganTextBox.TextChanged += new EventHandler(ReaganTextBox__TextChanged);
            this.eisenhowerTextBox.TextChanged += new EventHandler(EisenhowerTextBox__TextChanged);
            this.vanburenTextBox.TextChanged += new EventHandler(VanburenTextBox__TextChanged);
            this.washingtonTextBox.TextChanged += new EventHandler(WashingtonTextBox__TextChanged);
            this.adamsTextBox.TextChanged += new EventHandler(AdamsTextBox__TextChanged);
            this.theodoreTextBox.TextChanged += new EventHandler(TheodoreTextBox__TextChanged);
            this.jeffersonTextBox.TextChanged += new EventHandler(JeffersonTextBox__TextChanged);

            this.allRadioButton.CheckedChanged += new EventHandler(AllRadioButton__CheckedChange);
            this.democratRadioButton.CheckedChanged += new EventHandler(DemocratRadioButton__CheckedChange);
            this.republicanRadioButton.CheckedChanged += new EventHandler(RepublicanRadioButton__CheckedChange);
            this.demRepublicanRadioButton.CheckedChanged += new EventHandler(DemRepublicanRadioButton__CheckedChange);
            this.federalistRadioButton.CheckedChanged += new EventHandler(FederalistRadioButton__ChangedChange);

            this.harrisonRadioButton.CheckedChanged += new EventHandler(HarrisonRadioButton__CheckedChange);
            this.rooseveltRadioButton.CheckedChanged += new EventHandler(RooseveltRadioButton__CheckedChange);
            this.clintonRadioButton.CheckedChanged += new EventHandler(ClintonRadioButton__CheckedChange);
            this.buchananRadioButton.CheckedChanged += new EventHandler(BuchananRadioButton__CheckedChange);
            this.pierceRadioButton.CheckedChanged += new EventHandler(PierceRadioButton__CheckedChange);
            this.bushRadioButton.CheckedChanged += new EventHandler(BushRadioButton__CheckedChange);
            this.obamaRadioButton.CheckedChanged += new EventHandler(ObamaRadioButton__CheckedChange);
            this.kennedyRadioButton.CheckedChanged += new EventHandler(KennedyRadioButton__CheckedChange);
            this.mckinleyRadioButton.CheckedChanged += new EventHandler(MckinleyRadioButton__CheckedChange);
            this.reaganRadioButton.CheckedChanged += new EventHandler(ReaganRadioButton__CheckedChange);
            this.eisenhowerRadioButton.CheckedChanged += new EventHandler(EisenhowerRadioButton__CheckedChange);
            this.vanburenRadioButton.CheckedChanged += new EventHandler(VanburenRadioButton__CheckedChange);
            this.washingtonRadioButton.CheckedChanged += new EventHandler(WashingtonRadioButton__CheckedChange);
            this.adamsRadioButton.CheckedChanged += new EventHandler(AdamsRadioButton__CheckedChange);
            this.theodoreRadioButton.CheckedChanged += new EventHandler(TheodoreRadioButton__CheckedChange);
            this.jeffersonRadioButton.CheckedChanged += new EventHandler(JeffersonRadioButton__CheckedChange);

            this.pictureBox.MouseHover += new EventHandler(PictureBox__MouseHover);
            this.pictureBox.MouseLeave += new EventHandler(PictureBox__MouseLeave);

            this.harrisonTextBox.Validated += new EventHandler(HarrisonTextBox__Validated);
            this.rooseveltTextBox.Validated += new EventHandler(RooseveltTextBox__Validated);
            this.clintonTextBox.Validated += new EventHandler(ClintonTextBox__Validated);
            this.buchananTextBox.Validated += new EventHandler(BuchananTextBox__Validated);
            this.pierceTextBox.Validated += new EventHandler(PierceTextBox__Validated);
            this.bushTextBox.Validated += new EventHandler(BushTextBox__Validated);
            this.obamaTextBox.Validated += new EventHandler(ObamaTextBox__Validated);
            this.kennedyTextBox.Validated += new EventHandler(KennedyTextBox__Validated);
            this.mckinleyTextBox.Validated += new EventHandler(MckinleyTextBox__Validated);
            this.reaganTextBox.Validated += new EventHandler(ReaganTextBox__Validated);
            this.eisenhowerTextBox.Validated += new EventHandler(EisenhowerTextBox__Validated);
            this.vanburenTextBox.Validated += new EventHandler(VanburenTextBox__Validated);
            this.washingtonTextBox.Validated += new EventHandler(WashingtonTextBox__Validated);
            this.adamsTextBox.Validated += new EventHandler(AdamsTextBox__Validated);
            this.theodoreTextBox.Validated += new EventHandler(TheodoreTextBox__Validated);
            this.jeffersonTextBox.Validated += new EventHandler(JeffersonTextBox__Validated);

            this.timer1.Interval = 1000;

            this.toolStripProgressBar1.Value = 120;

            this.exitButton.Click += new EventHandler(ExitButton__Click);
            this.timer1.Tick += new EventHandler(Timer__Tick);

            exitButton.Enabled = false;


        }
        public void HarrisonTextBox__Validated(object sender, EventArgs e)
        {
            if (harrisonTextBox.Text == "23" || (harrisonTextBox.Text == "0"))
            {
                errorProvider1.SetError(this.harrisonTextBox, String.Empty);
                if (harrisonTextBox.Text == "23")
                {
                    score++;
                }
            }
            else
            {
                errorProvider1.SetError(this.harrisonTextBox, "That is the wrong number.");

            }
        }
        public void RooseveltTextBox__Validated(object sender, EventArgs e)
        {
            if (rooseveltTextBox.Text == "32" || (rooseveltTextBox.Text == "0"))
            {
                errorProvider1.SetError(this.rooseveltTextBox, String.Empty);
                if (rooseveltTextBox.Text == "32")
                {
                    score++;
                }
            }
            else
            {
                errorProvider1.SetError(this.rooseveltTextBox, "That is the wrong number.");

            }
        }
        public void ClintonTextBox__Validated(object sender, EventArgs e)
        {
            if (clintonTextBox.Text == "42" || (clintonTextBox.Text == "0"))
            {
                errorProvider1.SetError(this.clintonTextBox, String.Empty);
                if (clintonTextBox.Text == "42")
                {
                    score++;
                }
            }
            else
            {
                errorProvider1.SetError(this.clintonTextBox, "That is the wrong number.");

            }
        }
        public void BuchananTextBox__Validated(object sender, EventArgs e)
        {
            if (buchananTextBox.Text == "15" || (buchananTextBox.Text == "0"))
            {
                errorProvider1.SetError(this.buchananTextBox, String.Empty);
                if (buchananTextBox.Text == "15")
                {
                    score++;
                }
            }
            else
            {
                errorProvider1.SetError(this.buchananTextBox, "That is the wrong number.");

            }
        }
        public void PierceTextBox__Validated(object sender, EventArgs e)
        {
            if (pierceTextBox.Text == "14" || (pierceTextBox.Text == "0"))
            {
                errorProvider1.SetError(this.pierceTextBox, String.Empty);
                if (pierceTextBox.Text == "14")
                {
                    score++;
                }
            }
            else
            {
                errorProvider1.SetError(this.pierceTextBox, "That is the wrong number.");

            }
        }
        public void BushTextBox__Validated(object sender, EventArgs e)
        {
            if (bushTextBox.Text == "43" || (bushTextBox.Text == "0"))
            {
                errorProvider1.SetError(this.bushTextBox, String.Empty);
                if (bushTextBox.Text == "43")
                {
                    score++;
                }
            }
            else
            {
                errorProvider1.SetError(this.bushTextBox, "That is the wrong number.");

            }
        }
        public void ObamaTextBox__Validated(object sender, EventArgs e)
        {
            if (obamaTextBox.Text == "44" || (obamaTextBox.Text == "0"))
            {
                errorProvider1.SetError(this.obamaTextBox, String.Empty);
                if (obamaTextBox.Text == "44")
                {
                    score++;
                }
            }
            else
            {
                errorProvider1.SetError(this.obamaTextBox, "That is the wrong number.");

            }
        }
        public void KennedyTextBox__Validated(object sender, EventArgs e)
        {
            if (kennedyTextBox.Text == "35" || (kennedyTextBox.Text == "0"))
            {
                errorProvider1.SetError(this.kennedyTextBox, String.Empty);
                if (kennedyTextBox.Text == "35")
                {
                    score++;
                }
            }
            else
            {
                errorProvider1.SetError(this.kennedyTextBox, "That is the wrong number.");

            }
        }
        public void MckinleyTextBox__Validated(object sender, EventArgs e)
        {
            if (mckinleyTextBox.Text == "25" || (mckinleyTextBox.Text == "0"))
            {
                errorProvider1.SetError(this.mckinleyTextBox, String.Empty);
                if (mckinleyTextBox.Text == "25")
                {
                    score++;
                }
            }
            else
            {
                errorProvider1.SetError(this.mckinleyTextBox, "That is the wrong number.");

            }
        }
        public void ReaganTextBox__Validated(object sender, EventArgs e)
        {
            if (reaganTextBox.Text == "40" || (reaganTextBox.Text == "0"))
            {
                errorProvider1.SetError(this.reaganTextBox, String.Empty);
                if (reaganTextBox.Text == "40")
                {
                    score++;
                }
            }
            else
            {
                errorProvider1.SetError(this.reaganTextBox, "That is the wrong number.");

            }
        }
        public void EisenhowerTextBox__Validated(object sender, EventArgs e)
        {
            if (eisenhowerTextBox.Text == "34" || (eisenhowerTextBox.Text == "0"))
            {
                errorProvider1.SetError(this.eisenhowerTextBox, String.Empty);
                if (eisenhowerTextBox.Text == "34")
                {
                    score++;
                }
            }
            else
            {
                errorProvider1.SetError(this.eisenhowerTextBox, "That is the wrong number.");

            }
        }
        public void VanburenTextBox__Validated(object sender, EventArgs e)
        {
            if (vanburenTextBox.Text == "8" || (vanburenTextBox.Text == "0"))
            {
                errorProvider1.SetError(this.vanburenTextBox, String.Empty);
                if (vanburenTextBox.Text == "8")
                {
                    score++;
                }
            }
            else
            {
                errorProvider1.SetError(this.vanburenTextBox, "That is the wrong number.");

            }
        }
        public void WashingtonTextBox__Validated(object sender, EventArgs e)
        {
            if (washingtonTextBox.Text == "1" || (washingtonTextBox.Text == "0"))
            {
                errorProvider1.SetError(this.washingtonTextBox, String.Empty);
                if(washingtonTextBox.Text == "1")
                {
                    score++;
                }
            }
            else
            {
                errorProvider1.SetError(this.washingtonTextBox, "That is the wrong number.");

            }
        }
        public void AdamsTextBox__Validated(object sender, EventArgs e)
        {
            if (adamsTextBox.Text == "2" || (adamsTextBox.Text == "0"))
            {
                errorProvider1.SetError(this.adamsTextBox, String.Empty);
                if (adamsTextBox.Text == "2")
                {
                    score++;
                }
            }
            else
            {
                errorProvider1.SetError(this.adamsTextBox, "That is the wrong number.");

            }
        }
        public void TheodoreTextBox__Validated(object sender, EventArgs e)
        {
            if (theodoreTextBox.Text == "26" || (theodoreTextBox.Text == "0"))
            {
                errorProvider1.SetError(this.theodoreTextBox, String.Empty);
                if (theodoreTextBox.Text == "26")
                {
                    score++;
                }
            }
            else
            {
                errorProvider1.SetError(this.theodoreTextBox, "That is the wrong number.");

            }
        }
        public void JeffersonTextBox__Validated(object sender, EventArgs e)
        {
            if (jeffersonTextBox.Text == "3" || (jeffersonTextBox.Text == "0"))
            {
                errorProvider1.SetError(this.jeffersonTextBox, String.Empty);
                if (jeffersonTextBox.Text == "3")
                {
                    score++;
                }
            }
            else
            {
                errorProvider1.SetError(this.jeffersonTextBox, "That is the wrong number.");

            }
        }
        public void PictureBox__MouseHover(object sender, EventArgs e)
        {
  
            pictureBox.Height = 300;
            pictureBox.Width = 200;
        }
        public void PictureBox__MouseLeave(object sender, EventArgs e)
        {

            pictureBox.Height = 200;
            pictureBox.Width = 150;
        }

        public void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElementCollection htmlElementCollection = webBrowser1.Document.GetElementsByTagName("a");

            foreach (HtmlElement link in htmlElementCollection)
            {
                link.SetAttribute("title", "Professor Schuh for President!");
            }

           
        }
        public void Timer__Tick(object sender, EventArgs e)
        {
            --this.toolStripProgressBar1.Value;

            if (this.toolStripProgressBar1.Value == 0)
            {
                this.timer1.Stop();
  
               harrisonTextBox.Text = "0";
               rooseveltTextBox.Text = "0";
               clintonTextBox.Text = "0";
               buchananTextBox.Text = "0";
               pierceTextBox.Text = "0";
               bushTextBox.Text = "0";
               obamaTextBox.Text = "0";
               mckinleyTextBox.Text = "0";
               reaganTextBox.Text = "0";
               eisenhowerTextBox.Text = "0";
               vanburenTextBox.Text = "0";
               washingtonTextBox.Text = "0";
               adamsTextBox.Text = "0";
               theodoreTextBox.Text = "0";
               jeffersonTextBox.Text = "0";
               kennedyTextBox.Text = "0";

                this.toolStripProgressBar1.Value = 120;
                timer1.Stop();
            }
            else if(this.toolStripProgressBar1.Value != 0 &&(score == 16))
            {
                webBrowser1.Navigate("https://www.youtube.com/watch?v=aV1p2PGXq0k");
                timer1.Stop();
                exitButton.Enabled = true;
            }
        }

        public void HarrisonTextBox__TextChanged(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        public void RooseveltTextBox__TextChanged(object sender, EventArgs e)
        {
            this.timer1.Start();

        }
        public void ClintonTextBox__TextChanged(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        public void BuchananTextBox__TextChanged(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        public void PierceTextBox__TextChanged(object sender, EventArgs e)
        {

            this.timer1.Start();
        }
        public void BushTextBox__TextChanged(object sender, EventArgs e)
        {

            this.timer1.Start();
        }
        public void ObamaTextBox__TextChanged(object sender, EventArgs e)
        {

            this.timer1.Start();
        }
        public void KennedyTextBox__TextChanged(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        public void MckinleyTextBox__TextChanged(object sender, EventArgs e)
        {

            this.timer1.Start();
        }
        public void ReaganTextBox__TextChanged(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        public void EisenhowerTextBox__TextChanged(object sender, EventArgs e)
        {
            //this.timer1.Interval = 500;

            //this.toolStripProgressBar1.Value = 120;

            this.timer1.Start();
        }
        public void VanburenTextBox__TextChanged(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        public void WashingtonTextBox__TextChanged(object sender, EventArgs e)
        {

            this.timer1.Start();
        }
        public void AdamsTextBox__TextChanged(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        public void TheodoreTextBox__TextChanged(object sender, EventArgs e)
        {

            this.timer1.Start();
        }
        public void JeffersonTextBox__TextChanged(object sender, EventArgs e)
        {
 
            this.timer1.Start();
        }
        public void MckinleyRadioButton__CheckedChange(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/William_McKinley");
            this.webBrowserGroupBox.Text = "https://en.wikipedia.org/wiki/William_McKinley";
            this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/WilliamMcKinley.jpeg";
        }
        public void ReaganRadioButton__CheckedChange(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Ronald_Reagan");
            this.webBrowserGroupBox.Text = "https://en.wikipedia.org/wiki/Ronald_Reagan";
            this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/RonaldReagan.jpeg";
        }
        public void EisenhowerRadioButton__CheckedChange(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Dwight_D._Eisenhower");
            this.webBrowserGroupBox.Text = "https://en.wikipedia.org/wiki/Dwight_D._Eisenhower";
            this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/DwightDEisenhower.jpeg";
        }
        public void VanburenRadioButton__CheckedChange(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Martin_Van_Buren");
            this.webBrowserGroupBox.Text = "https://en.wikipedia.org/wiki/Martin_Van_Buren";
            this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/MartinVanBuren.jpeg";
        }
        public void WashingtonRadioButton__CheckedChange(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/George_Washington");
            this.webBrowserGroupBox.Text = "https://en.wikipedia.org/wiki/George_Washington";
            this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWashington.jpeg";
        }
        public void AdamsRadioButton__CheckedChange(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/John_Adams");
            this.webBrowserGroupBox.Text = "https://en.wikipedia.org/wiki/John_Adams";
            this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JohnAdams.jpeg";
        }
        public void TheodoreRadioButton__CheckedChange(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Theodore_Roosevelt");
            this.webBrowserGroupBox.Text = "https://en.wikipedia.org/wiki/Theodore_Roosevelt";
            this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/TheodoreRoosevelt.jpeg";
        }
        public void JeffersonRadioButton__CheckedChange(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Thomas_Jefferson");
            this.webBrowserGroupBox.Text = "https://en.wikipedia.org/wiki/Thomas_Jefferson";
            this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/ThomasJefferson.jpeg";
        }
        public void HarrisonRadioButton__CheckedChange(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Benjamin_Harrison");
            this.webBrowserGroupBox.Text = "https://en.wikipedia.org/wiki/Benjamin_Harrison";
            this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/BenjaminHarrison.jpeg";
        }
        public void RooseveltRadioButton__CheckedChange(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Franklin_D._Roosevelt");
            this.webBrowserGroupBox.Text = "https://en.wikipedia.org/wiki/Franklin_D._Roosevelt";
            this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/FranklinDRoosevelt.jpeg";
        }

        public void ClintonRadioButton__CheckedChange(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Bill_Clinton");
            this.webBrowserGroupBox.Text = "https://en.wikipedia.org/wiki/Bill_Clinton";
            this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/WilliamJClinton.jpeg";
        }
        public void BuchananRadioButton__CheckedChange(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/James_Buchanan");
            this.webBrowserGroupBox.Text = "https://en.wikipedia.org/wiki/James_Buchanan";
            this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JamesBuchanan.jpeg";
        }
        public void PierceRadioButton__CheckedChange(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Franklin_Pierce");
            this.webBrowserGroupBox.Text = "https://en.wikipedia.org/wiki/Franklin_Pierce";
            this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/FranklinPerce.jpeg";
        }

        public void BushRadioButton__CheckedChange(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/George_W._Bush");
            this.webBrowserGroupBox.Text = "https://en.wikipedia.org/wiki/George_W._Bush";
            this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWBush.jpeg";
        }
        public void ObamaRadioButton__CheckedChange(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Barack_Obama");
            this.webBrowserGroupBox.Text = "https://en.wikipedia.org/wiki/Barack_Obama";
            this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/BarackObama.png";
        }
        public void KennedyRadioButton__CheckedChange(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/John_F._Kennedy");
            this.webBrowserGroupBox.Text = "https://en.wikipedia.org/wiki/John_F._Kennedy";
            this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JohnFKennedy.jpeg";
        }

        public void DemocratRadioButton__CheckedChange(object sender, EventArgs e)
        {
            harrisonRadioButton.Visible = false;
            bushRadioButton.Visible = false;
            mckinleyRadioButton.Visible = false;
            reaganRadioButton.Visible = false;
            eisenhowerRadioButton.Visible = false;
            washingtonRadioButton.Visible = false;
            adamsRadioButton.Visible = false;
            theodoreRadioButton.Visible = false;
            jeffersonRadioButton.Visible = false;
            rooseveltRadioButton.Visible = true;
            clintonRadioButton.Visible = true;
            buchananRadioButton.Visible = true;
            pierceRadioButton.Visible = true;
            obamaRadioButton.Visible = true;
            kennedyRadioButton.Visible = true;
            vanburenRadioButton.Visible = true;

            rooseveltRadioButton.Checked = true;
            
        }

        public void AllRadioButton__CheckedChange(object sender, EventArgs e)
        {
            harrisonRadioButton.Visible = true;
            rooseveltRadioButton.Visible = true;
            clintonRadioButton.Visible = true;
            buchananRadioButton.Visible = true;
            pierceRadioButton.Visible = true;
            bushRadioButton.Visible = true;
            obamaRadioButton.Visible = true;
            kennedyRadioButton.Visible = true;

            mckinleyRadioButton.Visible = true;
            reaganRadioButton.Visible = true;
            eisenhowerRadioButton.Visible = true;
            vanburenRadioButton.Visible = true;
            theodoreRadioButton.Visible = true;
            jeffersonRadioButton.Visible = true;

            washingtonRadioButton.Visible = true;
            adamsRadioButton.Visible = true;
            harrisonRadioButton.Checked = true;
        }
        public void RepublicanRadioButton__CheckedChange(object sender, EventArgs e)
        {
            rooseveltRadioButton.Visible = false;
            clintonRadioButton.Visible = false;
            buchananRadioButton.Visible = false;
            pierceRadioButton.Visible = false;
            obamaRadioButton.Visible = false;
            kennedyRadioButton.Visible = false;
            vanburenRadioButton.Visible = false;
            washingtonRadioButton.Visible = false;
            adamsRadioButton.Visible = false;
            jeffersonRadioButton.Visible = false;
            harrisonRadioButton.Visible = true;
            bushRadioButton.Visible = true;
            mckinleyRadioButton.Visible = true;
            reaganRadioButton.Visible = true;
            eisenhowerRadioButton.Visible = true;
            theodoreRadioButton.Visible = true;

            harrisonRadioButton.Checked = true;

        }

        public void DemRepublicanRadioButton__CheckedChange(object sender, EventArgs e)
        {
            harrisonRadioButton.Visible = false;
            rooseveltRadioButton.Visible = false;
            clintonRadioButton.Visible = false;
            buchananRadioButton.Visible = false;
            pierceRadioButton.Visible = false;
            bushRadioButton.Visible = false;
            obamaRadioButton.Visible = false;
            kennedyRadioButton.Visible = false;
            mckinleyRadioButton.Visible = false;
            reaganRadioButton.Visible = false;
            eisenhowerRadioButton.Visible = false;
            vanburenRadioButton.Visible = false;
            washingtonRadioButton.Visible = false;
            adamsRadioButton.Visible = false;
            theodoreRadioButton.Visible = false;
            jeffersonRadioButton.Visible = true;

            jeffersonRadioButton.Checked = true;

        }

        public void FederalistRadioButton__ChangedChange(object sender, EventArgs e)
        {
            harrisonRadioButton.Visible = false;
            rooseveltRadioButton.Visible = false;
            clintonRadioButton.Visible = false;
            buchananRadioButton.Visible = false;
            pierceRadioButton.Visible = false;
            bushRadioButton.Visible = false;
            obamaRadioButton.Visible = false;
            kennedyRadioButton.Visible = false;

            mckinleyRadioButton.Visible = false;
            reaganRadioButton.Visible = false;
            eisenhowerRadioButton.Visible = false;
            vanburenRadioButton.Visible = false;
            theodoreRadioButton.Visible = false;
            jeffersonRadioButton.Visible = false;

            washingtonRadioButton.Visible = true;
            adamsRadioButton.Visible = true;

            washingtonRadioButton.Checked = true;
        }

        public void ExitButton__Click(object sender, EventArgs e)
        { 
            Application.Exit();
        }

        public void HarrisonTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if(Char.IsDigit(e.KeyChar)|| e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        public void RooseveltTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        public void ClintonTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        public void BuchananTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        public void PierceTextBox__KeyPress(object sender, KeyPressEventArgs e)
        { 
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        public void BushTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        public void ObamaTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }


        public void KennedyTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        public void MckinleyTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        public void ReaganTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        public void EisenhowerTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        public void VanburenTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        public void WashingtonTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        public void AdamsTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        public void TheodoreTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        public void JeffersonTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }
    }
}
