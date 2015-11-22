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

        private void frmMeters_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }
    }
}
