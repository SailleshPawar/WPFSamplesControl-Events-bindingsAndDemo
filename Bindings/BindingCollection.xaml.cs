using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Bindings
{
    /// <summary>
    /// Interaction logic for BindingCollection.xaml
    /// </summary>
    public partial class BindingCollection : Window
    {

        public ObservableCollection<Craftsman> Craftsman { get; set; }
        public BindingCollection()
        {
            Craftsman = new ObservableCollection<Craftsman>()
            {
                new Craftsman{Age=10,LastName="Gurav",Name="Digambar",PicturePath="Images/azure.png" },
                new Craftsman{Age=22,LastName="Saillesh",Name="Pawar",PicturePath="Images/amazon.png" }
            };
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Craftsman.Add(new Craftsman()
            {
                Age = 100,
                Name = "Deepa",
                LastName = "Devi",
                PicturePath = "Images/google.png"
            });
        }
    }
}
