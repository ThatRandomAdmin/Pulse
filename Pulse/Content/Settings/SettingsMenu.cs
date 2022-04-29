using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pulse.Content.Settings
{
    public class userData
    {
        public string name { get; set; }
        public string country { get; set; }
    }

    public partial class SettingsMenu : UserControl
    {

        public SettingsMenu()
        {
            InitializeComponent();
        }

        private void SettingsMenu_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            userData newData = new userData
            {
                name = textBox1.Text
            };
            string json = JsonConvert.SerializeObject(newData, Formatting.Indented);
            System.IO.File.WriteAllText(@"..\Pulse\user.json", json);
        }
    }
}
