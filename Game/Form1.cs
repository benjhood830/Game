﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SoundPlayer player = new SoundPlayer(Properties.Resources.countdown);
            player.Play();
            startButton.Visible = false;
            label3.Visible = true;

            Refresh(); 
            Thread.Sleep(1000);

            label3.Visible = false;
            label2.Visible = true;

            Refresh();
            Thread.Sleep(1000);

            label2.Visible = false;
            label1.Visible = true;

            Refresh();
            Thread.Sleep(1000);

            label1.Visible = false;
            BackColor = Color.Green;
            textLabelgo.Visible = true;

        }

    }
}
