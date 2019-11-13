using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvaluateRs.Data.Residentes
{
    public class Residente
    {

        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        [Required (ErrorMessage = "El año de residencia es requerido")]
        [Range(1,5, ErrorMessage = "El año de residencia debe estar entre 1 y 5")]
        [Display(Name = "Año residencia")]
        public int AnyoResidencia { get; set; }


        public EspecialidadesEnum Especialidad { get; set; }
        

    }
}
