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
    //Fenster für die Benutzerwahl(nicht Implementiert) und den Übergang in das Hauptmenü
    public partial class Start : Form
    {

        public Start()
        {
            InitializeComponent();
        }

        //Initialsiert das Hauptmenü
        private void startStart_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.menue_01.checkedListBoxFill();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            Form1.menue_01.Show();
            this.Hide();
        }

        //Leitet zum neuen Benutzer Feld
        private void startNeuerBenutzer_Click(object sender, EventArgs e)
        {
            Form1.neuerbenutzer_01.Show();
            this.Hide();
           
        }

        //Wenn dieses Fenster geschlossen wird, wird jedes Fenster der Anwendung geschlossen
        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
