using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEditor
{
    public partial class Form1 : Form
    {
        public Form1(MyEditorParent myEditorParent)
        {
            InitializeComponent();

            this.MdiParent = myEditorParent;

            //this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem__Click);
            myEditorParent.openToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem__Click);
            myEditorParent.saveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem__Click);
            //this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem__Click);

            myEditorParent.closeAllToolStripMenuItem.Click += new EventHandler(CloseAllToolStripMenuItem__Click);

            myEditorParent.copyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem__Click);
            myEditorParent.cutToolStripMenuItem.Click += new EventHandler(CutToolStripMenuItem__Click);
            myEditorParent.pasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem__Click);

            this.toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(ToolStrip__ItemClicked);
            this.Text = "MyEditor";

            this.FormClosing += new FormClosingEventHandler(Form1__FormClosing);

        }

        private void Form1__FormClosing(object sender, FormClosingEventArgs e)
        {
            MyEditorParent myEditorParent = (MyEditorParent)this.MdiParent;
            myEditorParent.openToolStripMenuItem.Click -= new EventHandler(OpenToolStripMenuItem__Click);
            myEditorParent.saveToolStripMenuItem.Click -= new EventHandler(SaveToolStripMenuItem__Click);

            myEditorParent.closeAllToolStripMenuItem.Click -= new EventHandler(CloseAllToolStripMenuItem__Click);

            myEditorParent.copyToolStripMenuItem.Click -= new EventHandler(CopyToolStripMenuItem__Click);
            myEditorParent.cutToolStripMenuItem.Click -= new EventHandler(CutToolStripMenuItem__Click);
            myEditorParent.pasteToolStripMenuItem.Click -= new EventHandler(PasteToolStripMenuItem__Click);
        }

        private void CloseAllToolStripMenuItem__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            this.Text = "MyEditor";
        }

        private void OpenToolStripMenuItem__Click(object sender, EventArgs e)
        {
            if(this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if(openFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }

                richTextBox.LoadFile(openFileDialog.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + openFileDialog.FileName + ")";
            }
        }

        private void SaveToolStripMenuItem__Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }
            saveFileDialog.FileName = openFileDialog.FileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if (saveFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }

                richTextBox.SaveFile(saveFileDialog.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + saveFileDialog.FileName + ")";
            }
        }

        private void ExitToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CopyToolStripMenuItem__Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }
            richTextBox.Copy();
        }
        private void CutToolStripMenuItem__Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }
            richTextBox.Cut();
        }
        private void PasteToolStripMenuItem__Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }
            richTextBox.Paste();
        }

        private void ToolStrip__ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            ToolStripButton toolStripButton = null;

            if(e.ClickedItem == this.boldToolStripButton)
            {
                fontStyle = FontStyle.Bold;
                toolStripButton = this.boldToolStripButton;
            }
            else if(e.ClickedItem == this.italicsToolStripButton)
            {
                fontStyle = FontStyle.Italic;
                toolStripButton = this.italicsToolStripButton;
            }
            else if (e.ClickedItem == this.underlineToolStripButton)
            {
                fontStyle = FontStyle.Underline;
                toolStripButton = this.underlineToolStripButton;
            }
            else if(e.ClickedItem == this.colorToolStripButton)
            {
                if(colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SelectionColor = colorDialog.Color;
                    colorToolStripButton.BackColor = colorDialog.Color;
                }
            }

            if(fontStyle != FontStyle.Regular)
            {
                toolStripButton.Checked = !toolStripButton.Checked;

                SetSelectionFont(fontStyle, toolStripButton.Checked);

            }

        }

        private void SetSelectionFont(FontStyle fontStyle, bool bSet)
        {
            Font newFont = null;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if(selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            if (bSet)
            {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);
            }
            else
            {
                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }

            this.richTextBox.SelectionFont = newFont;
        }

    }


}
