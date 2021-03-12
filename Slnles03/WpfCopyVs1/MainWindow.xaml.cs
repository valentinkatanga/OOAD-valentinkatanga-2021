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

namespace WpfCopyVs1
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
            List<string> lines = new List<string>();
            string document = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string documentweg = System.IO.Path.Combine(document, "lines");
            using (StreamReader reader = File.OpenText(documentweg))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            string filePathbis = System.IO.Path.Combine(document, "lines2");
            using (StreamWriter writer = File.CreateText(documentweg))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                    


                }
                lbllines.Content = "bestand is overgezet";
            }
        }
    }
}    
