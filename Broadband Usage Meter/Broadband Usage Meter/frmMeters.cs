using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadband_Usage_Meter
{
    public partial class frmMeters : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    m.Result = (IntPtr)HTCLIENT;
                    return;
            }
            base.WndProc(ref m);
        }

        public frmMeters()
        {
            InitializeComponent();
        }

        private async void frmMeters_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);

            SLTAPI api = new SLTAPI();
            await api.login("HC2185334", "Netass1st");

            Usage usage = await api.fetchUsage();

            lblTotalPercentage.Text = usage.RemainingTotalDataPercentage.ToString() + "%";
            pgbTotal.Value = usage.RemainingTotalDataPercentage;
            lblTotalRemainingData.Text = usage.RemainingTotalData.ToString() + " GB Left";

            lblPeakPercentage.Text = usage.RemainingPeakDataPercentage.ToString() + "%";
            pgbPeak.Value = usage.RemainingPeakDataPercentage;
            lblPeakRemainingData.Text = usage.RemainingPeakData.ToString() + " GB Left";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.Show();
        }
    }
}
