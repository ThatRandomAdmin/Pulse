using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pulse.Content.Apps
{
    public partial class AppsMenu : UserControl
    {
        public AppsMenu()
        {
            InitializeComponent();
        }

        private void AppsMenu_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
