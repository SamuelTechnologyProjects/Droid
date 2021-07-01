using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.ComponentModel;

namespace Droid_NG___2._0
{
    class Downlaod_file
	{
        public static string path;
        public static string progress = "■";
 
        public static void Get(string url,string savepath)
        {
            path = savepath;
            WebClient webClient = new WebClient();
            webClient.DownloadFile(url, @""+savepath);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
        }
        public static void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine(progress);
            
            
            

        }
        public static void Completed(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Download Has Finshed!");
            Console.WriteLine("Right Here At " + path);
        }


    }
}
