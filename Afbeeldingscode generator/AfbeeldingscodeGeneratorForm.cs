using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            string resultaat;
            string resultaat2;

            resultaat = String.Format("&lt;a&nbsp;href=&quot;{0}&quot;&gt;&lt;img&nbsp;src=&quot;{1}&quot;&nbsp;title=&quot;{2}&quot;&gt;&lt;/a&gt;",
            hyperlink, afbeeldingslocatie, omschrijving);
            txtTeKopierenHTMLCode.Text = resultaat;

            resultaat2 = String.Format("<a href='{0}'><img src='{1}' title='{2}'></a>", hyperlink, afbeeldingslocatie, omschrijving);
            txtVoorbeeldHTMLCode.Text = resultaat2;
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
            txtTeKopierenHTMLCode.Text = "";
            txtVoorbeeldHTMLCode.Text = "";
            txtAfbeeldingslocatie.Focus();

        }

        private void overToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 over = new AboutBox1();
            over.ShowDialog();
        }
    }
}
