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
            BerekenLayout();

        }
        int prijs = 0;
        private void BerekenLayout()
        {
            if (combops1.IsSelected == true)
            {
                if (zwart.IsChecked == true)
                {

                    psimg.Source = new BitmapImage(new Uri("playstation/ps1b.jpg", UriKind.Relative));
                    prijs += 170;

                }
                else
                if (wit.IsChecked == true)
                {

                    psimg.Source = new BitmapImage(new Uri("playstation/ps1w.jpg", UriKind.Relative));
                    prijs += 100;


                }
                else
                if (grijs.IsChecked == true)
                {

                    psimg.Source = new BitmapImage(new Uri("playstation/ps1g.jpg", UriKind.Relative));
                    prijs += 125;

                }
            }
            else
         if (combops2.IsSelected == true)
            {
                if (zwart.IsChecked == true)
                {

                    psimg.Source = new BitmapImage(new Uri(@"playstation/ps2b.jpg", UriKind.Relative));
                    prijs += 120 + 70;

                }
                else
                if (wit.IsChecked == true)
                {

                    psimg.Source = new BitmapImage(new Uri(@"playstation/ps2w.jpg", UriKind.Relative));
                    prijs += 120;

                }
                else
                if (grijs.IsChecked == true)
                {

                    psimg.Source = new BitmapImage(new Uri(@"playstation/ps2g.jpg", UriKind.Relative));
                    prijs += 120 + 25;
                }
            }
            else
         if (combops3.IsSelected == true)
            {
                if (zwart.IsChecked == true)
                {

                    psimg.Source = new BitmapImage(new Uri(@"playstation/ps2b.jpg", UriKind.Relative));
                    prijs += 150 + 70;
                }
                else
                if (wit.IsChecked == true)
                {

                    psimg.Source = new BitmapImage(new Uri(@"playstation/ps2w.jpg", UriKind.Relative));
                    prijs += 150;

                }
                else
                if (grijs.IsChecked == true)
                {

                    psimg.Source = new BitmapImage(new Uri(@"playstation/ps2g.jpg", UriKind.Relative));
                    prijs += 150 + 25;
                }
            }
            if (headset.IsChecked == true)
            {
                headset.Opacity = 1;
                prijs += 40;
            }
            else
            if (randgame.IsChecked == true)
            {
                randgame.Opacity = 1;
                prijs += 60;
            }
            else
            if (dualshock.IsChecked == true)
            {
                dualshock.Opacity = 1;
                prijs += 70;
            }
        }
    }







}   


