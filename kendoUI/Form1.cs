﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kendoUI
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button_player_Click(object sender, EventArgs e)
        {
            us_player_list.Show();
        }
    }
}
