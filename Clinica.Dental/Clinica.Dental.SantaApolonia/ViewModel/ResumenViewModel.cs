using Clinica.Dental.BE;
using Clinica.Dental.BL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Clinica.Dental.SantaApolonia.ViewModel
{
    public class ResumenViewModel : vmb, vmbClose
    {
        public ResumenViewModel()
        {
            LTratamientos = new ObservableCollection<TratamientoBE.Atencion>();
        }

        public ResumenViewModel(PacienteBE paciente,IEnumerable<TratamientoBE.Atencion> tratamientos)
        {
            Paciente = paciente;
            LTratamientos = new ObservableCollection<TratamientoBE.Atencion>(tratamientos);
        }

        public PacienteBE Paciente { get; set; }

        private ObservableCollection<TratamientoBE.Atencion> lTratamientos;

        public string Total
        {
            get
            {
                return "Total de atenciones : " + lTratamientos.Count.ToString();
            }
        }

        public string SumaTotal => $"Total en atenciones : S/ {lTratamientos.Sum(x => x.Precio)}";


        public ObservableCollection<TratamientoBE.Atencion> LTratamientos
        {
            get { return lTratamientos; }
            set { lTratamientos = value; OnPropertyChanged(); }
        }

        public ICommand Finalizar =>
            new vmbCommand(execute =>
            {
                try
                {
                    //var encontrados = lTratamientos.Where(x => x.Precio != 0);

                    //var nuevo = new TratamientoBL();

                    //nuevo.RegistrarAtencion(
                    //    new TratamientoBE.Historial
                    //    {
                    //        Archivo = Paciente.Dni + ".xml",
                    //        Especificasiones = "Sin especificar",
                    //        IdPaciente = Paciente.IdPaciente
                    //    }, 
                    //    encontrados);

                    System.Windows.MessageBox.Show("Atención finalizada correctamente.");
                    CloseWindowEvent?.Invoke(this, null);
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show(ex.Message, "Error al finalizar", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Hand, System.Windows.MessageBoxResult.OK);
                }
            });


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
