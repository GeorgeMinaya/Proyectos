using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Dental.DM;
using Clinica.Dental.BE;

namespace Clinica.Dental.DA
{
    public class TratamientoDA
    {
        ClinicaDentalDataContext bdClinica;
        public TratamientoDA()
        {
            this.bdClinica = new ClinicaDentalDataContext(ConfigurationManager.ConnectionStrings["Clinica"].ConnectionString);
        }
        
        public IEnumerable<TratamientoBE.Atencion> listarTratamientos()
        {
            var lista = from t in this.bdClinica.TRATAMIENTO
                        select new TratamientoBE.Atencion
                        {
                            IdTratamiento = t.IdTratamiento,
                            CodTratamiento = t.CodTratamiento,
                            Descripcion = t.Descripcion,
                            Precio = t.Precio
                        };

            return lista;
        }

        public void RegistrarAtencion(TratamientoBE.Historial nuevo, IEnumerable<TratamientoBE.Atencion> lencontrados)
        {            
            var historia = new HISTORIAL
            {
                ArchivoDiagnostico = nuevo.Archivo,
                ArchivoAtendido = nuevo.Archivo,
                Especificaciones = nuevo.Especificasiones,
                FchCreacion = DateTime.Now,
                FchModificacion = DateTime.Now,
                IdPaciente = nuevo.IdPaciente
            };

            bdClinica.HISTORIAL.InsertOnSubmit(historia);
                        
            foreach (var r in lencontrados)
            {
                var detalle = new DETALLE_HISTORIAL
                {
                    FchRealizado = DateTime.Now,
                    IdHistorial = historia.IdHistorial,
                    IdTratamiento = r.IdTratamiento,
                    Realizado = true                    
                };

                bdClinica.DETALLE_HISTORIAL.InsertOnSubmit(detalle);
            }

            bdClinica.SubmitChanges();

        }


    }
}
