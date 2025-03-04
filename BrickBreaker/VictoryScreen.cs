﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class VictoryScreen : UserControl
    {
        public VictoryScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VictoryScreen_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.VictoryScreen_Background;
        }
    }
}
