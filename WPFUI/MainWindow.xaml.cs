using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void OrdinaryButton_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private async void SubmitButton_Click(object sender, RoutedEventArgs e)
        {

            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
            //MessageBox.Show($"Hello {firstNameText.Text}");
        }

        private async void ToggleButton_Check(object sender, RoutedEventArgs e)
        {
            var toggelButton = (ToggleButton)sender;
            Debug.WriteLine($"{toggelButton.Name} is checked. Now isChecked {1}", toggelButton.Name, toggelButton.IsChecked);
        }
        private async void ToggleButton_UnCheck(object sender, RoutedEventArgs e)
        {
            var toggelButton = (ToggleButton)sender;
            Debug.WriteLine($"{toggelButton.Name} is unchecked. Now isChecked {1}", toggelButton.Name, toggelButton.IsChecked);
        }
        private async void OnValueChanged(object sender, RoutedEventArgs e)
        {
            var slider = (Slider)sender;
            SliderValue.Text = slider.Value.ToString();
            Debug.WriteLine($"{slider.Name} is unchecked. Now isChecked {1}", slider.Name, slider.Value);
        }
    }
}
