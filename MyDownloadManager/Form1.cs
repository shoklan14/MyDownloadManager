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
using System.Net;
using System.Threading;
using System.Diagnostics;

namespace MyDownloadManager
{
    public partial class Form1 : Form
    {
        byte[] downBuffer = new byte[2048];
        public string FileName { get; set; }
        public string url { get; set; }
        Stopwatch sw = new Stopwatch();
        private Thread thrDownload;
        private Stream strResponse;
        private Stream strLocal;
        private HttpWebRequest webRequest;
        private HttpWebResponse webResponse;
        private static int PercentageProgress;
        private delegate void UpdateProgressCallback(Int64 BytesRead, Int64 TotalBytes);
        bool goPause = false;

        double pbUnit;
        int pbWITH, pbHIGHT, bpComplet;
        Bitmap bmp;

        Graphics g;


        


        public Form1()
        {
            InitializeComponent();
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            lblStatus.ForeColor = Color.Blue;
            if (thrDownload != null && thrDownload.ThreadState == System.Threading.ThreadState.Running)
            {
                MessageBox.Show("A download is already runnig. Either stop current download or wait for it to complete");
            }
            else
            {
                sw.Start();
                lblURL.Text = txtURL.Text;
                thrDownload = new Thread(new ParameterizedThreadStart(Download));
                thrDownload.Start(0);

                btnPauseResume.Enabled = true;
                btnPauseResume.Text = "Pause";
            }
        }



        private void UpdateProgress(Int64 BytesRead, Int64 TotalBytes)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;

                PercentageProgress = Convert.ToInt32((BytesRead * 100) / TotalBytes);
                //progressBar.Value = PercentageProgress;

                g = Graphics.FromImage(bmp);
                g.Clear(Color.White);
                g.FillRectangle(Brushes.Lime, new Rectangle(0, 0, (int)(bpComplet * pbUnit), pbHIGHT));

                g.DrawString(bpComplet + "%", new Font("Arial", pbHIGHT / 2), Brushes.Black, new PointF(pbWITH / 2 - pbHIGHT, pbHIGHT / 10));
                picBoxPB.Image = bmp;
                bpComplet = PercentageProgress + 1;


                //lblProgress.Text = "Downloader " + BytesRead + "out of " + TotalBytes + " (" + PercentageProgress + "%)";
                lblcurrentstatus.Text = "Receiving data";
                lblcurrentfilesize.Text = (TotalBytes / 1024d / 1024d).ToString("0.000") + "    MB";
                lblcurrentdownloaded.Text = (BytesRead / 1024d / 1024d).ToString("0.000") + "    MB";
                lblcurrenttransferrate.Text = string.Format("{0}  KB/sec", (BytesRead / 1024d / sw.Elapsed.TotalSeconds).ToString("0.000"));
                if (bpComplet == 101)
                {
                    lblcurrentstatus.Text = "Completed";
                    MessageBox.Show("Download complete");
                }
            }
            catch
            {

            }
            }



        private void Download(object startPoint)
        {
            try
            {
                int startPointInt = Convert.ToInt32(startPoint);
                try
                {
                    webRequest = (HttpWebRequest)WebRequest.Create(txtURL.Text);
                    webRequest.AddRange(startPointInt);

                    webRequest.Credentials = CredentialCache.DefaultCredentials;
                    webResponse = (HttpWebResponse)webRequest.GetResponse();
                    Int64 filesize = webResponse.ContentLength;

                    strResponse = webResponse.GetResponseStream();

                    if (startPointInt == 0)
                    {
                        strLocal = new FileStream(txtPath.Text, FileMode.Create, FileAccess.Write, FileShare.None);
                    }
                    else
                    {
                        strLocal = new FileStream(txtPath.Text, FileMode.Append, FileAccess.Write, FileShare.None);
                    }

                    int bytesSize = 0;

                    while ((bytesSize = strResponse.Read(downBuffer, 0, downBuffer.Length)) > 0)
                    {
                        strLocal.Write(downBuffer, 0, bytesSize);
                        this.Invoke(new UpdateProgressCallback(this.UpdateProgress), new object[] { strLocal.Length, filesize + startPointInt });

                        if (goPause == true)
                        {
                            break;
                        }
                    }
                }
                finally
                {
                    strResponse.Close();
                    strLocal.Close();
                }
            }
            catch
            {

            }
        }



        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                g.Clear(Color.White);
                bpComplet = 0;
                g.Dispose();

                thrDownload.Abort();

                webResponse.Close();
                strResponse.Close();
                strLocal.Close();

                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "          Canceled";

                btnPauseResume.Enabled = false;

            }
            catch
            {

            }
        }



        private void btnPauseResume_Click(object sender, EventArgs e)
        {
            try
            {
                if (thrDownload != null)
                {
                    if (btnPauseResume.Text == "Pause")
                    {
                        goPause = true;

                        btnPauseResume.Text = "Resume";

                        lblStatus.Text = "          Pause";

                        webResponse.Close();
                        strResponse.Close();
                        strLocal.Close();

                        thrDownload.Abort();
                    }
                    else
                    {
                        goPause = false;

                        btnPauseResume.Text = "Pause";

                        long startPoint = 0;

                        if(File.Exists(txtPath.Text))
                        {
                            startPoint = new FileInfo(txtPath.Text).Length;
                        }
                        else
                        {
                            MessageBox.Show("The file you choosed to resume doesn't exit.", "Cannot resume", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        lblStatus.ForeColor = Color.Blue;
                        lblStatus.Text = "          Receiving data";

                        thrDownload = new Thread(new ParameterizedThreadStart(Download));
                        thrDownload.Start(startPoint);
                        btnPauseResume.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("A download does not appear to be in progress.", "Could not pause.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }


        private void btnBrows_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowDialog();
                this.url = txtURL.Text;
                Uri uri = new Uri(this.url);
                FileName = System.IO.Path.GetFileName(uri.AbsolutePath);
                txtPath.Text = fbd.SelectedPath + "\\" + FileName;
            }
            catch
            {

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About obj = new About();
            obj.ShowDialog();
        }

        private void txtURL_MouseHover(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if(txtURL.Text == "")
            {
                txtURL.Paste();
            }
            if (txtURL.Text.StartsWith("http://") || txtURL.Text.StartsWith("https://"))
            {
                if (txtURL.Text == "")
                {
                    txtURL.Paste();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbWITH = picBoxPB.Width;
            pbHIGHT = picBoxPB.Height;
            pbUnit = pbWITH / 100.0;
            bpComplet = 0;
            bmp = new Bitmap(pbWITH, pbHIGHT);
        }

    }
    }
