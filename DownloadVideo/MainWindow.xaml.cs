using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using DownloadVideo.ViewModel;

namespace DownloadVideo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Progress<double> progress;
        
        public  MainWindow()
        {
            InitializeComponent();
            //initialize progess
            progress = new Progress<double>();
            progress.ProgressChanged += Progress_ProgressChanged;

            this.DataContext = new DownloadVideoViewModel( progress);
            
        }

        private void Progress_ProgressChanged(object sender, double e)
        {
            progerssBar.Value = e;
        }
    }
}
