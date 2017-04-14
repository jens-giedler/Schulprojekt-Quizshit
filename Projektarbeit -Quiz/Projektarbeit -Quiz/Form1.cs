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

        MySqlDataAdapter da = null;
        DataSet ds = null;
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
                string sql = "SELECT * FROM kategorie";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                da = new MySqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "tErgebnismenge");
                dataGridView1.DataSource = ds.Tables["tErgebnismenge"];
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                da.UpdateCommand = cb.GetUpdateCommand();
                da.DeleteCommand = cb.GetDeleteCommand();
                da.InsertCommand = cb.GetInsertCommand();
                cb.ConflictOption = ConflictOption.CompareAllSearchableValues;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


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



