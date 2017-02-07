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
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }

        public void menueBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menü_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void colorDialog_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                farbFeld.BackColor = colorDialog1.Color;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
