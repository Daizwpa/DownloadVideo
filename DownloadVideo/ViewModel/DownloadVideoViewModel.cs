using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VideoLibrary;
namespace DownloadVideo.ViewModel
{
    public class DownloadVideoViewModel : NotifyPropertyChangedBase
    {
        #region private propreties
        IProgress<double> progress;
        #endregion
        #region constructor
        public DownloadVideoViewModel( IProgress<double>  progress)
        {
            this.progress = progress;
        }
        #endregion

        #region Command
        public  ICommand download
        {
            set => download = value;

            get =>  new RelayCommand(  (paramter) => {  downloadMethod(paramter); });
        }
        #endregion

        private async void downloadMethod(object url)
        {
            string urlString = (string)url;
            YouTube youTube = new YouTube();
            YouTubeVideo video = await youTube.GetVideoAsync(urlString);
            progress.Report(50.00);
            await Task.Run(()=> File.WriteAllBytes(@"C:\Users\Daix wap\" + video.FullName, video.GetBytes()));
            progress.Report(100.00);
        }
    }
}
