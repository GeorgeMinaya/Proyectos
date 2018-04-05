using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Dental.BE
{
    public class PacienteBE
    {
        public int IdPaciente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Sexo { get; set; }
        public DateTime FchNacimiento { get; set; }
        public string EstadoCivil { get; set; }

    }
}
