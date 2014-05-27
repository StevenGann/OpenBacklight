namespace OpenBacklight
{
    partial class MainGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerSample = new System.Windows.Forms.Timer(this.components);
            this.trackBarSampleSize = new System.Windows.Forms.TrackBar();
            this.labelSampleSize = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.trayContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSampleSize)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.trayContextMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "OpenBacklight";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuOptions});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.Size = new System.Drawing.Size(117, 26);
            // 
            // contextMenuOptions
            // 
            this.contextMenuOptions.Name = "contextMenuOptions";
            this.contextMenuOptions.Size = new System.Drawing.Size(116, 22);
            this.contextMenuOptions.Text = "Options";
            this.contextMenuOptions.Click += new System.EventHandler(this.contextMenuOptions_Click);
            // 
            // previewPanel
            // 
            this.previewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewPanel.Location = new System.Drawing.Point(12, 314);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(209, 56);
            this.previewPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Output";
            // 
            // timerSample
            // 
            this.timerSample.Enabled = true;
            this.timerSample.Tick += new System.EventHandler(this.timerSample_Tick);
            // 
            // trackBarSampleSize
            // 
            this.trackBarSampleSize.Location = new System.Drawing.Point(12, 29);
            this.trackBarSampleSize.Maximum = 50;
            this.trackBarSampleSize.Minimum = 1;
            this.trackBarSampleSize.Name = "trackBarSampleSize";
            this.trackBarSampleSize.Size = new System.Drawing.Size(209, 45);
            this.trackBarSampleSize.TabIndex = 2;
            this.trackBarSampleSize.Value = 10;
            this.trackBarSampleSize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarSampleSize_MouseUp);
            // 
            // labelSampleSize
            // 
            this.labelSampleSize.AutoSize = true;
            this.labelSampleSize.Location = new System.Drawing.Point(13, 13);
            this.labelSampleSize.Name = "labelSampleSize";
            this.labelSampleSize.Size = new System.Drawing.Size(65, 13);
            this.labelSampleSize.TabIndex = 3;
            this.labelSampleSize.Text = "Sample Size";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM52";
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 382);
            this.Controls.Add(this.labelSampleSize);
            this.Controls.Add(this.trackBarSampleSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainGUI";
            this.Text = "OpenBacklight";
            this.Resize += new System.EventHandler(this.MainGUI_Resize);
            this.trayContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSampleSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerSample;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextMenuOptions;
        private System.Windows.Forms.TrackBar trackBarSampleSize;
        private System.Windows.Forms.Label labelSampleSize;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

