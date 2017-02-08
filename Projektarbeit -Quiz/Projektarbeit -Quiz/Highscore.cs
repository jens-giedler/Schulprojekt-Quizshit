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
    public partial class Highscore : Form
    {
        public Highscore()
        {
            InitializeComponent();
        }

        public static Form highscore_1 = new Form();

        private void highscoreZurueck_Click(object sender, EventArgs e)
        {
            Form1.menue_01.Show();
            this.Hide();
        }

        private void Highscore_Load(object sender, EventArgs e)
        {

        }

        private void Highscore_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
