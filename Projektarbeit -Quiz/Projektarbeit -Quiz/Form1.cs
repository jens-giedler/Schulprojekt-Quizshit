using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

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
        public static DatabaseConnect databaseconnect_01 = new DatabaseConnect();

        public static int frageCounter = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            start_01.Show();
            //this.Hide();
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

    public class Benutzer
    {

        public Benutzer(int id, String na)
        {
            this.beId = id;
            this.name = na;
        }
        private int beId;
        private String name;
        private int farbe;
        private String musik;
        private Boolean ton;

        public int getBeId() { return beId; }
        public String getName() { return name; }
        public int getFarbe() { return farbe; }
        public String getMusik() { return musik; }
        public Boolean getTon() { return ton; }

        public void setName(String n) { name = n; }
        public void setFarbe(int f) { farbe = f; }
        public void setMusik(String m) { musik = m; }
        public void setTon(Boolean t) { ton = t; }

    }

    public class Frage
    {
        public Frage(int id, String txt, String aeins, String azwei, String adrei, int ra)
        {
            this.frId = id;
            this.text = txt;
            this.antwortEins = aeins;
            this.antwortZwei = azwei;
            this.antwortDrei = adrei;
            this.richtigeAntwort = ra;
        }

        private int frId;
        private String text;
        private String antwortEins;
        private String antwortZwei;
        private String antwortDrei;
        private int richtigeAntwort;

        public String getText() { return text; }
        public String getAntwortEins() { return antwortEins; }
        public String getAntwortZwei() { return antwortZwei; }
        public String getAntwortDrei() { return antwortDrei; }
        public int getRichtigeAntwort() { return richtigeAntwort; }


    }

    public class Kategorie
    {
        public Kategorie(String name)
        {
            this.kaName = name;
        }

        private String kaName;

        public String getKaName() { return kaName; }

    }
}




