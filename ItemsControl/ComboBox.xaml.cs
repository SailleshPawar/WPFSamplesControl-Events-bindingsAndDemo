using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ItemsControl
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

        private void Dates_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IList items = e.AddedItems;
            int index = Dates.SelectedIndex;
            var selectedItem = Dates.SelectedItem;
            var selectedValue = Dates.SelectedValue;
            Debug.WriteLine($"Addeditems[0] {(DateTime)items[0]}");

            Debug.WriteLine($"SelectedIndex {index}");
            Debug.WriteLine($"SelectedItem {(DateTime)selectedItem}");
            Debug.WriteLine($"SelectedValue {(DayOfWeek)selectedValue}");
        }
    }
}
