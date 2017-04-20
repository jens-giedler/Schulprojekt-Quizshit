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
    public partial class Quizfenster : Form
    {
        public Quizfenster()
        {
            InitializeComponent();
        }

        Frage aktuelleFrage = new Frage(0, "", "", "", "", 0);

        private void Quizfenster_Load(object sender, EventArgs e)
        {

        }

        private void Quizfenster_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Holt sich entweder die Nächste Frage, oder wenn bereits die die Maximale Anzahl an Fragen gekommen ist, geht zum Hauptmenü über.
        private void naechsteFrage_Click(object sender, EventArgs e)
        {
            Form1.frageCounter = Form1.frageCounter + 1;
            if (frageÜberprüfen() == true)
            {
                if (Form1.frageCounter == Form1.databaseconnect_01.dataGridViewFragensatz.Rows.Count)
                {
                    Form1.menue_01.Show();
                    this.Hide();
                    //Leert den Fragensatz.
                    int temp = Form1.databaseconnect_01.dataGridViewFragensatz.Rows.Count;
                    temp = temp - 1;
                    while (Form1.databaseconnect_01.dataGridViewFragensatz.Rows.Count > 0)
                    {
                        Form1.databaseconnect_01.dataGridViewFragensatz.Rows.RemoveAt(temp);
                    }
                }
                else
                {
                    ladeNaechsteFrage(Form1.frageCounter);
                }
            }
            else
            {
                Form1.menue_01.Show();
                this.Hide();
                //Leert den Fragensatz.
                int temp = Form1.databaseconnect_01.dataGridViewFragensatz.Rows.Count;
                temp = temp - 1;
                while (Form1.databaseconnect_01.dataGridViewFragensatz.Rows.Count > 0)
                {
                    Form1.databaseconnect_01.dataGridViewFragensatz.Rows.RemoveAt(temp);
                }
            }
        }

        //Methode um den Inhalt der Nächsten Frage auf alle Labels des Quizfensters anzuzeigen. Dafür Läd er sich über eine Methode des Databaseconnects eine Frage.
        //Außerdem werden die Checkboxen zurückgesetzt.
        public void ladeNaechsteFrage(int nr)
        {
            Frage f = Form1.databaseconnect_01.getNextQuestionAusTabelle(nr);
            Form1.quizfenster_01.frageText.Text = f.getText();
            Form1.quizfenster_01.fragenNummer.Text = Convert.ToString(nr);
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
                    Popup p = new Popup("Verloren nach " + Form1.frageCounter + " Fragen!");
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
                    Popup p = new Popup("Verloren nach " + Form1.frageCounter + " Fragen!");
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
                    Popup p = new Popup("Verloren nach " + Form1.frageCounter + " Fragen!");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        

    }
}
