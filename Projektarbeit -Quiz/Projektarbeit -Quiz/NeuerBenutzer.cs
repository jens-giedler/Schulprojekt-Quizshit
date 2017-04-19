using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektarbeit__Quiz
{
    public partial class NeuerBenutzer : Form
    {
        public NeuerBenutzer()
        {
            InitializeComponent();
        }

        //Resetett das Fenster, setzt es auf Hide und macht das Hauptmenü sichtbar.
        private void neuerBenutzerZurueck_Click(object sender, EventArgs e)
        {
            Form1.start_01.Show();
            Form1.neuerbenutzer_01.neuerBenutzerUngleich.Hide();
            Form1.neuerbenutzer_01.textBoxName.Text = "";
            Form1.neuerbenutzer_01.textBoxNameRepeat.Text = "";
            this.Hide();
        }

        //Wenn dieses Fenster geschlossen wird werden alle Fenster geschlossen.
        private void NeuerBenutzer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Vergleicht, ob die eingetragenen Usernames gleich sind. Wenn ja erstellt er neue Einträge in der Benutzer Tabelle. Bei Nein gibt er eine kleine Fehlermeldung aus.
        private void neuerBenutzerFertig_Click(object sender, EventArgs e)
        {
            if (Form1.neuerbenutzer_01.textBoxName.Text == Form1.neuerbenutzer_01.nameEingeben.Text)
            {
                Benutzer test = new Benutzer(1, Form1.neuerbenutzer_01.textBoxName.Text);
                DataGridViewRow row = (DataGridViewRow)Form1.databaseconnect_01.dataGridViewBenutzer.Rows[0].Clone();
                row.Cells[0].Value = test.getBeId();
                row.Cells[1].Value = test.getName();
                Form1.databaseconnect_01.dataGridViewBenutzer.Rows.Add(row);
            }
            else
            {
                Form1.neuerbenutzer_01.neuerBenutzerUngleich.Show();
            }
        }
    }
}
