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
    //Fenster in der aus der Datenbank alle Informationen in Datagridviews geladen werden.
    //Beinhaltet auch eine weitere Datagridview, welche zum Verwalten der für die Aktuelle Quiz zu verwendenden Fragen
    //Beinhaltet Methoden, welche auf die Datagridviews zugreifen
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
            //Setzt die Variablen auf Einträge aus der Tabelle.
            id = Convert.ToInt32(Form1.databaseconnect_01.dataGridViewFragensatz[0, nr].Value.ToString());
            txt = Form1.databaseconnect_01.dataGridViewFragensatz[1, nr].Value.ToString();
            a1 = Form1.databaseconnect_01.dataGridViewFragensatz[2, nr].Value.ToString();
            a2 = Form1.databaseconnect_01.dataGridViewFragensatz[3, nr].Value.ToString();
            a3 = Form1.databaseconnect_01.dataGridViewFragensatz[4, nr].Value.ToString();
            ra = Convert.ToInt32(Form1.databaseconnect_01.dataGridViewFragensatz[5, nr].Value.ToString());

            Frage f = new Frage(id, txt, a1, a2, a3, ra);

            return f;
        }

        //Füllt die FragensatzTabelle in Abhängigkeit zu den Kategorien die Ausgewählt wurden.
        public void fragensatzErstellen()
        {
            //FÜr jede ausgewählte Kategorie
            for (int i = 0; i < Form1.menue_01.kategorieCheckList.CheckedItems.Count; i++)
            {
                String ka = Form1.menue_01.kategorieCheckList.CheckedItems[i].ToString();

                //Für jede Reihe in "Frageninkategorie"
                foreach (DataGridViewRow row in Form1.databaseconnect_01.dataGridViewFrageninkategorie.Rows)
                {
                    //Exkludieren der letzten Zeile, da diese immer "null" ist
                    if (row.Index != Form1.databaseconnect_01.dataGridViewFragen.Rows.Count - 1)
                    {
                        //Falls der Wert "Kategorie" der Reihe aus "Frageninkategorie" gleich dem der aktuellen Zeile der Ausgewählten Kategorien ist
                        if (ka == row.Cells[0].Value.ToString())
                        {
                            //Für jede Reihe in "Fragen"
                            foreach (DataGridViewRow row2 in Form1.databaseconnect_01.dataGridViewFragen.Rows)
                            {
                                //Ekludieren der letzen Zeile, da diese immer "null" ist                            }
                                if (row2.Index != Form1.databaseconnect_01.dataGridViewFragen.Rows.Count - 1)
                                {
                                    //Falls die FragenID der aktuellen Zeile in "Fragen" der FragenID der aktuellen Zeile in "FrageninKategorie" entspricht
                                    //Kopieren der aktuellen Zeile von Fragen zu Fragensatz
                                    if (row.Cells[1].Value.ToString() == row2.Cells[0].Value.ToString())
                                    {
                                        DataGridViewRow row3 = (DataGridViewRow)Form1.databaseconnect_01.dataGridViewFragensatz.Rows[0].Clone();
                                        row3.Cells[0].Value = row2.Cells[0].Value;
                                        row3.Cells[1].Value = row2.Cells[1].Value;
                                        row3.Cells[2].Value = row2.Cells[2].Value;
                                        row3.Cells[3].Value = row2.Cells[3].Value;
                                        row3.Cells[4].Value = row2.Cells[4].Value;
                                        row3.Cells[5].Value = row2.Cells[5].Value;
                                        Form1.databaseconnect_01.dataGridViewFragensatz.Rows.Add(row3);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}
