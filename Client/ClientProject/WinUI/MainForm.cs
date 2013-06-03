using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WinUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// StorageUrl地址
        /// </summary>

        private string strStorageUrl;
        /// <summary>
        /// 上传到SAE服务器端的PHP脚本
        /// </summary>
        private string strServerDownPHPScriptUrl;

        /// <summary>
        /// SAE应用名称
        /// </summary>
        private string strSAEName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            InitAddress();

            WebRequest myRequest= WebRequest.Create(strServerDownPHPScriptUrl);

            WebResponse myResponse=myRequest.GetResponse();

            StreamReader reader=new StreamReader(myResponse.GetResponseStream());

            string FileName=reader.ReadToEnd();

            String [] DownFileName=FileName.Split('|');

            WebClient myWebClient=new WebClient();

            

            try
            {
                foreach (string fname in DownFileName)
                {

                    if (fname != "")
                    {
                        string downloadfileaddress = strStorageUrl + fname;
                        Debug.Print(downloadfileaddress);
                        myWebClient.DownloadFile(downloadfileaddress, Path.GetFileName(fname));
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("出错");
            }



        }
        /// <summary>
        /// 生成下载地址
        /// </summary>
        private void InitAddress()
        {
            strSAEName = this.txtSAEName.Text;
            strStorageUrl = string.Format("http://{0}-{1}.stor.sinaapp.com/", strSAEName,this.txtStoragename.Text);
            strServerDownPHPScriptUrl = string.Format("http://{0}.sinaapp.com/sae_mutiple_downloads.php?storeapp={1}", 
                strSAEName,this.txtStoragename.Text);
            Debug.Print(strStorageUrl);
            Debug.Print(strServerDownPHPScriptUrl);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

        }



    }
}
