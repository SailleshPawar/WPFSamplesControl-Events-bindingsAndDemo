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

namespace Bindings
{
    /// <summary>
    /// Interaction logic for Source.xaml
    /// </summary>
    public partial class Source : Window
    {
        public Craftsman Craftsman { get; set; }
        public Source()
        {
            Craftsman = new Craftsman() { Age = 50, LastName = "Pawar", Name = "Saillesh", PicturePath = "Images/azure.png" };
            //InitializeComponent();
            //Binding pictureBinding = new Binding();
            //pictureBinding.Source = Craftsman;
            //pictureBinding.Path = new PropertyPath("PicturePath");
            //CraftsmanPicture.SetBinding(Image.SourceProperty, pictureBinding);

            //Binding nameBinding = new Binding();
            //nameBinding.Source = Craftsman;
            //nameBinding.Path = new PropertyPath("Name");
            //Name.SetBinding(TextBlock.TextProperty, nameBinding);

            //Binding LastnameBinding = new Binding();
            //LastnameBinding.Source = Craftsman;
            //LastnameBinding.Path = new PropertyPath("LastName");
            //LastName.SetBinding(TextBlock.TextProperty, LastnameBinding);

            //Binding ageBinding = new Binding();
            //ageBinding.Source = Craftsman;
            //ageBinding.Path = new PropertyPath("Age");
            //Age.SetBinding(TextBox.TextProperty, ageBinding);
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Craftsman.Age = 40;
        }
    }
}
