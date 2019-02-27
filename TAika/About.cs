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

namespace TAika
{
    public partial class About : Form
    {
        
        public About()
        {
            InitializeComponent();

            System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            var fieVersionInfo = FileVersionInfo.GetVersionInfo(executingAssembly.Location);
            var version = fieVersionInfo.FileVersion;

            lblVersio.Text = "Versio: " + version;
        }

        private void btnSulje_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
