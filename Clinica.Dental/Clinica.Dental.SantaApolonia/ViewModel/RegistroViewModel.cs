using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Clinica.Dental.BE;
using Clinica.Dental.BL;
using System.Windows.Input;
using Clinica.Dental.SantaApolonia.Views;

namespace Clinica.Dental.SantaApolonia.ViewModel
{
    public class RegistroViewModel : vmb, vmbClose
    {
        private PacienteBE paciente;
        private vmbCommand _registrar;
        private Dictionary<string, string> _listaSexo;
        private Dictionary<string,string> _listaEstados;
        
        public RegistroViewModel()
        {
            IniciarDatos();
        }

        private void IniciarDatos()
        {
            Paciente = new PacienteBE() { FchNacimiento = DateTime.Now };
            _listaSexo = new Dictionary<string, string>() { { "Hombre", "H" }, { "Mujer", "M" }, { "Otro", "O" } };
            _listaEstados = new Dictionary<string, string>() { { "Soltero", "S" }, { "Casado", "C" } };
        }

        public PacienteBE Paciente
        {
            get { return paciente; }
            set
            {
                paciente = value;
                OnPropertyChanged();
            }
        }

        public Dictionary<string,string> ListaSexo
        {
            get { return _listaSexo; }
            set {
                _listaSexo = value;
                OnPropertyChanged();
            }
        }

        public Dictionary<string, string> ListaEstados
        {
            get { return _listaEstados; }
            set { _listaEstados = value; }
        }        

        public ICommand Registrar
        {
            get { return _registrar = _registrar ?? new vmbCommand(execute => RegistrarPaciente(), canExecute => PuedeRegistrar()); }
        }

        private bool PuedeRegistrar()
        {
            foreach (var r in Paciente.GetType().GetProperties())
            {
                if (r.GetValue(Paciente, null) == null || r.GetValue(Paciente, null).Equals("")) return false;
            }
            return true;
        }

        private void RegistrarPaciente()
        {
            try
            {
                var nuevo = new PacienteBL();
                var registrado = nuevo.RegistrarPaciente(Paciente);

                var vm = new OdontogramaViewModel(registrado);
                var view = new Odontograma { DataContext = vm };
                view.Show();
                // solo cerramos la view
                CloseWindowEvent?.Invoke(this, null); 
                
                               
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error al registrar", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Hand, System.Windows.MessageBoxResult.OK);
            }

        }

        #region Implementacion vmbClose

        public event EventHandler CloseWindowEvent;

        public ICommand Cerrar
        {
            get
            {
                return new vmbCommand(execute =>
                {
                    CloseWindowEvent?.Invoke(this, null);
                });
            }
        }

        #endregion
    }
}
