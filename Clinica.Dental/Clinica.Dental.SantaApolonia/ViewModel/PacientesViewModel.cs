using Clinica.Dental.BE;
using Clinica.Dental.BL;
using Clinica.Dental.SantaApolonia.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Clinica.Dental.SantaApolonia.ViewModel
{
    public class PacientesViewModel : vmb, vmbClose
    {

        public PacientesViewModel()
        {
            var pacientes = new PacienteBL();
            var lista = pacientes.ListarPaciente();
            if (lista.Count() > 0)
                lpacientes.AddRange(lista);
        }

        private List<PacienteBE> lpacientes = new List<PacienteBE>();
        private PacienteBE pacienteElegido;
        private vmbCommand atender;
        private vmbCommand darcita;

        public PacienteBE PacienteElegido
        {
            get { return pacienteElegido; }
            set { pacienteElegido = value; }
        }

        public List<PacienteBE> lPacientes
        {
            get { return lpacientes; }
            set {
                lpacientes = value;
                //OnPropertyChanged();
            }
        }

        public ICommand Darcita
        {
            get
            {
                return darcita = darcita ?? new vmbCommand(execute =>
                {
                    if (PacienteElegido != null)
                    {
                        ReservarViewModel vm = new ReservarViewModel(PacienteElegido);
                        var view = new Reservar() { DataContext = vm };
                        view.ShowDialog();
                    }
                },
                canExecute => PuedeAtender());
            }
        }

        public ICommand Atender
        {
            get
            {
                return atender = atender ?? new vmbCommand(execute => Atendiendo(), canExecute => PuedeAtender());
            }
        }

        private bool PuedeAtender()
        {
            return lPacientes.Count > 0 ? true : false;
        }

        private void Atendiendo()
        {
            if (pacienteElegido != null)
            {
                var vm = new OdontogramaViewModel(pacienteElegido);
                var view = new Odontograma { DataContext = vm };
                view.SetCanvas(pacienteElegido.Dni.ToString());
                view.Show();
                // solo cerramos la view por ahora TwT
                CloseWindowEvent?.Invoke(this, null);
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
