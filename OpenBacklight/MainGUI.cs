﻿using ScreenScanner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenBacklight
{
    public partial class MainGUI : Form
    {
        private Scanner scanner = new Scanner();

        public MainGUI()
        {
            InitializeComponent();
            scanner.Start();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void MainGUI_Resize(object sender, EventArgs e)
        {
            //Minimize to tray code courtesy of Code Project
            //Source: http://www.codeproject.com/Articles/27599/Minimize-window-to-system-tray

            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }
    }
}
