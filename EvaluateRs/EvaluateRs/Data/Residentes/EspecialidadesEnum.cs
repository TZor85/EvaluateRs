using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EvaluateRs.Data.Residentes
{
    public enum EspecialidadesEnum
    {
        [Display(Name = "Medicina Familiar y Comunitaria")]
        MedicinaFamiliarComunitaria,
        [Display(Name = "Anestesiología y Reanimación")]
        Anestesiologia,
        [Display(Name = "Medicina Interna")]
        MedicinaInterna,
        [Display(Name = "Cardiología")]
        Cardiologia,
        [Display(Name = "Neumología")]
        Neumologia,
        [Display(Name = "Medicina Intensiva")]
        MedicinaIntensiva,
        [Display(Name = "Cirugía General")]
        CirugiaGeneral,
        [Display(Name = "Radiodiagnóstico")]
        Radiodiagnostico,
        [Description("Cirugía Ortopédica y Traumatología")]
        Traumatologia,
        [Description("Medicina Preventiva")]
        MedicinaPreventiva,
        [Description("Oncología Radioterápica")]
        OncologiaRadioterapica,
        [Description("Medicina Nuclear")]
        MedicinaNuclear,
        [Description("Psiquiatría")]
        Psiquiatria,
        [Description("Urologia")]
        Urologia,
        [Description("Oncología Médica")]
        OncologiaMedica,
        [Description("Dermatología")]
        Dermatologia

    }
}
