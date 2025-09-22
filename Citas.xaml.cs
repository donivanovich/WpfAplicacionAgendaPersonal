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

namespace WpfAplicacionAgendaPersonal
{
    /// <summary>
    /// Lógica de interacción para Citas.xaml
    /// </summary>
    public partial class Citas : Page
    {
        public Citas()
        {
            InitializeComponent();
            // Crear una lista para almacenar las citas vacia
            // List<Cita> ListaCitas = new List<Cita>();

            // Crear una lista con valores por defecto
            List<Cita> ListaCitas = new List<Cita>
            {
                new Cita(titulo: "Comida", fecha: DateTime.Now, descripcion: "Comida en el restaurante"),
                new Cita(titulo: "Reunión", fecha: DateTime.Now.AddDays(1), descripcion: "Reunión con el equipo de trabajo")
            };
            // Asignar la lista al ListBox(llamado ListaCitasInterfaz)
            ListaCitasInterfaz.ItemsSource = ListaCitas;
        }
    }
}
