namespace Projektarbeit__Quiz
{
    partial class DatabaseConnect
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_Connection = new System.Windows.Forms.Label();
            this.dataGridViewKategorie = new System.Windows.Forms.DataGridView();
            this.dataGridViewBenutzer = new System.Windows.Forms.DataGridView();
            this.dataGridViewErgebnis = new System.Windows.Forms.DataGridView();
            this.dataGridViewFragen = new System.Windows.Forms.DataGridView();
            this.dataGridViewFrageninkategorie = new System.Windows.Forms.DataGridView();
            this.dataGridViewFragensatz = new System.Windows.Forms.DataGridView();
            this.FrID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FragenText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antwort1Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antwort2Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antwort3Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RichtigeAntwort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBenutzer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErgebnis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFragen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrageninkategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFragensatz)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Connection
            // 
            this.label_Connection.AutoSize = true;
            this.label_Connection.Location = new System.Drawing.Point(12, 9);
            this.label_Connection.Name = "label_Connection";
            this.label_Connection.Size = new System.Drawing.Size(89, 13);
            this.label_Connection.TabIndex = 0;
            this.label_Connection.Text = "label_Connection";
            // 
            // dataGridViewKategorie
            // 
            this.dataGridViewKategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategorie.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewKategorie.Name = "dataGridViewKategorie";
            this.dataGridViewKategorie.Size = new System.Drawing.Size(288, 155);
            this.dataGridViewKategorie.TabIndex = 1;
            // 
            // dataGridViewBenutzer
            // 
            this.dataGridViewBenutzer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBenutzer.Location = new System.Drawing.Point(306, 41);
            this.dataGridViewBenutzer.Name = "dataGridViewBenutzer";
            this.dataGridViewBenutzer.Size = new System.Drawing.Size(283, 155);
            this.dataGridViewBenutzer.TabIndex = 2;
            // 
            // dataGridViewErgebnis
            // 
            this.dataGridViewErgebnis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewErgebnis.Location = new System.Drawing.Point(595, 41);
            this.dataGridViewErgebnis.Name = "dataGridViewErgebnis";
            this.dataGridViewErgebnis.Size = new System.Drawing.Size(275, 155);
            this.dataGridViewErgebnis.TabIndex = 3;
            // 
            // dataGridViewFragen
            // 
            this.dataGridViewFragen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFragen.Location = new System.Drawing.Point(12, 202);
            this.dataGridViewFragen.Name = "dataGridViewFragen";
            this.dataGridViewFragen.Size = new System.Drawing.Size(288, 174);
            this.dataGridViewFragen.TabIndex = 4;
            // 
            // dataGridViewFrageninkategorie
            // 
            this.dataGridViewFrageninkategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFrageninkategorie.Location = new System.Drawing.Point(306, 202);
            this.dataGridViewFrageninkategorie.Name = "dataGridViewFrageninkategorie";
            this.dataGridViewFrageninkategorie.Size = new System.Drawing.Size(283, 174);
            this.dataGridViewFrageninkategorie.TabIndex = 5;
            // 
            // dataGridViewFragensatz
            // 
            this.dataGridViewFragensatz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFragensatz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FrID,
            this.FragenText,
            this.Antwort1Text,
            this.Antwort2Text,
            this.Antwort3Text,
            this.RichtigeAntwort});
            this.dataGridViewFragensatz.Location = new System.Drawing.Point(595, 202);
            this.dataGridViewFragensatz.Name = "dataGridViewFragensatz";
            this.dataGridViewFragensatz.Size = new System.Drawing.Size(275, 174);
            this.dataGridViewFragensatz.TabIndex = 6;
            // 
            // FrID
            // 
            this.FrID.HeaderText = "FrID";
            this.FrID.Name = "FrID";
            // 
            // FragenText
            // 
            this.FragenText.HeaderText = "FragenText";
            this.FragenText.Name = "FragenText";
            // 
            // Antwort1Text
            // 
            this.Antwort1Text.HeaderText = "Antwort1Text";
            this.Antwort1Text.Name = "Antwort1Text";
            // 
            // Antwort2Text
            // 
            this.Antwort2Text.HeaderText = "Antwort2Text";
            this.Antwort2Text.Name = "Antwort2Text";
            // 
            // Antwort3Text
            // 
            this.Antwort3Text.HeaderText = "Antwort3Text";
            this.Antwort3Text.Name = "Antwort3Text";
            // 
            // RichtigeAntwort
            // 
            this.RichtigeAntwort.HeaderText = "RichtigeAntwort";
            this.RichtigeAntwort.Name = "RichtigeAntwort";
            // 
            // DatabaseConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 476);
            this.Controls.Add(this.dataGridViewFragensatz);
            this.Controls.Add(this.dataGridViewFrageninkategorie);
            this.Controls.Add(this.dataGridViewFragen);
            this.Controls.Add(this.dataGridViewErgebnis);
            this.Controls.Add(this.dataGridViewBenutzer);
            this.Controls.Add(this.dataGridViewKategorie);
            this.Controls.Add(this.label_Connection);
            this.Name = "DatabaseConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabaseConnect";
            this.Load += new System.EventHandler(this.DatabaseConnect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBenutzer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErgebnis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFragen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrageninkategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFragensatz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // DataGridViews aus Mangel einer besseren Lösung auf public gesetzt damit diese von anderen Forms direkt verändert werden können.
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_Connection;
        public System.Windows.Forms.DataGridView dataGridViewKategorie;
        public System.Windows.Forms.DataGridView dataGridViewBenutzer;
        public System.Windows.Forms.DataGridView dataGridViewErgebnis;
        public System.Windows.Forms.DataGridView dataGridViewFragen;
        public System.Windows.Forms.DataGridView dataGridViewFrageninkategorie;
        public System.Windows.Forms.DataGridView dataGridViewFragensatz;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FragenText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antwort1Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antwort2Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antwort3Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn RichtigeAntwort;
    }
}