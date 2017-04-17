namespace Projektarbeit__Quiz
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBenutzer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErgebnis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFragen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrageninkategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 476);
            this.Controls.Add(this.dataGridViewFrageninkategorie);
            this.Controls.Add(this.dataGridViewFragen);
            this.Controls.Add(this.dataGridViewErgebnis);
            this.Controls.Add(this.dataGridViewBenutzer);
            this.Controls.Add(this.dataGridViewKategorie);
            this.Controls.Add(this.label_Connection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBenutzer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErgebnis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFragen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrageninkategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_Connection;
        private System.Windows.Forms.DataGridView dataGridViewKategorie;
        private System.Windows.Forms.DataGridView dataGridViewBenutzer;
        private System.Windows.Forms.DataGridView dataGridViewErgebnis;
        private System.Windows.Forms.DataGridView dataGridViewFragen;
        private System.Windows.Forms.DataGridView dataGridViewFrageninkategorie;
    }
}