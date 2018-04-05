using Clinica.Dental.BE;
using Clinica.Dental.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Clinica.Dental.SantaApolonia.ViewModel
{
    public class ReservarViewModel : vmb, vmbClose
    {
        public ReservarViewModel()
        {
            this.paciente = new PacienteBE();
            PoblarHorario();
        }

        public ReservarViewModel(PacienteBE paciente)
        {
            this.paciente = paciente;
            PoblarHorario();
        }

        private vmbCommand guardarcita;

        private List<string> lhoras = new List<string>();

        private string horaElegida;

        private DateTime fechaelegida = DateTime.Now.Date;

        private PacienteBE paciente;

        public PacienteBE Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        public DateTime FechaElegida
        {
            get { return fechaelegida; }
            set { fechaelegida = value; }
        }

        public string HoraElegida
        {
            get { return horaElegida; }
            set { horaElegida = value; OnPropertyChanged(); }
        }

        public List<string> lHoras
        {
            get { return lhoras; }
            set {
                lhoras = value;
                OnPropertyChanged();
            }
        }

        public ICommand GuardarCita
        {
            get
            {
                return guardarcita = guardarcita ?? new vmbCommand(execute =>
                {
                    try
                    {                        
                        var fchReserva = DateTime.ParseExact(
                            FechaElegida.ToString("dd/MM/yyyy") + " " + HoraElegida
                            , "dd/MM/yyyy hh:mm tt"
                            , System.Globalization.CultureInfo.InvariantCulture);

                        var oServicio = new ReservaBL();
                        oServicio.RegistrarCita(new ReservaBE
                        {
                            IdPaciente = Paciente.IdPaciente,
                            FchReserva = fchReserva
                        });

                        CloseWindowEvent?.Invoke(this, null);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show(ex.Message);
                    }
                });
            }
        }

        private void PoblarHorario()
        {
            lHoras = new List<string>
            {
                "09:00 AM",
                "09:30 AM",
                "10:00 AM",
                "10:30 AM",
                "11:00 AM",
                "11:30 AM",
                "12:00 PM",
                "12:30 PM",
                "01:00 PM",
                "01:30 PM",
                "02:00 PM",
                "02:30 PM",
                "03:00 PM",
                "03:30 PM",
                "04:00 PM",
                "04:30 PM",
                "05:00 PM",
                "05:30 PM",
                "06:00 PM",
                "06:30 PM",
                "07:00 PM",
                "07:30 PM",
                "08:00 PM",
                "08:30 PM"
            };
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
