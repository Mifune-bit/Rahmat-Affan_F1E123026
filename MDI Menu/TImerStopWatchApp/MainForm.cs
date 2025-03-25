namespace TImerStopWatchApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void stopWatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStopWatch formStopwatch = new FormStopWatch();
            formStopwatch.MdiParent = this; // Set form utama sebagai MDI Parent
            formStopwatch.Show(); // Tampilkan FormStopwatch
        }

        private void timerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormTimer formTimer = new FormTimer();
            formTimer.MdiParent = this; // Set form utama sebagai MDI Parent
            formTimer.Show(); // Tampilkan FormTimer
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }
    }
}
