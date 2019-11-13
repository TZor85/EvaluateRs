using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvaluateRs.Data.Residentes
{
    public class ResidenteService : IResidentesService
    {

        public DateTime CreationDate { get; set; }
        public List<Residente> Residentes { get; set; }

        public ResidenteService()
        {
            CreationDate = DateTime.Now;

            Residentes = new List<Residente>
            {
                new Residente { Id = 1, Nombre = "Ester Guilló Quiles", AnyoResidencia = 5, Especialidad = EspecialidadesEnum.MedicinaFamiliarComunitaria },
                new Residente { Id = 2, Nombre = "Alberto Cervantes Bañón", AnyoResidencia = 1, Especialidad = EspecialidadesEnum.CirugiaGeneral },
                new Residente { Id = 3, Nombre = "Natalia Guilló Quiles", AnyoResidencia = 3, Especialidad = EspecialidadesEnum.OncologiaMedica },
                new Residente { Id = 4, Nombre = "Arturo Fernández Ochoa", AnyoResidencia = 2, Especialidad = EspecialidadesEnum.Traumatologia },
                new Residente { Id = 5, Nombre = "Armando Martí Martinez", AnyoResidencia = 1, Especialidad = EspecialidadesEnum.MedicinaInterna },
            };

        }

        public List<Residente> GetResidentes()
        {
            return Residentes;
        }

        public Residente GetResidenteById(int residenteId)
        {
            return Residentes.Where(x => x.Id == residenteId).FirstOrDefault();
        }

        public DateTime GetCreateDate()
        {
            return CreationDate;
        }

        public string GetVersion()
        {
            return "v1";
        }

        public void SaveResidente(Residente residente)
        {


            residente.Id = Residentes.Count() + 1;

            Residentes.Add(residente);
        }
    }
}
