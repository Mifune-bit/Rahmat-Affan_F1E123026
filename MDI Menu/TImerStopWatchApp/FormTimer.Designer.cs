namespace TImerStopWatchApp
{
    partial class FormTimer
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
            btnStartStop = new Button();
            btnReset = new Button();
            numericUpDownMinutes = new NumericUpDown();
            numericUpDownSeconds = new NumericUpDown();
            numericUpDownHours = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTimeDisplay = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btnStartStop
            // 
            btnStartStop.Location = new Point(72, 207);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(75, 23);
            btnStartStop.TabIndex = 1;
            btnStartStop.Text = "Start";
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(196, 207);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // numericUpDownMinutes
            // 
            numericUpDownMinutes.Location = new Point(153, 142);
            numericUpDownMinutes.Name = "numericUpDownMinutes";
            numericUpDownMinutes.Size = new Size(38, 23);
            numericUpDownMinutes.TabIndex = 4;
            // 
            // numericUpDownSeconds
            // 
            numericUpDownSeconds.Location = new Point(233, 142);
            numericUpDownSeconds.Name = "numericUpDownSeconds";
            numericUpDownSeconds.Size = new Size(38, 23);
            numericUpDownSeconds.TabIndex = 5;
            // 
            // numericUpDownHours
            // 
            numericUpDownHours.Location = new Point(72, 142);
            numericUpDownHours.Name = "numericUpDownHours";
            numericUpDownHours.Size = new Size(38, 23);
            numericUpDownHours.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 168);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 7;
            label1.Text = "Jam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 168);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "Menit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 168);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 9;
            label3.Text = "Detik";
            // 
            // lblTimeDisplay
            // 
            lblTimeDisplay.AutoSize = true;
            lblTimeDisplay.Font = new Font("Segoe UI", 16F);
            lblTimeDisplay.Location = new Point(110, 95);
            lblTimeDisplay.Name = "lblTimeDisplay";
            lblTimeDisplay.Size = new Size(119, 30);
            lblTimeDisplay.TabIndex = 10;
            lblTimeDisplay.Text = "00 : 00 : 00";
            // 
            // FormTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 326);
            Controls.Add(lblTimeDisplay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownHours);
            Controls.Add(numericUpDownSeconds);
            Controls.Add(numericUpDownMinutes);
            Controls.Add(btnReset);
            Controls.Add(btnStartStop);
            Name = "FormTimer";
            Text = "FormTimer";
            Load += FormTimer_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button btnStartStop;
        private Button btnReset;
        private NumericUpDown numericUpDownMinutes;
        private NumericUpDown numericUpDownSeconds;
        private NumericUpDown numericUpDownHours;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTimeDisplay;
    }
}