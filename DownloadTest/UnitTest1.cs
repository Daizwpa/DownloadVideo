using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using VideoLibrary;
namespace DownloadTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            downloadMethod("https://www.youtube.com/watch?v=tbnLqRW9Ef0");
        }

        private  void downloadMethod(object url)
        {
            string urlString = (string)url;
            YouTube youTube = new YouTube();
            
            YouTubeVideo video =  youTube.GetVideo(urlString);
            File.WriteAllBytes(@"C:\Users\Daix wap\" + video.FullName, video.GetBytes());
        }
    }
}
