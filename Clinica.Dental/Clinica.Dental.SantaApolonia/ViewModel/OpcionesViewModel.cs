using Clinica.Dental.SantaApolonia.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Clinica.Dental.SantaApolonia.ViewModel
{
    public class OpcionesViewModel : vmb
    {
        public ICommand Registrar
        {
            get
            {
                return new vmbCommand(execute =>
                {
                    Registro ofrm = new Registro();
                    ofrm.ShowDialog();
                });
            }
        }

        public ICommand ListaPacientes
        {
            get
            {
                return new vmbCommand(execute =>
                {
                    Pacientes ofrm = new Pacientes();
                    ofrm.ShowDialog();
                });
            }
        }
    }
}
