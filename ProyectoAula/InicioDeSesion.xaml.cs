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

namespace ProyectoAula
{
    /// <summary>
    /// Lógica de interacción para InicioDeSesion.xaml
    /// </summary>
    public partial class InicioDeSesion : Page
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void TxtUsuario_GotFocus(object sender, RoutedEventArgs e)
        {
            placeholderUsuario.Visibility = Visibility.Collapsed;
        }

        private void TxtUsuario_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                placeholderUsuario.Visibility = Visibility.Visible;
        }

        private void TxtContrasena_GotFocus(object sender, RoutedEventArgs e)
        {
            placeholderContrasena.Visibility = Visibility.Collapsed;
        }

        private void TxtContrasena_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena.Password))
                placeholderContrasena.Visibility = Visibility.Visible;
        }

        private void BtnIngresar_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Password;

            if (usuario == "admin" && contrasena == "1234") // Lógica de autenticación
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                // Cerrar la ventana de inicio de sesión
                Window.GetWindow(this).Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
