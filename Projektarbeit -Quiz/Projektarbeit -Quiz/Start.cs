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
            Menü hm = new Menü();
            hm.Show();
            this.Close();
        }

        private void startNeuerBenutzer_Click(object sender, EventArgs e)
        {
            NeuerBenutzer nb = new NeuerBenutzer();
            nb.Show();
            this.Close();
        }
    }
}
