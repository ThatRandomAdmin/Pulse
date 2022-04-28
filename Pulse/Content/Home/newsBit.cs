using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pulse.Content.Home
{
    public partial class newsBit : UserControl
    {
        string title;
        string urllink;
        string imgurl;
        public newsBit(string text, string url, string img)
        {
            InitializeComponent();
            title = text;
            urllink = url;
            imgurl = img;
        }

        private void newsBit_Load(object sender, EventArgs e)
        {
            label1.Text = title;
            if (imgurl != null){
                try
                {
                    WebRequest req = WebRequest.Create(imgurl);
                    WebResponse res = req.GetResponse();
                    Stream imgStream = res.GetResponseStream();
                    Image img1 = Image.FromStream(imgStream);
                    imgStream.Close();
                    button1.BackgroundImage = img1;
                }
                catch
                {
                    button1.BackgroundImage = Image.FromFile(@"..\Pulse\Images\Newsimg\error.jpg");
                }
            }
            else
            {
                button1.BackgroundImage = Image.FromFile(@"..\Pulse\Images\Newsimg\error.jpg");
            }
            //Btn click
            button1.Click += (s, c) =>
            {
                //trys to open item preview
                try
                {
                    Process.Start(urllink);
                }
                //Throws error if any errors occur
                catch
                {
                    MessageBox.Show("An error occured, try again later.");
                }
            };
        }
    }
}
