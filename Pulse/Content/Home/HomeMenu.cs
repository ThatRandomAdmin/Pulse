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
                      "country=gb&" +
                      "apiKey="+ secret.NewsAPIkey;

            //Download the data
            string json = new WebClient().DownloadString(url);

            //Getting a weird bug where â€™ is displayed instead of ' and œ appears sometimes
            //Probably an error with how I am formatting my json, but this will work for now
            string jsonCorrected = json.Replace("â€™", "'");
            string jsonCorrected2 = jsonCorrected.Replace("œ", "");

            //Prettify the data received
            string jsonFormatted = JValue.Parse(jsonCorrected2).ToString(Formatting.Indented);
            //Write data to Json file
            System.IO.File.WriteAllText(@"..\Pulse\news.json", jsonFormatted);
        }
        private void genNews()
        {
            JSONResponse response = JsonConvert.DeserializeObject<JSONResponse>(File.ReadAllText(@"..\Pulse\news.json"));
            foreach(var x in response.articles)
            {
                flowLayoutPanel1.Controls.Add(new newsBit(x.title, x.url, x.urlToImage));
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
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
    }
}
