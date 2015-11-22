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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            txtUserD.Text = Properties.Settings.Default.userID;
            txtPassword.Text = Properties.Settings.Default.password;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["userID"] = txtUserD.Text;
            Properties.Settings.Default["password"] = txtPassword.Text;
            Properties.Settings.Default.Save();

            this.Close();
        }

    }
}
