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

        MySqlDataAdapter da1 = null;
        DataSet ds1 = null;

        MySqlDataAdapter da2 = null;
        DataSet ds2 = null;

        MySqlDataAdapter da3 = null;
        DataSet ds3 = null;

        MySqlDataAdapter da4 = null;
        DataSet ds4 = null;

        MySqlDataAdapter da5 = null;
        DataSet ds5 = null;
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
            ConnectDatabase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConnectDatabase()
        {
            MySqlConnection conn = null;
            try
            {
                string connStr = "server=127.0.0.1;user=root;database=quiz;";
                conn = new MySqlConnection(connStr);
                conn.Open();
                label_Connection.BackColor = Color.LightGreen;
                label_Connection.Text = "MySql-Server verbunden";
                //kategorie
                string sql1 = "SELECT * FROM kategorie";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                da1 = new MySqlDataAdapter(cmd1);
                ds1 = new DataSet();
                da1.Fill(ds1, "tErgebnismenge");
                dataGridViewKategorie.DataSource = ds1.Tables["tErgebnismenge"];
                MySqlCommandBuilder cb1 = new MySqlCommandBuilder(da1);
                da1.UpdateCommand = cb1.GetUpdateCommand();
                da1.DeleteCommand = cb1.GetDeleteCommand();
                da1.InsertCommand = cb1.GetInsertCommand();
                cb1.ConflictOption = ConflictOption.CompareAllSearchableValues;
                //benutzer
                string sql2 = "SELECT * FROM benutzer";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                da2 = new MySqlDataAdapter(cmd2);
                ds2 = new DataSet();
                da2.Fill(ds2, "tErgebnismenge");
                dataGridViewBenutzer.DataSource = ds2.Tables["tErgebnismenge"];
                MySqlCommandBuilder cb2 = new MySqlCommandBuilder(da2);
                da2.UpdateCommand = cb2.GetUpdateCommand();
                da2.DeleteCommand = cb2.GetDeleteCommand();
                da2.InsertCommand = cb2.GetInsertCommand();
                cb2.ConflictOption = ConflictOption.CompareAllSearchableValues;
                //ergebnis
                string sql3 = "SELECT * FROM ergebniss";
                MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                da3 = new MySqlDataAdapter(cmd3);
                ds3 = new DataSet();
                da3.Fill(ds3, "tErgebnismenge");
                dataGridViewErgebnis.DataSource = ds3.Tables["tErgebnismenge"];
                MySqlCommandBuilder cb3 = new MySqlCommandBuilder(da3);
                da3.UpdateCommand = cb3.GetUpdateCommand();
                da3.DeleteCommand = cb3.GetDeleteCommand();
                da3.InsertCommand = cb3.GetInsertCommand();
                cb3.ConflictOption = ConflictOption.CompareAllSearchableValues;
                //fragen
                string sql4 = "SELECT * FROM fragen";
                MySqlCommand cmd4 = new MySqlCommand(sql4, conn);
                da4 = new MySqlDataAdapter(cmd4);
                ds4 = new DataSet();
                da4.Fill(ds4, "tErgebnismenge");
                dataGridViewFragen.DataSource = ds4.Tables["tErgebnismenge"];
                MySqlCommandBuilder cb4 = new MySqlCommandBuilder(da4);
                da4.UpdateCommand = cb4.GetUpdateCommand();
                da4.DeleteCommand = cb4.GetDeleteCommand();
                da4.InsertCommand = cb4.GetInsertCommand();
                cb4.ConflictOption = ConflictOption.CompareAllSearchableValues;
                //frageninkategorie
                string sql5 = "SELECT * FROM frageninkategorie";
                MySqlCommand cmd5 = new MySqlCommand(sql5, conn);
                da5 = new MySqlDataAdapter(cmd5);
                ds5 = new DataSet();
                da5.Fill(ds5, "tErgebnismenge");
                dataGridViewFrageninkategorie.DataSource = ds5.Tables["tErgebnismenge"];
                MySqlCommandBuilder cb5 = new MySqlCommandBuilder(da5);
                da5.UpdateCommand = cb5.GetUpdateCommand();
                da5.DeleteCommand = cb5.GetDeleteCommand();
                da5.InsertCommand = cb5.GetInsertCommand();
                cb5.ConflictOption = ConflictOption.CompareAllSearchableValues;
            }
            catch (Exception e)
            {
                label_Connection.BackColor = Color.Red;
                label_Connection.Text = "Verbindung mit MySql-Server fehlgeschlagen";
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }


    }

    public class Benutzer
    {


        private int beId;
        private String name;
        private int farbe;
        private String musik;
        private Boolean ton;

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

        private String kaName;

        public String getKaName() { return kaName; }

    }
}




