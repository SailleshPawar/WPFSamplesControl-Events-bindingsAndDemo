using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace ResourcesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "ResourcesWPF.Images.azure.png";
            Stream stream = assembly.GetManifestResourceStream(resourceName);
            byte[] result = new byte[stream.Length];
            stream.Read(result, 0, result.Length);
            cloudPicture.Source = LoadImage(result);
        }

        private BitmapImage LoadImage(byte[] imageData)
        {
           if(imageData==null || imageData.Length == 0)
            {
                return null;
            }
            var image = new BitmapImage();
            using(var mem=new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
    }
}
