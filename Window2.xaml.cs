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

namespace ISRPO_Cherednichenko_PR10
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Add(textbox1.Text);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Remove(listbox1.SelectedItem);
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Content", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("image/1.jpg", UriKind.Relative));
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("image/2.jpg", UriKind.Relative));
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("image/3.jpg", UriKind.Relative));
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("image/4.jpg", UriKind.Relative));
        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("image/5.jpg", UriKind.Relative));
        }
    }
}
