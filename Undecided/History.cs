﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Undecided
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.Exit();
        }
    }
}
