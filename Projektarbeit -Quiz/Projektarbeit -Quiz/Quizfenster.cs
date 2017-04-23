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
    //Fenster in der das Quiz schließlich Läuft.
    //Beinhaltet mehrere Methoden zum Verwalten der Fragen
    public partial class Quizfenster : Form
    {
        public Quizfenster()
        {
            InitializeComponent();
        }

        //Variable in der die Werte für die aktuelle Frage gespeichert werden
        Frage aktuelleFrage = new Frage(0, "", "", "", "", 0);

        private void Quizfenster_Load(object sender, EventArgs e)
        {

        }

        //Wenn dieses Fenster geschlossen wird schließen sich alle Fenster
        private void Quizfenster_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Holt sich entweder die Nächste Frage, oder wenn bereits die die Maximale Anzahl an Fragen gekommen ist, geht zum Hauptmenü über.
        private void naechsteFrage_Click(object sender, EventArgs e)
        {
            Form1.frageCounter = Form1.frageCounter + 1;
            Form1.selbeFrage = false;
            if (frageÜberprüfen() == true)
            {
                if (Form1.frageCounter == 20)
                {
                    Form1.menue_01.Show();
                    this.Hide();
                    //Leert den Fragensatz.
                    int temp = Form1.databaseconnect_01.dataGridViewFragensatz.Rows.Count;
                    temp = temp - 2;
                    Form1.frageCounter = 0;
                    for (int j = temp; Form1.databaseconnect_01.dataGridViewFragensatz.Rows.Count > 1; j--)
                    {
                        Form1.databaseconnect_01.dataGridViewFragensatz.Rows.RemoveAt(j);
                    }
                    Popup2 Sieg = new Popup2("Erfolgreich 20 Zufällige Fragen aus den Kategorien beantwortet!");
                }
                else
                {
                    while (Form1.selbeFrage == false)
                    {
                        RNGFrage(Form1.frageCounter);
                    }
                    ladeNaechsteFrage(Form1.globalInt);
                }
            }
            else
            {
                Form1.menue_01.Show();
                this.Hide();
                //Leert den Fragensatz.
                int temp = Form1.databaseconnect_01.dataGridViewFragensatz.Rows.Count;
                temp = temp - 2;
                Form1.frageCounter = 0;
                for (int j = temp; Form1.databaseconnect_01.dataGridViewFragensatz.Rows.Count > 1; j--)
                {
                    Form1.databaseconnect_01.dataGridViewFragensatz.Rows.RemoveAt(j);
                }
            }
        }

        //Methode um den Inhalt der Nächsten Frage auf alle Labels des Quizfensters anzuzeigen. Dafür Läd er sich über eine Methode des Databaseconnects eine Frage.
        //Außerdem werden die Checkboxen zurückgesetzt.
        public void ladeNaechsteFrage(int nr)
        {
            Frage f = Form1.databaseconnect_01.getNextQuestionAusTabelle(nr);
            Form1.quizfenster_01.frageText.Text = f.getText();
            Form1.quizfenster_01.fragenNummer.Text = Convert.ToString(Form1.frageCounter);
            Form1.quizfenster_01.antwort1.Text = f.getAntwortEins();
            Form1.quizfenster_01.antwort2.Text = f.getAntwortZwei();
            Form1.quizfenster_01.antwort3.Text = f.getAntwortDrei();
            Form1.quizfenster_01.antwort1.Checked = false;
            Form1.quizfenster_01.antwort2.Checked = false;
            Form1.quizfenster_01.antwort3.Checked = false;
            Form1.quizfenster_01.aktuelleFrage = f;
        }

        //Überprüft ob von der Aktuellen Frage die Richtige Lösung ausgewählt wurde.
        //Wenn das der Fall ist, läuft gibt die Methode ein "true" zurück. Wenn das nicht der fall ist Öffnet die Methode eine "Verloren"-Meldung
        //und gibt ein false zurück
        public bool frageÜberprüfen()
        {
            if (aktuelleFrage.getRichtigeAntwort() == 1)
            {
                if (Form1.quizfenster_01.antwort1.Checked == true)
                {
                    return true;
                }
                else
                {
                    Popup2 p = new Popup2("Verloren bei Frage " + Form1.frageCounter + " !");
                    p.Show();
                    return false;
                }
            }
            else if (aktuelleFrage.getRichtigeAntwort() == 2)
            {
                if (Form1.quizfenster_01.antwort2.Checked == true)
                {
                    return true;
                }
                else
                {
                    Popup2 p = new Popup2("Verloren bei Frage " + Form1.frageCounter + " !");
                    p.Show();
                    return false;
                }
            }
            else if (aktuelleFrage.getRichtigeAntwort() == 3)
            {
                if (Form1.quizfenster_01.antwort3.Checked == true)
                {
                    return true;
                }
                else
                {
                    Popup2 p = new Popup2("Verloren bei Frage " + Form1.frageCounter + " !");
                    p.Show();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        //Wählt eine zufällige Frage aus dem Fragensatz. Überprüft anschließend ob die Frage bereits vorgekommen ist.
        public void RNGFrage(int i)
        {
            int rng = 0;
            int Wiederholungcounter = 0;
            Random rnd1 = new Random();
            rng = rnd1.Next(Form1.databaseconnect_01.dataGridViewFragensatz.Rows.Count - 1);

            foreach (String s in Form1.rngListe)
            {
                if (Form1.databaseconnect_01.dataGridViewFragensatz[0, rng].Value.ToString() == s)
                {
                    Wiederholungcounter = Wiederholungcounter + 1;
                }

            }
            if (Wiederholungcounter == 0)
            {
                Form1.rngListe.SetValue(Form1.databaseconnect_01.dataGridViewFragensatz[0, i].ToString(), i);
                Form1.selbeFrage = true;
                Form1.globalInt = rng;
            }

        }
    }
}
