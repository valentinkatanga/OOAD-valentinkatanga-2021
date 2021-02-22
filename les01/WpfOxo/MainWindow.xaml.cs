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

namespace WpfOxo
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (plchck1.IsChecked == true)
            {
                btn1.Content = "X";
            }
            if (plchck2.IsChecked == true)
            {
                btn1.Content = "O";
            }
           
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (plchck1.IsChecked == true)
            {
                btn2.Content = "X";
            }
            if (plchck2.IsChecked == true)
            {
                btn2.Content = "O";
            }
            
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (plchck1.IsChecked == true)
            {
                btn3.Content = "X";
            }
            if (plchck2.IsChecked == true)
            {
                btn3.Content = "O";
            }
            
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (plchck1.IsChecked == true)
            {
                btn4.Content = "X";
            }
            if (plchck2.IsChecked == true)
            {
                btn4.Content = "O";
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (plchck1.IsChecked == true)
            {
                btn5.Content = "X";
            }
            if (plchck2.IsChecked == true)
            {
                btn5.Content = "O";
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (plchck1.IsChecked == true)
            {
                btn6.Content = "X";
            }
            if (plchck2.IsChecked == true)
            {
                btn6.Content = "O";
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (plchck1.IsChecked == true)
            {
                btn7.Content = "X";
            }
            if (plchck2.IsChecked == true)
            {
                btn7.Content = "O";
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (plchck1.IsChecked == true)
            {
                btn8.Content = "X";
                
            }
            if (plchck2.IsChecked == true)
            {
                btn8.Content = "O";
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (plchck1.IsChecked == true)
            {
                btn9.Content = "X";
            }
            if (plchck2.IsChecked == true)
            {
                btn9.Content = "O";
            }
        }

        private void plchck1_Checked(object sender, RoutedEventArgs e)
        {
            if(plchck1.IsChecked == true)
            {
                plchck2.IsChecked = false;
            }
            

        }

        private void plchck2_Checked(object sender, RoutedEventArgs e)
        {
            if (plchck2.IsChecked == true)
            {
                plchck1.IsChecked = false;
            }
        }
      
        
        

        
    }
}
