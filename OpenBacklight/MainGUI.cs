using ScreenScanner;
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
            scanner.SampleRate = 100;
            scanner.SetSampleSize(10);

            labelSampleSize.Text = "Sample Size: 10";
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

        //Tick event handler for main timer
        private void timerSample_Tick(object sender, EventArgs e)
        {
            previewPanel.BackColor = scanner.Output;

        }

        //Same as double-clicking the tray icon
        private void contextMenuOptions_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void trackBarSampleSize_MouseUp(object sender, MouseEventArgs e)
        {
            labelSampleSize.Text = "Sample Size: " + Convert.ToString(trackBarSampleSize.Value);
            scanner.SetSampleSize(trackBarSampleSize.Value);
        }
    }
}
