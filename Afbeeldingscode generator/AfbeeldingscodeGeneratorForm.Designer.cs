namespace Afbeeldingscode_generator
{
    partial class AfbeeldingscodeGeneratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfbeeldingscodeGeneratorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aflsuitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAfbeeldingslocatie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOmschrijving = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHyperlink = new System.Windows.Forms.TextBox();
            this.btnMaakCode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTeKopierenHTMLCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVoorbeeldHTMLCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.webBrowserVoorbeeld = new System.Windows.Forms.WebBrowser();
            this.label7 = new System.Windows.Forms.Label();
            this.nieuwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opslaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Afbeeldingslocatie*:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.f1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuwToolStripMenuItem,
            this.opslaanToolStripMenuItem,
            this.aflsuitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "&Bestand";
            // 
            // aflsuitenToolStripMenuItem
            // 
            this.aflsuitenToolStripMenuItem.Name = "aflsuitenToolStripMenuItem";
            this.aflsuitenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aflsuitenToolStripMenuItem.Text = "&Aflsuiten";
            this.aflsuitenToolStripMenuItem.Click += new System.EventHandler(this.aflsuitenToolStripMenuItem_Click);
            // 
            // f1ToolStripMenuItem
            // 
            this.f1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.overToolStripMenuItem});
            this.f1ToolStripMenuItem.Name = "f1ToolStripMenuItem";
            this.f1ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.f1ToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // overToolStripMenuItem
            // 
            this.overToolStripMenuItem.Name = "overToolStripMenuItem";
            this.overToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.overToolStripMenuItem.Text = "Over Afbeeldingscode generator";
            this.overToolStripMenuItem.Click += new System.EventHandler(this.overToolStripMenuItem_Click);
            // 
            // txtAfbeeldingslocatie
            // 
            this.txtAfbeeldingslocatie.Location = new System.Drawing.Point(25, 58);
            this.txtAfbeeldingslocatie.Name = "txtAfbeeldingslocatie";
            this.txtAfbeeldingslocatie.Size = new System.Drawing.Size(415, 20);
            this.txtAfbeeldingslocatie.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Omschrijving*:";
            // 
            // txtOmschrijving
            // 
            this.txtOmschrijving.Location = new System.Drawing.Point(25, 117);
            this.txtOmschrijving.Name = "txtOmschrijving";
            this.txtOmschrijving.Size = new System.Drawing.Size(415, 20);
            this.txtOmschrijving.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hyperlink:";
            // 
            // txtHyperlink
            // 
            this.txtHyperlink.Location = new System.Drawing.Point(25, 176);
            this.txtHyperlink.Name = "txtHyperlink";
            this.txtHyperlink.Size = new System.Drawing.Size(415, 20);
            this.txtHyperlink.TabIndex = 6;
            // 
            // btnMaakCode
            // 
            this.btnMaakCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaakCode.Location = new System.Drawing.Point(147, 226);
            this.btnMaakCode.Name = "btnMaakCode";
            this.btnMaakCode.Size = new System.Drawing.Size(171, 42);
            this.btnMaakCode.TabIndex = 7;
            this.btnMaakCode.Text = "Maak Code";
            this.btnMaakCode.UseVisualStyleBackColor = true;
            this.btnMaakCode.Click += new System.EventHandler(this.btnMaakCode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Te kopiëren HTML-code:";
            // 
            // txtTeKopierenHTMLCode
            // 
            this.txtTeKopierenHTMLCode.Location = new System.Drawing.Point(25, 307);
            this.txtTeKopierenHTMLCode.Multiline = true;
            this.txtTeKopierenHTMLCode.Name = "txtTeKopierenHTMLCode";
            this.txtTeKopierenHTMLCode.Size = new System.Drawing.Size(415, 86);
            this.txtTeKopierenHTMLCode.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Voorbeeld HTML-code:";
            // 
            // txtVoorbeeldHTMLCode
            // 
            this.txtVoorbeeldHTMLCode.Location = new System.Drawing.Point(25, 422);
            this.txtVoorbeeldHTMLCode.Multiline = true;
            this.txtVoorbeeldHTMLCode.Name = "txtVoorbeeldHTMLCode";
            this.txtVoorbeeldHTMLCode.Size = new System.Drawing.Size(415, 86);
            this.txtVoorbeeldHTMLCode.TabIndex = 11;
            this.txtVoorbeeldHTMLCode.TextChanged += new System.EventHandler(this.txtVoorbeeldHTMLCode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(465, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Voorbeeld banner:";
            // 
            // webBrowserVoorbeeld
            // 
            this.webBrowserVoorbeeld.Location = new System.Drawing.Point(468, 58);
            this.webBrowserVoorbeeld.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserVoorbeeld.Name = "webBrowserVoorbeeld";
            this.webBrowserVoorbeeld.Size = new System.Drawing.Size(492, 450);
            this.webBrowserVoorbeeld.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "* = verplicht";
            // 
            // nieuwToolStripMenuItem
            // 
            this.nieuwToolStripMenuItem.Name = "nieuwToolStripMenuItem";
            this.nieuwToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nieuwToolStripMenuItem.Text = "&Nieuw";
            this.nieuwToolStripMenuItem.Click += new System.EventHandler(this.nieuwToolStripMenuItem_Click);
            // 
            // opslaanToolStripMenuItem
            // 
            this.opslaanToolStripMenuItem.Name = "opslaanToolStripMenuItem";
            this.opslaanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.opslaanToolStripMenuItem.Text = "Op&slaan";
            // 
            // AfbeeldingscodeGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 555);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.webBrowserVoorbeeld);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVoorbeeldHTMLCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTeKopierenHTMLCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMaakCode);
            this.Controls.Add(this.txtHyperlink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOmschrijving);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAfbeeldingslocatie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AfbeeldingscodeGeneratorForm";
            this.Text = "Afbeeldingscode generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aflsuitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAfbeeldingslocatie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOmschrijving;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHyperlink;
        private System.Windows.Forms.Button btnMaakCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTeKopierenHTMLCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVoorbeeldHTMLCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.WebBrowser webBrowserVoorbeeld;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem nieuwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opslaanToolStripMenuItem;
    }
}

