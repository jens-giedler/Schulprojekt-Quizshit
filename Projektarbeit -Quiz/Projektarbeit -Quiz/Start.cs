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
    public partial class Start : Form
    {


        public Start()
        {
            InitializeComponent();
        }

        private void startStart_Click(object sender, EventArgs e)
        {
            Form1.menue_01.Show();
            this.Hide();
        }

        private void startNeuerBenutzer_Click(object sender, EventArgs e)
        {
            Form1.neuerbenutzer_01.Show();
            this.Hide();
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
