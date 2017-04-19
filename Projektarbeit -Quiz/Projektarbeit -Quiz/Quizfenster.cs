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
            if (Form1.frageCounter == Form1.databaseconnect_01.dataGridViewFragensatz.Rows.Count)
            {
                Form1.menue_01.Show();
                this.Hide();
            }
            else
            {
                ladeNaechsteFrage(Form1.frageCounter);
            }
        }

        //Methode um den Inhalt der Nächsten Frage auf alle Labels des Quizfensters anzuzeigen. Dafür Läd er sich über eine Methode des Databaseconnects eine Frage.
        public void ladeNaechsteFrage(int nr)
        {

            Frage f = Form1.databaseconnect_01.getNextQuestionAusTabelle(nr);
            Form1.quizfenster_01.frageText.Text = f.getText();
            Form1.quizfenster_01.fragenNummer.Text = Convert.ToString(nr);
            Form1.quizfenster_01.antwort1.Text = f.getAntwortEins();
            Form1.quizfenster_01.antwort2.Text = f.getAntwortZwei();
            Form1.quizfenster_01.antwort3.Text = f.getAntwortDrei();
        }

    }
}
