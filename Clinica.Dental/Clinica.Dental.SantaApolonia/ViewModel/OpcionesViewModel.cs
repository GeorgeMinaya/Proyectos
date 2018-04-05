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
        private vmbCommand registrar;
        private vmbCommand listaPacientes;

        public ICommand Registrar
        {
            get
            {
                return registrar = registrar ?? new vmbCommand(execute =>
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
                return listaPacientes = listaPacientes ?? new vmbCommand(execute =>
                {
                    Pacientes ofrm = new Pacientes();
                    ofrm.ShowDialog();
                });
            }
        }
    }
}
