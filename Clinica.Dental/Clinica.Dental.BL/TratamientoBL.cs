using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Dental.BE;
using Clinica.Dental.DA;

namespace Clinica.Dental.BL
{
    public class TratamientoBL
    {
        TratamientoDA oTratamiento;

        public TratamientoBL()
        {
            oTratamiento = new TratamientoDA();
        }

        public IEnumerable<TratamientoBE.Atencion> listarTratamientos()
        {
            try
            {
                return oTratamiento.listarTratamientos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Genera el registro de la atención
        /// </summary>
        /// <param name="nuevo"></param>
        /// <param name="lencontrados"></param>
        public void RegistrarAtencion(TratamientoBE.Historial nuevo, IEnumerable<TratamientoBE.Atencion> lencontrados)
        {
            try
            {
                oTratamiento.RegistrarAtencion(nuevo, lencontrados);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
