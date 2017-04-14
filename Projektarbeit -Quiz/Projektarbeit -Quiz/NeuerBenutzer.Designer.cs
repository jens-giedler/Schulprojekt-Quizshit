namespace Projektarbeit__Quiz
{
    partial class NeuerBenutzer
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.neuerName = new System.Windows.Forms.Label();
            this.nameEingeben = new System.Windows.Forms.Label();
            this.nameWiederholen = new System.Windows.Forms.Label();
            this.neuerBenutzerFertig = new System.Windows.Forms.Button();
            this.neuerBenutzerZurueck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // neuerName
            // 
            this.neuerName.AutoSize = true;
            this.neuerName.Location = new System.Drawing.Point(199, 73);
            this.neuerName.Name = "neuerName";
            this.neuerName.Size = new System.Drawing.Size(123, 13);
            this.neuerName.TabIndex = 2;
            this.neuerName.Text = "Neuer Benutzer erstellen";
            // 
            // nameEingeben
            // 
            this.nameEingeben.AutoSize = true;
            this.nameEingeben.Location = new System.Drawing.Point(90, 137);
            this.nameEingeben.Name = "nameEingeben";
            this.nameEingeben.Size = new System.Drawing.Size(106, 13);
            this.nameEingeben.TabIndex = 3;
            this.nameEingeben.Text = "Bitte Name eingeben";
            // 
            // nameWiederholen
            // 
            this.nameWiederholen.AutoSize = true;
            this.nameWiederholen.Location = new System.Drawing.Point(90, 177);
            this.nameWiederholen.Name = "nameWiederholen";
            this.nameWiederholen.Size = new System.Drawing.Size(95, 13);
            this.nameWiederholen.TabIndex = 4;
            this.nameWiederholen.Text = "Name wiederholen";
            // 
            // neuerBenutzerFertig
            // 
            this.neuerBenutzerFertig.Location = new System.Drawing.Point(400, 358);
            this.neuerBenutzerFertig.Name = "neuerBenutzerFertig";
            this.neuerBenutzerFertig.Size = new System.Drawing.Size(75, 23);
            this.neuerBenutzerFertig.TabIndex = 5;
            this.neuerBenutzerFertig.Text = "Erstellen";
            this.neuerBenutzerFertig.UseVisualStyleBackColor = true;
            // 
            // neuerBenutzerZurueck
            // 
            this.neuerBenutzerZurueck.Location = new System.Drawing.Point(311, 358);
            this.neuerBenutzerZurueck.Name = "neuerBenutzerZurueck";
            this.neuerBenutzerZurueck.Size = new System.Drawing.Size(75, 23);
            this.neuerBenutzerZurueck.TabIndex = 6;
            this.neuerBenutzerZurueck.Text = "Zurück";
            this.neuerBenutzerZurueck.UseVisualStyleBackColor = true;
            this.neuerBenutzerZurueck.Click += new System.EventHandler(this.neuerBenutzerZurueck_Click);
            // 
            // NeuerBenutzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 414);
            this.Controls.Add(this.neuerBenutzerZurueck);
            this.Controls.Add(this.neuerBenutzerFertig);
            this.Controls.Add(this.nameWiederholen);
            this.Controls.Add(this.nameEingeben);
            this.Controls.Add(this.neuerName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "NeuerBenutzer";
            this.Text = "Supertollesquiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NeuerBenutzer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label neuerName;
        private System.Windows.Forms.Label nameEingeben;
        private System.Windows.Forms.Label nameWiederholen;
        private System.Windows.Forms.Button neuerBenutzerFertig;
        private System.Windows.Forms.Button neuerBenutzerZurueck;
    }
}