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

namespace PROJEKT.Views
{
    /// <summary>
    /// Interaction logic for KsiegaInwentarzowaView.xaml
    /// </summary>
    public partial class KsiegaInwentarzowaView : UserControl
    {
        public KsiegaInwentarzowaView()
        {
            InitializeComponent();
        }
        private void DodajSrodekTrwalyWindow(object sender, RoutedEventArgs e)
        {
            DodajSrodekTrwalyWindow dodajSrodekTrwaly = new DodajSrodekTrwalyWindow();
            dodajSrodekTrwaly.Show();
        }
        private void KSTWindow(object sender, RoutedEventArgs e)
        {
            KSTWindow kSTWindow = new KSTWindow();
            kSTWindow.Show();
        }
    }
}
