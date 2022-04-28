using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pulse.Content.Music
{
    public partial class MusicMenu : UserControl
    {
        public MusicMenu()
        {
            InitializeComponent();
        }

        private void MusicMenu_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
