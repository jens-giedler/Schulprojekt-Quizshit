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
            //Form1.quizfenster_01.frageText.Text = Form1.
        }

    }
}
