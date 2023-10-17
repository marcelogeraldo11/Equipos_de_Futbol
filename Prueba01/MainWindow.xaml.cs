using Prueba01.Pages;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Prueba01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Uri("Pages/AgregarEquipo.xaml", UriKind.Relative));
        }

        private void ListarTodos_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Uri("Pages/ListarEquipos.xaml", UriKind.Relative));
        }

        private void AcercaDe_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Uri("Pages/AcercaDe.xaml", UriKind.Relative));
        }
    }


}

