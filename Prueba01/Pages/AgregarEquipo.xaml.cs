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
using System.Xml.Serialization;


namespace Prueba01.Pages
{
    /// <summary>
    /// Lógica de interacción para AgregarEquipo.xaml
    /// </summary>
    public partial class AgregarEquipo : Page


    {






        public AgregarEquipo()
        {
            InitializeComponent();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out _);
        }


        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }



        

        private void AgregarEquipo_Click(object sender, RoutedEventArgs e)
        {
            // Obtener valores del formulario
            string nombreEquipo = txtNombreEquipo.Text;
            int cantidadJugadores = int.Parse(txtCantidadJugadores.Text);
            string nombreDT = txtNombreDT.Text;
            string tipoEquipo = txtTipoEquipo.Text;
            string capitanEquipo = txtCapitanEquipo.Text;
            bool tieneSub21 = chkTieneSub21.IsChecked ?? false;

            // Crear un nuevo equipo
            Equipo Equipo = new Equipo(nombreEquipo, cantidadJugadores, nombreDT, tipoEquipo, capitanEquipo, tieneSub21);

            // Agregar el equipo a la lista estática
            EquipoRepository.Equipos.Add(Equipo);

            MessageBox.Show("Equipo agregado con éxito.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);


        }

        private void LimpiarFormulario()
        {
            txtNombreEquipo.Clear();
            txtCantidadJugadores.Clear();
            txtNombreDT.Clear();
            txtTipoEquipo.Clear();
            txtCapitanEquipo.Clear();
            chkTieneSub21.IsChecked = false;
        }
    }

}
