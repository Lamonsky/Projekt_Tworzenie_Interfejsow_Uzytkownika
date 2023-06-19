using PROJEKT.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Windows.Threading;

namespace PROJEKT.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer(TimeSpan.FromSeconds(1), DispatcherPriority.Normal, (object s, EventArgs ev) =>
            {
               this.myDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            }, this.Dispatcher);
            timer.Start();
        }

        private void KontrahenciView(object sender, RoutedEventArgs e)
        {
            ClearWorkspace(sender, e);
            Workspace.Content = new KontrahenciView();
        }
        

        private void DokumentyView(object sender, RoutedEventArgs e)
        {
            ClearWorkspace(sender, e);
            Workspace.Content = new DokumentyView();
        }
        private void TowaryView(object sender, RoutedEventArgs e)
        {
            ClearWorkspace(sender, e);
            Workspace.Content = new TowaryView();
        }
        private void MagazynyView(object sender, RoutedEventArgs e)
        {
            ClearWorkspace(sender, e);
            Workspace.Content = new MagazynyView();
        }
        private void ClearWorkspace(object sender, RoutedEventArgs e)
        {
            Workspace.Content = null;
            Workspace.NavigationService.RemoveBackEntry();
        }

        private void KsiegaInwentarzowaView(object sender, RoutedEventArgs e)
        {
            ClearWorkspace(sender, e);
            Workspace.Content = new KsiegaInwentarzowaView();
        }

        private void TabelaAmortyzacjiView(object sender, RoutedEventArgs e)
        {
            ClearWorkspace(sender, e);
            Workspace.Content = new TabelaAmortyzacjiView();
        }

    }

}
