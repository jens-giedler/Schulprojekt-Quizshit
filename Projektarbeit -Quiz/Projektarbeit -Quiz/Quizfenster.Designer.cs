namespace Projektarbeit__Quiz
{
    partial class Quizfenster
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
            this.fragenNummer = new System.Windows.Forms.Label();
            this.highscore = new System.Windows.Forms.Label();
            this.frageText = new System.Windows.Forms.Label();
            this.naechsteFrage = new System.Windows.Forms.Button();
            this.antwort1 = new System.Windows.Forms.RadioButton();
            this.antwort2 = new System.Windows.Forms.RadioButton();
            this.antwort3 = new System.Windows.Forms.RadioButton();
            this.antwort4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // fragenNummer
            // 
            this.fragenNummer.AutoSize = true;
            this.fragenNummer.Location = new System.Drawing.Point(289, 31);
            this.fragenNummer.Name = "fragenNummer";
            this.fragenNummer.Size = new System.Drawing.Size(76, 13);
            this.fragenNummer.TabIndex = 0;
            this.fragenNummer.Text = "fragenNummer";
            // 
            // highscore
            // 
            this.highscore.AutoSize = true;
            this.highscore.Location = new System.Drawing.Point(557, 20);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(53, 13);
            this.highscore.TabIndex = 1;
            this.highscore.Text = "highscore";
            // 
            // frageText
            // 
            this.frageText.AutoSize = true;
            this.frageText.Location = new System.Drawing.Point(43, 102);
            this.frageText.Name = "frageText";
            this.frageText.Size = new System.Drawing.Size(52, 13);
            this.frageText.TabIndex = 2;
            this.frageText.Text = "frageText";
            // 
            // naechsteFrage
            // 
            this.naechsteFrage.Location = new System.Drawing.Point(535, 347);
            this.naechsteFrage.Name = "naechsteFrage";
            this.naechsteFrage.Size = new System.Drawing.Size(75, 23);
            this.naechsteFrage.TabIndex = 7;
            this.naechsteFrage.Text = "naechste";
            this.naechsteFrage.UseVisualStyleBackColor = true;
            // 
            // antwort1
            // 
            this.antwort1.AutoSize = true;
            this.antwort1.Location = new System.Drawing.Point(156, 197);
            this.antwort1.Name = "antwort1";
            this.antwort1.Size = new System.Drawing.Size(66, 17);
            this.antwort1.TabIndex = 8;
            this.antwort1.TabStop = true;
            this.antwort1.Text = "antwort1";
            this.antwort1.UseVisualStyleBackColor = true;
            // 
            // antwort2
            // 
            this.antwort2.AutoSize = true;
            this.antwort2.Location = new System.Drawing.Point(156, 221);
            this.antwort2.Name = "antwort2";
            this.antwort2.Size = new System.Drawing.Size(66, 17);
            this.antwort2.TabIndex = 9;
            this.antwort2.TabStop = true;
            this.antwort2.Text = "antwort2";
            this.antwort2.UseVisualStyleBackColor = true;
            // 
            // antwort3
            // 
            this.antwort3.AutoSize = true;
            this.antwort3.Location = new System.Drawing.Point(156, 245);
            this.antwort3.Name = "antwort3";
            this.antwort3.Size = new System.Drawing.Size(66, 17);
            this.antwort3.TabIndex = 10;
            this.antwort3.TabStop = true;
            this.antwort3.Text = "antwort3";
            this.antwort3.UseVisualStyleBackColor = true;
            // 
            // antwort4
            // 
            this.antwort4.AutoSize = true;
            this.antwort4.Location = new System.Drawing.Point(156, 269);
            this.antwort4.Name = "antwort4";
            this.antwort4.Size = new System.Drawing.Size(66, 17);
            this.antwort4.TabIndex = 11;
            this.antwort4.TabStop = true;
            this.antwort4.Text = "antwort4";
            this.antwort4.UseVisualStyleBackColor = true;
            // 
            // Quizfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 394);
            this.Controls.Add(this.antwort4);
            this.Controls.Add(this.antwort3);
            this.Controls.Add(this.antwort2);
            this.Controls.Add(this.antwort1);
            this.Controls.Add(this.naechsteFrage);
            this.Controls.Add(this.frageText);
            this.Controls.Add(this.highscore);
            this.Controls.Add(this.fragenNummer);
            this.Name = "Quizfenster";
            this.Text = "Quizfenster";
            this.Load += new System.EventHandler(this.Quizfenster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fragenNummer;
        private System.Windows.Forms.Label highscore;
        private System.Windows.Forms.Label frageText;
        private System.Windows.Forms.Button naechsteFrage;
        private System.Windows.Forms.RadioButton antwort1;
        private System.Windows.Forms.RadioButton antwort2;
        private System.Windows.Forms.RadioButton antwort3;
        private System.Windows.Forms.RadioButton antwort4;
    }
}