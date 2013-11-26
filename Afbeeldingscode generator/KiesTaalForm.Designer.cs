namespace Afbeeldingscode_generator
{
    partial class KiesTaalForm
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
            this.btnNederlands = new System.Windows.Forms.Button();
            this.btnFrans = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnDeutsch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNederlands
            // 
            this.btnNederlands.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNederlands.Location = new System.Drawing.Point(23, 22);
            this.btnNederlands.Name = "btnNederlands";
            this.btnNederlands.Size = new System.Drawing.Size(128, 35);
            this.btnNederlands.TabIndex = 0;
            this.btnNederlands.Text = "Nederlands";
            this.btnNederlands.UseVisualStyleBackColor = true;
            this.btnNederlands.Click += new System.EventHandler(this.btnNederlands_Click);
            // 
            // btnFrans
            // 
            this.btnFrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrans.Location = new System.Drawing.Point(23, 63);
            this.btnFrans.Name = "btnFrans";
            this.btnFrans.Size = new System.Drawing.Size(128, 35);
            this.btnFrans.TabIndex = 1;
            this.btnFrans.Text = "Français";
            this.btnFrans.UseVisualStyleBackColor = true;
            // 
            // btnEnglish
            // 
            this.btnEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglish.Location = new System.Drawing.Point(23, 104);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(128, 35);
            this.btnEnglish.TabIndex = 2;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = true;
            // 
            // btnDeutsch
            // 
            this.btnDeutsch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeutsch.Location = new System.Drawing.Point(23, 145);
            this.btnDeutsch.Name = "btnDeutsch";
            this.btnDeutsch.Size = new System.Drawing.Size(128, 35);
            this.btnDeutsch.TabIndex = 3;
            this.btnDeutsch.Text = "Deutsch";
            this.btnDeutsch.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Afbeeldingscode_generator.Properties.Resources.AfbeeldingscodeGeneratorLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(171, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // KiesTaalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 203);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeutsch);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnFrans);
            this.Controls.Add(this.btnNederlands);
            this.Name = "KiesTaalForm";
            this.Text = "Choose Language";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNederlands;
        private System.Windows.Forms.Button btnFrans;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnDeutsch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}