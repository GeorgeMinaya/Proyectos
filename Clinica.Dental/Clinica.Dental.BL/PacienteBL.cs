using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Dental.DA;
using Clinica.Dental.BE;

namespace Clinica.Dental.BL
{
    public class PacienteBL
    {
        PacienteDA oPaciente;

        public PacienteBL()
        {
            oPaciente = new PacienteDA();
        }

        public PacienteBE RegistrarPaciente(PacienteBE pNuevo)
        {
            try
            {
                return oPaciente.RegistrarPaciente(pNuevo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<PacienteBE> ListarPaciente()
        {
            try
            {
                return oPaciente.ListarPacientes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
