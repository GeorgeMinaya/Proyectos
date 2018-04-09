using Clinica.Dental.BE;
using Clinica.Dental.BL;
using Clinica.Dental.SantaApolonia.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Clinica.Dental.SantaApolonia.ViewModel
{
    public class PacientesViewModel : vmb, vmbClose
    {

        public PacientesViewModel()
        {
            try
            {
                var pacientes = new PacienteBL();
                var lista = pacientes.ListarPaciente();
                if (lista.Count() > 0)
                {
                    cvFiltrable = new CollectionViewSource();                    
                    cvFiltrable.Source = new ObservableCollection<PacienteBE>(lista);
                    cvFiltrable.Filter += CvFiltrable_Filter;
                }                 
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        private void CvFiltrable_Filter(object sender, FilterEventArgs e)
        {
            if (string.IsNullOrEmpty(Filtro))
            {
                e.Accepted = true;
                return;
            }

            var buscar = e.Item as PacienteBE;
            if (buscar.Nombres.ToUpper().Contains(Filtro.ToUpper()) ||
                buscar.Apellidos.ToUpper().Contains(Filtro.ToUpper()) ||
                buscar.Dni.ToUpper().Contains(Filtro.ToUpper()))
                e.Accepted = true;
            else
                e.Accepted = false;
               
        }

        private List<PacienteBE> lpacientes = new List<PacienteBE>();        
        private PacienteBE pacienteElegido;
        private string filtro = string.Empty;
        private CollectionViewSource cvFiltrable;
                
        public string Filtro
        {
            get { return filtro; }
            set {
                filtro = value;
                cvFiltrable.View.Refresh();
                OnPropertyChanged();
            }
        }

        public ICollectionView ColeccionFiltrable
        {
            get { return cvFiltrable.View; }
        }

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
                return new vmbCommand(execute =>
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
                return new vmbCommand(execute => Atendiendo(), canExecute => PuedeAtender());
            }
        }

        private bool PuedeAtender()
        {
            return PacienteElegido != null ? true : false;
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
