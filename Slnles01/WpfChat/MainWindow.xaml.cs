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

namespace WpfChat
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string bericht = txt_bericht.Text;
            string naam = txt_naam.Text;

            txt_venster.Text += naam + " says:"+ "\n" + bericht + "\n";

            txt_naam.Text = "";
            txt_bericht.Text = "";
            txt_venster.Text += Environment.NewLine;

            txt_venster.Text = txt_venster.Text.Replace("salaud", "***");
            txt_venster.Text = txt_venster.Text.Replace("batard", "***");
            txt_venster.Text = txt_venster.Text.Replace("niquer", "***");


        }
        

        private void txt_bericht_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void naam_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
