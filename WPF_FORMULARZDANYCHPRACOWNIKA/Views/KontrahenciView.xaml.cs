﻿using System;
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
    /// Interaction logic for KontrahenciView.xaml
    /// </summary>
    public partial class KontrahenciView : UserControl
    {
        public KontrahenciView()
        {
            InitializeComponent();
        }

        private void DaneKontrahentaWindow(object sender, RoutedEventArgs e)
        {
            DaneKontrahentaWindow daneKontrahentaWindow = new DaneKontrahentaWindow();
            daneKontrahentaWindow.Show();
        }

    }
}
