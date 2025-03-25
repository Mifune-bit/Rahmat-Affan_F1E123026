using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TImerStopWatchApp
{
    public partial class FormStopWatch : Form
    {
        private Stopwatch stopwatch; // Objek Stopwatch untuk mengukur waktu

        public FormStopWatch()
        {
            InitializeComponent();
            stopwatch = new Stopwatch(); // Inisialisasi Stopwatch
        }

        private void FormStopWatch_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update label dengan waktu yang telah berlalu
            labelStopwatch.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            stopwatch.Start(); // Mulai stopwatch
            timer1.Start();    // Mulai timer untuk update tampilan
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();  // Hentikan stopwatch
            timer1.Stop();    // Hentikan timer
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            stopwatch.Reset(); // Reset stopwatch ke 0
            labelStopwatch.Text = "00:00:00"; // Update tampilan
        }

        private void labelStopwatch_Click(object sender, EventArgs e)
        {

        }
    }
}
