using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TImerStopWatchApp
{
    public partial class FormTimer : Form
    {
        private TimeSpan remainingTime;
        private bool isRunning = false;
        private DateTime endTime;

        public FormTimer()
        {
            InitializeComponent();
            remainingTime = TimeSpan.Zero;
            UpdateTimeDisplay();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingTime = endTime - DateTime.Now;

            if (remainingTime.TotalSeconds > 0)
            {
                UpdateTimeDisplay();
            }
            else
            {
                remainingTime = TimeSpan.Zero;
                isRunning = false;
                timer1.Stop();
                btnStartStop.Text = "Start";
                ToggleNumberControls(true);
                UpdateTimeDisplay();
                MessageBox.Show("Waktu habis!", "Timer Selesai", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                
                remainingTime = new TimeSpan(
                    (int)numericUpDownHours.Value,
                    (int)numericUpDownMinutes.Value,
                    (int)numericUpDownSeconds.Value);

                if (remainingTime.TotalSeconds > 0)
                {
                    endTime = DateTime.Now.Add(remainingTime);
                    isRunning = true;
                    timer1.Start();
                    btnStartStop.Text = "Stop";
                    ToggleNumberControls(false);
                }
                else
                {
                    MessageBox.Show("Silakan set waktu terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                isRunning = false;
                timer1.Stop();
                btnStartStop.Text = "Start";
                ToggleNumberControls(true);

                
                remainingTime = endTime - DateTime.Now;
                if (remainingTime.TotalSeconds < 0)
                    remainingTime = TimeSpan.Zero;

                UpdateTimeDisplay();
            }
        }

        private void FormTimer_Load(object sender, EventArgs e)
        {
            
            numericUpDownHours.Value = 0;
            numericUpDownMinutes.Value = 0;
            numericUpDownSeconds.Value = 0; 

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            isRunning = false;
            timer1.Stop();
            remainingTime = TimeSpan.Zero;
            UpdateTimeDisplay();
            btnStartStop.Text = "Start";
            ToggleNumberControls(true);

            
            remainingTime = new TimeSpan(
                (int)numericUpDownHours.Value,
                (int)numericUpDownMinutes.Value,
                (int)numericUpDownSeconds.Value);
            UpdateTimeDisplay();
        }

        private void UpdateTimeDisplay()
        {
            lblTimeDisplay.Text = remainingTime.ToString(@"hh\:mm\:ss");

            if (!isRunning)
            {
                numericUpDownHours.Value = remainingTime.Hours;
                numericUpDownMinutes.Value = remainingTime.Minutes;
                numericUpDownSeconds.Value = remainingTime.Seconds;
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                remainingTime = new TimeSpan(
                    (int)numericUpDownHours.Value,
                    (int)numericUpDownMinutes.Value,
                    (int)numericUpDownSeconds.Value);
                UpdateTimeDisplay();
            }
        }

        private void ToggleNumberControls(bool enabled)
        {
            numericUpDownHours.Enabled = enabled;
            numericUpDownMinutes.Enabled = enabled;
            numericUpDownSeconds.Enabled = enabled;
        }


    }
}

