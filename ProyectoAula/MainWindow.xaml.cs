using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnConsultar.Click += BtnConsultar_Click;

        }

        private void BtnConsultar_Click(object sender, RoutedEventArgs e)
        {            
            ConsultarAlertas consultarAlertas = new ConsultarAlertas();

            this.Content = consultarAlertas;
        }


        private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CerrarSesionDialogo
            {
                Owner = this
            };
            dialog.ShowDialog();

            if (dialog.CerrarSesion)
            {
                
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
                this.Close();
            }
            
        }

    }
}