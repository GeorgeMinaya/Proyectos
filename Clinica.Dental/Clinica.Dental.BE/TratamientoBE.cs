using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Dental.BE
{
    public class TratamientoBE
    {

        public class Atencion
        {
            public int Indice { get; set; }
            public int IdTratamiento { get; set; }
            public string CodTratamiento { get; set; }
            public string Descripcion { get; set; }
            public decimal Precio { get; set; }
        }

        public class Historial
        {
            public int IdPaciente { get; set; }
            public string Archivo { get; set; }
            public string Especificasiones { get; set; }
        }
        
    }
}
