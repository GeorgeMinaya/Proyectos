using Clinica.Dental.BE;
using Clinica.Dental.DM;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Dental.DA
{
    public class ReservaDA
    {
        ClinicaDentalDataContext bdClinica; 

        public ReservaDA()
        {
            this.bdClinica = new ClinicaDentalDataContext(ConfigurationManager.ConnectionStrings["Clinica"].ConnectionString);
        }

        public void RegistrarCita(ReservaBE reserva)
        {
            var nueva = new RESERVA
            {
                FchRegistro = DateTime.Now,
                Activo = true,
                Estado = "Pendiente",
                IdPaciente = reserva.IdPaciente,
                FchReserva = reserva.FchReserva 
            };

            bdClinica.RESERVA.InsertOnSubmit(nueva);
            bdClinica.SubmitChanges();

        }

        public void ModificarCita(ReservaBE modificar)
        {
            var reserva = (from r in bdClinica.RESERVA
                           where 
                           r.Activo == true &&
                           r.FchReserva == modificar.FchReserva &&
                           r.IdPaciente == modificar.IdPaciente
                           select r).Single();

            reserva.Estado = modificar.Estado;

            bdClinica.SubmitChanges();
        }
    }
}
