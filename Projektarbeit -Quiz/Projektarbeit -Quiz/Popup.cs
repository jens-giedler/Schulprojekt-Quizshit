﻿using System;
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
    public partial class Popup : Form
    {
        public Popup(String s)
        {
            this.label1.Text = s;
            InitializeComponent();
        }
    }
}
