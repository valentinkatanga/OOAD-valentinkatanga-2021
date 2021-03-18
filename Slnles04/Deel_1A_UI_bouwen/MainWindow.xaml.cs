using Microsoft.Win32;
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

namespace Deel_1A_UI_bouwen
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            statlbl.Content = "Chars: " + txtBox1.Text.Length.ToString();
            if (txtBox1.SelectedText == "")
            {
                btnCopy.IsEnabled = false;
            }
            else
            {
                btnCopy.IsEnabled = true;

            }
            if (txtBox1.SelectedText == "")
            {
                btnCut.IsEnabled = false;
            }
            else
            {
                btnCut.IsEnabled = true;

            }

        }

        
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
            
        }


        private void btnCopy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Convert.ToString(txtBox1.SelectedText));
            txtBox1.SelectedText = "";
        }

        private void btnCut_Click(object sender, RoutedEventArgs e)
        {

            Clipboard.SetText(Convert.ToString(txtBox1.SelectedText));
            txtBox1.SelectedText = "";

        }
        private void btnPaste_Click(object sender, RoutedEventArgs e)
        {
            txtBox1.Text = Clipboard.GetText();
        }


        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.Show();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.Filter = "Tekstbestanden|*.TXT;*.TEXT";
            string chosenFileName;
            if (dialog.ShowDialog() == true)
            {

                chosenFileName = dialog.FileName;
                txtBox1.Text = File.ReadAllText(chosenFileName);
            }

        }
    }
}
