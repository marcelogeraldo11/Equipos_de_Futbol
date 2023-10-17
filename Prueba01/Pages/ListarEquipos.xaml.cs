using Prueba01.Class;
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

namespace Prueba01.Pages
{
    /// <summary>
    /// Lógica de interacción para ListarEquipos.xaml
    /// </summary>
    public partial class ListarEquipos : Page
    {
        public ListarEquipos()
        {
            InitializeComponent();

            dataGridEquipos.ItemsSource = EquipoRepository.Equipos;
        }

        private void EliminarEquipo_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridEquipos.SelectedItem is Equipo equipoSeleccionado)
            {
                EquipoRepository.Equipos.Remove(equipoSeleccionado);
                dataGridEquipos.Items.Refresh(); // Actualizar la grilla
            }
        }

        private void ActualizarEquipo_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridEquipos.SelectedItem is Equipo equipoSeleccionado)
            {
                ActualizarEquipo actualizarEquipo = new ActualizarEquipo(equipoSeleccionado);
                

                // Actualizar la grilla después de la actualización en "ActualizarEquipoWindow"
                dataGridEquipos.Items.Refresh();
            }
        }

    }
}
