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
using System.Windows.Shapes;

namespace ResourcesWPF
{
    /// <summary>
    /// Interaction logic for LogicalResource.xaml
    /// </summary>
    public partial class LogicalResource : Window
    {
        public LogicalResource()
        {
            InitializeComponent();
        }

        private void BtnClick_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["CustomBrush"] = new SolidColorBrush(Colors.Green);
        }
    }
}
