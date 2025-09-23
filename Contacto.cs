using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAplicacionAgendaPersonal
{
    public class Contactos
    {
        public string Nombre { get; set; }

        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

        public DateTime Creacion { get; set; }
        public string Genero { get; set; }


        public Contactos(string nombre, string apellido1, string apellido2, DateTime creacion, string genero)
        {
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Creacion = creacion;
            Genero = genero;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Apellido1: {Apellido1}, Apellido2: {Apellido2}, Creacion: {Creacion.ToShortDateString()}, Genero: {Genero}";
        }
    }
}
