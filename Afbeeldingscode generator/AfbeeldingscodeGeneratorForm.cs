using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Afbeeldingscode_generator
{
    public partial class AfbeeldingscodeGeneratorForm : Form
    {
        public AfbeeldingscodeGeneratorForm()
        {
            InitializeComponent();
        }

        private void btnMaakCode_Click(object sender, EventArgs e)
        {
            string afbeeldingslocatie = txtAfbeeldingslocatie.Text;
            string omschrijving = txtOmschrijving.Text;
            string hyperlink = txtHyperlink.Text;
            string breedte = txtBreedte.Text;
            string hoogte = txtHoogte.Text;
            string rand = txtRand.Text;
            string resultaat;
            string resultaat2;

            if (checkBoxHyperlink.Checked && checkBoxCentreren.Checked)
            {
                resultaat = String.Format("&lt;center&gt;&lt;a&nbsp;target=&quot;_blank&quot;&nbsp;href=&quot;{0}&quot;&gt;&lt;img&nbsp;src=&quot;{1}&quot;&nbsp;title=&quot;{2}&quot;&nbsp;width=&quot;{3}&quot;&nbsp;height=&quot;{4}&quot;&nbsp;border=&quot;{5}&quot;&gt;&lt;/a&gt;&lt;/center&gt;",hyperlink, afbeeldingslocatie, omschrijving, breedte, hoogte, rand);
                txtTeKopierenHTMLCode.Text = resultaat;

                resultaat2 = String.Format("<center><a target=\"_blank\" href=\"{0}\"><img src=\"{1}\" title=\"{2}\" width=\"{3}\" height=\"{4}\" border=\"{5}\" alt=\"gegenereerd met RHCV's Afbeeldingscodegenerator\" /></a></center>", hyperlink, afbeeldingslocatie, omschrijving, breedte, hoogte, rand);
                txtVoorbeeldHTMLCode.Text = resultaat2;
            }
                else if (checkBoxHyperlink.Checked)
                    {
                        resultaat = String.Format("&lt;a&nbsp;target=&quot;_blank&quot;&nbsp;href=&quot;{0}&quot;&gt;&lt;img&nbsp;src=&quot;{1}&quot;&nbsp;title=&quot;{2}&quot;&nbsp;width=&quot;{3}&quot;&nbsp;height=&quot;{4}&quot;&nbsp;border=&quot;{5}&quot;&gt;&lt;/a&gt;", hyperlink, afbeeldingslocatie, omschrijving, breedte, hoogte, rand);
                        txtTeKopierenHTMLCode.Text = resultaat;

                        resultaat2 = String.Format("<a target=\"_blank\" href=\"{0}\"><img src=\"{1}\" title=\"{2}\" width=\"{3}\" height=\"{4}\" border=\"{5}\" alt=\"gegenereerd met RHCV's Afbeeldingscodegenerator\" /></a>", hyperlink, afbeeldingslocatie, omschrijving, breedte, hoogte, rand);
                        txtVoorbeeldHTMLCode.Text = resultaat2;
                    }
                else if (checkBoxCentreren.Checked)
                    {
                        resultaat = String.Format("&lt;center&gt;&lt;a&nbsp;href=&quot;{0}&quot;&gt;&lt;img&nbsp;src=&quot;{1}&quot;&nbsp;title=&quot;{2}&quot;&nbsp;width=&quot;{3}&quot;&nbsp;height=&quot;{4}&quot;&nbsp;border=&quot;{5}&quot;&gt;&lt;/a&gt;&lt;/center&gt;", hyperlink, afbeeldingslocatie, omschrijving, breedte, hoogte, rand);
                        txtTeKopierenHTMLCode.Text = resultaat;

                        resultaat2 = String.Format("<center><a href=\"{0}\"><img src=\"{1}\" title=\"{2}\" width=\"{3}\" height=\"{4}\" border=\"{5}\" alt=\"gegenereerd met RHCV's Afbeeldingscodegenerator\" /></a></center>", hyperlink, afbeeldingslocatie, omschrijving, breedte, hoogte, rand);
                        txtVoorbeeldHTMLCode.Text = resultaat2;
                    }
            else
            {
                resultaat = String.Format("&lt;a&nbsp;href=&quot;{0}&quot;&gt;&lt;img&nbsp;src=&quot;{1}&quot;&nbsp;title=&quot;{2}&quot;&nbsp;width=&quot;{3}&quot;&nbsp;height=&quot;{4}&quot;&nbsp;border=&quot;{5}&quot;&gt;&lt;/a&gt;", hyperlink, afbeeldingslocatie, omschrijving, breedte, hoogte, rand);
                txtTeKopierenHTMLCode.Text = resultaat;

                resultaat2 = String.Format("<a href=\"{0}\"><img src=\"{1}\" title=\"{2}\" width=\"{3}\" height=\"{4}\" border=\"{5}\" alt=\"gegenereerd met RHCV's Afbeeldingscodegenerator\" /></a>", hyperlink, afbeeldingslocatie, omschrijving, breedte, hoogte, rand);
                txtVoorbeeldHTMLCode.Text = resultaat2;
            }
        }

        private void txtVoorbeeldHTMLCode_TextChanged(object sender, EventArgs e)
        {
            webBrowserVoorbeeld.DocumentText = txtVoorbeeldHTMLCode.Text;
        }

        private void aflsuitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nieuwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtAfbeeldingslocatie.Text = "";
            txtOmschrijving.Text = "";
            txtHyperlink.Text = "";
            txtBreedte.Text = "";
            txtHoogte.Text = "";
            txtRand.Text = "";
            txtTeKopierenHTMLCode.Text = "";
            txtVoorbeeldHTMLCode.Text = "";
            txtAfbeeldingslocatie.Focus();
            checkBoxHyperlink.Checked = false;
            checkBoxCentreren.Checked = false;
        }

        private void overToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 over = new AboutBox1();
            over.ShowDialog();
        }

        private void AfbeeldingscodeGeneratorForm_Load(object sender, EventArgs e)
        {

        }

        private void opslaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File | *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(txtTeKopierenHTMLCode.Text);
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
            
        }


    }
}
