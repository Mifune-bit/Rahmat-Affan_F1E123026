namespace TImerStopWatchApp
{
    partial class FormStopWatch
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonStart = new Button();
            buttonStop = new Button();
            labelStopwatch = new Label();
            buttonReset = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(30, 147);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(135, 147);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(75, 23);
            buttonStop.TabIndex = 1;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // labelStopwatch
            // 
            labelStopwatch.AutoSize = true;
            labelStopwatch.Font = new Font("Segoe UI", 14F);
            labelStopwatch.Location = new Point(135, 81);
            labelStopwatch.MaximumSize = new Size(0, 90);
            labelStopwatch.Name = "labelStopwatch";
            labelStopwatch.Size = new Size(80, 25);
            labelStopwatch.TabIndex = 3;
            labelStopwatch.Text = "00:00:00";
            labelStopwatch.Click += labelStopwatch_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(240, 147);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 23);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // FormStopWatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 316);
            Controls.Add(labelStopwatch);
            Controls.Add(buttonReset);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Name = "FormStopWatch";
            Text = "FormStopWatch";
            Load += FormStopWatch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button buttonStart;
        private Button buttonStop;
        private Label labelStopwatch;
        private Button buttonReset;
    }
}