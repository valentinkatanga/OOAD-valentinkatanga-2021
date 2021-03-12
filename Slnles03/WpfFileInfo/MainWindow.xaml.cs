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

namespace WpfFileInfo
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
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.Filter = "Tekstbestanden|*.TXT;*.TEXT";
            string chosenFileName;
            if (dialog.ShowDialog() == true)
            {

                chosenFileName = dialog.FileName; 
                FileInfo fi = new FileInfo(chosenFileName);
                string info = "";
                info += $"bestandsnaam: {fi.Name}{Environment.NewLine}";
                info += $"extensie: {fi.Extension}{Environment.NewLine}";
                info += $"gemaakt op: {fi.CreationTime.ToString()}{Environment.NewLine}";
                info += $"mapnaam: {fi.Directory.Name}{Environment.NewLine}";
                info += $"mapwoorden: {fi.Length}{Environment.NewLine}";


                txtblvck.Text = info;

            }
        }
    }
}
