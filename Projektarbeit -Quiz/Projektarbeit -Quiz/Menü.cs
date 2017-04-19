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
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }

        public static Form menue_1 = new Form();
        
        private void Menü_Load(object sender, EventArgs e)
        {

        }

        //Methode um die checkedListBox im Hauptmenü zu füllen. Ruft dafür eine Methode aus DatabaseConnect auf um ein Array aus Strings zu füllen.
        //Anschließend Füllt er die Box mit den Arrayeinträgen.
        public void checkedListBoxFill()
        {
            String[] a = Form1.databaseconnect_01.getKategorienAusTabelle();

            for (int i = 0; i < 10; i++)
            {
                this.kategorieCheckList.Items.Add(a.GetValue(i));
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ton_CheckedChanged(object sender, EventArgs e)
        {

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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //Wenn dieses Fenster geschlossen wird werden alle Fenster geschlossen.
        private void Menü_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Starten des Quizes. Setzt den frageCounter auf 0 (falls dieser von einem Vergangenen Quiz noch einen Wert hatte).
        //Führt anschließend eine Methode aus dem Quizfenster aus. Zeigt das Quizfenster an und versteckt das Menü.
        private void menueQuizStart_Click(object sender, EventArgs e)
        {
            Form1.frageCounter = 0;
            Form1.quizfenster_01.ladeNaechsteFrage(Form1.frageCounter);
            Form1.quizfenster_01.Show();
            this.Hide();
            
        }
    }
}
