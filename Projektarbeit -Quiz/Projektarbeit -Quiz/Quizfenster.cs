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

        private void naechsteFrage_Click(object sender, EventArgs e)
        {
            Form1.frageCounter = Form1.frageCounter + 1;
            if (Form1.frageCounter == 11)
            {
                Form1.menue_01.Show();
                this.Hide();
            }
            else
            {
                //ladeNaechsteFrage();
            }
        }

        public void ladeNaechsteFrage()
        {
            
            //Form1.quizfenster_01.frageText = Form1.dataGridViewFragen;
            //Form1.quizfenster_01.fragenNummer = Form1.frageCounter;
            //Form1.quizfenster_01.antwort1 =;
            //Form1.quizfenster_01.antwort2 =;
            //Form1.quizfenster_01.antwort3 =;
        }

    }
}
