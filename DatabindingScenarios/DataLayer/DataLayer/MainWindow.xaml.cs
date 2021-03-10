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
using DevExpress.Xpf.Core;

namespace DataLayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void basicCollectionButton_Click(object sender, RoutedEventArgs e)
        {
            new BasicCollectionWindow().Show();
        }

        private void efButton_Click(object sender, RoutedEventArgs e)
        {
            new EFWindow().Show();
        }

        private void efServerModeSourceButton_Click(object sender, RoutedEventArgs e)
        {
            new EntityServerModeSourceWindow().Show();
        }

        private void virtualSourceButton_Click(object sender, RoutedEventArgs e)
        {
            new VirtualSourceWindow().Show();
        }

        private void efCurrentItemButton_Click(object sender, RoutedEventArgs e)
        {
            new CurrentItemWindow().Show();
        }
    }
}
