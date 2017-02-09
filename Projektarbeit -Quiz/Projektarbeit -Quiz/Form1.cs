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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Start start_01 = new Start();
        public static Menü menue_01 = new Menü();
        public static Highscore highscore_01 = new Highscore();
        public static NeuerBenutzer neuerbenutzer_01 = new NeuerBenutzer();
        public static Quizfenster quizfenster_01 = new Quizfenster();

        public static Benutzer Max = new Benutzer();

        private void timer1_Tick(object sender, EventArgs e)
        {
            start_01.Show();
            this.Hide();
            menue_01.Hide();
            highscore_01.Hide();
            neuerbenutzer_01.Hide();
            quizfenster_01.Hide();
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }

    public class Benutzer {


        private int beId;
        private String name;
        private int farbe;
        private String musik;
        private Boolean ton;
        private Array kategorieListe;

        public String getName() { return name; }
        public int getFarbe() { return farbe; }
        public String getMusik() { return musik; }
        public Boolean getTon() { return ton; }

        public void setName(String n) { name = n; }
        public void setFarbe(int f) { farbe = f; }
        public void setMusik(String m) { musik = m; }
        public void setTon(Boolean t) { ton = t; }

    }

    public class Frage {

        private int frId;
        private String text;
        private String antwortEins;
        private String antwortZwei;
        private String antwortDrei;
        private String antwortVier;
        private int richtigeAntwort;

        public String getText() { return text; }
        public String getAntwortEins() { return antwortEins; }
        public String getAntwortZwei() { return antwortZwei; }
        public String getAntwortDrei() { return antwortDrei; }
        public String getAntwortVier() { return antwortVier; }
        public int getRichtigeAntwort() { return richtigeAntwort; }


    }

    public class Kategorie { 
    }

}
