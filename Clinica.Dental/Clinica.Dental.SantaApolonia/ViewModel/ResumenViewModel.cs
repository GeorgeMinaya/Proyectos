using Clinica.Dental.BE;
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
            this.ltratamientos = new List<TratamientoBE.Atencion>();
        }

        public ResumenViewModel(IEnumerable<TratamientoBE.Atencion> tratamientos)
        {
            this.lTratamientos = tratamientos.ToList();
        }

        private List<TratamientoBE.Atencion> ltratamientos;

        private vmbCommand finalizar;        

        public string Total
        {
            get
            {
                return "Total de atenciones : " + lTratamientos.Count.ToString();
            }
        }

        public string SumaTotal
        {
            get { return "Total en atenciones : S/. " + lTratamientos.Sum(x => x.Precio).ToString(); }
        }


        public List<TratamientoBE.Atencion> lTratamientos
        {
            get { return ltratamientos; }
            set {
                ltratamientos = value;
                OnPropertyChanged();
            }
        }

        public ICommand Finalizar
        {
            get
            {
                return finalizar = finalizar ?? new vmbCommand(execute =>
                {
                    var ad = lTratamientos;
                    OnPropertyChanged("Total");
                    OnPropertyChanged("SumaTotal");
                });
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
