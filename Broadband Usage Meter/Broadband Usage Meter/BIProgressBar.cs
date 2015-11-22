using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Broadband_Usage_Meter
{
    class BIProgressBar: ProgressBar
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        /* 1 - Green, 2 - Red, 3 - Yellow */

        public new int Value
        {
            set
            {
                base.Value = value;

                if (value > 30)
                {
                    SendMessage(this.Handle, 1040, (IntPtr)1, IntPtr.Zero);

                }
                else if (value < 30 && value > 10)
                {
                    SendMessage(this.Handle, 1040, (IntPtr)3, IntPtr.Zero);
                }
                else if (value < 10)
                {
                    SendMessage(this.Handle, 1040, (IntPtr)2, IntPtr.Zero);
                }
            }
        }
    }
}
