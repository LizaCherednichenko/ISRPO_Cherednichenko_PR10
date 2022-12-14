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

namespace ISRPO_Cherednichenko_PR10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add(textbox1.Text);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Text", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void pr2_Click(object sender, RoutedEventArgs e)
        {
            Window window1 = new Window1();
            window1.Show();
        }

        private void individual_Click(object sender, RoutedEventArgs e)
        {
            Window window2 = new Window2();
            window2.Show();
        }
    }
}
