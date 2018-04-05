using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Dental.DM;
using Clinica.Dental.BE;
using System.Configuration;

namespace Clinica.Dental.DA
{
    public class PacienteDA
    {
        ClinicaDentalDataContext bdClinica;

        public PacienteDA()
        {
            this.bdClinica = new ClinicaDentalDataContext(ConfigurationManager.ConnectionStrings["Clinica"].ConnectionString);
        }

        public PacienteBE RegistrarPaciente(PacienteBE pNuevo)
        {
            PACIENTE paciente = new PACIENTE
            {
                Activo = true,
                Apellidos = pNuevo.Apellidos,
                Celular = pNuevo.Celular,
                Correo = pNuevo.Correo,
                Dni = pNuevo.Dni,
                EstadoCivil = Convert.ToChar(pNuevo.EstadoCivil),
                FchModifico = DateTime.Now,
                FchNacimiento = pNuevo.FchNacimiento,
                FchRegistro = DateTime.Now,
                Nombres = pNuevo.Nombres,
                Sexo = pNuevo.Sexo
            };

            this.bdClinica.PACIENTE.InsertOnSubmit(paciente);
            this.bdClinica.SubmitChanges();

            pNuevo.IdPaciente = paciente.IdPaciente;

            return pNuevo;
        }

        public IEnumerable<PacienteBE> ListarPacientes()
        {
            var lista = from p in bdClinica.PACIENTE
                        where p.Activo.Equals(true)
                        select new PacienteBE
                        {
                            Apellidos = p.Apellidos,
                            Celular = p.Celular,
                            Correo = p.Correo,
                            Dni = p.Dni,
                            EstadoCivil = p.EstadoCivil.ToString(),
                            FchNacimiento = p.FchNacimiento.Value,
                            IdPaciente = p.IdPaciente,
                            Nombres = p.Nombres,
                            Sexo = p.Sexo
                        };
            return lista;

        }
    }
}
