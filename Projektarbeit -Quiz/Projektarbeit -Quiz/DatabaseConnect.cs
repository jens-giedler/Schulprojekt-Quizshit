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
    public partial class DatabaseConnect : Form
    {

        public DatabaseConnect()
        {
            InitializeComponent();
        }

        //Variablen für den Connector
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

        //MySqlDataAdapter da6 = null;
        //DataSet ds6 = null;

        //Beim Starten des Fensters wird die Methode ConnectDatabase ausgeführt. Dadurch wird sofort mit der Datenbank verbunden.
        private void DatabaseConnect_Load(object sender, EventArgs e)
        {
            ConnectDatabase();
        }

        //Wenn dieses Fenster geschlossen wird, werden alle Fenster geschlossen
        private void DatabaseConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Verbindet das Programm mit mehreren Tabellen aus einer mysql-Datenbank.
        //Läd sich die 5 Tabellen und schreibt diese in eine jeweilig eigene DataGridView.
        public void ConnectDatabase()
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
                string sql3 = "SELECT * FROM ergebnis";
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
                //frageinkategorie
                string sql5 = "SELECT * FROM frageinkategorie";
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
                //fragensatz (leere Tabelle mit den Selben Spalten wie fragen)
                //string sql6 = "SELECT * FROM fragensatz";
                //MySqlCommand cmd6 = new MySqlCommand(sql6, conn);
                //da6 = new MySqlDataAdapter(cmd6);
                //ds6 = new DataSet();
                //da6.Fill(ds6, "tErgebnismenge");
                //dataGridViewFragensatz.DataSource = ds6.Tables["tErgebnismenge"];
                //MySqlCommandBuilder cb6 = new MySqlCommandBuilder(da6);
                //da6.UpdateCommand = cb6.GetUpdateCommand();
                //da6.DeleteCommand = cb6.GetDeleteCommand();
                //da6.InsertCommand = cb6.GetInsertCommand();
                //cb6.ConflictOption = ConflictOption.CompareAllSearchableValues;
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

        //Methode um alle Kategorien aus der Kategorientabelle auszulesen. Diese werden in ein Array geschrieben und dieses wird ausgegeben.
        // Sucht zuerst die Spalte, in der die Kategorienamen stehen ("katname") und Schreibt anschließend alle Werte heraus.
        public String[] getKategorienAusTabelle()
        {
            String[] a = new String[Form1.databaseconnect_01.dataGridViewKategorie.Rows.Count];
            int kaindex = 0;

            foreach (DataGridViewColumn column in Form1.databaseconnect_01.dataGridViewKategorie.Columns)
            {
                if (column.HeaderText == "Kategorie")
                {
                    kaindex = column.Index;
                }
            }
            

            for (int i = 0; i < Form1.databaseconnect_01.dataGridViewKategorie.Rows.Count - 1; i++)
            {
                String strTemp = Form1.databaseconnect_01.dataGridViewKategorie.Rows[i].Cells[kaindex].Value.ToString();
                a.SetValue(strTemp, i);                
            }


            return a;
        }

        //Methode um die Nächste Frage aus der Tabelle "FragenSatz" zu holen. Es wird eine "Frage" ausgegeben"
        //Dafür werden die Entsprechenden Zeilen herausgesucht und in Variablen geschrieben. Mit diesen wird eine Frage Erstellt.
        public Frage getNextQuestionAusTabelle(int nr)
        {
            int id = 0;
            String txt = "";
            String a1 = "";
            String a2 = "";
            String a3 = "";
            int ra = 0;
            //FragenID
            foreach (DataGridViewColumn column in Form1.databaseconnect_01.dataGridViewFragensatz.Columns)
            {
                if (column.HeaderText == "FrID")
                {
                    id = Convert.ToInt32(Form1.databaseconnect_01.dataGridViewFragensatz[nr, column.Index].Value.ToString());
                }
            }
            //FragenText
            foreach (DataGridViewColumn column in Form1.databaseconnect_01.dataGridViewFragensatz.Columns)
            {
                if (column.HeaderText == "FragenText")
                {
                    txt = Form1.databaseconnect_01.dataGridViewFragensatz[nr, column.Index].Value.ToString();
                }
            }            
            //FragenAntwortEins
            foreach (DataGridViewColumn column in Form1.databaseconnect_01.dataGridViewFragensatz.Columns)
            {
                if (column.HeaderText == "Antwort1Text")
                {
                    a1 = Form1.databaseconnect_01.dataGridViewFragensatz[nr, column.Index].Value.ToString();
                }
            }           
            //FragenAntwortZwei
            foreach (DataGridViewColumn column in Form1.databaseconnect_01.dataGridViewFragensatz.Columns)
            {
                if (column.HeaderText == "Antwort2Text")
                {
                    a2 = Form1.databaseconnect_01.dataGridViewFragensatz[nr, column.Index].Value.ToString();
                }
            }          
            //FragenAntwortDrei
            foreach (DataGridViewColumn column in Form1.databaseconnect_01.dataGridViewFragensatz.Columns)
            {
                if (column.HeaderText == "Antwort3Text")
                {
                    a3 = Form1.databaseconnect_01.dataGridViewFragensatz[nr, column.Index].Value.ToString();
                }
            }
            //FragenRichtigeAntwort
            foreach (DataGridViewColumn column in Form1.databaseconnect_01.dataGridViewFragensatz.Columns)
            {
                if (column.HeaderText == "RichtigeAntwort")
                {
                    ra = Convert.ToInt32(Form1.databaseconnect_01.dataGridViewFragensatz[nr, column.Index].Value.ToString());
                }
            }

            Frage f = new Frage(id, txt, a1, a2, a3, ra);

            return f;
        }

        //Füllt die FragensatzTabelle in Abhängigkeit zu den Kategorien die Ausgewählt wurden.
        public void fragensatzErstellen()
        {

            int[] it = new int[Form1.menue_01.kategorieCheckList.CheckedItems.Count * 20];
            int itcounter = 0;

            int kaid = 0;
            int frid = 0;
            int frid2 = 0;

            //Spalte katname suchen
            foreach (DataGridViewColumn column in Form1.databaseconnect_01.dataGridViewFrageninkategorie.Columns)
            {
                if (column.HeaderText == "Kategorie")
                {
                    kaid = column.Index;
                }
            }

            //Spalte frid suchen
            foreach (DataGridViewColumn column in Form1.databaseconnect_01.dataGridViewFrageninkategorie.Columns)
            {
                if (column.HeaderText == "FragenID")
                {
                    frid = column.Index;
                }
            }

            //Für Jedes Element in der checkedList (jede Kategorie)
            for (int i = 0; i < Form1.menue_01.kategorieCheckList.CheckedItems.Count - 1; i++)
            {
                String ka = Form1.menue_01.kategorieCheckList.CheckedItems[i].ToString();
                
                //Reihen durchgehen und für jedes vorkommen der Aktuellen Kategorie die fragen ID in ein array schreiben
                foreach (DataGridViewRow row in Form1.databaseconnect_01.dataGridViewFrageninkategorie.Rows)
                {
                    if (row.Index != Form1.databaseconnect_01.dataGridViewFrageninkategorie.Rows.Count - 1)
                    {
                        if (row.Cells[kaid].Value.ToString() == ka)
                        {
                            it.SetValue(Convert.ToInt32(row.Cells[frid].Value.ToString()), itcounter);
                            itcounter = itcounter++;
                        }
                    }
                }
            }

            //Spalte frid in Fragen suchen
            foreach (DataGridViewColumn column in Form1.databaseconnect_01.dataGridViewFragen.Columns)
            {
                if (column.HeaderText == "FrID")
                {
                    frid2 = column.Index;
                }
            }


            int id = 0;

            //Für jedes Element in dem Array "it"
            for (int i = 0; i < it.GetLength(0); i++ )
            {
                //Holt sich die Fragen aus der Fragenliste anhand der ID, schreibt diese Fragen in die Fragensatz tabelle
                foreach (DataGridViewRow row in Form1.databaseconnect_01.dataGridViewFragen.Rows)
                {
                    if (row.Index != 200)
                    {
                        if (row.Cells[frid2].Value.ToString() == it.GetValue(i).ToString())
                        {
                            String fid = "1";
                            String ftxt = "b";
                            String fa1 = "c";
                            String fa2 = "d";
                            String fa3 = "e";
                            String fra = "6";
                          
                            //fid = row.Cells[0].ToString();
                            //ftxt = row.Cells[1].ToString();
                            //fa1 = row.Cells[2].ToString();
                            //fa2 = row.Cells[3].ToString();
                            //fa3 = row.Cells[4].ToString();
                            //fra = row.Cells[5].ToString();

                            string[] row0 = {fid, ftxt, fa1, fa2, fa3, fra};


                            Form1.databaseconnect_01.dataGridViewFragensatz.Rows.Add(row0);
                            //Form1.databaseconnect_01.dataGridViewFragensatz.Rows[id].;

                            id = id + 1;
                            
                        }
                    }
                }
            }

        }

    }
}
