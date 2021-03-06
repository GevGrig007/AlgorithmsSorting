using AlgorithmsSort;
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

namespace AlgorithmWPF
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
        private readonly List<int> Numbers = new();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(AddNumber.Text, out int value))
            {
                Numbers.Add(value);
            }
            AddNumber.Clear();
            shownumber.ItemsSource = Numbers.ToList();
        }
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e) { }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)  { }
        private void progbar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)  { }
        private void shownumber_SelectionChanged(object sender, SelectionChangedEventArgs e) { }
        private void refresh_btn_Click(object sender, RoutedEventArgs e)
        {
            Numbers.Clear();
            sortednumber.ItemsSource = null;
            shownumber.ItemsSource = null;
        }
        
        private void Shake_Click(object sender, RoutedEventArgs e)
        {
            var sortednumbers = new ShakeSort(Numbers);
            sortednumber.ItemsSource = sortednumbers.MakeSort();
            operationcount.Text = sortednumbers.OperationCount.ToString();
        }
        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            var sortednumbers = new InsertionSort(Numbers);
            sortednumber.ItemsSource = sortednumbers.MakeSort();
            operationcount.Text = sortednumbers.OperationCount.ToString();
        }
        private void Bubble_Click(object sender, RoutedEventArgs e)
        {
            var sortednumbers = new BubbleSort(Numbers);
            sortednumber.ItemsSource = sortednumbers.MakeSort();
            operationcount.Text = sortednumbers.OperationCount.ToString();
        }
        private void Shell_Click(object sender, RoutedEventArgs e)
        {
            var sortednumbers = new ShellSort(Numbers);
            sortednumber.ItemsSource = sortednumbers.MakeSort();
            operationcount.Text = sortednumbers.OperationCount.ToString();
        }
    }
}
