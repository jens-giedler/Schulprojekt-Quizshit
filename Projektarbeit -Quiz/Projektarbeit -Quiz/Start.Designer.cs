namespace Projektarbeit__Quiz
{
    partial class Start
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.startStart = new System.Windows.Forms.Button();
            this.startDropDown = new System.Windows.Forms.ComboBox();
            this.startNeuerBenutzer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startStart
            // 
            this.startStart.Location = new System.Drawing.Point(195, 361);
            this.startStart.Name = "startStart";
            this.startStart.Size = new System.Drawing.Size(486, 88);
            this.startStart.TabIndex = 0;
            this.startStart.Text = "Start";
            this.startStart.UseVisualStyleBackColor = true;
            this.startStart.Click += new System.EventHandler(this.startStart_Click);
            // 
            // startDropDown
            // 
            this.startDropDown.FormattingEnabled = true;
            this.startDropDown.Location = new System.Drawing.Point(195, 210);
            this.startDropDown.Name = "startDropDown";
            this.startDropDown.Size = new System.Drawing.Size(446, 21);
            this.startDropDown.TabIndex = 1;
            // 
            // startNeuerBenutzer
            // 
            this.startNeuerBenutzer.Location = new System.Drawing.Point(251, 255);
            this.startNeuerBenutzer.Name = "startNeuerBenutzer";
            this.startNeuerBenutzer.Size = new System.Drawing.Size(334, 35);
            this.startNeuerBenutzer.TabIndex = 2;
            this.startNeuerBenutzer.Text = "Neuer Benutzer";
            this.startNeuerBenutzer.UseVisualStyleBackColor = true;
            this.startNeuerBenutzer.Click += new System.EventHandler(this.startNeuerBenutzer_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 554);
            this.Controls.Add(this.startNeuerBenutzer);
            this.Controls.Add(this.startDropDown);
            this.Controls.Add(this.startStart);
            this.Name = "Start";
            this.Text = "Supertollesquiz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startStart;
        private System.Windows.Forms.ComboBox startDropDown;
        private System.Windows.Forms.Button startNeuerBenutzer;
    }
}

