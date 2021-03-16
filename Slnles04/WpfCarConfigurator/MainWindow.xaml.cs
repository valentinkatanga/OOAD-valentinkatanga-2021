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
using System.Diagnostics;

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

        private int prijs;
        private void radiobutton1_CheckedChanged(Object sender, EventArgs e)
        { 
            prijs = Berekenprijs();
            txtBox.Text = Convert.ToString(prijs);
            Layout();
        }
        private void radiobutton2_CheckedChanged(Object sender, EventArgs e)
        {
            prijs = Berekenprijs();
            txtBox.Text = Convert.ToString(prijs);
            Layout();
        }

        private void radiobutton3_CheckedChanged(Object sender, EventArgs e)
        {
            prijs = Berekenprijs();
            txtBox.Text = Convert.ToString(prijs);
            Layout();
        }
        private void accessoire1(object sender, EventArgs e)
        {
            berekenAssecoire();
        }
        private void accessoire2(object sender, EventArgs e)
        {
            berekenAssecoire();
        }
        private void accessoire3(object sender, EventArgs e)
        {
            berekenAssecoire();
            Layout();
        }


    private int Berekenprijs()
    {
            int prijs = 0;
            if (combops1.IsSelected)
            {
                if (zwart.IsChecked == true)
                {
                    prijs += 170;
                }
                else
                if (wit.IsChecked == true)
                {
                    prijs += 100;
                }
                else
                if (grijs.IsChecked == true)
                {
                    prijs += 125;
                }
            }
            else
        if (combops2.IsSelected == true)
            {
                if (zwart.IsChecked == true)
                {
                    prijs += 190;
                }
                else
                if (wit.IsChecked == true)
                {


                    prijs += 120;

                }
                else
                if (grijs.IsChecked == true)
                {


                    prijs += 145;
                }
            }
            else
         if (combops3.IsSelected == true)
            {
                if (zwart.IsChecked == true)
                {


                    prijs += 150 + 70;
                }
                else
                if (wit.IsChecked == true)
                {


                    prijs += 150;

                }
                else
                if (grijs.IsChecked == true)
                {


                    prijs += 150 + 25;
                }


            }
            return prijs;

        }

        private void berekenAssecoire()

        {
            prijs = Berekenprijs();
            if ((bool)headset.IsChecked)
            {

                prijs += 40;
            }
            else
            if ((bool)randgame.IsChecked)
            {
                prijs += 60;
            }
            else
            if ((bool)dualshock.IsChecked)
            {
              
                prijs += 70;
            }

            txtBox.Text = Convert.ToString(prijs);
        }
    private void Layout()
    {
        if (combops1.IsSelected == true)
        {
            if (zwart.IsChecked == true)
            {

                psimg.Source = new BitmapImage(new Uri("playstation/ps1b.jpg", UriKind.Relative));


            }
            else
            if (wit.IsChecked == true)
            {

                psimg.Source = new BitmapImage(new Uri("playstation/ps1w.jpg", UriKind.Relative));



            }
            else
            if (grijs.IsChecked == true)
            {

                psimg.Source = new BitmapImage(new Uri("playstation/ps1g.jpg", UriKind.Relative));


            }
        }
        else
        if (combops2.IsSelected == true)
        {
            if (zwart.IsChecked == true)
            {

                psimg.Source = new BitmapImage(new Uri(@"playstation/ps2b.jpg", UriKind.Relative));


            }
            else
            if (wit.IsChecked == true)
            {

                psimg.Source = new BitmapImage(new Uri(@"playstation/ps2w.jpg", UriKind.Relative));


            }
            else
            if (grijs.IsChecked == true)
            {

                psimg.Source = new BitmapImage(new Uri(@"playstation/ps2g.jpg", UriKind.Relative));

            }
        }
        else
         if (combops3.IsSelected == true)
         {
            if (zwart.IsChecked == true)
            {

                psimg.Source = new BitmapImage(new Uri(@"playstation/ps2b.jpg", UriKind.Relative));

            }
            else
            if (wit.IsChecked == true)
            {

                psimg.Source = new BitmapImage(new Uri(@"playstation/ps2w.jpg", UriKind.Relative));


            }
            else
            if (grijs.IsChecked == true)
            {

                psimg.Source = new BitmapImage(new Uri(@"playstation/ps2g.jpg", UriKind.Relative));

            }
            if (headset.IsChecked == true)
            {
                headset.Opacity = 1;
            }
            else
            if (randgame.IsChecked == true)
            {
                randgame.Opacity = 1;
            }
            else
            if (dualshock.IsChecked == true)
            {
                dualshock.Opacity = 1;
            }
         }
    }

        private void headset_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }


    }





   


