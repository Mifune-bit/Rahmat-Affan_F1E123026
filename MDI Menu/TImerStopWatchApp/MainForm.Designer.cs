namespace TImerStopWatchApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            pilihMenuToolStripMenuItem = new ToolStripMenuItem();
            stopWatchToolStripMenuItem = new ToolStripMenuItem();
            timerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { pilihMenuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // pilihMenuToolStripMenuItem
            // 
            pilihMenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stopWatchToolStripMenuItem, timerToolStripMenuItem });
            pilihMenuToolStripMenuItem.Name = "pilihMenuToolStripMenuItem";
            pilihMenuToolStripMenuItem.Size = new Size(76, 20);
            pilihMenuToolStripMenuItem.Text = "Pilih Menu";
            // 
            // stopWatchToolStripMenuItem
            // 
            stopWatchToolStripMenuItem.Name = "stopWatchToolStripMenuItem";
            stopWatchToolStripMenuItem.Size = new Size(180, 22);
            stopWatchToolStripMenuItem.Text = "StopWatch ";
            stopWatchToolStripMenuItem.Click += stopWatchToolStripMenuItem_Click;
            // 
            // timerToolStripMenuItem
            // 
            timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            timerToolStripMenuItem.Size = new Size(180, 22);
            timerToolStripMenuItem.Text = "Timer";
            timerToolStripMenuItem.Click += timerToolStripMenuItem_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pilihMenuToolStripMenuItem;
        private ToolStripMenuItem stopWatchToolStripMenuItem;
        private ToolStripMenuItem timerToolStripMenuItem;
    }
}
