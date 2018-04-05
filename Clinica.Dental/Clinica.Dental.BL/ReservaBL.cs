using Clinica.Dental.BE;
using Clinica.Dental.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Dental.BL
{
    public class ReservaBL
    {
        ReservaDA oReserva;

        public ReservaBL()
        {
            oReserva = new ReservaDA();
        }

        public void RegistrarCita(ReservaBE reserva)
        {
            try
            {
                oReserva.RegistrarCita(reserva);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
