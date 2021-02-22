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

namespace WpfAlcohol
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
    

        private void updateRectangle()
        {
            Dispatcher.Invoke(() =>
            {
                rec_glazen.Width = 250 * ((slider_Bier.Value + slider_Whiskey.Value + slider_Wijn.Value) / 15);
                Color color = Color.FromRgb(Convert.ToByte(17 * (slider_Bier.Value + slider_Whiskey.Value + slider_Wijn.Value)), Convert.ToByte(255 - (17 * (slider_Bier.Value + slider_Whiskey.Value + slider_Wijn.Value))), Convert.ToByte(0));
                rec_glazen.Fill = new SolidColorBrush(color);
               
            }); 
        }



        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            if (slider_Bier.Value == 1)
            {
                label_bier.Content = slider_Bier.Value + " glas";
            }
            else
            {
                label_bier.Content = slider_Bier.Value + " glazen";
            }
            updateRectangle();

        }

        private void slider_Wijn_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (slider_Wijn.Value == 1)
            {
                label_wijn.Content = slider_Wijn.Value + " glas";
            }
            else
            {
                label_wijn.Content = slider_Wijn.Value + " glazen";
            }
            updateRectangle();
        }


        private void slider_Whiskey_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {



            if (slider_Whiskey.Value == 1)
            {
                label_Whiskey.Content = slider_Whiskey.Value + " glas";
            }
            else
            {
                label_Whiskey.Content = slider_Whiskey.Value + " glazen";
            }
            updateRectangle();
        }
    }
}

