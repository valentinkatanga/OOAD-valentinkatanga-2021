using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfCarConfigurator
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }




        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox1.SelectedItem == ps1 )
            {
               psimg.Source = new BitmapImage(new Uri("playstation/ps2b.jpg", UriKind.Relative));

            }
            else 
            if(ComboBox1.SelectedItem == ps2)
            {
                psimg.Source = new BitmapImage(new Uri("playstation/ps2b.jpg", UriKind.Relative));
            }
            else
            if (ComboBox1.SelectedItem == ps3)
            {
                psimg.Source = new BitmapImage(new Uri("playstation/ps3b.jpg", UriKind.Relative));
            }
            

        }

        private void dualcb_Checked(object sender, RoutedEventArgs e)
        {
            if (dualcb.IsChecked == false)
            {
                imgDs.Opacity = 0.3;
            }
        }

        private void hdcb_Checked(object sender, RoutedEventArgs e)
        {
            if (hdcb.IsChecked == false)
            {
                imgHd.Opacity = 0.3;
            }
        }

        private void gamecb1_Checked(object sender, RoutedEventArgs e)
        {
            if (hdcb.IsChecked == false)
            {
                imgG.Opacity = 0.3;
            }
        }

    }
}

