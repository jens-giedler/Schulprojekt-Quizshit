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
}
