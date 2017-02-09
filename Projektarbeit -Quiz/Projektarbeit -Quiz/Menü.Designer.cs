namespace Projektarbeit__Quiz
{
    partial class Menü
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
            this.kategorieCheckList = new System.Windows.Forms.CheckedListBox();
            this.kategorien = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ton = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog = new System.Windows.Forms.Button();
            this.musik = new System.Windows.Forms.Label();
            this.farbFeld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kategorieCheckList
            // 
            this.kategorieCheckList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.kategorieCheckList.FormattingEnabled = true;
            this.kategorieCheckList.Items.AddRange(new object[] {
            "Wasser",
            "Erde",
            "Luft",
            "Feuer",
            "Doch",
            "alles ",
            "änderte ",
            "sich",
            "als ",
            "die ",
            "Feuernation ",
            "angriff",
            "stuff",
            "shit",
            "quiz",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "",
            "shit"});
            this.kategorieCheckList.Location = new System.Drawing.Point(0, 61);
            this.kategorieCheckList.Name = "kategorieCheckList";
            this.kategorieCheckList.Size = new System.Drawing.Size(352, 274);
            this.kategorieCheckList.TabIndex = 1;
            this.kategorieCheckList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // kategorien
            // 
            this.kategorien.AutoSize = true;
            this.kategorien.Location = new System.Drawing.Point(144, 22);
            this.kategorien.Name = "kategorien";
            this.kategorien.Size = new System.Drawing.Size(58, 13);
            this.kategorien.TabIndex = 2;
            this.kategorien.Text = "Kategorien";
            this.kategorien.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(531, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.SystemColors.Control;
            this.name.Location = new System.Drawing.Point(467, 77);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(58, 13);
            this.name.TabIndex = 5;
            this.name.Text = "Username:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(531, 160);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // ton
            // 
            this.ton.AutoSize = true;
            this.ton.Location = new System.Drawing.Point(531, 201);
            this.ton.Name = "ton";
            this.ton.Size = new System.Drawing.Size(45, 17);
            this.ton.TabIndex = 8;
            this.ton.Text = "Ton";
            this.ton.UseVisualStyleBackColor = true;
            this.ton.CheckedChanged += new System.EventHandler(this.ton_CheckedChanged);
            // 
            // colorDialog
            // 
            this.colorDialog.Location = new System.Drawing.Point(531, 116);
            this.colorDialog.Name = "colorDialog";
            this.colorDialog.Size = new System.Drawing.Size(75, 23);
            this.colorDialog.TabIndex = 9;
            this.colorDialog.Text = "Farbe";
            this.colorDialog.UseVisualStyleBackColor = true;
            this.colorDialog.Click += new System.EventHandler(this.colorDialog_Click);
            // 
            // musik
            // 
            this.musik.AutoSize = true;
            this.musik.Location = new System.Drawing.Point(478, 163);
            this.musik.Name = "musik";
            this.musik.Size = new System.Drawing.Size(38, 13);
            this.musik.TabIndex = 10;
            this.musik.Text = "Musik:";
            // 
            // farbFeld
            // 
            this.farbFeld.AutoSize = true;
            this.farbFeld.Location = new System.Drawing.Point(620, 120);
            this.farbFeld.Name = "farbFeld";
            this.farbFeld.Size = new System.Drawing.Size(16, 13);
            this.farbFeld.TabIndex = 11;
            this.farbFeld.Text = "   ";
            this.farbFeld.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 398);
            this.Controls.Add(this.farbFeld);
            this.Controls.Add(this.musik);
            this.Controls.Add(this.colorDialog);
            this.Controls.Add(this.ton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.kategorien);
            this.Controls.Add(this.kategorieCheckList);
            this.Name = "Menü";
            this.Text = "Supertollesquiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menü_FormClosing);
            this.Load += new System.EventHandler(this.Menü_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox kategorieCheckList;
        private System.Windows.Forms.Label kategorien;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox ton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorDialog;
        private System.Windows.Forms.Label musik;
        private System.Windows.Forms.Label farbFeld;
    }
}