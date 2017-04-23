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
    //Fenster in dem die Highscoreliste geladen wird.
    //Wird aktuell nicht verwendet.
    public partial class Highscore : Form
    {
        public Highscore()
        {
            InitializeComponent();
        }

        public static Form highscore_1 = new Form();

        //Versteckt dieses Fenster, Zeigt das Hauptmenü.
        private void highscoreZurueck_Click(object sender, EventArgs e)
        {
            Form1.menue_01.Show();
            this.Hide();
        }

        private void Highscore_Load(object sender, EventArgs e)
        {

        }

        //Wenn dieses Fenster geschlossen wird, werden alle Fenster geschlossen.
        private void Highscore_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void setHighscoreLabel1(String s)
        {
            this.highscore1.Text = s;
        }

        public void setHighscoreLabel2(String s)
        {
            this.highscore2.Text = s;
        }

        public void setHighscoreLabel3(String s)
        {
            this.highscore3.Text = s;
        }

        public void setHighscoreLabel4(String s)
        {
            this.highscore4.Text = s;
        }

        public void setHighscoreLabel5(String s)
        {
            this.highscore5.Text = s;
        }

    }
}
