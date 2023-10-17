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
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class ActualizarEquipo : Page



    {

        private Equipo equipoParaActualizar;
        public ActualizarEquipo(Class.Equipo equipo)
        {
            InitializeComponent();



            // Guarda una referencia al equipo que se va a actualizar
            equipoParaActualizar = equipo;

            // Rellena el formulario con los datos del equipo
            txtNombreEquipo.Text = equipo.NombreEquipo;
            txtCantidadJugadores.Text = equipo.CantidadJugadores.ToString();
            txtNombreDT.Text = equipo.NombreDT;
            txtTipoEquipo.Text = equipo.TipoEquipo;
            txtCapitanEquipo.Text = equipo.CapitanEquipo;
            chkTieneSub21.IsChecked = equipo.TieneSub21;
        }

        private void ActualizarEquipo_Click(object sender, RoutedEventArgs e)
        {
            // Obtiene los valores del formulario
            string nombreEquipo = txtNombreEquipo.Text;
            int cantidadJugadores;

            if (!int.TryParse(txtCantidadJugadores.Text, out cantidadJugadores))
            {
                MessageBox.Show("La cantidad de jugadores debe ser un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string nombreDT = txtNombreDT.Text;
            string tipoEquipo = txtTipoEquipo.Text;
            string capitanEquipo = txtCapitanEquipo.Text;
            bool tieneSub21 = chkTieneSub21.IsChecked ?? false;

            // Actualiza los datos del equipo
            equipoParaActualizar.NombreEquipo = nombreEquipo;
            equipoParaActualizar.CantidadJugadores = cantidadJugadores;
            equipoParaActualizar.NombreDT = nombreDT;
            equipoParaActualizar.TipoEquipo = tipoEquipo;
            equipoParaActualizar.CapitanEquipo = capitanEquipo;
            equipoParaActualizar.TieneSub21 = tieneSub21;

            
        }
    }

        


    }

