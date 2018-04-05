using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Dental.BE
{
    public class ReservaBE
    {
        public int IdPaciente { get; set; }
        public DateTime FchReserva { get; set; }
        public string Estado { get; set; }
    }
}
