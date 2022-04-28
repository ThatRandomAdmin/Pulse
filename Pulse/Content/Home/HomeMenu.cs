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
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net.Http;
using System.Drawing.Imaging;

namespace Pulse.Content.Home
{
    public partial class HomeMenu : UserControl
    {
        //Get API key
        secrets secret = new secrets();

        //Classes to hold news data
        public class Source
        {
            public string id { get; set; }
            public string name { get; set; }
        }
        public class Article
        {
            public Source source { get; set; }
            public string author { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string url { get; set; }
            public string urlToImage { get; set; }
            public DateTime publishedAt { get; set; }
        }
        public class JSONResponse
        {
            public string status { get; set; }
            public List<Article> articles { get; set; }
        }

        public HomeMenu()
        {
            InitializeComponent();
        }

        private void HomeMenu_Load(object sender, EventArgs e)
        {
            //Fill the parent
            this.Dock = DockStyle.Fill;
            try
            {
                //Get top BBC news from News API
                getNews();
                //Create buttons for the news
                genNews();
            }
            catch
            {
                //Create buttons for the last loaded news
                genNews();
            }
        }

        private void getNews()
        {
            //News API Link
            var url = "https://newsapi.org/v2/top-headlines?" +
                      "sources=bbc-news&" +
                      "apiKey="+ secret.NewsAPIkey;

            //Download the data
            string json = new WebClient().DownloadString(url);

            //Prettify the data received
            string jsonFormatted = JValue.Parse(json).ToString(Formatting.Indented);
            //Write data to Json file
            System.IO.File.WriteAllText(@"..\Pulse\news.json", jsonFormatted);
        }
        private void genNews()
        {
            JSONResponse response = JsonConvert.DeserializeObject<JSONResponse>(File.ReadAllText(@"..\Pulse\news.json"));
            foreach(var x in response.articles)
            {
                //Create btn
                Button btn = new Button();

                //Btn style
                btn.Size = new Size(230, 230);
                btn.FlatStyle = FlatStyle.Popup;
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                btn.BackColor = Color.FromArgb(45, 21, 110);
                //Try to create img for btn if there is internet connection
                try
                {
                    string sURL = x.urlToImage;
                    WebRequest req = WebRequest.Create(sURL);
                    WebResponse res = req.GetResponse();
                    Stream imgStream = res.GetResponseStream();
                    Image img1 = Image.FromStream(imgStream);
                    imgStream.Close();
                    btn.BackgroundImage = img1;
                }
                catch
                {
                    btn.BackgroundImage = Image.FromFile(@"..\Pulse\Images\Newsimg\error.jpg");
                }

                //Btn text
                btn.Text = x.title;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Font = new Font("Rockwell", 12f);
                btn.ForeColor = Color.White;

                flowLayoutPanel1.Controls.Add(btn);
            }
        }
    }
}
