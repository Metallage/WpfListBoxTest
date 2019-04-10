using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfListBoxTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ViewModel myVM = new ViewModel();

        public MainWindow()
        {

            //AddSomeData();
            InitializeComponent();
            DataContext = myVM;
        }

        private void AddSomeData()
        {
            for(int i = 1; i <=5; i++)
            {
                myVM.ItsSource.Add(new SampleClass
                {
                    First = $"First name {i}",
                    Second = $"Second name {i}",
                    Third = $"Third name {i}",
                    Fouth = $"Fouth name {i}"
                });
                myVM.Thirds.Add($"Third name {i}");
                myVM.Fouths.Add($"Fouth name {i}");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AddSomeData();
        }

        private void CommandBinding_DeleteExecuted(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void CommandBinding_DeleteCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }
    }
}
