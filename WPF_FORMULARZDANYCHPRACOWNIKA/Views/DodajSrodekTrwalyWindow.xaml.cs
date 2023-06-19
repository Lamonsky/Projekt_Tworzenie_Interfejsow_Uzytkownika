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
using System.Windows.Shapes;

namespace PROJEKT.Views
{
    /// <summary>
    /// Interaction logic for DodajSrodekTrwalyWindow.xaml
    /// </summary>
    public partial class DodajSrodekTrwalyWindow : Window
    {
        public DodajSrodekTrwalyWindow()
        {
            InitializeComponent();
        }

        private void KSTWindow(object sender, RoutedEventArgs e)
        {
            KSTWindow kSTWindow = new KSTWindow();
            kSTWindow.Show();
        }

        private void SamochodyWindow(object sender, RoutedEventArgs e)
        {
            SamochodWindow samochodwindow = new SamochodWindow();
            samochodwindow.Show();
        }
    }
}
