using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web;
using System.Net;
using System.Threading;
using System.Collections.Specialized;

namespace SearchNoise
{
    public partial class Form1 : Form
    {
        static List<string> words = new List<string>();
        static object wordsLocker = new object();
        static Random rndgen = new Random();

        static DateTime nextSearch = DateTime.Now + new TimeSpan(0, 0, 0, 5);
        static object nextSearchLocker = new object();

        static string searchTerms = "";
        static object searchTermsLocker = new object();

        static List<Thread> threads = new List<Thread>();
        static object threadsLocker = new object();

        public Form1()
        {
            InitializeComponent();
        }

        delegate void SetTextCallback(string text);

        //Thread safe function to set the time left label
        private void SetLblTimeLeftText(string text)
        {
            if (this.lbl_TimeLeft.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLblTimeLeftText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbl_TimeLeft.Text = text;
            }
        }

        //Thread safe function to set the search terms label
        private void SetLblSearchTermsText(string text)
        {
            if (this.lbl_SearchTerms.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLblSearchTermsText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbl_SearchTerms.Text = text;
            }
        }

        //Thread safe function to set the searched label
        private void SetLblSearchedText(string text)
        {
            if (this.lbl_Searched.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLblSearchedText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbl_Searched.Text = text;
            }
        }

        private void SetLblR1Text(string text)
        {
            if (this.lbl_Result1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLblR1Text);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbl_Result1.Text = text;
            }
        }

        private void SetLblR2Text(string text)
        {
            if (this.lbl_Result2.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLblR2Text);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbl_Result2.Text = text;
            }
        }

        private void SetLblR3Text(string text)
        {
            if (this.lbl_Result3.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLblR3Text);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbl_Result3.Text = text;
            }
        }

        private void SetLblR4Text(string text)
        {
            if (this.lbl_Result4.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLblR4Text);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbl_Result4.Text = text;
            }
        }

        private void SetLblR5Text(string text)
        {
            if (this.lbl_Result5.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLblR5Text);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbl_Result5.Text = text;
            }
        }

        private void SetTxtboxText(string text)
        {
            if(this.txt_NextSearch.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTxtboxText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txt_NextSearch.Text = text;
            }
        }

        public void UpdateTimeLabel()
        {
            while (true)
            {
                long timeleft = 0;
                lock (nextSearchLocker)
                {
                    timeleft = ((nextSearch - DateTime.Now).Ticks / TimeSpan.TicksPerMillisecond);
                }

                if (timeleft > 0)
                {
                    SetLblTimeLeftText(timeleft.ToString());
                }
                else 
                {
                    //////////////////////////////////////
                    // Perform search
                    SetLblSearchedText(lbl_SearchTerms.Text);
                    
                    //Get search string
                    int len = rndgen.Next(1, 5);
                    string keywordString = "";
                    lock (wordsLocker)
                    {
                        for (int i = 0; i < len; i++)
                        {
                            int arrindex = rndgen.Next(0, words.Count - 1);
                            keywordString += words[arrindex];
                            if (i != len - 1) keywordString += "+";
                        }
                    }
                    lock (searchTermsLocker)
                    {
                        searchTerms = keywordString;
                        SetLblSearchTermsText(searchTerms);
                    }
                    try
                    {
                        //Get search string
                        int numterms = rndgen.Next(1, 5);

                        // Search google
                        string uriString = "http://www.google.com/search";
                        WebClient webClient = new WebClient();
                        NameValueCollection nameValueCollection = new NameValueCollection();
                        nameValueCollection.Add("q", lbl_Searched.Text);
                        webClient.QueryString.Add(nameValueCollection);
                        string responseFromServer = webClient.DownloadString(uriString);

                        // Parse the result from google
                        string[] split1 = responseFromServer.Split(new string[] { "url?q=" }, StringSplitOptions.RemoveEmptyEntries);
                        List<string> urls = new List<string>();
                        foreach (string s in split1)
                        {
                            string[] split2 = s.Split('&');
                            urls.Add(split2[0]);
                        }
                        for (Int32 index = urls.Count - 1; index >= 0; --index)
                        {
                            if (
                                urls[index].Contains("google"))
                            {
                                urls.RemoveAt(index);
                            }
                        }
                        if (urls.Count > 3) urls.RemoveRange(0, 3);

                        // Sleep a short time
                        int sleeptime = rndgen.Next(100, 800);
                        Thread.Sleep(sleeptime);

                        // Load some of the pages from results
                        
                        int pageload = rndgen.Next(3, 5);
                        for (int i = 0; i < 5; i++)
                        {
                            if (urls.Count > i)
                            {
                                try
                                {
                                    PageFetcher pf = new PageFetcher();
                                    pf.url = urls[i];
                                    pf.resultnum = i;
                                    pf.outputDirectory = outputDirTextbox.Text;

                                    Thread th = new Thread(new ThreadStart(pf.FetchPage));
                                    lock(threadsLocker)
                                    {
                                        threads.Add(th);
                                        th.Start();
                                    }
                                }
                                catch
                                {

                                }

                            }
                            int sleeptime3 = rndgen.Next(100, 300);
                            Thread.Sleep(sleeptime3);
                        }
                        if(urls.Count > 0) SetLblR1Text(urls[0]);
                        if (urls.Count > 1) SetLblR2Text(urls[1]);
                        if (urls.Count > 2) SetLblR3Text(urls[2]);
                        if (urls.Count > 3 && pageload > 3) SetLblR4Text(urls[3]);
                        else SetLblR4Text("...");
                        if (urls.Count > 4 && pageload > 4) SetLblR5Text(urls[4]);
                        else SetLblR5Text("...");
                        int sleeptime2 = rndgen.Next(2000, 7000);

                        Thread.Sleep(sleeptime2);
                        lock(threadsLocker)
                        {
                            foreach (Thread thread in threads)
                            {
                                thread.Abort();
                            }
                        }
                    }
                    catch { }

                    int minSleepTime = 5;
                    int maxSleepTime = 20;
                    try
                    {
                        minSleepTime = Convert.ToInt32(txt_MinSleepTime.Text);
                    }
                    catch { }
                    try
                    {
                        maxSleepTime = Convert.ToInt32(txt_MaxSleepTime.Text);
                    }
                    catch { }
                    if (minSleepTime < 2 || minSleepTime > 9999) minSleepTime = 2;
                    if (maxSleepTime < minSleepTime) maxSleepTime = minSleepTime + 1;
                    lock (nextSearchLocker)
                    {
                        nextSearch = DateTime.Now + new TimeSpan(0, 0, 0, rndgen.Next(minSleepTime, maxSleepTime - 1), rndgen.Next(0, 999));
                    }
                }
                Thread.Sleep(17);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //populate the Output Directory textbox
            var formatted = Environment.ExpandEnvironmentVariables("%USERPROFILE%\\Documents\\Searchnoise\\");
            if(!Directory.Exists(formatted))
            {
                formatted = Environment.ExpandEnvironmentVariables("%USERPROFILE%\\");
            }
            outputDirTextbox.Text = formatted;

            //Read in the words from the wordlist
            StreamReader SR = File.OpenText("20k.txt");
            string line;
            lock(wordsLocker)
            {
                while ((line = SR.ReadLine()) != null)
                {
                    words.Add(line);
                }
            }
            SR.Close();

            //Get search string
            int len = rndgen.Next(1, 5);
            string keywordString = "";
            for (int i = 0; i < len; i++)
            {
                int arrindex = rndgen.Next(0, words.Count - 1);
                keywordString += words[arrindex];
                if (i != len - 1) keywordString += "+";
            }
            lock(searchTermsLocker)
            {
                searchTerms = keywordString;
                lbl_SearchTerms.Text = searchTerms;
            }

            lock(nextSearchLocker)
            {
                nextSearch = DateTime.Now + new TimeSpan(0, 0, 0, rndgen.Next(5, 20), rndgen.Next(0, 999));
            }
            Thread th = new Thread(new ThreadStart(UpdateTimeLabel));
            th.Start();
        }

        private void btn_NextSearch_Click(object sender, EventArgs e)
        {
            if(txt_NextSearch.Text.Length > 0)
            {
                string converted = txt_NextSearch.Text.Replace(' ', '+');
                SetTxtboxText("");
                SetLblSearchTermsText(converted);
            }

        }

        private void folderBrowserButton_Click(object sender, EventArgs e)
        {
            DialogResult DR = outputDirFolderBrowserDialog.ShowDialog();
            if( DR == DialogResult.OK)
            {
                outputDirTextbox.Text = outputDirFolderBrowserDialog.SelectedPath;
            }
        }

        private void openFolderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(outputDirTextbox.Text))
                {
                    System.Diagnostics.Process.Start(outputDirTextbox.Text);
                }
            }
            catch { }
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            lock(threadsLocker)
            {
                foreach (Thread th in threads)
                {
                    th.Abort();
                }
            }
        }
    }
}
