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
    //Hauptmenü des Spiels. Von Hier kann man das Quiz Starten.
    //Man kann im aktuellen Format Hier auswählen, aus welchen Kategorien Fragen geladen werden sowie welche Hintergrundsfarbe das Quizfenster hat.
    //Geplante Features: Musikwahl, an & ausschalten des Tons, Wechseln des Benutzernamens, Highscoreliste.
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }
        
        private void Menü_Load(object sender, EventArgs e)
        {

        }

        //Methode um die checkedListBox im Hauptmenü zu füllen. Ruft dafür eine Methode aus DatabaseConnect auf um ein Array aus Strings zu füllen.
        //Anschließend Füllt er die Box mit den Arrayeinträgen.
        public void checkedListBoxFill()
        {
            String[] a = Form1.databaseconnect_01.getKategorienAusTabelle();

            for (int i = 0; i < Form1.databaseconnect_01.dataGridViewKategorie.Rows.Count - 1; i++)
            {
                this.kategorieCheckList.Items.Add(a.GetValue(i));
            }
        }


        //Änderung der Farbe über ein colorDialog. Verändert die Farbe eines kleinen bereiches neben dem Knopf sowie von dem Quizfenster.
        private void colorDialog_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                farbFeld.BackColor = colorDialog1.Color;
                //this.BackColor = colorDialog1.Color;
                Form1.quizfenster_01.BackColor = colorDialog1.Color;
            }
        }


        //Wenn dieses Fenster geschlossen wird werden alle Fenster geschlossen.
        private void Menü_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        //Starten des Quizes. Setzt den frageCounter auf 0 (falls dieser von einem Vergangenen Quiz noch einen Wert hatte).
        //Führt anschließend eine Methode aus dem Quizfenster aus. Zeigt das Quizfenster an und versteckt das Menü.
        //Falls keine Kategorie ausgewählt ist kommt nur eine Meldung, das eine Ausgewählt werden soll.
        private void menueQuizStart_Click(object sender, EventArgs e)
        {
            if (Form1.menue_01.kategorieCheckList.CheckedItems.Count > 0)
            {
                Form1.frageCounter = 0;
                Form1.databaseconnect_01.fragensatzErstellen();
                while (Form1.selbeFrage == false)
                {
                    Form1.quizfenster_01.RNGFrage(Form1.frageCounter);
                }
                Form1.quizfenster_01.ladeNaechsteFrage(Form1.globalInt);
                for (int j = 0; j < Form1.rngListe.Length; j++)
                {
                    Form1.rngListe.SetValue("", j);
                }
                Form1.quizfenster_01.Show();
                this.Hide();
            }
            else
            {
                Popup2 Kategoriewahl = new Popup2("Bitte Kategorie Auswählen");
                Kategoriewahl.Show();
            }
            
        }
    }
}
