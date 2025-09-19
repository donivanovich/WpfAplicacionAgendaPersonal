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

namespace WpfAplicacionAgendaPersonal
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
        private void ButtonMenu(object sender, RoutedEventArgs e)
        {
            txtSeccion.Text = "Sección Menu";

        }

        private void ButtonContactos(object sender, RoutedEventArgs e)
        {
            txtSeccion.Text = "Sección Contactos";
        }

        private void ButtonCitas(object sender, RoutedEventArgs e)
        {
            txtSeccion.Text = "Sección Citas";
        }
    }
}