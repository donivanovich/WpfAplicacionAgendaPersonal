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
    /// Lógica de interacción para Contacto.xaml
    /// </summary>
    public partial class Contacto : Page
    {
        public Contacto()
        {
            InitializeComponent();

            List<Contactos> ListaContacto = new List<Contactos>
            {
                new Contactos(nombre: "Juan", apellido1: "Gonzalez", apellido2: "Perez", creacion: DateTime.Now, genero: "Hombre"),
                new Contactos(nombre: "Paco", apellido1: "Juarez", apellido2: "Perez", creacion: DateTime.Now, genero: "Hombre"),
                new Contactos(nombre: "Javier", apellido1: "Quevedo", apellido2: "Perez", creacion: DateTime.Now, genero: "Hombre"),
                new Contactos(nombre: "Domingo", apellido1: "Dominguez", apellido2: "Perez", creacion: DateTime.Now, genero: "Hombre"),
                new Contactos(nombre: "Ivan", apellido1: "Sanchez", apellido2: "Perez", creacion: DateTime.Now, genero: "Hombre"),
                new Contactos(nombre: "Mario", apellido1: "Martinez", apellido2: "Perez", creacion: DateTime.Now, genero: "Hombre"),
                new Contactos(nombre: "Jose", apellido1: "Perez", apellido2: "Perez", creacion: DateTime.Now, genero: "Hombre"),
                new Contactos(nombre: "Jorge", apellido1: "Dominguez", apellido2: "Perez", creacion: DateTime.Now, genero: "Hombre"),
            };
            // Asignar la lista al ListBox(llamado ListaCitasInterfaz)
            ListaContactosInterfaz.ItemsSource = ListaContacto;
        }
    }
}
