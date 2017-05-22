using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Net;

namespace SearchNoise
{
    public class PageFetcher
    {
        public string url;
        public string outputDirectory;
        public int resultnum;
        public void FetchPage()
        {
            try
            {
                WebClient webClient = new WebClient();
                string responseFromServer = webClient.DownloadString(url);
                string filename = "Output" + resultnum + ".html";
                string fullOutputPath = "";
                if(outputDirectory.Last() == '\\')
                {
                    fullOutputPath = outputDirectory + filename;
                }
                else
                {
                    fullOutputPath = outputDirectory + "\\" + filename;
                }
                StreamWriter SW = File.CreateText(fullOutputPath);
                SW.WriteLine(responseFromServer);
                SW.Close();

            }
            catch { }
        }
    }
}
