using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAplicacionAgendaPersonal
{
    public class ContactosViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Contactos> Contactos { get; set; }

        private Contactos _contactoSeleccionado;

        // Crear un getter y setter para el contacto seleccionado

        public Contactos ContactoSeleccionado
        {
            get => _contactoSeleccionado;
            set
            {
                _contactoSeleccionado = value;
                OnPropertyChanged();
            }
        }

        public ICommand AgregarContactoCommand { get; }

        private void AgregarContacto(object parameter) 
        {   
            Contactos.Add(
                new Contactos(
                    nombre: "Nuevo",
                    apellido1: "Contacto",
                    apellido2: "",
                    creacion: DateTime.Now,
                    genero: "Otro"
                )
            );
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string nombre = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}
