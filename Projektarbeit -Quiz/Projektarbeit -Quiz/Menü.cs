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

        public static Form menue_1 = new Form();
        
        private void Menü_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ton_CheckedChanged(object sender, EventArgs e)
        {
            if (ton.Checked == true)
            {
                Form1.Max.setTon(true);
            }
            else if (ton.Checked == false)
            {
                Form1.Max.setTon(false);
            }
        }

        private void colorDialog_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                farbFeld.BackColor = colorDialog1.Color;
                //Form1.Max.setFarbe(colorDialog1.Color);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Menü_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menueQuizStart_Click(object sender, EventArgs e)
        {

            Form1.quizfenster_01.Show();
            this.Hide();
        }
    }
}
