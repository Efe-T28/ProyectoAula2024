using System.Configuration;
using System.Data;
using System.Windows;

namespace ProyectoAula
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Mostrar la página de inicio de sesión primero
            InicioDeSesion inicioDeSesion = new InicioDeSesion();
            Window loginWindow = new Window
            {
                Content = inicioDeSesion,
                Width = 800,
                Height = 450,
                Title = "Inicio de Sesión",
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            loginWindow.Show();
        }
    }

}
