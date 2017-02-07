namespace Projektarbeit__Quiz
{
    partial class Highscore
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
            this.highscoreOben = new System.Windows.Forms.Label();
            this.highscore1 = new System.Windows.Forms.Label();
            this.highscore2 = new System.Windows.Forms.Label();
            this.highscore3 = new System.Windows.Forms.Label();
            this.highscore4 = new System.Windows.Forms.Label();
            this.highscore5 = new System.Windows.Forms.Label();
            this.highscoreZurueck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // highscoreOben
            // 
            this.highscoreOben.AutoSize = true;
            this.highscoreOben.Location = new System.Drawing.Point(222, 52);
            this.highscoreOben.Name = "highscoreOben";
            this.highscoreOben.Size = new System.Drawing.Size(55, 13);
            this.highscoreOben.TabIndex = 0;
            this.highscoreOben.Text = "Highscore";
            // 
            // highscore1
            // 
            this.highscore1.AutoSize = true;
            this.highscore1.Location = new System.Drawing.Point(162, 98);
            this.highscore1.Name = "highscore1";
            this.highscore1.Size = new System.Drawing.Size(61, 13);
            this.highscore1.TabIndex = 1;
            this.highscore1.Text = "Highscore1";
            // 
            // highscore2
            // 
            this.highscore2.AutoSize = true;
            this.highscore2.Location = new System.Drawing.Point(162, 122);
            this.highscore2.Name = "highscore2";
            this.highscore2.Size = new System.Drawing.Size(61, 13);
            this.highscore2.TabIndex = 2;
            this.highscore2.Text = "Highscore2";
            // 
            // highscore3
            // 
            this.highscore3.AutoSize = true;
            this.highscore3.Location = new System.Drawing.Point(162, 149);
            this.highscore3.Name = "highscore3";
            this.highscore3.Size = new System.Drawing.Size(61, 13);
            this.highscore3.TabIndex = 3;
            this.highscore3.Text = "Highscore3";
            // 
            // highscore4
            // 
            this.highscore4.AutoSize = true;
            this.highscore4.Location = new System.Drawing.Point(162, 175);
            this.highscore4.Name = "highscore4";
            this.highscore4.Size = new System.Drawing.Size(61, 13);
            this.highscore4.TabIndex = 4;
            this.highscore4.Text = "Highscore4";
            // 
            // highscore5
            // 
            this.highscore5.AutoSize = true;
            this.highscore5.Location = new System.Drawing.Point(162, 200);
            this.highscore5.Name = "highscore5";
            this.highscore5.Size = new System.Drawing.Size(61, 13);
            this.highscore5.TabIndex = 5;
            this.highscore5.Text = "Highscore5";
            // 
            // highscoreZurueck
            // 
            this.highscoreZurueck.Location = new System.Drawing.Point(472, 305);
            this.highscoreZurueck.Name = "highscoreZurueck";
            this.highscoreZurueck.Size = new System.Drawing.Size(75, 23);
            this.highscoreZurueck.TabIndex = 6;
            this.highscoreZurueck.Text = "Zurück";
            this.highscoreZurueck.UseVisualStyleBackColor = true;
            this.highscoreZurueck.Click += new System.EventHandler(this.highscoreZurueck_Click);
            // 
            // Highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 354);
            this.Controls.Add(this.highscoreZurueck);
            this.Controls.Add(this.highscore5);
            this.Controls.Add(this.highscore4);
            this.Controls.Add(this.highscore3);
            this.Controls.Add(this.highscore2);
            this.Controls.Add(this.highscore1);
            this.Controls.Add(this.highscoreOben);
            this.Name = "Highscore";
            this.Text = "Supertollesquiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label highscoreOben;
        private System.Windows.Forms.Label highscore1;
        private System.Windows.Forms.Label highscore2;
        private System.Windows.Forms.Label highscore3;
        private System.Windows.Forms.Label highscore4;
        private System.Windows.Forms.Label highscore5;
        private System.Windows.Forms.Button highscoreZurueck;
    }
}