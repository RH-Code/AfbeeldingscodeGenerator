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

        private void KleurRand_Click(object sender, EventArgs e)
        {
            //De colorDialog tonen
            colorDialog1.ShowDialog();

            Color kleur = colorDialog1.Color;
            //Color name of RGB code omzetten naar HEX
            string hex = kleur.R.ToString("X2") + kleur.G.ToString("X2") + kleur.B.ToString("X2");
            lblKleur.Text = hex;
        }
        
        private void btnMaakCode_Click(object sender, EventArgs e)
        {
            string afbeeldingslocatie = txtAfbeeldingslocatie.Text;
            string omschrijving = txtOmschrijving.Text;
            string hyperlink = txtHyperlink.Text;
            string breedte = txtBreedte.Text;
            string hoogte = txtHoogte.Text;
            string rand = txtRand.Text;
            string resultaat; //code van de HTML-code
            string resultaat2; //gewone HTML-code

            

            if (checkBoxHyperlink.Checked && checkBoxCentreren.Checked) //zorgt voor centrering én openen in nieuw venster/tabblad
            {
                //hier krijg je de code van de HTML-code
                resultaat = String.Format("&lt;center&gt;&lt;a&nbsp;target=&quot;_blank&quot;&nbsp;href=&quot;{0}&quot;&gt;&lt;img&nbsp;src=&quot;{1}&quot;&nbsp;title=&quot;{2}&quot;&nbsp;width=&quot;{3}&quot;&nbsp;height=&quot;{4}&quot;&nbsp;STYLE=&quot;border:&nbsp;solid&nbsp;{5}px&nbsp;#{6};&quot;&gt;&lt;/a&gt;&lt;/center&gt;", hyperlink, afbeeldingslocatie, omschrijving, breedte, hoogte, rand, lblKleur.Text);
                txtTeKopierenHTMLCode.Text = resultaat;

                //hier krijg je de gewone HTML-code
                resultaat2 = String.Format("<center><a target='_blank' href='{0}'><img src='{1}' title='{2}' width='{3}' height='{4}' STYLE='border: solid {5}px #{6};'></a></center>", hyperlink, afbeeldingslocatie, omschrijving, breedte, hoogte, rand, lblKleur.Text);
                txtVoorbeeldHTMLCode.Text = resultaat2;
            }
                else if (checkBoxHyperlink.Checked) //zorgt voor openen in nieuw venster/tabblad
                    {
                        resultaat = String.Format("&lt;a&nbsp;target=&quot;_blank&quot;&nbsp;href=&quot;{0}&quot;&gt;&lt;img&nbsp;src=&quot;{1}&quot;&nbsp;title=&quot;{2}&quot;&nbsp;width=&quot;{3}&quot;&nbsp;height=&quot;{4}&quot;&nbsp;STYLE=&quot;border:&nbsp;solid&nbsp;{5}px&nbsp;#{6};&quot;&gt;&lt;/a&gt;", hyperlink, afbeeldingslocatie, omschrijving, breedte, hoogte, rand, lblKleur.Text);
                        txtTeKopierenHTMLCode.Text = resultaat;

                        resultaat2 = String.Format("<a target=\"_blank\" href=\"{0}\"><img src=\"{1}\" title=\"{2}\" width=\"{3}\" height=\"{4}\" STYLE=\"border: solid {5}px #{6};\"></a>", hyperlink, afbeeldingslocatie, omschrijving, breedte, hoogte, rand, lblKleur.Text);
                        txtVoorbeeldHTMLCode.Text = resultaat2;
                    }
                else if (checkBoxCentreren.Checked) //zorgt voor centrering
                    {
                        resultaat = String.Format("&lt;center&gt;&lt;a&nbsp;href=&quot;{0}&quot;&gt;&lt;img&nbsp;src=&quot;{1}&quot;&nbsp;title=&quot;{2}&quot;&nbsp;width=&quot;{3}&quot;&nbsp;height=&quot;{4}&quot;&nbsp;STYLE=&quot;border:&nbsp;solid&nbsp;{5}px&nbsp;#{6};&quot;&gt;&lt;/a&gt;&lt;/center&gt;", hyperlink, afbeeldingslocatie, omschrijving, breedte, hoogte, rand, lblKleur.Text);
                        txtTeKopierenHTMLCode.Text = resultaat;

                        resultaat2 = String.Format("<center><a href=\"{0}\"><img src=\"{1}\" title=\"{2}\" width=\"{3}\" height=\"{4}\" STYLE=\"border: solid {5}px #{6};\"></a></center>", hyperlink, afbeeldingslocatie, omschrijving, breedte, hoogte, rand, lblKleur.Text);
                        txtVoorbeeldHTMLCode.Text = resultaat2;
                    }
            else
            {
                resultaat = String.Format("&lt;a&nbsp;href=&quot;{0}&quot;&gt;&lt;img&nbsp;src=&quot;{1}&quot;&nbsp;title=&quot;{2}&quot;&nbsp;width=&quot;{3}&quot;&nbsp;height=&quot;{4}&quot;&nbsp;STYLE=&quot;border:&nbsp;solid&nbsp;{5}px&nbsp;#{6};&quot;&gt;&lt;/a&gt;", hyperlink, afbeeldingslocatie, omschrijving, breedte, hoogte, rand, lblKleur.Text);
                txtTeKopierenHTMLCode.Text = resultaat;

                resultaat2 = String.Format("<a href=\"{0}\"><img src=\"{1}\" title=\"{2}\" width=\"{3}\" height=\"{4}\" STYLE=\"border: solid {5}px #{6};\"></a>", hyperlink, afbeeldingslocatie, omschrijving, breedte, hoogte, rand, lblKleur.Text);
                txtVoorbeeldHTMLCode.Text = resultaat2;
            }
        }

        private void txtVoorbeeldHTMLCode_TextChanged(object sender, EventArgs e)
        {
            //Toont de voorbeeldcode omgezet in afbeelding in webbrowser
            webBrowserVoorbeeld.DocumentText = txtVoorbeeldHTMLCode.Text;
        }

        private void aflsuitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nieuwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Wist alle velden
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
            //Toont de informatie van het programma
            AboutBox1 over = new AboutBox1();
            over.ShowDialog();
        }

        private void AfbeeldingscodeGeneratorForm_Load(object sender, EventArgs e)
        {

        }

        private void opslaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opslaan van de te kopiëren HTML-code
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
            //Toont de helpfunctie wanneer je in de menu op help klikt
            Help.ShowHelp(this, "Help.chm");
            
        }

        private void controleerOpUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //handmatig controleren op updates
            System.Diagnostics.Process.Start("https://sourceforge.net/projects/afbeeldingscodegenerator/");
        }

        private void nederlandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Afbeeldingslocatie*:";
            label2.Text = "Omschrijving*:";
            label3.Text = "Hyperlink:";
            btnMaakCode.Text = "Maak Code";
            label4.Text = "Te kopiëren HTML-code:";
            label5.Text = "Voorbeeld HTML-code:";
            groupBox1.Text = "Opmaak (afm. in px)";
            label8.Text = "Breedte:";
            label9.Text = "Hoogte:";
            label11.Text = "Rand:";
            KleurRand.Text = "Kleur";
            checkBoxCentreren.Text = "Centreren: ";
            label6.Text = "Voorbeeld banner:";
            bestandToolStripMenuItem.Text = "&Bestand";
            nieuwToolStripMenuItem.Text = "&Nieuw";
            opslaanToolStripMenuItem.Text = "Op&slaan";
            aflsuitenToolStripMenuItem.Text = "&Aflsuiten";
            talenToolStripMenuItem.Text = "Talen";
            nederlandsToolStripMenuItem.Text = "Nederlands";
            fransToolStripMenuItem.Text = "Frans";
            engelsToolStripMenuItem.Text = "Engels";
            duitsToolStripMenuItem.Text = "Duits";
            f1ToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Text = "Help";
            overToolStripMenuItem.Text = "Over Afbeeldingscode generator";
            controleerOpUpdatesToolStripMenuItem.Text = "Controleer op updates";
            label7.Text = "* = verplicht";
            checkBoxHyperlink.Text = "Hyperlink openen in nieuw tabblad:";
        }

        private void engelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Image location*:";
            label2.Text = "Description*:";
            label3.Text = "Hyperlink:";
            btnMaakCode.Text = "Make Code";
            label4.Text = "HTML-code to copy:";
            label5.Text = "HTML-code example:";
            groupBox1.Text = "Layout (in px)";
            label8.Text = "Width:";
            label9.Text = "Height:";
            label11.Text = "Border:";
            KleurRand.Text = "Color";
            checkBoxCentreren.Text = "Center: ";
            label6.Text = "Banner example:";
            bestandToolStripMenuItem.Text = "&File";
            nieuwToolStripMenuItem.Text = "&New";
            opslaanToolStripMenuItem.Text = "&Save";
            aflsuitenToolStripMenuItem.Text = "&Exit";
            talenToolStripMenuItem.Text = "Language";
            nederlandsToolStripMenuItem.Text = "Dutch";
            fransToolStripMenuItem.Text = "French";
            engelsToolStripMenuItem.Text = "English";
            duitsToolStripMenuItem.Text = "German";
            f1ToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Text = "Help";
            overToolStripMenuItem.Text = "About Imagecode generator";
            controleerOpUpdatesToolStripMenuItem.Text = "Check for updates";
            label7.Text = "* = required";
            checkBoxHyperlink.Text = "Opens hyperlink in new window/tab:";
        }

        private void fransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Location d'image*:";
            label2.Text = "Description*:";
            label3.Text = "Le lien hypertexte:";
            btnMaakCode.Text = "Rendre le Code";
            label4.Text = "Code HTML à copier:";
            label5.Text = "Code HTML exemple:";
            groupBox1.Text = "Visualisation (en px)";
            label8.Text = "Largeur:";
            label9.Text = "Hauteur:";
            label11.Text = "Bordure:";
            KleurRand.Text = "Couleur";
            checkBoxCentreren.Text = "Centrer: ";
            label6.Text = "Bannière exemple:";
            bestandToolStripMenuItem.Text = "&Fichier";
            nieuwToolStripMenuItem.Text = "&Nouveau";
            opslaanToolStripMenuItem.Text = "Enregi&strer";
            aflsuitenToolStripMenuItem.Text = "Quit&er";
            talenToolStripMenuItem.Text = "Langue";
            nederlandsToolStripMenuItem.Text = "Néerlandais";
            fransToolStripMenuItem.Text = "Français";
            engelsToolStripMenuItem.Text = "Anglais";
            duitsToolStripMenuItem.Text = "Allemand";
            f1ToolStripMenuItem.Text = "Aide";
            helpToolStripMenuItem.Text = "Aide";
            overToolStripMenuItem.Text = "Au sujet de générateur du code image ";
            controleerOpUpdatesToolStripMenuItem.Text = "Véfifier pour des mise à jour";
            label7.Text = "* = obligé";
            checkBoxHyperlink.Text = "Ouvrir le lien hypertexte dans une nouvelle fenêtre:";
        }

        private void duitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Bild Lage*:";
            label2.Text = "Beschreibung*:";
            label3.Text = "Hyperlink:";
            btnMaakCode.Text = "Machen der Kode";
            label4.Text = "HTML Kode um kopieren:";
            label5.Text = "Vorbild HTML Kode:";
            groupBox1.Text = "Lay-out (en px)";
            label8.Text = "Breite:";
            label9.Text = "Höhe:";
            label11.Text = "Rand:";
            KleurRand.Text = "Farbe";
            checkBoxCentreren.Text = "Zentrieren: ";
            label6.Text = "Banner Vorbild:";
            bestandToolStripMenuItem.Text = "Datei";
            nieuwToolStripMenuItem.Text = "&Neu";
            opslaanToolStripMenuItem.Text = "Speichern";
            aflsuitenToolStripMenuItem.Text = "Beenden";
            talenToolStripMenuItem.Text = "Sprache";
            nederlandsToolStripMenuItem.Text = "Niederländisch";
            fransToolStripMenuItem.Text = "Französisch";
            engelsToolStripMenuItem.Text = "Englisch";
            duitsToolStripMenuItem.Text = "Deutsch";
            f1ToolStripMenuItem.Text = "Hilfe";
            helpToolStripMenuItem.Text = "Hilfe";
            overToolStripMenuItem.Text = "Über Bildkode Generator";
            controleerOpUpdatesToolStripMenuItem.Text = "Kontrollieren für Update";
            label7.Text = "* = verpflichtet";
            checkBoxHyperlink.Text = "Hyperlink in neuem Fenster  Öffnen:";
        }

        
        

    }
}
